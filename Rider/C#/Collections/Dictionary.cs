using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Rider.C_.Collections;

public class Dictionary
{
    public static void Main(string[] args)
    {
        // Declaration
        Dictionary<string, string> d1 = new Dictionary<string, string>();
        Dictionary<string, int> d2 = new Dictionary<string, int>();
        Dictionary<int, string> mp = new Dictionary<int, string>(3);
        Dictionary<int, string> mp1 = new Dictionary<int, string>(3) {{1, "Hello"}, {2, "yash"}, {3, "Good Evening"}};

        // Initialization
        mp[1] = "How";
        mp[2] = "Are";
        mp[3] = "You?";
        
        // Access Elements

        // for (int i = 1; i <= 3; i++)
        // {
        //     Console.WriteLine("Key: "+i+" Value: "+mp[i]);
        // }
        //

        
        // ➡️ Contains Method
        // if(mp.ContainsKey(1)) Console.WriteLine("Yesss");
        
        //use ContainsKey() to check for an unknown key
                // if(cities.ContainsKey("France")){  
                //     Console.WriteLine(cities["France"]);
                // }

        //use TryGetValue() to get a value of unknown key
                // string result;
                //
                // if(cities.TryGetValue("France", out result))
                // {
                //     Console.WriteLine(result);
                // }

        //use ElementAt() to retrieve key-value pair using index
                // for (int i = 0; i < cities.Count; i++)
                // {
                //     Console.WriteLine("Key: {0}, Value: {1}", 
                //         cities.ElementAt(i).Key, 
                //         cities.ElementAt(i).Value);
                // }
                
        // ➡️ Update or Remove
        if (mp.ContainsKey(1))
        {
            mp[1] = "Changed";
        }

        if (mp.ContainsKey(2))
        {
            mp.Remove(2);
        }
        
        foreach (var item in mp)
        {
            Console.WriteLine($"Key : {item.Key} | Value: {item.Value}");
        }
    }
}