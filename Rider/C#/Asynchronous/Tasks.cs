// namespace Rider.C_.Asynchronous;
// using System.Threading.Tasks;
//
// class HelloWorld
// {
//     public static void MyAsyncMethod()
//     {
//         Console.WriteLine("Starting MyAsyncMethod");
//
//         Thread.Sleep(5000);
//
//         Console.WriteLine("Finished MyAsyncMethod");
//     }
//
//     public static void Main()
//     {
//         Console.WriteLine("Starting Main");
//
//         MyAsyncMethod();
//
//         Console.WriteLine("Finished Main");
//     }
//
//
//     // ➡️ Why Tasks? What were the problems with the threads?
//     // Threads have some limitations that can make it challenging to write scalable and efficient multithreaded applications. These limitations include:
//     //
//     // Limited resources: Each thread requires memory and other system resources, so creating too many threads can result in resource exhaustion and decreased performance.
//     //
//     //     High overhead: Creating and destroying threads can be expensive in terms of both time and system resources.
//     //
//     //     Limited control: Managing threads directly can be challenging and error-prone, especially in complex applications.
//     //
//     //     Difficult error handling: Unhandled exceptions in a thread can cause the entire process to crash, making it difficult to handle errors in a multithreaded application.
//
//     // ➡️ To overcome this -> TPL (Task Parallel Library) is came in c#
//     //      It is High-Level Abstraction -> TPL
//     //      over low-level  -> Thread API
//
//     // ➡️ A Task is a lightweight object that represents a single unit of work that can be executed in parallel with other Tasks.
//     // Tasks are managed by the .NET runtime, and can be dynamically scheduled on any available Thread in the ThreadPool.
//
//     // ➡️ Task is background or Foreground?
//     // Sooo... Task is by default Background <--- task.Run() pick up thread from Thread pool which is background by default
//
//     // Example: 
//     // Task.Run(() =>
//     // {
//     //     var name = Console.ReadLine();       <---- it'll not wait for this -> Just start and finished!
//     //     Console.WriteLine("Hellooo " + name);
//     // });
//
//
//     // But..Task.Wait() <---- Method can't terminate the Task If Program is finished
//     // I know <-- It is against the background property
//     // 
//     // BUTTTTT... It is one type of good property
//     
//     // ➡️ Task.Factory.New()
//     // One important thing to keep in mind when using Task.Run() is that it is designed to execute short-running operations. 
//     //     If you need to execute a long-running operation asynchronously, 
//     // it is recommended that you use the Task.Factory.StartNew() method instead, 
//     //     which provides more control over the execution of the task.
//     
//     // ➡️ Task.Run(()=>{})
//     // takes a new thread from ThreadPool and Start asynchronously
//     // When Task is completed, It's result is stored in Task.Result
//     
//     // ➡️ Task.Wait()
//     // Calling Wait on a task blocks until it completes and is the equivalent of calling Join
//     // on a thread:
//     
//     // Task task = Task.Run(() =>
//     // {
//     //     // Simulate some work that takes 5 seconds
//     //     // Thread.Sleep(5000);
//     //     var name = Console.ReadLine();
//     //     Console.WriteLine("Hello " + name);
//     // });
//     // Console.WriteLine("Main program is done.");
//     // task.Wait(); // <-- If Wait is used <- Then only it will wait to complete task <- wheather It has sleep time 0, 5 or 5 seconds
//     
//     // ➡️ Returning Values
//     // Task<TResult> <-- This has Result values on Task completion
//     // Task.result <-- Blocks the thread until Result is not arrived i.e. Until Task completion
//     
//     // ➡️ Continuations
//     // 1)
//     // var awaiter = primeNumberTask.GetAwaiter();
//     // awaiter.OnCompleted (() =>
//     // {
//     //     int result = awaiter.GetResult();
//     //     Console.WriteLine (result); // Writes result
//     // });
//
//
//     // 2) 
//     // var x = 10;
//     // var y = 20;
//     // var task = Task.Run(() => x + y);
//     //     
//     // task.ContinueWith(resultTask =>
//     // {
//     //     var ans = resultTask.Result;
//     //     return ans * ans;
//     // }).ContinueWith(resultTask =>
//     // {
//     //     Console.WriteLine("And the Result is : "+resultTask.Result);
//     // });
//     // Console.Readline();      <-- We have to add this, bcz ContinueWith Run asynchronously,
//     //                             ➡️ Because the continuation doesn't block. ⬅️ 
//     
//     // ➡️ Task.Delay()
//     // Equivalent to Thread.Sleep() <-- But diff is it doesn't block the code
//     // Task.Delay() is a method in C# that returns a Task that completes after a specified period of time has elapsed.
//     //     It allows you to introduce a delay in your asynchronous code without blocking the current thread.
//     
//     // Example -> How it not block other thread !!!!
//     
//     // public static async Task MyAsyncMethod()
//     // {
//     //     Console.WriteLine("Starting MyAsyncMethod");
//     //     await Task.Delay(5000);
//     //     Console.WriteLine("Finished MyAsyncMethod");
//     // }
//     //
//     // public static void Main()
//     // {
//     //     Console.WriteLine("Starting Main");  
//     //     MyAsyncMethod();
//     //     Console.WriteLine("Finished Main");  <-- It'll print immediately after showing Task.Delay()
//     // }
//     
//     // ❤️ Important !!
//     //    Yes, that's correct. The Thread.Sleep() method blocks the current thread,
//     //     whereas the Task.Delay() method does not block the current thread.
//     //
//     //     When you call Thread.Sleep(), the current thread is blocked and cannot execute any other code during the sleep period.
//     //     This can cause performance issues in applications that require high concurrency or responsiveness.
//     //
//     //     On the other hand, when you call Task.Delay(), the current thread is not blocked and can continue executing other code
//     //     while waiting for the delay to complete. 
//     //     This allows the application to remain responsive and can improve performance in certain scenarios.
//
// }
