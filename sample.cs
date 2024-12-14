// using System;
// using System.Collections.Generic;
// class Program<T>{
//     private T data;
//     public T Data{
//         get{return data;}
//         set{data = value;}
//     }

// }
// class Test{
//     public static void Main(string []args){
//         Program<int> sample= new Program<int>();
//         Program<string> sample1=new Program<string>();
//         sample.Data=5;
//         sample1.Data="Venugopal";
//         Console.WriteLine(sample.Data);
//                 Console.WriteLine(sample1.Data);

//     }
// }

// using System;
// class Test{
//     public void test(string a, int length){
//         if(length<0){
//             return;
//         }
//         Console.Write(a[length]);
//         test(a, length-1);

//     }
//     public static void Main(string []args){
//         string a= Console.ReadLine();
//         int length= a.Length-1;
//         Test tes= new Test();
//         tes.test(a, length);


//     }
// }

// using System;
// class Test{
//     public int factorial(int n){
//         if(n<0){
//            return -1;
//         }
//          if (n == 0 || n == 1) {
//             return 1; // Base case: factorial of 0 and 1 is 1
//         }
//         return n* factorial(n-1);
//     }
//     public static void Main(string []args){
//         int a=Convert.ToInt32(Console.ReadLine());
//         int b=Convert.ToInt32(Console.ReadLine());
//         Test test= new Test();
//         int ncr=test.factorial(a)/(test.factorial(b)*test.factorial(a-b));
//         Console.WriteLine(""+ncr);

//     }
// }


// using System;
// class Test{
//     public static void Main(string []args){
//         int [][]arr=new int[][]{
//             new int[]{1,2,3,4},
//             new int[]{1,2},
//             new int[]{1,2,3,4,5,6};
//         };
//         int len=arr.Length;
//         Console.WriteLine("", len);
//         for(int i=0;i<arr.Length;i++){
//             Console.WriteLine(arr[i].Length);
//         }

//     }
// }

//  using System;
// delegate int name(int n);
// class Test{
//     public int feet(int n){
//         return n*12;

//     }
//     public static void Main(string []args){
//         Test test= new Test();
//         int num=Convert.ToInt32(Console.ReadLine());
//         name n=new name(test.feet);
//         int np=n(num);
//         Console.WriteLine(+np);
//     }
// }

//  using System;
// delegate int name(int v);
// delegate int names(int v);
// class Test{
//     public static void Main(string[] args){
//         name ns=count=>count+2;
//         names nsv=n=>n%2==0;
//         int x=-10;
//         while(x<=0){
//             x=ns(x);
//             Console.WriteLine(x);
//         }
//         for(int i=0;i<30;i++){
//             int w=nsv(i);
//             Console.WriteLine(w);
//         }

//     }
// }

// using System; 



// class length 

// { 

//     public static void Main(string[] args) 

//     { 

//         Console.Write("Enter Word : "); 

//         string word=Console.ReadLine(); 
//         int count = 0;
//         char []arr=word.ToCharArray();
//         foreach(char c in arr){
//             count++;
//         }
//         Console.WriteLine(count);
//     }
// }



// using System; 



// class length 

// { 

//     public static void Main(string[] args) 

//     { 

//         Console.Write("Enter Word : "); 

//         string word=Console.ReadLine(); 



//         for(int i=word.Length-1;i>=0;i--){
//             Console.WriteLine(word[i]);

//         }
//     }
// }


// using System; 



// class length 

// { 

//     public static void Main(string[] args) 

//     { 

//         Console.Write("Enter Word : "); 

//         string word=Console.ReadLine(); 

// int count=0;

//         string []arr=word.Split(' ');
//         for (int i=0; i<arr.Length;i++){
//             count++;
//         }
//         Console.WriteLine(""+count);
//     }
// }

// using System;
// class maximum

// {

//     public static void Main(string[] args)

//     {
//         string word = Console.ReadLine();

//         int count = 0;
//         char []arr=word.ToCharArray();
//         for(int i=0;i<arr.Length;i++){
//             for(int j=i+1;j<arr.Length;j++){
//                 if(arr[i]==arr[j]){
//                     count++;
//                 }
//             }
//             Console.WriteLine(arr[i],count);

//         }


//     }
// }


// using System;

// class maximum

// {

//     public static void Main(string[] args)

//     {
//         int max = 0;
//         char a1 = ' ';

//         string word = Console.ReadLine();


//         for (int i = 0; i < word.Length; i++)
//         {
//             int count = 1;
//             char c = word[i];
//             for (int j = i + 1; j < word.Length; j++)
//             {
//                 if (word[i] == word[j])
//                 {
//                     count++;
//                 }
//                 if (max < count)
//                 {
//                     max = count;
//                     a1 = word[j];
//                 }


//             }



//         }
//         Console.WriteLine(a1 + " " + max);
//     }
// }



// using System; 

// class library 

// { 

//     public static void Main(string[] args) 

//     { 

//         string word = Console.ReadLine(); 

//         char[] arr = word.ToCharArray(); 

//         int a = Convert.ToInt32(Console.ReadLine()); 

