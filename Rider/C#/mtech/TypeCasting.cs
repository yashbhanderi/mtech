// using System;
 
// namespace mtech
 
// {
//     class TypeCasting {
 
//        static void Main(string[] args)  {
            
//             // All small data type can automatically convert from Bigger Data type

//             // Implicit Typecasting

//             int var1 = 10;
//             // Automatically conversion
//             long var2 = var1;
//             Console.WriteLine(var2.GetType());
            

//             // Explicit Type Casting


//             double var4 = 10.9;
//             // This can't possible
//             // int var3 = var4;      

//             // We have to specify data type to compiler
//             // 10.9 ---->  10 (Lossy Conversion)
//             int var3 = (int)var4;      
//             Console.WriteLine(var3);    
            

//             // Built-In Conversion

//             // Convert.ToString()
//             // Convert.ToInt32()
//             // Convert.ToUInt32()
//             // Convert.ToDouble()

//         }
 
//     }
// }