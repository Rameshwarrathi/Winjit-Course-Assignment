using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Student stud = new Student();
            stud.setdata(1, "Rameshwar", "C#");
            stud.getdata();

            Console.ReadLine();
        }
    }
}
