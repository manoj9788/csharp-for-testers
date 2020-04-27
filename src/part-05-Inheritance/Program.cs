using System;

namespace Inheritance

{
    class Branch
    {
        int BranchCode = 101;
        string BranchName = "Bangalore";

        public void DisplayBranchData()
           {
            Console.WriteLine("BRANCH CODE IS : " + BranchCode);
            Console.WriteLine("BRANCH NAME IS : " + BranchName);
            
           }
    }
    class Employee : Branch
    {
        int EmployeeId = 1000;
        string EmployeeName = "John";
       
    public void DisplayEmployeeData()
        {
            Console.WriteLine("EMPLOYEE ID IS : " + EmployeeId);
            Console.WriteLine("EMPLOYEE NAME IS : " + EmployeeName);
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj1 = new Employee();
            
            obj1.DisplayBranchData();
            obj1.DisplayEmployeeData();
            
        }
    }
}