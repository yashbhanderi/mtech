using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MySql.Data.MySqlClient;
using Rider.C_.Practical1;
using Z.Dapper.Plus;
using Z.BulkOperations;
using System.Timers;

public class Source
{
    public int id { get; set; }
    public int FirstNumber { get; set; }
    public int SecondNumber { get; set; }
}

class Program
{
    public static int k = 1;
    private static object[] GetData()
    {
        // var data = new List<Source>();
        // ArrayList data = new ArrayList();
        // object[] data = new object[1000000];
        Random rnd = new Random();
        object[] data = new object[100];
        for (int i = 0; i < 100; i++)
        {
            data[i] = new Source()
            {
                id = k++,
                FirstNumber = rnd.Next(1, 101),
                SecondNumber = rnd.Next(1, 101)
            };
        }

        return data;
    }

    private static void BulkInsertData()
    {
        var connection = Connection.MySqlConnection;
        connection.Open();
        DapperPlusManager.Entity<Source>().Table("source_table");
        for (int i = 0; i < 100; i++)
        {
            // connection.Execute("INSERT INTO source_table VALUES (@id, @FirstNumber, @SecondNumber)", GetData());
            connection.BulkInsert(GetData());
        }

        connection.Close();
    }

    private static void Method1()
    {
        //➡️ 10 Minutes

        // var sql = "INSERT INTO source_table VALUES(@id, @FirstNumber, @SecondNumber)";
        // for (int i = 0; i < 1000000; i++)
        // {   
        //     var result = await connection.ExecuteAsync(sql, new { @id = i+1, @FirstNumber = rnd.Next(1, 11), @SecondNumber = rnd.Next(1, 11) });
        // }
    }

    private static void Method2()
    {
        // connection.Open();
        // for (int i = 0; i < 10000; i++)
        // { 
        //     var trans =  await connection.BeginTransactionAsync();
        //     
        //     await connection.ExecuteAsync(@"
        //     insert into source_table values (@id, @FirstNumber, @SecondNumber)", GetData(), transaction: trans);
        //     
        //     trans.Commit();
        //
        // }
        //
        // connection.Close();

        //     var result = await connection.ExecuteAsync(sql, new { @id = i+1, @FirstNumber = rnd.Next(1, 11), @SecondNumber = rnd.Next(1, 11) });
    }

    public static void AddNumbers(object s, ElapsedEventArgs args)
    {
        
    }

    private static void StartTimer()
    {
        var t = new System.Timers.Timer();
        t.Interval = 1000;
        t.Elapsed += AddNumbers!;
        t.Start();
        if(Console.ReadLine()=="stop") t.Stop();
    }

    private static void BatchFunction()
    {
        // for (int i = 0; i < 10; i++)
        // {
            int start_range = 1;
            int end_range = 100;

            DataFetch(start_range, end_range);
            // }
    }

    private static void DataFetch(int startRange, int endRange)
    {
        var conn = Connection.MySqlConnection;
        conn.Open();

        var sql = $"SELECT * FROM source_table WHERE id BETWEEN {startRange} AND {endRange};";
        var dataset = conn.Query(sql);

        foreach(var item in dataset)
        {
            Console.WriteLine($"{item.id} | {item.FirstNumber} | {item.SecondNumber}");
        }
        
    }

    public static void Main(string[] args)
    {
        // Time Cost    
        //➡️ BulkInsert-DapperPlus : 28 seconds
        //➡️ List : 54 seconds
        //➡️ ArrayList : 54 seconds
        //➡️ Array : 54 seconds
        //➡️ 100 entries at one time : 1 min 08 seconds
            
        // BulkInsertData();
        BatchFunction();
        // StartApp();
    }
}