// using Z.Dapper.Plus;
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
//         BulkInsertData();
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
//             const string sql = "insert into source_table values(@id, @FirstNumber, @SecondNumber)";
//             connection.BulkInsert(GetData());    // <-- Avg: 1.6 sec
//             // connection.Execute(sql, GetData());  //  <--  Avg: 1.5 min
//             // SqlBulkCopy
//         }
//
//         connection.Close();
//     }
//
//     private static List<Source> GetData()
//     {
//         var data = new List<Source>();
//         Random rnd = new Random();
//         for (int i = 0; i < 10000; i++)
//         {
//             data.Add(new Source
//             {
//                 id = k++,
//                 FirstNumber = rnd.Next(1, 101),
//                 SecondNumber = rnd.Next(1, 101)
//             });
//         }
//
//         return data;
//     }
// }