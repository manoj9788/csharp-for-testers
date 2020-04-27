using System;

namespace MyFirstProject
{
    class Student
    {
        public int age;
        public String name;
    }
       class TestStudent{
       static void Main(string[] args)
        {

            Student s1 = new Student();//creating an object of Student    

            s1.age = 10;
            s1.name = "Vatsala";

            System.Console.WriteLine(s1.age);            
            System.Console.WriteLine(s1.name);

        }
        }
}

