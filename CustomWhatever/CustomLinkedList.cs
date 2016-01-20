using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomWhatever
{
    public class CustomLinkedList:ICustomString
    {
        LinkedList linkedList = new LinkedList();
        public void WriteAllValue()
        {
            linkedList.printAllNodes();
        }
        public void insert(string stringToInsert)
        {
            int startIndex = 3;
            linkedList.InsertIntoList(startIndex, stringToInsert);
        }

        public void remove(int startIndex, int numCharsToRemovre)
        {
            linkedList.Remove(startIndex, numCharsToRemovre);
        }

        public int length()
        {
            return linkedList.Count();
        }
        public void Add(string value)
        {
            linkedList.addNode(value);
        }
    }
}
