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
        public void addToList(string itemToAdd)
        {
            ListToBeConverted.AddLast(itemToAdd);
        }
        
        public string toString()
        {
            string finalString = String.Join("", ListToBeConverted);
            return finalString;
        }
        
        public void insert(string stringToInsert)
        {
            string value = ListToBeConverted.ElementAt(1);
            LinkedListNode<string> node = ListToBeConverted.Find(value);
            ListToBeConverted.AddAfter(node, stringToInsert);
        }

        public void insert(int index,string stringToInsert)
        {
            string value = ListToBeConverted.ElementAt(index);
            LinkedListNode<string> node = ListToBeConverted.Find(value);
            ListToBeConverted.AddAfter(node, stringToInsert);
        }



        public void remove(int startIndex, int numCharsToRemovre)
        {

            for (int i = startIndex; i < numCharsToRemovre -1; i++)
            {
                string value = ListToBeConverted.ElementAt(startIndex);
                LinkedListNode<string> node = ListToBeConverted.Find(value);
                ListToBeConverted.Remove(value);
                i++;
            }
                
            
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
