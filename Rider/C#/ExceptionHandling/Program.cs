// class Program
// {
//     public static void Main(string[] args)
//     {
//
//         var x = Convert.ToInt32(Console.ReadLine());
//         var y = Convert.ToInt32(Console.ReadLine());
//
//         Console.WriteLine(DivideNumbers(x, y));
//
//         // ➡️ Exception Handling
//         // It provides a way to detect and handle errors that may occur during the execution of a program,
//         // preventing the program from crashing and allowing for recovery from the error.
//
//         // ➡️ Exception Hierarchy
//
//         // Exception
//         // --> System Exception     --> OutOfMemory
//         //                          --> StackOverflow
//         //                          --> Argument        --> ArgumentNull
//         //                                              --> ArgumentOutOfRange
//
//
//         // --> Arithmetic Exception     --> DivideByZero, Overflow
//         // --> Application Exception
//
//
//         // 🟨 Try Block :
//         // 3 types:
//
//         // 1)  
//         //  try {..}
//         // catch(ArgumentNullException ex) {
//         //          Handle ArgumentNullException
//         // }
//         // catch(InvalidOperationException ex) {
//         //          Handle InvalidOperationException
//         // }
//         // catch(Exception ex) {            or...   catch {
//         //     All Other exceptions                     ...
//         // }                                           }
//
//         // 2)
//         // try {..}
//         // finally {..}  <--- Whatever happens at try, This will run every time
//
//         // 3) 
//         // try {..}
//         // catch {..}
//         // finally {..}
//
//
//     }
//
//     private static int DivideNumbers(int x, int y)
//     {
//         int ans;
//         try
//         {
//             ans = x / y;
//             return ans;
//         }
//         catch (DivideByZeroException ex)
//         {
//             // Console.WriteLine(ex);
//             // Console.WriteLine("Divide by zero is not possible");
//             throw new Exception("Divide by zero is not possible");
//         }
//         finally
//         {
//             Console.WriteLine("This was demo of Exceptional Handling in C#");
//         }
//     }
// }