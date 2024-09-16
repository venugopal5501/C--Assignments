using System;
class index
{
    public static void Main(string[] args)
    {
        string word = Console.ReadLine();
        string search = Console.ReadLine();
        int position = word.IndexOf(search);
        if (position!=-1)
        {
            Console.Write(position+1);
        }
        else{
            Console.Write("Not Found");
        }

    }
}