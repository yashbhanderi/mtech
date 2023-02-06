// using System;
 
// namespace mtech
 
// {
    
//     // No Access Modifiers
//     interface IUser {

//         // No Implementation
//         void GetInfo();
//     }
//     interface IUser1 {
//         void GetInfo();
//     }

//     // MULTIPLE <--- SUPPORTED
//     public class User : IUser, IUser1 {

//         // MUSTTTT Provide implementation for every method of interface..!!!
//         // ANDDDD DONN'T Overload the method <------ EXACT SAME parameters
//         public void GetInfo() {
//             Console.Write("This is User class Implementation of Interface");
//         }

//     }

//     class Interface {
 
//        static void Main(string[] args)  {
//             User u1 = new User();
//             u1.GetInfo();
//         }
 
//     }
// }