using System.Data.SqlClient;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Dapper;
using Rider.C_.Practical2;

class Practical2
{
    public static void Main(string[] args)
    {
        // 3 Million Unique String Generation

        Stopwatch stopwatch = Stopwatch.StartNew();

        string[] lst = new string[3000001];

        for (var i = 1; i <= 3000000; i++)
        {
            lst[i] = GenerateString.UniqueStringGenerator(i);
        }


        using (SqlConnection conn =
               new SqlConnection("Data Source=DESKTOP-K63766J;Initial Catalog=practical2;Integrated Security=True"))
        {
            conn.Open();

            for (int i = 1; i <= 3000000; i++)
            {
                var sql = "insert into practical2 values(@id, @password)";
                conn.Execute(sql, new { id = i, password = lst[i] });
            }
            conn.Close();
        }

        stopwatch.Stop();
        var timeTaken = stopwatch.ElapsedMilliseconds;

        Console.WriteLine("Total time taken is : "+TimeSpan.FromMilliseconds(timeTaken).TotalSeconds+" Sec  |  "+TimeSpan.FromMilliseconds(timeTaken).TotalMinutes + " Min");
        
        
        
        
        
        
        // ⚡⚡⚡⚡⚡⚡⚡ Performance Analysis ⚡⚡⚡⚡⚡⚡⚡⚡
        
        // 🟨 With Fisher Yates Algorithm
        
        // ----> For 1 million:
        // string generate and insert together : 119 sec
        // string generate and insert different : 99 sec
        
        // ➡️ ----> 3 MILLION RECORDS : 288 sec, 4.81 Min
        // ➡️ ----> 3 MILLION RECORDS : 306 sec, 5.12 Min
        // ➡️ ----> 3 MILLION RECORDS : 339 sec, 5.65 Min
        //                            ________________________
        //               Average:       311 sec, 5.19 Min
        
        
        // 🟨 Without Algorithm
        
        // ➡️ ----> 3 MILLION RECORDS : 278 sec, 4.63 Min
        // ➡️ ----> 3 MILLION RECORDS : 319 sec, 5.32 Min
        // ➡️ ----> 3 MILLION RECORDS : 295 sec, 4.92 Min
        //                           ________________________
        //               Average:       297 sec, 4.95 Min
    }
}