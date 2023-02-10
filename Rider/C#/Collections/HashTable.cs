// using System.Collections;
// namespace Rider.C_.Collections;
//
// public class HashTable
//
// // Implement IDictionary Interface
// // Data retrieval is slower than dictionary because of boxing-unboxing. ⚡
// // Better than Array and ArrayList for data retrieval
// {
//     public static void Main(string[] args)
//     {
//         Hashtable ht = new Hashtable();
//         ht.Add("id", 101);
//         ht.Add("name", "Yash Bhanderi");
//         ht.Add("city", "Ahmedabad");
//         ht.Add("country", "India");
//         
//         // 👉-> Accessing elements
//         // *** Two methods: Both generate random order of list every time  
//         // 1)
//         
//         foreach (DictionaryEntry item in ht)        // Elements are stored as DictionaryEntry objects
//         {
//             Console.WriteLine(item.Key +" | "+item.Value);
//         }
//         
//         // 2)
//         // foreach (var item in ht.Keys)
//         // {
//         //     Console.WriteLine(item + " | " + ht[item]);
//         // }
//         
//         // 👉-> Hashcode object has main 3 properties
//         // Key, Value and hashcode
//         // Hashcode is a code generated using 32-bit signed algorithm used for strings
//         // If int-> code is as it is
//         // If string -> Algorithm generate code
//         // Console.WriteLine("name".GetHashCode());    // Every time new generated code
//         
//         // 👉 Remove
//         ht.Remove("name");
//         
//         // 👉 Check Availability
//         if(ht.Contains("name") || ht.ContainsKey("name")) Console.WriteLine("Yes");     // Both works same
//         else Console.WriteLine("No");
//         
//         if(ht.ContainsValue("India")) Console.WriteLine("Yes");
//         else Console.WriteLine("No"); 
//         
//         // 👉 Convert to specific data type
//         // string? city = ht["city"].ToString();
//         string? city = (string) ht["city"]!;
//         Console.WriteLine(city);
//         
//         // 👉 Dictionary to Hashtable
//         // Dictionary<int, string> dict = new Dictionary<int, string>();
//         // dict.Add(1, "one");
//         // dict.Add(2, "two");
//         // dict.Add(3, "three");
//         //
//         // Hashtable ht = new Hashtable(dict);
//         
//         
//     }
// }