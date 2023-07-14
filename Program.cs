using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDailyExercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList() { "apple", "banana", "cheery", "date", "elderberry" };
            Console.WriteLine("Total no. of element in arraylist:\t" + arrayList.Count);
            Printlist(arrayList);
            
            Insert(arrayList);
 
            Remove(arrayList);
            
            Search(arrayList);

            Console.ReadKey();
        }

        public static void Printlist(ArrayList arrayList)
        {
            Console.WriteLine("Printing all the elements in the arraylist");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
        }
        public static void Insert(ArrayList arrayList)
        {
            Console.WriteLine("Enter what to insert");
            arrayList.Add(Console.ReadLine());
            
            Printlist(arrayList);
        }
        public static void Remove(ArrayList arrayList)
        {
            Console.WriteLine("Enter what to remove");
            int index = arrayList.IndexOf(Console.ReadLine());
            if(index == -1)
            {
                Console.WriteLine("No such element is present...");

            }
            else
            {
                arrayList.RemoveAt(index);
                
                Printlist(arrayList);
            }
        }
        public static void Search(ArrayList arrayList)
        {
            Console.WriteLine("Enter the element name that you what to search");
            int index = arrayList.IndexOf(Console.ReadLine());
            if(index == -1)
            {
                Console.WriteLine("Element is not present");
            }
            else
            {
                Console.WriteLine("Element is present at: "+(index+1)+" position");
            }
        }
    }
}
