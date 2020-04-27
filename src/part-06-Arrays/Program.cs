using System;  
public class ArrayExample  
{  
    public static void Main(string[] args)  
    {  
        int[] arr = { 10, 20, 30, 40, 50 };//creating and initializing array  
   
        //traversing array  
        foreach (int i in arr)  
        {  
            Console.WriteLine(i);  
        }  
    }  
}  

//Passing Array as Function
/*
public class ArrayExample  
{  
    static void printArray(int[] arr)  
    {  
        Console.WriteLine("Printing array elements:");  
        for (int i = 0; i < arr.Length; i++)  
        {  
              Console.WriteLine(arr[i]);  
        }  
    }  
    public static void Main(string[] args)  
    {  
        int[] arr1 = { 25, 10, 20, 15, 40, 50 };  
        int[] arr2 = { 12, 23, 44, 11, 54 };  
        printArray(arr1);//passing array to function  
        printArray(arr2);  
    }  
}  
*/

//C# Params - Array

/*
using System;  
namespace AccessSpecifiers  
{  
    class Program  
    {  
        // User defined function  
        public void Show(params int[] val) // Params Paramater  
        {  
            for (int i=0; i<val.Length; i++)  
            {  
                Console.WriteLine(val[i]);  
            }  
        }  
        // Main function, execution entry point of the program  
        static void Main(string[] args)  
        {  
            Program program = new Program(); // Creating Object  
            program.Show(2,4,6,8,10,12,14); // Passing arguments of variable length  
        }  
    }  
}  
*/