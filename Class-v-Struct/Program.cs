using System;
namespace ConsoleApp1
{
    public class PersonC
    {
        public byte Age { get; set; }
    }
    public struct PersonS
    {
        public byte Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //class reference type example
            Console.WriteLine("Class object - reference type");
            PersonC c1 = new PersonC(); //object from class
            c1.Age = 21;
            Console.WriteLine($"c1.Age = {c1.Age}");
            PersonC c1Copy = c1; //reference type, points to same location in heap
            c1Copy.Age = 55; //reference type changes object in heap, c1 and c1copy both .Age=55
            Console.WriteLine($"c1Copy.Age = {c1Copy.Age}");
            // Does this change if Person is a class instead of a struct
            Console.WriteLine($"c1.Age = {c1.Age}\n\n");


            //struct value type example
            Console.WriteLine("Struct object - value type");
            PersonS s1 = new PersonS();
            s1.Age = 34;
            Console.WriteLine($"s1.Age = {s1.Age}");
            PersonS s1Copy = s1; //value type stays in stack. each has it's own value
            s1Copy.Age = 99; //value type, did not change s1
            Console.WriteLine($"s1Copy.Age = {s1Copy.Age}");
            Console.WriteLine($"s1.Age = {s1.Age}");
        }
    }
}