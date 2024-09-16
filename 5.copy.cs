using System;
class copy
{
    public static void Main(string[] args)
    {
        string word = Console.ReadLine();
        string copy = word;
        int count = word.Length;
        Console.WriteLine(copy);
        Console.WriteLine("Word Count is : " + count);
    }
}