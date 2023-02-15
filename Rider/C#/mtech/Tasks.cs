// using System;
// using System.Threading.Tasks;
//
// // public static class Global
// // {
// //     public static 
// // }
//
// class Program
// {
//     static async Task Main()
//     {
//         // Start a background task that runs a method
//         Task backgroundTask = Task.Run(() => BackgroundMethod());
//
//         while (true)
//         {
//             Console.Write("Enter a number: ");
//             string input = Console.ReadLine();
//
//             if (int.TryParse(input, out int number))
//             {
//                 // Do some work on the main thread while the background task runs
//                 Console.WriteLine("Main thread is working...");
//
//                 // Wait for the background task to complete
//                 await backgroundTask;
//
//                 // Get the result of the background task and print it to the console
//                 int result = await GetBackgroundTaskResult();
//                 Console.WriteLine($"The result is {result}");
//                     
//                 if(Console.ReadLine()=="okay") Console.WriteLine("ok");
//
//                 // Reset the background task to run again
//                 backgroundTask = Task.Run(() => BackgroundMethod());
//             }
//             else
//             {
//                 Console.WriteLine("Invalid input.");
//             }
//         }
//     }
//
//     static async Task BackgroundMethod()
//     {
//         while (true)
//         {
//             // Simulate a long-running operation
//             await Task.Delay(5000);
//
//             // Do some work in the background
//             Console.WriteLine("Background method is working...");
//         }
//     }
//
//     static async Task<int> GetBackgroundTaskResult()
//     {
//         // Simulate a long-running operation
//         await Task.Delay(5000);
//
//         // Return a result
//         return 42;
//     }
// }