using System;

namespace Encapsulation
{
    public class Example
    {
        private int x;

         public int getX()
        {
            return x;
        }
        public void setX(int x)
        {
            if (x > 0)
            {
                this.x = x;
            }
            else
            {
                Console.WriteLine("Please Pass a positive value");
            }
        }
    }
    

    class Sample
    {
        public static void Main()
        {
            Example e = new Example();
            //We cannot use the variable directly here
            // e.x = 50; //Compile time errr
            // Console.WriteLine(e.x); //Compile time errr
            e.setX(10);
            Console.WriteLine(e.getX());
            e.setX(-50);
            Console.WriteLine(e.getX());
            
        }
    }

}