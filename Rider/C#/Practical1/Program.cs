using System.Collections;
using Dapper;
using MySql.Data.MySqlClient;

namespace Rider.C_.Practical1;

public class Source
{
    public string id { get; set; }
    public int FirstNumber { get; set; }
    public int LastNumber { get; set; }
}

class Program
{
    public static object[] GetData()
    {
        
        Random rnd = new Random();
        object[] data = new object[100];
        for (int i = 0; i < 100; i++)
        {
            data[i] = new Source()
            {
                id = Guid.NewGuid().ToString("N"),
                FirstNumber = rnd.Next(1, 11),
                LastNumber = rnd.Next(1, 11)
            };
        }

        return data;
    }
    
    static async Task Main(string[] args)
    {
        await using var connection =
            new MySqlConnection("Server=localhost;Port=3306;Database=practical1;Uid=root;Pwd=Yy@8140279748;");

        // var people = 
        //     await connection.QueryAsync<object>("select * from temp");

        // foreach (var person in people)
        // {
        //     Console.WriteLine($"Hello from {person}");
        // }


        // Task 1: Add 1 Million records in source table
        
        connection.Open();
        // Random rnd = new Random();
        
        //➡️ List : 54 seconds
        //➡️ ArrayList : 54 seconds
        //➡️ Array : 54 seconds
        //➡️ 100 entries at one time : 1 min 08 seconds
        //

        // var data = new List<Source>();
        // ArrayList data = new ArrayList();
        // object[] data = new object[1000000];
        // int k = 1;
        // for (int i = 0; i < 100; i++)
        // {
        //     data[i] = new Source()
        //     {
        //         id = i+ (1*k),
        //         FirstNumber = rnd.Next(1, 11),
        //         LastNumber = rnd.Next(1, 11)
        //     };
        // }
        int k = 1;
        for (int i = 0; i < 10000; i++)
        { 
            var trans =  await connection.BeginTransactionAsync();
            
            await connection.ExecuteAsync(@"
            insert into source_table values (@id, @FirstNumber, @LastNumber)", GetData(), transaction: trans);
            
            trans.Commit();

        }
        
        connection.Close();
        
        //     var result = await connection.ExecuteAsync(sql, new { @id = i+1, @FirstNumber = rnd.Next(1, 11), @SecondNumber = rnd.Next(1, 11) });
        
        //➡️ 10 Minutes
        
        // var sql = "INSERT INTO source_table VALUES(@id, @FirstNumber, @SecondNumber)";
        // for (int i = 0; i < 1000000; i++)
        // {   
        //     var result = await connection.ExecuteAsync(sql, new { @id = i+1, @FirstNumber = rnd.Next(1, 11), @SecondNumber = rnd.Next(1, 11) });
        // }
        
    }
}