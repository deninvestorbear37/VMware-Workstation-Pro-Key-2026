using System;
using System.Text;
class StringManipulator{
    public string Reverse(string input){
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    public string ToUpperCase(string input){
        return input.ToUpper();
    }
    public string ToLowerCase(string input){
        return input.ToLower();
    }
    public string RemoveWhitespace(string input){
        return input.Replace(" ", "");
    }
    public string Append(string str1, string str2){
        return string.Concat(str1, str2);
    }
    public string ReplaceSubstring(string input, string oldValue, string newValue){
        return input.Replace(oldValue, newValue);
    }
    public string Trim(string input){
        return input.Trim();
    }
    public int CountVowels(string input){
        int count = 0;
        foreach(char c in input.ToLower()){
            if("aeiou".Contains(c)){
                count++;
            }
        }
        return count;
    }
    public string[] SplitByDelimiter(string input, char delimiter){
        return input.Split(delimiter);
    }
    public bool ContainsSubstring(string input, string substring){
        return input.Contains(substring);
    }
    public void PrintStrings(string[] strings){
        foreach(string str in strings){
            Console.WriteLine(str);
        }
    }
    public static void Main(){
        StringManipulator sm = new StringManipulator();
        string testString = "Hello World";
        Console.WriteLine(sm.Reverse(testString));
        Console.WriteLine(sm.ToUpperCase(testString));
        Console.WriteLine(sm.RemoveWhitespace(testString));
        Console.WriteLine(sm.CountVowels(testString));
        string[] splitResult = sm.SplitByDelimiter(testString, ' ');
        sm.PrintStrings(splitResult);
    }
}
