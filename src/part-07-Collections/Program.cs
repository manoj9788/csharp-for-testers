using System;
using System.Collections.Generic;
namespace testExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step2: Create a list using List<T> class
            List<int> list_name = new List<int>(); // declaration of list
            //List<int> list_name = new List<int>() { 10, 6, 1, 4, 100, 21, 34, 2, 7 }; // declarations and initialization of a list
            list_name.Add(1);
            list_name.Add(100);
            list_name.Add(2);
            list_name.Add(1);
            list_name.Add(4);
           
            List<string> stirngname = new List<string>(); // declaration of list
            stirngname.Add("John");
            stirngname.Add("Smith");
            foreach (string a in stirngname)
            {
                Console.WriteLine("values are:: *******" + a);
            }
            Console.WriteLine("The length of the list is:  " + list_name.Count);
            list_name.AddRange(list_name);
            
            foreach (int a in list_name)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("index 0 value in the list is:: " + list_name[0]);
            Console.WriteLine("Index 4 value in the list is:: " + list_name[4]);
            
            foreach (int a in list_name)
            {
                Console.WriteLine(a);
            }
            for (int i = 0; i < list_name.Count; i++)
            {
                Console.WriteLine(list_name[i]);
            }
            
            list_name.Remove(14);
            for (int i = 0; i < list_name.Count; i++)
            {
                Console.WriteLine(list_name[i]);
            }
            
            list_name.RemoveAt(4);
            Console.WriteLine(list_name.Count);
            for (int i = 0; i < list_name.Count; i++)
            {
                Console.WriteLine(list_name[i]);
            }
            
            list_name.RemoveRange(2, 5);
            Console.WriteLine(list_name.Count);
            for (int i = 0; i < list_name.Count; i++)
            {
                Console.WriteLine(list_name[i]);
            }
            
            list_name.Clear();
            Console.WriteLine(list_name.Count);
            
            list_name.Add(1000000);
            Console.WriteLine(list_name.Count);
            
            list_name.Sort();
            for (int i = 0; i < list_name.Count; i++)
            {
                Console.WriteLine(list_name[i]);
            }
            
//****************** Dictionary class *********************
            /*Dictionary<string, string> my_dict = new Dictionary<string, string>();
            my_dict.Add("1", "c");
            my_dict.Add("2", "c++");
            my_dict.Add("3", "JAVA");
            my_dict.Add("4", "RUBY");
            my_dict.Add("5", "PYTHON");
            my_dict.Add("6", "csharp");
            my_dict.Add("7", "js");
            my_dict.Add("8", "goLang");
            Console.WriteLine("Total key value pairs in dictionary are:: " + my_dict.Count);
            foreach (KeyValuePair<string, string> kvp in my_dict)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
            Dictionary<string, string>.KeyCollection keyCol = my_dict.Keys;
            Console.WriteLine("Keys are:: ");
            foreach (String s in keyCol)
            {
                Console.WriteLine("Key={0}", s);
            }
            Dictionary<string, string>.ValueCollection valueCol = my_dict.Values;
            Console.WriteLine("Values are:: ");
            foreach (String v in valueCol)
            {
                Console.WriteLine("value = {0}", v);
            }
            my_dict.Clear();
            Console.WriteLine("Total key/value pairs in " + "myDict after Clear() operation are : " + my_dict.Count);
            Console.WriteLine("Before removing total key value pair:: " + my_dict.Count);
            my_dict.Remove("4");
            Console.WriteLine("After removing total key value pair:: " + my_dict.Count);
            */
        }
    }
}