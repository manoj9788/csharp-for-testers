using System;  
   public class Employee  
    {  
        public int id;   
        public String name;  
        public float salary;  
        public void insert(int i, String n,float s)  
        {  
            id = i;  
            name = n;  
            salary = s;  
        }  
        public void display()  
        {  
            Console.WriteLine($"The Employee information is: {id} {name} {salary}");  
        }  
   }  
   class TestEmployee{  
       public static void Main(string[] args)  
        {  
            Employee e1 = new Employee();  
            Employee e2 = new Employee();  
            e1.insert(101, "Manoj",001);  
            e2.insert(102, "Kumar",002);  
            e1.display();  
            e2.display();  
  
        }  
    }  
