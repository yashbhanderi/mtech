// using System;
//  
// namespace mtech
//  

// Delegate -----------> Call back function in Javascript
// {
//     class Delegates {
//
//         // Step-1: Define delegates
//         // Exactly same as methods..parameters and return types
//         // static keyword is not needed for static methods
//         public delegate string GetNameDelegate(string _name);
//         public delegate int AddDelegate(int a, int b);
//         public delegate void Method1Del(string name);
//
//         public string GetName(string _name) {
//             return "Helloo " + _name;
//         }
//
//         public static int AddNums(int a, int b) {
//             return a+b;
//         }
//         
//
//         // Multicast delegates
//         // Same parameters, same return type    
//         
//         public void Method1(string name)  {
//             Console.Write("Good Evening " + name+"\n");
//         }
//         public void Method2(string name)  {
//             Console.Write("Good Morning " + name+"\n");
//         }
//
//        static void Main(string[] args)  {
//             
//             var obj = new Delegates();
//
//             Console.Write(obj.GetName("Yash Bhanderi\n"));
//             Console.Write(Delegates.AddNums(6, 5)+"\n");
//
//             // Step 2: Declaration and Initialization
//             var Add = new AddDelegate(Delegates.AddNums);
//             var GetName = new GetNameDelegate(obj.GetName);
//
//
//             // Step 3: Method Calling
//             Console.Write(Add(3, 4)+"\n");  
//             Console.Write(Add.Invoke(4, 5)+"\n");
//             Console.Write(GetName("yashbhanderi")+"\n");
//
//
//             // Multicast Delegats
//             // If multiple methods have same parameters and same return type
//             // Then We can call multiple delegates in one time
//             
//             
//             var Method1 = obj.Method1;  // Other way to initialize delegate
//             Method1 += obj.Method2; 
//             // Even delegate is not created for 2nd one
//             // Still we can add it to the first one and call them    
//
//             Method1.Invoke("yash");
//         }
//  
//     }
// }