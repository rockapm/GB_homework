// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string[] FirstArray(string str)
        {
            string[] arr = str.Split(',');
            return arr;
        }
        
        void PrintArray(string[] arr)
        {
            string s;
            int ii;
            Console.Write("Your words: ");
            for (int i = 0; i < arr.Length; i++)
            {
                s = arr[i];
                ii = i+1;
                Console.Write(s.Trim());
                if (ii < arr.Length) Console.Write(", ");
            }
            Console.WriteLine();
        }
        
        void FilterArray(string[] arr)
        {
            //string[] res = new string[];
            string s;
            int ii;
            Console.Write("Words < 3 symbols: ");
            for (int i = 0; i < arr.Length; i++)
            {
                s = arr[i].Trim();
                ii = i+1;
                if (s.Length <= 3) 
                {
                    Console.Write(s);
                    if (ii < arr.Length) {Console.Write(", ");}
                }
            }
        }
        
        
        //.WriteLine(FirstArray("2312, sasfa, 23, 123123,232"));
        PrintArray(FirstArray("2312, sasfa, 23, 123123,232, sdf, gggggg, 123"));
        FilterArray(FirstArray("2312, sasfa, 23, 123123,232, sdf, gggggg, 123"));
    }
}
