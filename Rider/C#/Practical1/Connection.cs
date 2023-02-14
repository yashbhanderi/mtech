using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Rider.C_.Practical1
{
    public static class Connection
    {
        public static readonly MySqlConnection MySqlConnection =
            new("Server=localhost;Port=3306;Database=practical1;Uid=root;Pwd=Yy@8140279748;");
        public static readonly SqlConnection SqlConnection =
            new("Data Source=DESKTOP-K63766J;Initial Catalog=practical2;Integrated Security=True");
    }
    
    // private static void Method1()
    // {
    //     //➡️ 10 Minutes
    //
    //     // var sql = "INSERT INTO source_table VALUES(@id, @FirstNumber, @SecondNumber)";
    //     // for (int i = 0; i < 1000000; i++)
    //     // {   
    //     //     var result = await connection.ExecuteAsync(sql, new { @id = i+1, @FirstNumber = rnd.Next(1, 11), @SecondNumber = rnd.Next(1, 11) });
    //     // }
    // }
    //
    // private static void Method2()
    // {
    //     // connection.Open();
    //     // for (int i = 0; i < 10000; i++)
    //     // { 
    //     //     var trans =  await connection.BeginTransactionAsync();
    //     //     
    //     //     await connection.ExecuteAsync(@"
    //     //     insert into source_table values (@id, @FirstNumber, @SecondNumber)", GetData(), transaction: trans);
    //     //     
    //     //     trans.Commit();
    //     //
    //     // }
    //     //
    //     // connection.Close();
    //
    //     //     var result = await connection.ExecuteAsync(sql, new { @id = i+1, @FirstNumber = rnd.Next(1, 11), @SecondNumber = rnd.Next(1, 11) });
    // }
}