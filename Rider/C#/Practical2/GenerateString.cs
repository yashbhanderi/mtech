using System;
using System.Linq;
using System.Security.Cryptography;

namespace Rider.C_.Practical2;

public class GenerateString
{
    public static string UniqueStringGenerator(int num)
    {
        var hexNum = num.ToString("X");
        var uniqueString = hexNum + GenerateRandomString(20-hexNum.Length);
        return uniqueString;
    }
    
    public static string GenerateRandomString(int length)
    {
        
        // 🟨 Without Algorithm
        
        // string str = "aA1#";
        // for (int i = 4; i < length; i++) str += 'a';
        // return str;
        
        
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
}