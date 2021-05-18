using System;
using System.Collections;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            

            /* ArrayList arrlist = new ArrayList();
             arrlist.Add("Welcome");
             arrlist.Add(100);
             arrlist.Add(20.5f);
             arrlist.Add("Tutlane");
             ArrayList arraylist2 = new ArrayList() { "raam", 34, 34.6, true };
             arrlist.AddRange(arraylist2);
             // check for an item 100 exists in arraylist or not
             foreach (var item in arrlist) 
             {
                 Console.WriteLine(item);
             }


             Dictionary<string, string> cities = new Dictionary<string, string>()
             {
              {"UK", "London, Manchester, Birmingham"},
              {"USA", "Chicago, New York, Washington"},
              {"India", "Mumbai, New Delhi, Pune"}
             };
             Console.WriteLine(cities["UK"]);

             foreach (var kvp in cities)
             {
                 Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
             }*/



            Hashtable htbl = new Hashtable();
            htbl.Add("msg", "Welcome");
            htbl.Add("site", "Tutlane");
            htbl.Add(1, 20.5f);
            htbl.Add(2, null);

           
            // Another way to add elements. If key not exist, then that key adds a new key/value pair.
            htbl[3] = "Tutorials";
            // Add method will throws an exception if key already exists in hash table
            try
            {
                htbl.Add(2, 100);
            }
            catch
            {
                Console.WriteLine("An element with Key = '2' already exists.");

                Console.WriteLine("The index of hashtable 1 is :"+htbl["msg"]);

            }

            foreach (DictionaryEntry item in htbl)
            {
                Console.WriteLine("Key = {0}, Value = {1}", item.Key, item.Value);
            }
        }
    }
    
    
}
