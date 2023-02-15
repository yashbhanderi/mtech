// namespace Rider.C_.mtech;
//
// public class Program
// {
//     public static void Main()
//     {
//         // create a new thread and start it
//         MyThread myThread = new MyThread();
//         Thread thread = new Thread(myThread.Start);
//         thread.Start();
//         
//         // wait for the user to press a key
//         Console.WriteLine("Press any key to stop the thread...\n");
//         Console.ReadKey();
//         
//         // request that the thread stop
//         myThread.Stop();
//         
//         // wait for the thread to exit
//         thread.Join();
//         
//         Console.WriteLine("\n\nThread stopped.");
//     }
// }
//
// public class MyThread
// {
//     private bool _stopRequested = false;
//     
//     public void Start()
//     {
//         while (!_stopRequested)
//         {
//             Console.WriteLine("Thread is working...");
//             Thread.Sleep(500);
//         }
//     }
//     
//     public void Stop()
//     {
//         _stopRequested = true;
//     }
// }