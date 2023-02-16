// using System.Threading.Tasks;
// using Dapper;
// using Z.Dapper.Plus;
//
// namespace Rider.C_.Practical1;
//
// public class Final
// {
//     public class Destination
//     {
//         public int id { get; set; }
//         public int sum { get; set; }
//         public int sid { get; set; }
//     }
//
//     public static class Global
//     {
//         public static Dictionary<int, int> MigrationStatus = new();
//         public static int q = 1;
//     }
//
//     public static void Main(string[] args)
//     {
//         // Enter range from user
//         Console.WriteLine("Enter the range: ");
//         var startId = Convert.ToInt32(Console.ReadLine());
//         var endId = Convert.ToInt32(Console.ReadLine());
//
//         // Use to give the signal to start/cancel the migration
//         var token = new CancellationTokenSource();
//
//         // Start and run the migration of data in background
//         Task backgroundTask = Task.Run(() => { MigrateData(startId, endId, token); });
//
//         while (true)
//         {
//             var input = Console.ReadLine();
//
//             if (input == "cancel")
//             {
//                 token.Cancel();
//                 // break;
//             }
//             else if (input == "status")
//             {
//                 // Console.WriteLine("status");
//                 GetMigrationStatus();
//             }
//             else if (input == "exit")
//             {
//                 break;
//             }
//         }
//     }
//
//     private static void GetMigrationStatus()
//     {
//         List<int> completed = new();
//         List<int> ongoing = new();
//         List<int> cancelled = new();
//
//         foreach (var key in Global.MigrationStatus.Keys)
//         {
//             if (Global.MigrationStatus[key] == 1) completed.Add(key);
//             else if (Global.MigrationStatus[key] == 0) cancelled.Add(key);
//             else ongoing.Add(key);
//         }
//
//         Console.WriteLine("\n\nCompleted Migrations: ");
//         Console.WriteLine(Global.MigrationStatus.Count(item=>item.Value==1));
//         // foreach (var item in completed)
//         // {
//         //     Console.Write(item + " ");
//         // }
//
//         Console.WriteLine("\n\nOngoing Migrations: ");
//         Console.WriteLine(Global.MigrationStatus.Count(item=>item.Value==2));
//         // foreach (var item in ongoing)
//         // {
//         //     Console.Write(item + " ");
//         // }
//
//         Console.WriteLine("\n\nCancelled Migrations: ");
//         Console.WriteLine(Global.MigrationStatus.Count(item=>item.Value==0));
//         // foreach (var item in cancelled)
//         // {
//         //     Console.Write(item + " ");
//         // }
//
//         Console.WriteLine("\n");
//     }
//
//     private static async void MigrateData(int startId, int endId, CancellationTokenSource token)
//     {
//         // Fetch data from database
//         var data = FetchData(startId, endId);
//         var lst = data.ToList();
//
//         foreach (var item in lst.Chunk(100))
//         {
//             List<Destination> dataBatch = new();
//             foreach (var it in item)
//             {
//                 // Global.MigrationStatus[it.sid] = 2;
//                 if (token.IsCancellationRequested)
//                 {
//                     for (int curr = it.sid; curr <= endId; curr++)
//                     {
//                         Global.MigrationStatus[curr] = 0;
//                     }
//
//                     Console.WriteLine("Migration Cancelled...!");
//                     return;
//                 }
//                 
//                 dataBatch.Add(it);
//
//                 // update to status to completed
//                 Global.MigrationStatus[it.sid] = 1;
//             }
//
//             await Task.Delay(1000);
//
//             // Save data into destination table
//             SaveData(dataBatch);
//         }
//     }
//
//     private static Destination[] FetchData(int startId, int endId)
//     {
//         var conn = Connection.SqlConnection;
//         conn.Open();
//
//         var sql = $"select * from source_table where id between {startId} and {endId};";
//         var dataset = conn.Query(sql);
//         conn.Close();
//
//         var i = 0;
//         var data = new Destination[endId - startId + 1];
//
//         foreach (var item in dataset)
//         {
//             var id = (int)item.id;
//             var firstNumber = (int)item.FirstNumber;
//             var secondNumber = (int)item.SecondNumber;
//             data[i++] = new Destination
//             {
//                 id = id + ++Global.q,
//                 sum = AddNumber(firstNumber, secondNumber),
//                 sid = id
//             };
//             Global.MigrationStatus[id] = 2;
//         }
//
//         return data;
//     }
//
//     private static int AddNumber(int firstNumber, int secondNumber)
//     {
//         
//         return firstNumber + secondNumber;
//     }
//
//     private static void SaveData(List<Destination> dataBatch)
//     {
//         var conn = Connection.SqlConnection;
//         conn.Open();
//
//         // var sql = "insert into destination_table values(@id, @sum, @sid);";
//         // conn.Query(sql, new { id, sum, sid });
//         DapperPlusManager.Entity<Destination>().Table("destination_table");
//         conn.BulkInsert(dataBatch);
//         conn.Close();
//     }
// }