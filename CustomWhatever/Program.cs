using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomWhatever
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList customLinkedList = new CustomLinkedList();

            customLinkedList.Add("A");
            customLinkedList.Add("B");
            customLinkedList.Add("C");
            customLinkedList.Add("D");
            customLinkedList.Add("E");
            customLinkedList.insert("Q");

            Console.WriteLine("before: ");
            customLinkedList.WriteAllValue();
            Console.WriteLine("count: ");
            Console.WriteLine(customLinkedList.length());

            customLinkedList.remove(2, 2);

            Console.WriteLine("After: ");
            customLinkedList.WriteAllValue();

            Console.WriteLine("Count: ");
            Console.WriteLine(customLinkedList.length().ToString());


            Console.ReadLine();

        }
    }
}
