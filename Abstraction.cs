Abstraction program 


//main class


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



//father class


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


//child class


using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //inheritance of father class
    public class Child:father
    {
        
        //implementation of abstract class using override keyword whereas in method overriding this is not compulsary 
        //to implement 


        public override void display()
        {
            Console.WriteLine("I am implanted class");
        }
        public void disk()
        {
            Console.Write("I am pradeep");
        }
    }
}

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