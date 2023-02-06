// // This is like import
// // We can manage and organize different classes and parts of the program
// // Here..We can import namespace with USING  keyword..
// // If nested namespace is available..-----> namespace.inner_namespace
// // We can only import namespace...can't namespace.class
// using ProjectA;         
// using PR_B = ProjectB;      // Alias name
// using ProjectC.ProjectD;

// namespace mtech
 
// {
//     class Namespace {
 
//        static void Main(string[] args)  {

//             // Here..All the code in block of namespace : ProjectA is available here
//             // We can directly call them by class name
//             // If two namespace have same class ---> We have to specify namespace name ahead
//             TeamA.AddNumbers(3,4);    
//             PR_B.TeamB.MultiplyNumbers(4, 5);
//             TeamD.DivideNumbers(10, 2);
//         }
 
//     }
// }

// // This is custom namespace directly in the main file
// namespace ProjectB {
//     public class TeamB {
//         public static void MultiplyNumbers(int x, int y) {
//             Console.WriteLine($"Multiplication of {x} and {y} is : {x*y}");
//         }
//     }
// }

// namespace ProjectC {
//     namespace ProjectD {
//     public class TeamD {
//         public static void DivideNumbers(int x, int y) {
//             Console.WriteLine($"Divison of {x} and {y} is : {x/y}");
//         }
//     }
// }
// }