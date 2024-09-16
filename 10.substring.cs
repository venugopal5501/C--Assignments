using System;
class substring
{
    public static void Main(string[] args)
    {
        string word = Console.ReadLine();
        char[] arr = word.ToCharArray();
        string search = Console.ReadLine();
        int position = word.IndexOf(search);
        if (position != -1)
        {
            Console.Write(position + 1);
        }
        else
        {
            Console.Write("Not Found");
        }
    }
}