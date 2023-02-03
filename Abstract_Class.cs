// using System;

// namespace mtech

// {

//     abstract class Shape
//     {
//         public void Welcome() {
//             Console.Write("Hello");
//         }
//         abstract public void draw();
//     }

//     class Circle : Shape
//     {     

//         // Abstract class is saaaaaaammeeee like VIRTUAL keyword internally
//         // Soo..they need to be overridden by DERIVED class
//         public override void draw()
//         {
//             Welcome();
//             Console.Write("This is Circle class");
//         }
//     }
//     class Abstract_Class
//     {

//         // In c#, abstract is a keyword, 
//         // and it is useful to define classes and class members that are needed to be implemented
//         // or overridden in a derived class.
//         public static void Main(string[] args)
//         {
//             Circle c1 = new Circle();
//         }

//     }
// }