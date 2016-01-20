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

        public CustomLinkedList(string stringToPass)
        {

        }
        public string toString()
        {
            char[] allCharacters = linkedList.getAllNodes();
            string combinedCharacters = new string(allCharacters);
            return combinedCharacters;

        }
        public void WriteAllValue()
        {
            linkedList.printAllNodes();
        }
        public void insert(string stringToInsert)
        {
            char[] charArrayOfString = stringToInsert.ToArray<char>();
            int startIndex = 3;
            foreach (char letter in charArrayOfString)
            {
                linkedList.InsertIntoList(startIndex, letter);
            }
            
        }

        public void remove(int startIndex, int numCharsToRemovre)
        {
            linkedList.Remove(startIndex, numCharsToRemovre);
        }

        public int length()
        {
            return linkedList.Count();
        }
        public void Add(char value)
        {
            linkedList.addNode(value);
        }
    }
}
