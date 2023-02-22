using System.Data.SqlClient;
using System.Diagnostics;
using Dapper;

namespace Rider.C_.Practical2;

class Practical2
{
    // private static int cnt = 1;

    public static async Task Main(string[] args)
    {
        // 3 Million Unique String Generation
        Stopwatch stopwatch = Stopwatch.StartNew();

        await AddData();

        stopwatch.Stop();
        var timeTaken = stopwatch.ElapsedMilliseconds;

        Console.WriteLine("Total time taken is : " + TimeSpan.FromMilliseconds(timeTaken).TotalSeconds + " Sec  |  " +
                          TimeSpan.FromMilliseconds(timeTaken).TotalMinutes + " Min");
    }

    private static async Task AddData()
    {
        // Create an array of 100 tasks

        Task[] tasks = new Task[100];
        
        for (int i = 0; i < tasks.Length; i++)
        {
             // Add a new task to the array
            tasks[i] = Task.Run(() =>
            {
                using SqlConnection conn =
                        new SqlConnection(
                            "Data Source=DESKTOP-K63766J;Initial Catalog=practical2;Integrated Security=True");
                    conn.Open();

                    using (SqlCommand command = conn.CreateCommand())
                    {
                        command.CommandText = "INSERT INTO PasswordTable (Password) VALUES (@Password)";
                        command.Parameters.AddWithValue("@Password", GenerateString.UniqueStringGenerator());

                        for (int i = 0; i < 30000; i++)
                        {
                            command.Parameters["@Password"].Value = GenerateString.UniqueStringGenerator();
                            command.ExecuteNonQuery();
                        }
                    }
                    conn.Close();
            });
        }


        // Wait for all tasks to complete
        await Task.WhenAll(tasks);
    }
}