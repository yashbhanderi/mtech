using System.Threading.Tasks;
using Dapper;
using Z.Dapper.Plus;

namespace Rider.C_.Practical1;

public class Final
{
    public class Destination
    {
        public int id { get; set; }
        public int sum { get; set; }
        public int sid { get; set; }
    }

    public static class Global
    {
        public static Dictionary<int, int> MigrationStatus = new();
        public static int q = 1;
    }

    public static void Main(string[] args)
    {
        // Enter range from user
        Console.WriteLine("Enter the range: ");
        var startId = Convert.ToInt32(Console.ReadLine());
        var endId = Convert.ToInt32(Console.ReadLine());

        // Use to give the signal to start/cancel the migration
        var token = new CancellationTokenSource();

        // Start and run the migration of data in background
        Task backgroundTask = Task.Run(() => { MigrateData(startId, endId, token); });

        while (true)
        {
            var input = Console.ReadLine();

            if (input == "cancel")
            {
                token.Cancel();
                // break;
            }
            else if (input == "status")
            {
                // Console.WriteLine("status");
                GetMigrationStatus();
            }
            else if (input == "exit")
            {
                break;
            }
        }
    }

    private static void GetMigrationStatus()
    {
        List<int> completed = new();
        List<int> ongoing = new();
        List<int> cancelled = new();

        foreach (var key in Global.MigrationStatus.Keys)
        {
            if (Global.MigrationStatus[key] == 1) completed.Add(key);
            else if (Global.MigrationStatus[key] == 0) cancelled.Add(key);
            else ongoing.Add(key);
        }

        Console.WriteLine("\n\nCompleted Migrations: ");
        foreach (var item in completed)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\n\nOngoing Migrations: ");
        foreach (var item in ongoing)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\n\nCancelled Migrations: ");
        foreach (var item in cancelled)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\n");
    }

    private static async void MigrateData(int startId, int endId, CancellationTokenSource token)
    {
        // Fetch data from database
        var data = FetchData(startId, endId);

        for (var i = 0; i < data.Length; i++)
        {
            Global.MigrationStatus[data[i].sid] = 2;
            if (token.IsCancellationRequested)
            {
                for (int curr = i; curr < data.Length; curr++)
                {
                    Global.MigrationStatus[data[curr].sid] = 0;
                }

                Console.WriteLine("Migration Cancelled...!");
                return;
            }

            int sid = data[i].sid, id = data[i].id, sum = data[i].sum;

            // Save data into destination table
            SaveData(sid, sum, id);

            await Task.Delay(2000);

            // update to status to completed
            Global.MigrationStatus[data[i].sid] = 1;
        }
    }

    private static Destination[] FetchData(int startId, int endId)
    {
        var conn = Connection.SqlConnection;
        conn.Open();

        var sql = $"select * from source_table where id between {startId} and {endId};";
        var dataset = conn.Query(sql);
        conn.Close();

        var i = 0;
        var data = new Destination[endId - startId + 1];

        foreach (var item in dataset)
        {
            var id = (int)item.id;
            var firstNumber = (int)item.FirstNumber;
            var secondNumber = (int)item.SecondNumber;
            data[i++] = new Destination
            {
                id = id + ++Global.q,
                sum = firstNumber + secondNumber,
                sid = id
            };
            Global.MigrationStatus[id] = 2;
        }

        return data;
    }

    private static void SaveData(int sid, int sum, int id)
    {
        var conn = Connection.SqlConnection;
        conn.Open();

        var sql = "insert into destination_table values(@id, @sum, @sid);";
        conn.Query(sql, new { id, sum, sid });
        conn.Close();
    }
}