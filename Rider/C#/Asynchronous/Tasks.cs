using System;
using System.Threading;
using System.Threading.Tasks;

class HelloWorld
{
    static void Main()
    {
        Task task = Task.Run(() =>
        {
            // Simulate some work that takes 5 seconds
            Thread.Sleep(5000);
            var name = Console.ReadLine();
            Console.WriteLine("Hellooo " + name);
        });
        Console.WriteLine("Main program is done.");
        task.Wait(); // Wait for the Task to finish before exiting the program.
    }


    // ➡️ Why Tasks? What were the problems with the threads?
    // Threads have some limitations that can make it challenging to write scalable and efficient multithreaded applications. These limitations include:
    //
    // Limited resources: Each thread requires memory and other system resources, so creating too many threads can result in resource exhaustion and decreased performance.
    //
    //     High overhead: Creating and destroying threads can be expensive in terms of both time and system resources.
    //
    //     Limited control: Managing threads directly can be challenging and error-prone, especially in complex applications.
    //
    //     Difficult error handling: Unhandled exceptions in a thread can cause the entire process to crash, making it difficult to handle errors in a multithreaded application.

    // ➡️ To overcome this -> TPL (Task Parallel Library) is came in c#
    //      It is High-Level Abstraction -> TPL
    //      over low-level  -> Thread API

    // ➡️ A Task is a lightweight object that represents a single unit of work that can be executed in parallel with other Tasks.
    // Tasks are managed by the .NET runtime, and can be dynamically scheduled on any available Thread in the ThreadPool.

    // ➡️ Task is background or Foreground?
    // Sooo... Task is by default Background <--- task.Run() pick up thread from Thread pool which is background by default

    // Example: 
    // Task.Run(() =>
    // {
    //     var name = Console.ReadLine();       <---- it'll not wait for this -> Just start and finished!
    //     Console.WriteLine("Hellooo " + name);
    // });


    // But..Task.Wait() <---- Method can't terminate the Task If Program is finished
    // I know <-- It is against the background property
    // 
    // BUTTTTT... It is one type of good property
}