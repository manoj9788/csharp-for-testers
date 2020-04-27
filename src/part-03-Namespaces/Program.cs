using System;
//using NameSpaces;
//using First;
//using Second;


namespace part_03_Namespaces
 {
    class Hello
    {  
    public void sayHello() { 
        Console.WriteLine("Hello First Namespace"); 
        
        }  
}  
}  
namespace part_03_Namespaces_Second  
{  
    public class Welcome 
    {  
        public void sayWelcome() { 
            Console.WriteLine("Welcome Namespace"); 
            
            }  
    }  
}  
public class TestNamespace  
{  
    public static void Main()  
    {  
        part_03_Namespaces.Hello h1 = new part_03_Namespaces.Hello();  
        part_03_Namespaces_Second.Welcome h2 = new part_03_Namespaces_Second.Welcome();  
        h1.sayHello();  
        h2.sayWelcome();  
  
    }  
} 