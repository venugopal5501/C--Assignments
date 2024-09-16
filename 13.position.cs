using System;
class position
{
    public static void Main(string[] args)
    {
        bool found = false;
        string word = Console.ReadLine();
        int count = word.Length;
        string[] arr = word.Split(new char[] { ' ' });
        string search = Console.ReadLine();
        for (int i = 0; i < arr.Length; i++)
        {
            if (search.Equals(arr[i]))
            {
                Console.Write("Found in ");
                Console.Write(i + 1 + " place");
                found = true;
            }
        }
        if (!found)
        {
            Console.Write("not found");
        }
    }
}