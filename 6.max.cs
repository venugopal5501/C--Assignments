using System;
class maximum
{
    public static void Main(string[] args)
    {
        string word = Console.ReadLine();
        int count = 0;
        char[] arr = word.ToCharArray();
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                    Console.Write(Math.Max(arr[i]));
                }
            }
        }
    }
}