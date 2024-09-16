// using System;
// class substring
// {
//     public static void Main(string[] args)
//     {
//         string word = Console.ReadLine();
//         char[] arr = word.ToCharArray();
//         string search = Console.ReadLine();
//         int position = word.IndexOf(search);
//         if (position != -1)
//         {
//             Console.Write(position + 1);
//         }
//         else
//         {
//             Console.Write("Not Found");
//         }
//     }
// }

using System;
class substring
{
    public static void Main(string[] args)
    {
        string word = Console.ReadLine();
        bool found=false;
        string[] arr = word.Split(new char[] { ' ' });
        string search=Console.ReadLine();
        for(int i=0;i<arr.Length;i++){
            if(search.Equals(arr[i])){
                Console.Write("Word present in string");
                found=true;
            }
            
        }
        if(!found){
            Console.Write("Not Found");
        }
    }
}