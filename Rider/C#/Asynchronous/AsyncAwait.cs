namespace Rider.C_.Asynchronous;

public class AsyncAwait
{
    public static void Main(string[] args)
    {   
        // ➡️ Async Keyword intialization 
        
        // public static async Task<int> FooAsync() { ... }    <---- Recommended
        // public async static Task<int> FooAsync() { ... }
        // async public Task<int> FooAsync() { ... }
        // public async virtual Task<int> FooAsync() { ... }

        
        
        // ➡️ When to use Async/Await
        // There are basically two scenarios where Async/Await is the right solution.
        //
        //     I/O-bound work: Your code will be waiting for something, such as data from a database, reading a file, 
        //     a call to a web service. In this case you should use Async/Await, but not use the Task Parallel Library.
        
        // CPU-bound work: Your code will be performing a complex computation. In this case, you should use Async/Await
        // but spawn the work off on another thread using Task.Run. You may also consider using the Task Parallel Library.
        
        
        
// ➡️ What is happening internally ? ➡️ Why are we returning Task instead of Void ?
// When you mark a method as async, the C# compiler generates a state machine that handles the asynchronous execution of the method. 
//     The state machine contains a reference to a TaskCompletionSource<T> object that is used to set the result of the Task that is returned by the async method.
//
//     When you use the await keyword inside an async method, 
//     the C# compiler generates code that checks if the awaited task is already completed.
// If the awaited task is not completed, 
// the compiler generates code that registers a continuation on the task using a TaskCompletionSource<T> object. 
//     When the awaited task completes, it sets the result of the TaskCompletionSource<T>, 
// which in turn sets the result of the Task that is returned by the async method.

    // ➡️ Lambda 
    // Func<Task> unnamed = async () =>
    // {
    //     await Task.Delay (1000);
    //     Console.WriteLine ("Foo");
    // };
    // await unnamed();
    }
    
    // ➡️ Cancel a asynchronous operation
    
    //  ➡️ The CancellationToken class represents a token that can be used to request cancellation of an operation.
    // It is passed as a parameter to the asynchronous method that you want to cancel.
    
    // i.e It is class for Token (like LinkedListNode for Linked List )
    
    // example
    // public async Task DoAsync(CancellationToken cancellationToken)
    // {
    //     // Do some work here...
    //     await Task.Delay(1000, cancellationToken);
    //     // Do some more work...
    // }
    
    // It called TaskCanceledException <-- To cancel the Task
    
    // ➡️ CancellationTokenSource
    
    // var cancellationToken = cancellationTokenSource.Token;
    // The Token property of the CancellationTokenSource returns a ------> CancellationToken instance 
    // that you can use to monitor and control the cancellation process.
    
    // var cts = new CancellationTokenSource(500);
    // await DoAsync(cts.Token);
    
    // ➡️ Properties and Methods
    
    // ➡️ token.IsCancellationRequested -> Returns True -> Cancel Method is called
    // ➡️ token.Cancel() -> Cancel the operation -> By calling TaskCanceledException Exception
    
        
}