//         int b = Convert.ToInt32(Console.ReadLine()); 

//         for (int j = a; j <= a + b; j++) 

//         { 

//             Console.Write(arr[j]); 

//         } 

//     } 

// } 

// using System; 

// class sort 

// { 

//     public static void Main(string[] args) 

//     { 

//         Console.Write("Enter array length : "); 

//         int a = Convert.ToInt32(Console.ReadLine()); 

//         string[] word = new string[a]; 

//         Console.Write("Enter word : "); 

//         for (int i = 0; i < a; i++) 

//         { 

//             word[i] = Console.ReadLine(); 

//         } 

//         for (int i = 0; i < word.Length; i++) 

//         { 

//             for (int j = 0 + i; j < word.Length; j++) 

//             { 

//                 if (string.Compare(word[i].ToLower(),word[j].ToLower())>0) 

//                 { 

//                     string temp = word[i]; 

//                     word[i] = word[j]; 

//                     word[j] = temp; 

//                 } 

//             } 

//         } 

//         for(int i=0;i<word.Length;i++){ 

//             Console.Write(word[i]); 

//         } 



//     } 

// } 

// using System; 

// class lowercase 

// { 

//     public static void Main(string[] args) 

//     { 

//         string word = Console.ReadLine(); 

//         string result = ""; 

//         foreach (char c in word) 

//         { 

//             if (char.IsLower(c)) 

//             { 

//                 result = result + char.ToUpper(c); 

//             } 

//             else 

//             { 

//                 result = result + char.ToLower(c); 

//             } 

//         } 

//         Console.Write(result); 

//     } 

// } 

// using System; 

// class substring 

// { 

//     public static void Main(string[] args) 

//     { 

//         string word = Console.ReadLine(); 

//         bool found=false; 

//         string[] arr = word.Split(new char[] { ' ' }); 

//         string search=Console.ReadLine(); 

//         for(int i=0;i<arr.Length;i++){ 

//             if(search.Equals(arr[i])){ 

//                 Console.Write("Word present in string"); 

//                 found=true; 

//             } 



//         } 

//         if(!found){ 

//             Console.Write("Not Found"); 

//         } 

//     } 

// } 



// using System; 

// class index 

// { 

//     public static void Main(string[] args) 

//     { 

//         string word = Console.ReadLine(); 

//         string search = Console.ReadLine(); 

//         int position = word.IndexOf(search); 

//         if (position!=-1) 

//         { 

//             Console.Write(position+1); 

//         } 

//         else{ 
//             Console.Write("Not Found"); 
//         } 
//     } 
// } 

// using System; 

// class mul 

// { 



//     public static void Main(string[] args) 

//     { 

//         int a = Convert.ToInt32(Console.ReadLine()); 

//         int b = Convert.ToInt32(Console.ReadLine()); 

//         int result = 1; 

//         // double res=(int)Math.Round(Math.Pow(a,b)); 

//         for (int i = 1; i <= b; i++) 

//         { 

//             result = result * a; 

//         } 

//         Console.Write(result); 

//     } 

// } 

// using System; 

// class fibonacci 

// {
//     public static void Main(string []args){
//         int a=0,b=1;
//         int c=Convert.ToInt32(Console.ReadLine());
//         for(int i=2;i<c;i++){
//             int next=a+b;
//             b=a;
//             a=next;
//             Console.WriteLine(next);
//         }
//     } 
// }


// using System;

// class Permutations
// {
//     // Method to swap two elements in the array
//     private static void Swap(ref int a, ref int b)
//     {
//         int temp = a;
//         a = b;
//         b = temp;
//     }

//     // Recursive method to generate permutations
//     private static void GeneratePermutations(int[] arr, int currentIndex, int length)
//     {
//         // Base case: if current index equals the length, print the permutation
//         if (currentIndex == length)
//         {
//             // Print the current permutation
//             Console.WriteLine(string.Join(" ", arr));
//             return;
//         }

//         for (int i = currentIndex; i < length; i++)
//         {
//             // Swap the current element with the element at the currentIndex
//             Swap(ref arr[currentIndex], ref arr[i]);

//             // Recursively generate permutations for the rest of the elements
//             GeneratePermutations(arr, currentIndex + 1, length);

//             // Swap back (backtrack) to maintain original array for the next iteration
//             Swap(ref arr[currentIndex], ref arr[i]);
//         }
//     }

//     public static void Main(string[] args)
//     {
//         // Input array
//         int[] arr = { 1, 2, 3 };

//         Console.WriteLine("All possible permutations of the array are:");
//         // Call the recursive method to generate permutations
//         GeneratePermutations(arr, 0, arr.Length);
//     }
// }

// using System;

// class Permutations
// {
//     // Method to swap two elements in the array
//     private static void Swap(ref int a, ref int b)
//     {
//         int temp = a;
//         a = b;
//         b = temp;
//     }

//     // Recursive method to generate permutations
//     private static void GeneratePermutations(int[] arr, int currentIndex, int length)
//     {
//         // Base case: if current index equals the length, print the permutation
//         if (currentIndex == length)
//         {
//             // Print the current permutation
//             Console.WriteLine(string.Join(" ", arr));
//             return;
//         }

