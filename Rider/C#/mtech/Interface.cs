// The basic difference is that a class has both a definition and an implementation whereas an interface only has a definition. Interfaces are actually implemented via a class. (Due to this an interface supports the concept of multiple inheritances.)
// Interfaces are developed in Java to implement the concept of multiple inheritance whereas classes are not used to implement multiple inheritance.
//     No memory is allocate for the interfaces whereas the memory is allocated for the classes.
//     Classes are templates for objects. The attributes of objects are defined by the components of the class, that describe the state and behaviour of objects. A class contains attributes, methods and events as its components. Interfaces contain only method prototypes, they don't provide an implementation of its methods, we can provide an implementation of its methods in our class, for that we can implement the interface. An interface is the source for polymorphism.
//     Interfaces are always implemented whereas classes are always extended.
//     The access specifiers private, public and protected are possible with classes. But interfaces can have only one specifier, public.

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
    

// INTERFACE supports Multiple Inheritance  <-------------------------------------------------- !!!!!!!!!!!!

// namespace Rider
// {
//     
//     public class User
//     {
//         public string name { get; set; }
//         public int id { get; set; }
//
//         public override string ToString()
//         {
//             return $"ID: {id}, Name: {name}";
//         }
//     }
//     class Program
//     {
//
//         interface IGetData<T>
//         {
//             public void GetData();
//         } 
//
//         interface IAddData<T>
//         {
//             public void AddData(T x);
//         }
//
//         class Database<T> : IGetData<T>, IAddData<T>
//         {
//             private List<T> ls = new();
//
//             public void GetData()
//             {
//                 foreach (var user in ls)
//                 {
//                     Console.WriteLine(user);
//                 }
//             }
//             public void AddData(T item)
//             {
//                 ls.Add(item);
//             }
//         }
//
//         public static void Main()
//         {
//             // User u1 = new User() {name="Yash Bhanderi"};
//             // User u2 = new User() {name="Kent Clarke"};
//             // User u3 = new User() {name="Robert Downey"};
//
//             var d = new Database<User>();
//             d.AddData(new User() {name="Yash Bhanderi"});
//             d.AddData(new User() {name="Kent Clarke"});
//             d.AddData(new User() {name="Robert Downey"});
//             
//             d.GetData();
//         }
//     }
// }
