using System;
class last
{
    public static void Main(string[] args)
    {
        string first = Console.ReadLine();
        string name = Console.ReadLine();
        string full = first + " " + name;
        string[] arr = full.Split(' ');
        for(int i=0;i<arr.Length;i++){
            for(int j=1+i;j<arr.Length;j++){
                if(string.Compare(arr[i].ToLower(),arr[j].ToLower())>0)
                {
                    string temp= arr[i];
                    arr[i]=arr[j];
                    arr[j]=temp;
                    
                }
                // Console.Write();
                
            }
        }
        for(int i=0;i<arr.Length;i++){
            Console.Write(arr[i]+" ");
        }
        


    }
}