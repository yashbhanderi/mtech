// using System.Data.SqlClient;
// using System.Threading;
// using Dapper;
// using Rider.C_.Practical1;
//
// namespace Rider.C_.Asynchronous;
//
// public class Threads
// {
//
//     public static void Main(string[] args)
//     {
//         // ➡️ Initialization
//         
//         // Four ways to create thread in c#
//         
//         // Delegate (type-safe function pointer) type Constructor
//         // Means ... Method must be of type ------> VOID <------------ AND ZERO PARAMETERS 
//         // ThreadStart t1 = new ThreadStart(PrintNumbers);
//         // ThreadStart t2 = PrintNumbers;
//         //
//         // ThreadStart obj = () => PrintNumbers();
//         // Thread t3 = new Thread(obj);
//         //
//         // Thread t4 = new Thread(PrintNumbers);
//
//         
//         // ➡️ Parameterized Constructor       // RETURN MUST BE VOID | BUT...CAN PASS OBJECT TYPE PARAMETERS ONLY
//         // ParameterizedThreadStart pt = new ParameterizedThreadStart(PrintNumbers(1000));
//         // pt.Start();      <- Only Pass valid type parameters | bcz it will not show compile errors  but RUNTIME ERRORS
//         
//         // ➡️ To pass parameter | BEST WAY --------> LAMBDA EXPRESSIONS
//         // Thread t = new Thread(() => someMethod(1, 2, 3));
//         
//         // ➡️ Background vs Foreground Threads
//         // Foreground -> Wait for th completion of Thread EVEN IF PARENT INSTANCE METHOD IS COMPLETED
//         // Background -> NO WAIT TO COMPLETE THREAD METHOD -> AS SOON AS PARENT INSTANCE TERMINATED -> OVERRR !!!
//         
//         // EXAMPLE      <--- args="Hello"
//         // Thread worker = new Thread ( () => Console.ReadLine() );
//         // if (args.Length > 0) worker.IsBackground = true; <--- If true => No wait for read input from console
//         // worker.Start();
//         // Console.WriteLine(args.ToString());
//         
//         
//         // ➡️ Thread Pool
//         // Whenever you start a thread, a few hundred microseconds are spent organizing
//         // such things as a fresh local variable stack. The thread pool cuts this overhead by
//         // having a pool of pre-created recyclable threads.
//         // • Pooled threads are always background threads
//         
//         // To submit a task to the thread pool, you can use one of the following methods:
//
//         // ThreadPool.QueueUserWorkItem: This method takes a delegate that represents the method to be executed
//         // and adds it to the thread pool.
//
//         // Task.Run: This method creates a task that represents the method to be executed and adds it to the thread pool.
//         
//         // ThreadPool.SetMaxThreads  <-- We can manage minimum and maximum number of threads to be create in thread-pool
//         
//         // We have to maintain good hygine in the thread Pool i.e. Not more threads than core of the CPU
//
//         // ➡️ Join Method
//         // It will block the -----> Instance Method(From where it is defined) <------ until Thread is not completed 
//         // Forcefully take the command and complete own thread execution
//         // In C#, Thread.Join() is a method that allows a calling thread to wait for a specified thread to complete its execution.
//         // When a thread calls Join() on another thread, the calling thread is blocked until the specified thread completes.
//         // (Note: It can't block other thread methods if they're already started)
//         
//         // For example
//
//         Thread t2 = new Thread(Method2);
//         t2.Start();
//
//         // t1.Join();
//         // t2.Join();
//         // Thread.Sleep(10000);
//         Console.WriteLine("\nMain Thread");
//     }
//
//     private static void Method1()
//     {
//         Console.WriteLine("\nMethod1 Thread");
//     }
//     
//     private static void Method2() {
//         Thread t1 = new Thread(Method1);
//         t1.Start();
//         Console.WriteLine(t1.IsAlive);      // <--- Trueee
//
//         if (t1.Join(2))     // Return True <- Either thread is completed or timeout elapsed
//         {
//             Console.WriteLine("Method1 is completed");
//         }
//         
//         Console.WriteLine(t1.IsAlive);      // <---- Falsseeee ➡️ Join INSURES THAT THREAD IS TERMINATED!!!
//         Console.WriteLine("\nMethod2 Thread");
//     }
//     
// }