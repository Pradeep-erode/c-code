using System;

namespace loopsample
{
    class sample
    {
        public void first()
        {
            int sum = 0;

            Console.Write("Enter number you want:");
            int a = Convert.ToInt16(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine(i);

                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            sample obj = new sample();
            obj.first();
           
            
        } 
    }
}
