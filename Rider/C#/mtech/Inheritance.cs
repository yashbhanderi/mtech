// using System;
 
// namespace mtech
 
// {


//     // Base class const. called first, Then child class const.
//     // MULTIPLE INHERITANCE <---------- NOT SUPPORTED

//     public class A {
//         public string name = "";
//         public int age;

//         public A() {
//             Console.Write("Base constructor called\n");
//         }

//         public void showDetails() {
//             Console.Write(name + " " + age);
//         }
//     }

//     public class B : A {
//         public B() {
//             Console.Write("Child constructor called\n");
//         }
//     }

//     class Inheritance {
 
//        static void Main(string[] args)  {
//             B obj = new B();
//             obj.name = "yash";
//             obj.age = 20;

//             obj.showDetails();
//         }
 
//     }
// }