using System;
class lowercase
{
    public static void Main(string[] args)
    {
        string word = Console.ReadLine();
        string result = "";
        foreach (char c in word)
        {
            if (char.IsLower(c))
            {
                result = result + char.ToUpper(c);
            }
            else
            {
                result = result + char.ToLower(c);
            }
        }
        Console.Write(result);
    }
}