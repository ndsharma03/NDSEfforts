using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsInCS
{
    public class SortedListDemo
    {
        public static void WorkingWithSortedList()
        {
            //Soreted list is a collection of sorted key value pair.
            // data can be accessed via key or index.

            var list = new SortedList<int, string>();
            list.Add(1, "One");
            list.Add(2, "Two");
            list.Add(3, "Three");
           // list.Add(2, "Two"); //Duplicates are not allowed.
            list.Add(5, "Five");
            list.Add(6, "Six");
            list.Add(4, "Four");//Adding at last but it would get added at index (3);
            list.Add(7, "One"); // Duplicate values are allowed!

            Console.WriteLine(list.Count);
            Console.WriteLine("Accessiing sorted list elements");
            //Below loop will print item which is Key-value pair object
            foreach (var item in list)
            {
                Console.WriteLine("Sorted list is a collection of KeyValue :" + item);
            }
           foreach (var item in list)
            {
               
                Console.WriteLine($"item Key={item.Key}, Value={item.Value}");


            }
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"Item at index {i}={list.GetKeyAtIndex(i)} ,{list.GetValueAtIndex(i)}");
            }
            //Chning item for key=2
            list[2] = "Two Changed";

            foreach (var item in list)
            {
                Console.WriteLine(item);
                Console.WriteLine($"item Key={item.Key}, Value={item.Value}");


            }
            Console.WriteLine(  "Getting index of last added item i.e.4");
            Console.WriteLine( list.IndexOfKey(4));
            Console.WriteLine("Getting index of value Four");
            Console.WriteLine(list.IndexOfValue("Four"));
            Console.WriteLine("Index of above key-value would get changed as removing itewm from index 2");
            
            list.Remove(2); //removed item by key;
            
            Console.WriteLine("Getting index of last added item i.e.4");
            Console.WriteLine(list.IndexOfKey(4));
            Console.WriteLine("Getting index of value Four");
            Console.WriteLine(list.IndexOfValue("Four"));

            Console.WriteLine(  "***********Prining Keys ****************");
            foreach(var key in list.Keys) { Console.WriteLine(key); }

            Console.WriteLine("***********Prining Values ****************");
            foreach (var val in list.Values) { Console.WriteLine(val); }
            Console.WriteLine(" WHat if trying to access key which is not present");
            Console.WriteLine(list[8]);
        }
    }
}
