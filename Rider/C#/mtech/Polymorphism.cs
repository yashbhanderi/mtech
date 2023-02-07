// using System;
 
// namespace mtech
 
// {   

//     public class A {
//         public virtual void GetInfo() {
//             Console.Write("This is Base class");
//         }
//     }
//     // Method Overriding


//     // public class B : A {

//     // Different class, Same Name of Methods


//     //     public void GetInfo() {
//     //         Console.Write("This is Base class");
//     //     }
//     // }

//     //      A b = new B();
//     //      b.GetInfo()    <--------- Base Class Method will execute...This method will override

//     public class B : A {

//         public override void GetInfo() {
//             // base.GetInfo();         // <------ Used to call base class method in the child class
//             Console.Write("This is Child class");
//         }
//     }

//     class Polymorphism {
 
//        static void Main(string[] args)  {

//             // Reference to the Base class 
//             // and holds the object of Derived Class

//             // This will Check into Base class FIRSSST
//             // Don't care Object is of Derived class

//             // SOOO... We have to override it..
//             // 3 ways main..
//             // 1) new keyword = method hiding  <------ This will override CHILD METHOD
//             // 2) virtual and overrirde keyword <------ This will override BASE CLASS METHOD    
//             // 3) base keyword <------------------------- This can directly call BASE class method into CHILD CLASS

//             A obj = new B();   

//             // B obj1 = new B();

//             obj.GetInfo();
//         }
 
//     }
// }