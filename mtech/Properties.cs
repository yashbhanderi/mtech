// using System;
 
// namespace mtech
 
// {

//     public class User {

//         // Extension of variables
//         // Getters and Setters for private variables

//         private string name = "";
//         private int age;

//         public string Name {
//             get{
//                 return name;
//             }
//             set {
//                 name = value;
//             }
//         }
//         public int Age {
//             get{
//                 return age;
//             }
//             set {
//                 age = value;
//             }
//         }

//         public void ShowDetails() {
//             Console.Write(name + " " + age);       // call Getters
//         }
//     }

//     class Properties {

//        static void Main(string[] args)  {
            
//             User u1 = new User();
//             u1.Name = "Yash";           // Call Setters
//             u1.Age = 20;        

//             u1.ShowDetails();

//         }
 
//     }
// }