using System;
class mul
{

    public static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int result = 1;
        // double res=(int)Math.Round(Math.Pow(a,b));
        for (int i = 1; i <= b; i++)
        {
            result = result * a;
        }
        Console.Write(result);
    }
}