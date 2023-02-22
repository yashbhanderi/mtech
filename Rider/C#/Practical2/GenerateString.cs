using System;
using System.Linq;
using System.Security.Cryptography;

namespace Rider.C_.Practical2;

public class GenerateString
{
    public static string UniqueStringGenerator()
    {
        var rnd = new Random();
        var hexNum =  rnd.Next(1, 3000000).ToString("X");
        var uniqueString = hexNum + GenerateRandomString(20-hexNum.Length);
        return uniqueString;
    }
    //
    public static string GenerateRandomString(int length)
    {
        // 🟨 Fisher Yates Rearrange Algorithm
        const string lowerChars = "abcdefghijklmnopqrstuvwxyz";
        const string upperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string numberChars = "0123456789";
        const string specialChars = "!@#$%^&*()_+-=[]{}|;':\",./<>?";
        
        var chars = new char[length];
        
        // Generate at least one character from each set
        chars[0] = lowerChars[RandomNumberGenerator.GetInt32(lowerChars.Length)];
        chars[1] = upperChars[RandomNumberGenerator.GetInt32(upperChars.Length)];
        chars[2] = numberChars[RandomNumberGenerator.GetInt32(numberChars.Length)];
        chars[3] = specialChars[RandomNumberGenerator.GetInt32(specialChars.Length)];
        
        // Fill the rest of the string with random characters
        for (var i = 4; i < length; i++)
        {
            var allChars = lowerChars + upperChars + numberChars + specialChars;
            chars[i] = allChars[RandomNumberGenerator.GetInt32(allChars.Length)];
        }
        
        // Shuffle the characters using Fisher-Yates algorithm
        for (var i = length - 1; i > 0; i--)
        {
            var j = RandomNumberGenerator.GetInt32(i + 1);
            (chars[i], chars[j]) = (chars[j], chars[i]);
        }
        
        return new string(chars);
    }

    public static string GeneratePassword1()
    {
        TimeSpan currentSpan = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        string currentSpanString = currentSpan.ToString(@"dd\.hh\:mm\:ss\.ff") + "aA$";
        return currentSpanString;
    }
        
        
        
    // ⚡⚡⚡⚡⚡⚡⚡ Performance Analysis ⚡⚡⚡⚡⚡⚡⚡⚡
        
    // 🟨 With Fisher Yates Algorithm
        
    // ----> For 1 million:
    // string generate and insert together : 119 sec
    // string generate and insert different : 99 sec
        
    // ➡️ ----> 3 MILLION RECORDS : 288 sec, 4.81 Min
    // ➡️ ----> 3 MILLION RECORDS : 306 sec, 5.12 Min
    // ➡️ ----> 3 MILLION RECORDS : 339 sec, 5.65 Min
    //                            ________________________
    //               Average:       311 sec, 5.19 Min
        
        
    // 🟨 Without Algorithm
        
    // ➡️ ----> 3 MILLION RECORDS : 278 sec, 4.63 Min
    // ➡️ ----> 3 MILLION RECORDS : 319 sec, 5.32 Min
    // ➡️ ----> 3 MILLION RECORDS : 295 sec, 4.92 Min
    //                           ________________________
    //               Average:       297 sec, 4.95 Min
}