//         for (int i = currentIndex; i < length; i++)
//         {
//             // Swap the current element with the element at the currentIndex
//             Swap(ref arr[currentIndex], ref arr[i]);

//             // Recursively generate permutations for the rest of the elements
//             GeneratePermutations(arr, currentIndex + 1, length);

//             // Swap back (backtrack) to maintain original array for the next iteration
//             Swap(ref arr[currentIndex], ref arr[i]);
//         }
//     }

//     public static void Main(string[] args)
//     {
//         // Input array
//         int[] arr = { 1, 2, 3 };

//         Console.WriteLine("All possible permutations of the array are:");
//         // Call the recursive method to generate permutations
//         GeneratePermutations(arr, 0, arr.Length);
//     }
// }


// using System; 

// class duplicate 

// { 

//     public static void Main(string[] args) 

//     { 

//         int count = 0; 

//         Console.Write("Enter length of an array : "); 

//         int a = Convert.ToInt32(Console.ReadLine()); 

//         int[] arr = new int[a]; 

//         for (int i = 0; i < a; i++) 

//         { 

//             arr[i] = Convert.ToInt32(Console.ReadLine()); 

//         } 

//         for (int i = 0; i < a; i++) 

//         { 

//             for (int j = i + 1; j < a; j++) 

//             { 

//                 if (arr[i] == arr[j]) 

//                 { 

//                     count++; 

//                     break; 

//                 } 

//             } 

//         } 



//         for(int i=0;i<a;i++){ 

//             Console.Write(arr[i]+" "); 

//         } 

//         Console.WriteLine("\n"+"The duplicate elements are : "+count); 

//     } 

// } 

// using System; 

// class matrix 

// { 

//     public static void Main(string[] args) 

//     { 

//         int c = 0; 

//         Console.Write("Enter the length 1 "); 

//         int a = Convert.ToInt32(Console.ReadLine()); 

//         int[] arr = new int[a]; 

 

//         Console.Write("Enter the length 2 "); 

 

//         int b = Convert.ToInt32(Console.ReadLine()); 

//         int[] ar = new int[b]; 

//         for (int i = 0; i < a; i++) 

//         { 

//             arr[i] = Convert.ToInt32(Console.ReadLine()); 

 

//         } 

//         for (int i = 0; i < a; i++) 

//         { 

//             ar[i] = Convert.ToInt32(Console.ReadLine()); 

//         } 

//         for (int i = 0; i < a; i++) 

//         { 

//             Console.Write(arr[i] + " "); 

//         } 

//         for (int i = 0; i < a; i++) 

//         { 

//             Console.Write(ar[i] + " "); 

//         } 

//         Console.WriteLine(); 

 

//         for (int i = 0; i < a; i++) 

//         { 

//             for (int j = 0; j < a; j++) 

//             { 

//                 if (i == j) 

//                 { 

//                     c = arr[i] + ar[j]; 

//                     Console.Write(c + " "); 
//                 } 
//             } 
//         } 
//     } 

// } 


// using System; 

// class row 

// { 

//     public static void Main(string[] args) 

//     { 

//         Console.Write("Enter Row Size"); 

//         int a = Convert.ToInt32(Console.ReadLine()); 

//         Console.Write("Enter Row Size"); 

//         int b = Convert.ToInt32(Console.ReadLine()); 

//         int[,] arr = new int[a, b]; 

//         int[] res = new int[a]; 

//         int[] res1 = new int[b]; 

//         for (int i = 0; i < a; i++) 

//         { 

//             for (int j = 0; j < b; j++) 

//             { 

//                 arr[i, j] = Convert.ToInt32(Console.ReadLine()); 

//             } 

//         }
//         for (int i = 0; i < a; i++) 

//         { 

//             for (int j = 0; j < b; j++) 

//             { 
//                 Console.Write(arr[j,i]);
//             }
//             Console.WriteLine();
//         }
//     } 
// } 

// using System; 

// class Quest14{ 

//     public static void Main(string[] args){ 

//         Console.Write("Enter which table is to be printed"); 

//         int a=Convert.ToInt32(Console.ReadLine()); 

     

//          int val=Convert.ToInt32(a.ToString(), 2); 

 

// Console.Write(val); 

//     } 

// } 


using System; 

// class Quest14{ 
//     public void recursive(int a){
         
//         if(a>10){
//             return;
//         }
//         Console.WriteLine(a);
//         recursive(a+1);

//     }

//     public static void Main(string[] args){ 
//         Quest14 q=new Quest14();
//         int b=1;
//         q.recursive(b);
//     }
// }


using System;
using System.Collections.Generic;
using System.Linq;

 class Program 

    { 

        static void Main(string[] args) 

        { 

        List <int> sample= new List<int> { -10, 15, 0, 8, -5, 22, 7, 4, -1, 12 }; 

        var result = from s in sample where s > 0 select s; 

        foreach(var res in result) 


        { 

            Console.WriteLine(res);  

        } 

 

    } 

    } 

 