using System;
using System.Text.RegularExpressions;
class counts
{
    public static void Main(string[] args)
    {
        int count = 0;
        int counts = 0;
        int counts1 = 0;
        string word = Console.ReadLine();
        string pattern = @"[a-zA-Z]$";
        string num = @"[0-9]$";
        string character = @"[.+!*&^%-_=$#@`~]$";
        Regex regex = new Regex(pattern);
        Regex rege = new Regex(num);
        Regex rege1 = new Regex(character);
        foreach (char c in word)
        {
            if (regex.IsMatch(c.ToString()))
            {
                count++;
            }
            if (rege.IsMatch(c.ToString()))
            {
                counts++;
            }
            if (rege1.IsMatch(c.ToString()))
            {
                counts1++;
            }
        }
        Console.WriteLine("Alphabet Count is : " + count);
        Console.WriteLine("Numbers Count is : " + counts);
        Console.WriteLine("Special char Count is : " + counts1);


    }
}