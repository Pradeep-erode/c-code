using System;

namespace oops
{
    class Program
    {
        static void Main(string[] args)
        {
            polybase obj = new polybase();
            obj.add(2, 3);
            obj.add(2, 3,7);
            overrid obj1 = new overrid();
            obj1.add(7, 4);
            sealclass obj5 = new sealclass();
            obj5.add(3, 5);
            overridr obj6 = new overridr();
            obj6.norm();
            obj6.abs();
            mutliinherti obj2 = new mutliinherti();
            obj2.class1();
            obj2.class2();
            sett obj3 = new sett();
            obj3.Name = "rav";
            Console.Write(obj3.Name);
            setand obj4 = new setand();
            obj4.display();
        }
    }



    /// <summary>
    /// /polymorphism==method overloading and method overriding
    /// </summary>


        public class polybase
        {
            public virtual void add(int a, int b)
            {
                Console.WriteLine("Adding two numbers in polybase virtual:"+(a + b));
            }
           public void add(int a, int b,int c)
           {
            Console.WriteLine("Adding three numbers in polybase normal:" + (a + b + c));
           }


        }
        public class overrid : polybase
        {
            public override void add(int a, int b)
            {
                Console.WriteLine("subtacting two number override virtual in polybase :"+(a - b));
            }
        }
        public  class sealclass : overrid
        {
            public sealed override void add(int a, int b)
            {
                Console.WriteLine("Limit of overriding with use od seal keyword:"+(a + b));
            }
        }
    

    /// <summary>
    /// //Encapsulation
    /// </summary>

       public class sett
       {
        protected string namee;
        public string Name 
        {
            get { return namee; } 
            set { namee = value + 123; } }

       }
    public class setand: sett
    {
        public void display()
        {
            Console.WriteLine();
            Console.WriteLine("\n\n"+namee+"\n");
        }
    }


             
        


    ///Abstract and interface in OOPS

    public abstract class abstracclass      //instance not created for abstract class
    {
       
        public abstract void abs();
        public void norm()
        {
            Console.WriteLine("This is normal method in abstractclass");
        }
        
    }

    public class overridr : abstracclass
    {
        public sealed override void abs()
        {
            Console.WriteLine("This is overrided class of abstract class inherited in another class");
        }
    }



    /// <summary>
    /// Interface
    /// </summary>



        interface clas1
        {
            void class1();

        }
       interface clas2
       {
        void class2();
       }
        public class mutliinherti : clas1,clas2
        {
            public void class1()
            {
                Console.Write("This is First Interface");
            }
        public void class2()
        {
            Console.Write("This is second Interface");
        }
    }

    
}




