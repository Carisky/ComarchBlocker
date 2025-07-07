
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using TSL.Data.Models.ERPXL_TSL;
namespace ComarchBlocker
{
    internal class Program
    {
        static readonly HashSet<string> ExceptionUsers = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "ADMIN"
        };

        static void Main()
        {
            var connStr = "Server=TSLCOMARCHDB;Database=ERPXL_TSL;User Id=sa_tsl;Password=@nalizyGrudzien24@;";

            var userGroups = LoadUserGroups("UserGroups.json");
            var groupLimits = LoadGroupLimits("GroupAccessLimits.json");

            Console.WriteLine("Загружены пользователи и группы:");
            foreach (var kv in userGroups)
                Console.WriteLine($"  Пользователь: {kv.Key} → Группа: {kv.Value}");

            Console.WriteLine("\nЗагружены лимиты по группам:");
            foreach (var kv in groupLimits)
                Console.WriteLine($"  Группа: {kv.Key.Group}, Час: {kv.Key.Hour} → Лимит: {kv.Value}");

            var options = new DbContextOptionsBuilder<ERPXL_TSLContext>()
                .UseSqlServer(connStr)
                .Options;

            using (var context = new ERPXL_TSLContext(options))
            {
                var now = DateTime.Now;
                var currentHour = now.Hour;

                var sessions = context.Sesjes
                    .Where(s => s.SesStop == 0 && s.SesAdospid != null)
                    .Select(s => (
                        Spid: (int)s.SesAdospid.Value,
                        UserName: s.SesOpeIdent,
                        Start: (long)(s.SesStart ?? 0)
                    ))
                    .ToList();

                Console.WriteLine($"\nНайдено {sessions.Count} активных сессий.");

                var sessionsWithGroups = sessions
                    .Where(s => userGroups.ContainsKey(s.UserName))
                    .Select(s => (s.Spid, s.UserName, s.Start, GroupCode: userGroups[s.UserName]))
                    .GroupBy(s => s.GroupCode);

                foreach (var group in sessionsWithGroups)
                {
                    var key = (group.Key, currentHour);
                    if (!groupLimits.TryGetValue(key, out var maxUsers))
                    {
                        Console.WriteLine($"\n[ГРУППА: {group.Key}] — нет лимита на {currentHour}:00, пропуск.");
                        continue;
                    }

                    var sorted = group.OrderBy(s => s.Start).ToList();
                    var filtered = sorted.Where(s => !ExceptionUsers.Contains(s.UserName)).ToList();

                    Console.WriteLine($"\n[ГРУППА: {group.Key}] Час: {currentHour}:00");
                    Console.WriteLine($"  Всего сессий: {group.Count()}, без исключений: {filtered.Count}, лимит: {maxUsers}");

                    if (filtered.Count <= maxUsers)
                    {
                        Console.WriteLine("  Лимит не превышен. Никто не будет удалён.");
                        continue;
                    }

                    var toKill = filtered.Skip(maxUsers).ToList();

                    Console.WriteLine($"  Превышение лимита. Будет завершено {toKill.Count} сессий:");
                    foreach (var s in toKill)
                    {
                        Console.WriteLine($"    - Пользователь: {s.UserName}, SPID: {s.Spid}, Start: {s.Start}");
                        KillSession(s.Spid, s.UserName, context, "Превышен лимит");
                    }
                }
            }
        }



        static Dictionary<string, string> LoadUserGroups(string path)
        {
            if (!File.Exists(path)) return new Dictionary<string, string>();
            var json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
        }

        static Dictionary<(string Group, int Hour), int> LoadGroupLimits(string path)
        {
            if (!File.Exists(path)) return new Dictionary<(string, int), int>();
            var json = File.ReadAllText(path);
            var list = JsonConvert.DeserializeObject<List<GroupLimit>>(json);
            return list.ToDictionary(x => (x.GroupCode, x.Hour), x => x.MaxUsers);
        }

        static void KillSession(int spid, string user, ERPXL_TSLContext context, string reason)
        {
            try
            {
                context.Database.ExecuteSqlRaw($"KILL {spid}");
                LogKill(user, spid, reason);
                Console.WriteLine($"KILL {spid} ({reason})");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка KILL {spid}: {ex.Message}");
            }
        }

        static void LogKill(string user, int spid, string reason)
        {
            var log = $"[{DateTime.Now}] KILL {spid} USER={user} REASON={reason}";
            File.AppendAllText("kill_log.txt", log + Environment.NewLine);
        }

        class GroupLimit
    {
        public string GroupCode { get; set; }
        public int Hour { get; set; }
        public int MaxUsers { get; set; }
    }
}
}
