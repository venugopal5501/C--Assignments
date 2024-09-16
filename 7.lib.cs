using System;
class library
{
    public static void Main(string[] args)
    {
        string word = Console.ReadLine();
        char[] arr = word.ToCharArray();
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        for (int j = a; j <= a + b; j++)
        {
            Console.Write(arr[j]);
        }
    }
}