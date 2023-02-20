// using System.Timers;
// using Dapper;
// using Z.Dapper.Plus;
// using Timer = System.Timers.Timer;
//
// namespace Rider.C_.Practical1;
//
// public class Source
// {
//     public int id { get; set; }
//     public int FirstNumber { get; set; }
//     public int SecondNumber { get; set; }
// }
//
// class Program
// {
//     public static int k = 1;
//     public static int q = 1;
//     public static Dictionary<int, Destination> ls = new();
//     public static List<Destination> total = new();
//
//     private static object[] GetData()
//     {
//         // var data = new List<Source>();
//         // ArrayList data = new ArrayList();
//         // object[] data = new object[1000000];
//         Random rnd = new Random();
//         object[] data = new object[10000];
//         for (int i = 0; i < 10000; i++)
//         {
//             data[i] = new Source()
//             {
//                 id = k++,
//                 FirstNumber = rnd.Next(1, 101),
//                 SecondNumber = rnd.Next(1, 101)
//             };
//         }
//
//         return data;
//     }
//
//     private static void BulkInsertData()
//     {
//         var connection = Connection.SqlConnection;
//         connection.Open();
//         DapperPlusManager.Entity<Source>().Table("source_table");
//
//         for (int i = 0; i < 100; i++)
//         {
//             // connection.Execute("INSERT INTO source_table VALUES (@id, @FirstNumber, @SecondNumber)", GetData());
//             connection.BulkInsert(GetData());
//         }
//
//
//         connection.Close();
//     }
//
//     private static void BatchFunction()
//     {
//         // for (int i = 0; i < 10; i++)
//         // {
//         const int startRange = 1;
//         const int endRange = 100;
//
//         DataFetch(startRange, endRange);
//         // }
//     }
//
//     private static void DataFetch(int startRange, int endRange)
//     {
//         var conn = Connection.SqlConnection;
//         conn.Open();
//
//         var sql = $"SELECT * FROM source_table WHERE id BETWEEN {startRange} AND {endRange};";
//         var dataset = conn.Query(sql);
//         conn.Close();
//
//         int i = 0;
//         Destination[] data = new Destination[100];
//
//         foreach (var item in dataset)
//         {
//             var _id = (int)item.id;
//             var firstNumber = (int)item.FirstNumber;
//             var secondNumber = (int)item.SecondNumber;
//             data[i++] = new Destination
//             {
//                 id = _id + ++q,
//                 sum = firstNumber + secondNumber,
//                 sid = _id
//             };
//         }
//
//         DataPost(data);
//     }
//
//     private static void DataPost(params Destination[] data)
//     {
//         int idx = 0;
//         Timer timer = new Timer();
//         timer.Interval = 50;
//         timer.Elapsed += (sender, e) => { AddNumbers(sender, e, data, idx++); };
//         timer.AutoReset = true;
//         timer.Enabled = true;
//         if (Console.Read().ToString() == "STATUS")
//         {
//             foreach (var item in ls.Keys)
//             {
//                 Console.WriteLine(item+" | "+ls[item]);
//             }
//         }
//     }
//
//     private static void AddNumbers(object? sender, ElapsedEventArgs elapsedEventArgs, Destination[] data, int idx)
//     {
//         var conn = Connection.SqlConnection;
//         conn.Open();
//         Console.WriteLine(ls);
//         
//         const string sql = "insert into destination_table values(@id, @sum, @sid)";
//         if (!ls.ContainsKey(data[idx].sid))
//         {
//             Console.WriteLine(ls);
//             conn.Query(sql, new { data[idx].id, data[idx].sum, data[idx].sid });
//             ls.Add(data[idx].sid, new Destination(){id=data[idx].id, sum=data[idx].sum, sid=data[idx].sid});
//         }
//         conn.Close();
//     }
//
//
//     public static void Main(string[] args)
//     {
//         // Time Cost    
//         //➡️ BulkInsert-DapperPlus : 28 seconds
//         //➡️ List : 54 seconds
//         //➡️ ArrayList : 54 seconds
//         //➡️ Array : 54 seconds
//         //➡️ 100 entries at one time : 1 min 08 seconds
//         //➡️ 1 million insert statement : 10 min
//
//         // Stopwatch stopwatch = Stopwatch.StartNew(); 
//
//         // BulkInsertData();
//
//         // stopwatch.Stop();
//         // Console.WriteLine(stopwatch.ElapsedMilliseconds);
//
//         BatchFunction();
//         // StartApp();
//     }
// }