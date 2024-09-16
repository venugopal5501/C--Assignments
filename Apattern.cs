using System;
class pattern
{
    public static void Main(string[] args)
    {
        int a = 6;
        // for(int i=1;i<=a;i++){
        //     for(int j=a;j>=i;j--){
        //         Console.Write("*");
        //     }
        //     Console.WriteLine();
        // }
        // for(int i=1;i<=a;i++){
        //     for (int j=1;j<=i;j++){
        //         Console.Write(" ");
        //     }

        //     Console.WriteLine();

        // }
        for (int i = 1; i <= a; i++)
        {
            for (int j = i; j < a; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= i; k++)
            {
                if (k == 1)
                {
                    Console.Write("*");
                }
                else if (i == 4)
                {
                    Console.Write(" *");
                }
            }
            Console.WriteLine();
            // for(int l=1;l<=i;l++){
            //     Console.Write("");
            // }
            // Console.WriteLine();

        }

    }

}
