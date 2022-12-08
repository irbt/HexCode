using System.Text.RegularExpressions;
namespace Program 
//Write a C# Sharp program to check whether a given string is a valid Hex code or not. Return true if the said string is a valid code otherwise false
{public class HexCode
{
    
    public static bool IsHex(string s){
        var pattern = @"[#][A-Za-z0-9]{6}\b";
        Regex rg = new Regex (pattern);
        
        return Regex.IsMatch(s,pattern);
    }
    public static void Main( )
    {
        Console.Clear();
        Console.WriteLine (IsHex("#CD5C5C"));
        Console.WriteLine (IsHex("#f08080"));
        Console.WriteLine (IsHex("#E9967A"));
        Console.WriteLine (IsHex("#EFFA07A"));
    }
}}