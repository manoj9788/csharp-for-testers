using System.Threading.Tasks;
 using System;
 using System.IO;
  class AsyncAwait  
{  
    static void Main()  
    {  
        Task task = new Task(CallMethod);  
        task.Start();  
       //task.Wait();  
        Console.ReadLine();  
    }  
  
    static async void CallMethod()  
    {  
        string filePath = "sample.txt";  
        Task<int> task = ReadFile(filePath);  
  
        Console.WriteLine(" Other Work 1");  
        Console.WriteLine(" Other Work 2");  
        Console.WriteLine(" Other Work 3");  
  
        int length = await task;  
        Console.WriteLine(" Total length: " + length);  
  
        Console.WriteLine(" After work 1");  
        Console.WriteLine(" After work 2");  
    }  
  
    static async Task<int> ReadFile(string file)  
    {  
        int length = 0;  
  
        Console.WriteLine(" File reading is starting");  
        StreamReader reader = new StreamReader(file); 
        if(reader!=null)
        {  
            // Reads all characters from the current position to the end of the stream asynchronously    
            // and returns them as one string.    
            string s = await reader.ReadToEndAsync();  
  
            length = s.Length;  
        }  
        Console.WriteLine(" File reading is completed");  
        return length;  
    }  
}  