// using System.Collections;
//
// namespace Rider.C_.Collections;
//
// //  It is of both generic and non-generic type of collection.
// // A SortedList object internally maintains two arrays to store the elements of the list,
// // i.e, one array for the keys and another array for the associated values.
// // Soretd order, By def Ascending 

//      👉In SortedList, the elements are stored in a continuous block in memory.
//    👉  In SortedDictionary, the elements are stored in separate object that can spread all over the heap.

//
// public class SortedLists
// {
//     public static void Main(string[] args)
//     {
//         SortedList slist = new SortedList();
//         slist.Add("name", "yash");
//         slist.Add("id", 101);
//         slist.Add("city", "surat");
//         slist.Add("country", "india");
//
//         foreach (var item in slist.Keys)
//         {
//             Console.WriteLine(item + " | " + slist[item]);
//         }
//     }
// }