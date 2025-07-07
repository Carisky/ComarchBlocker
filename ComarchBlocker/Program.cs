
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using static TSL.Data.Models.ERPXL_TSL.Sesje;
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

            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();

                var now = DateTime.Now;
                var currentHour = now.Hour;

                var cmdText = @"
            SELECT s.SES_ADOSPID, s.SES_OpeIdent, s.SES_Start
            FROM CDN.Sesje s
            WHERE s.SES_Stop = 0 AND s.SES_ADOSPID IS NOT NULL";

                var sessions = new List<(int Spid, string UserName, long Start)>();
                using (var cmd = new SqlCommand(cmdText, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        sessions.Add((
                            Convert.ToInt32(reader[0]),
                            reader.GetString(1),
                            Convert.ToInt64(reader[2])
                        ));
                    }
                }

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
                        KillSession(s.Spid, s.UserName, conn, "Превышен лимит");
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

        static void KillSession(int spid, string user, SqlConnection conn, string reason)
        {
            using (var cmd = new SqlCommand($"KILL {spid}", conn))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    LogKill(user, spid, reason);
                    Console.WriteLine($"KILL {spid} ({reason})");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка KILL {spid}: {ex.Message}");
                }
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
