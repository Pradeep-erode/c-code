using System;
namespace GeeksForGeeks
{

    // Declaring the delegates
    public delegate void mydel(int a, int b);
    
    class class1: class2
    {
        public void display(int a, int b)
        {
            Console.WriteLine("sum on class1 :"+(a - b));
        }
        public void disk()
        {
            Console.WriteLine("I am normal Delegate");
        }
    }
    class class2
    {

        // Delegate parameter and method parameter datatype should be same then only it is called

        // method "sum"
        public void sum(int a, int b)
        {
            Console.WriteLine("(100 + 60) = {0}", a + b);
        }

        // method "subtract"
        public void subtract(int a, int b)
        {
            Console.WriteLine("(100 - 60) = {0}", a - b);
        }

        // Main Method
        public static void Main(String[] args)
        {

            // creating object "object1" of class "class1"
            class1 object1 = new class1();
            


            //Implementation of Delegates
            // creating object of delegate, name as "dell1,dell2" 

            mydel delobj = new mydel(object1.display);
            delobj += object1.sum;
            delobj += object1.subtract;

            // pass the values to the methods by delegate object
            delobj(100, 60);
            
        }
    }
}