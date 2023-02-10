// using System.Collections;
// namespace Rider.C_.Collections;
//
// public class ArrayLists
// {   
//     
// // *** Array vs ArrayList
// // -> Fixed Size | Variable Size
// // -> Not possible to insert items | Possible at anywhere
// // -> Not possible to delete items | Possible at anywhere
//
// // -> The ArrayList class implements the IEnumerable, ICollection, IList, and ICloneable interfaces.
// // -> Soo We can create objects of them
// // IEnumerable arrlist3 = new ArrayList();
//     
//     public static void Main(string[] args)
//     {
//         ArrayList arl = new ArrayList(10);
//         // Console.WriteLine(arl.Capacity);    // Intital size = 0
//         arl.Add(10);
//         // Console.WriteLine(arl.Capacity);    // Now Size = 4, then 8->16->32->64
//         arl.Add(20);
//         arl.Add(40);
//         
//         // -> Insert
//         arl.Insert(2, 90);      // Index, Value
//             
//         // -> Remove
//         // arl.Remove(30);
//         // arl.RemoveAt(2); 
//         // arl.Clear();     // All delete
//         
//         // -> Sort
//         // arl.Sort();      // Uses Quick Sort
//         
//         // -> Convert to Array
//         // var arr = arl.ToArray();
//         
//         // -> Equality
//         ArrayList arr2 = new ArrayList() { 10, 20, 90, 40 };
//         Console.WriteLine(arr2.Equals(arl));      // False  -> Bcz ArrayList is Reference Type, It wil create new reference of ArrayList 
//         // ArrayList arr2 = arl;                  // True   -> Bcz It will assign same address of ref as original address
//
//         foreach (var item in arl)
//         {
//             Console.WriteLine(item);
//         }
//
//     }
// }