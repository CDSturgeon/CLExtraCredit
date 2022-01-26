using System;
namespace ConsoleApp1
{
    public class Person
    {
        public byte Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Age = 21;
            Console.WriteLine($"p1.Age = {p1.Age}");
            Person p1Copy = p1;
            p1Copy.Age = 55;
            Console.WriteLine($"p1Copy.Age = {p1Copy.Age}");
            // Does this change if Person is a class instead of a struct
            Console.WriteLine($"p1.Age = {p1.Age}");
        }
    }
}