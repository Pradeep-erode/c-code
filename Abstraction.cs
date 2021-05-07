Abstraction program 

///////////////main class

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Hello World!");
            Child obj = new Child();//object created for child class
            obj.display();//access display function with the help of object created
            obj.disk();
            obj.show(6, 7);//giving inputs for show function through arguments


        }
    }
}

///////////////class2

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //abstract can have both  marked abstract method and non-abstract method in abstract class
    //But interface class having abstract method only 

    public abstract class father
    {
        //abstract method(or marked abstract method) and implemention not done
        public abstract void display();


        //non-abstract method in abstract class 
        public void show(int a,int b)//getting inputs through arguments
        {
           
            Console.Write("\nsum =" + (a + b));
        }
    }


}