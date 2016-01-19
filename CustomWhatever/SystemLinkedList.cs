using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomWhatever
{
    class SystemLinkedList:ICustomString
    {
        LinkedList<string> ListToBeConverted;
        string convertedString;
        public SystemLinkedList(LinkedList<string> linkedList)
        {
            ListToBeConverted = linkedList;
        }
        public void insert(string stringToInsert)
        {
            LinkedListNode<string> node = ListToBeConverted.Find("one");
            ListToBeConverted.AddAfter(node, stringToInsert);
        }

        public void remove(int startIndex, int numCharsToRemovre)
        {
            
        }

        public int length()
        {
            int count = 0;
            foreach (var item in ListToBeConverted)
            {
                count++;
            }
            return count;
        }
    }
}
