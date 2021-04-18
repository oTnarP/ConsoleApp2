using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //All Variables

            int age = 22;
            string name = "Pranto";
            char eyes = '2';
            decimal rice = 2.5M;
            DateTime dateTime = DateTime.Now;


            Console.WriteLine("My name is " + name + " and I am " + age + " years old. I am gonna buy " + rice + " KG Rice and Current Time is : " + dateTime);
        }
    }
}
