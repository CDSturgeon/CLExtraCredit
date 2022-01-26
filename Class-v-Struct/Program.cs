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
            Console.WriteLine("Class object - reference type\nCreate new object c1 from class PersonC, set age to 21\n");
            PersonC c1 = new PersonC(); //object from class
            byte x = 21;
            c1.Age = x;
            Console.WriteLine($"c1.Age = {c1.Age}\n\nCreate obect c1Copy set equal to c1");
            PersonC c1Copy = c1; //reference type, points to same location in heap
            Console.WriteLine($"c1Copy.Age = {c1Copy.Age}\n\nSet c1Copy.Age = 55");
            c1Copy.Age = 55; //reference type changes object in heap, c1 and c1copy both .Age=55
            Console.WriteLine($"c1Copy.Age = {c1Copy.Age}\n");
            Console.WriteLine("Does c1.Age change when c1Copy.Age is changed?");

            if (c1.Age == x)
                Console.WriteLine("No.");
            else
                Console.WriteLine("Yes");

            Console.WriteLine($"c1.Age = {c1.Age}\n\n");


            //struct value type example
            Console.WriteLine("Struct object - value type\nCreate new object s1 from struct PersonS, set age to 21\n");
            PersonS s1 = new PersonS();
            s1.Age = x;
            Console.WriteLine($"s1.Age = {s1.Age}\n\nCreate obect s1Copy set equal to s1");
            PersonS s1Copy = s1; //value type stays in stack. each has it's own value
            Console.WriteLine($"s1Copy.Age = {s1Copy.Age}\n\nSet s1Copy.Age = 99");
            s1Copy.Age = 99; //value type, did not change s1
            Console.WriteLine($"s1Copy.Age = {s1Copy.Age}\n");
            Console.WriteLine("Does s1.Age change when s1Copy.Age is changed?");

            if (s1.Age == x)
                Console.WriteLine("No.");
            else
                Console.WriteLine("Yes");

            Console.WriteLine($"s1.Age = {s1.Age}");
        }
    }
}