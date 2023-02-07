// using System;
 
// namespace mtech
 
// {

//     public class Student {
//         public string _firstname;
//         public string _lastname;

//         public Student()
//         {
//             Console.Write("Hello! \n");
//         }

//         // parameterized constructor
//         // this ---> refers to class
        
//         // Constructor Chaining..First this() will called.. Then actual constructor called
//         public Student(string firstname, string lastname) : this()      // <-- Default const. called first..
//         {
//             this._firstname = firstname;
//             this._lastname = lastname;        
//         }


//         // Copy Constructor
//         public Student(Student stu) {
//             this._firstname = stu._firstname;
//             this._lastname  = stu._lastname;
//         }
        
//         // Static Constructor

//         // only called once when first instance is created...ONLY ONCEEEE...like useEffect({}, []) 
//         // No need of access modifiers
//         static Student() {
//             Console.Write("Static Constructor called\n");
//         }

//         public void ShowDetails() {
//             Console.WriteLine($"Student name is {this._firstname} {this._lastname}");

//             // This keyword

//             Classes_Objects.GetDetails(this);   // 'this' will send current instance(object) to the method
//         }

//         ~Student() {
//             Console.Write("Called auto when object is destroyed\n");
//         }
//     }   

//     class Classes_Objects {

//         public static void ToShowDestructor() {
//             Student s3 = new Student();
//         }

//         public static void GetDetails(Student s) {
//             Console.Write($"Full name of the student is {s._firstname} {s._lastname}");
//         }
 
//        static int Main(string[] args)  {

//             // Will call constructor automatically when new keyword is used
//             // parameterized
            
//             // Student s1 = new Student();     // Creating object
            
//             Student s1 = new Student("Yash", "Bhanderi");  
//             Student s2 = new Student(s1);    // Copy const.
//             s1.ShowDetails();


//             // Destructor

//             Classes_Objects.ToShowDestructor();
//             GC.Collect();   // Auto called when above function completed

//             return 0;
//         }
 
//     }
// }