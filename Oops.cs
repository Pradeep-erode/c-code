using System;

namespace Oops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string author1 = "Mahesh Chand";
            string author2 = "Praveen Kumar";
            string author3 = "Mahesh Chand";

            // Compare strings using String.Equals  
            if (String.Equals(author1, author2))
                Console.WriteLine($"{author1} and {author2} have same value.");
            else
                Console.WriteLine($"{author1} and {author2} are different.");

            if (String.Equals(author1, author3))
                Console.WriteLine($"{author1} and {author3} have same value.");
            else
                Console.WriteLine($"{author1} and {author3} are different.");
            sunil obj = new sunil();
            obj.add(2,3);
            vunil obj1 = new vunil();
            obj1.add(7, 4);
        }
    }
    public  class anil
    {
        public virtual void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }


     }
    public class sunil : anil
    {
        public  override void add(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }
    public class vunil : sunil 
    {
        public override void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}

