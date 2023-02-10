// using System.Collections.Generic;
// using System.Threading.Channels;
//
// namespace generics;
//
// public class List
// {
//     
//     
//     
//     public static void Main(string[] args)
//     {   
//         // Declaration
//         // List<T> ls = new List<T>();
//         // List<string> ls = new List<string>();
//         // List<string> ls = new();         # NEEEEWWWWWWW VERSION
//         
//         // Initialization
//         // List<int> ls = new List<int>() {1,2,3,4};
//         
//         List<string> ls = new ();
//         
//         
//         // Properties
//         // Count
//         // Index- ls[0]
//         // Capacity : If given then okay...Else take space 2,4,8,16,32,64, ... <--- JUST LIKE VECTOR
//     
//         ls.Capacity = 5;
//         ls.Add("Hello");
//         ls.Add("Yash");
//         ls.Add("How Are You?");
//         ls.Add("How Are You?");
//         // ls.Add("How Are You?");
//     
//         ls.Insert(2, "Boy");
//         ls.Sort();
//         
//         
//     
//         // string[] arr = ls.ToArray();
//         // var arr = ls.ToArray();
//         //
//         foreach (var item in ls)        
//         {
//             Console.WriteLine(item);
//         }
//         // foreach (var item in arr)        
//         // {
//         //     Console.WriteLine(item);
//         // }
//     
//         // Console.WriteLine(ls.Count);
//         
//         // if(ls.Contains("Yastrh")) Console.WriteLine("Yesss!");
//         // else Console.WriteLine("Noooo");
//         
//         
//         
//         // LIST OF OBJECTS
//         
//         // List<User> users = new List<User>(){
//         //     new User {Id= 1, Name= "Suresh Dasari", Location= "Hyderabad"},
//         //     new User {Id = 2, Name = "Rohini Alavala", Location = "Guntur"},
//         //     new User { Id = 3, Name = "Trishika Dasari", Location = "Guntur" },
//         //     new User { Id = 4, Name = "Praveen Alavala", Location = "Eluru" }
//         // };
//         
//     }
// }