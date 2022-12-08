using System.Text.RegularExpressions;
namespace Program 
//Write a C# Sharp program to check whether a given string is a valid Hex code or not. Return true if the said string is a valid code otherwise false
{public class HexCode
{
    
    public static bool IsHex(string s){
        
        //var pattern = "[#][A-Z a-z 0-9] {6}\b";
        //Regex rg = new Regex (pattern);
        
        return Regex.IsMatch(s,@"[#][A-Za-z0-9]{6}\b");
    }
    public static void Main( )
    {
        Console.WriteLine (IsHex("#CD5C5C"));
    }
}}