using System;
class library
{
    public static void Main(string[] args)
    {
        string word = Console.ReadLine();
        char[] arr = word.ToCharArray();
        int a = Convert.ToInt32(Console.ReadLine());
        // int position=arr.IndexOf(3);
        // Console.Write(position);

        // foreach(char c in word){


        // }
        for (int i = 0; i < arr.Length; i++)
        {
            if (a==i){
                Console.Write(arr[i]);
            }
        }

    }
}