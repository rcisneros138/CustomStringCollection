using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomWhatever
{
    class LinkedList
    {
        public Node head;

        public char[] getAllNodes()
        {
            char[] allCharacters = new char[Count()];
            List<Node> allNodes = new List<Node>();
            Node cur = head;
            while (cur.Next != null)
            {
                allNodes.Add(cur);
                cur = cur.Next;
            }
            allNodes.Add(cur);
            for (int i = 0; i < allCharacters.Length; i++)
            {
                allCharacters[i] = allNodes[i].Data;
            }
            return allCharacters;
        }
      

        public void printAllNodes()
        {
            Node cur = head;
            while (cur.Next != null)
            {
                Console.WriteLine(cur.Data.ToString());
                cur = cur.Next;
            }
            Console.WriteLine(cur.Data.ToString());
        }

        public void InsertIntoList(int index, char value)
        {
            Node current = head;
            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }
            Node newNode = new Node();
            newNode.Next = current.Next;
            newNode.Data = value;
            current.Next = newNode;

        }

        public void Remove(int index, int amountToRemove)
        {
            Node current = head;
            Node nodeRemovedUpTo = head;
            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }
            for (int i = 0; i < amountToRemove + index; i++)
            {
                nodeRemovedUpTo = nodeRemovedUpTo.Next;
            }
            current.Next = nodeRemovedUpTo.Next;
        }

        public void addNode(char data)
        {
            if (head == null)
            {
                head = new Node();
                head.Data = data;

            }
            else
            {
                Node toAdd = new Node();
                toAdd.Data = data;

                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = toAdd;
            }
        }

        public int Count()
        {
            int counter = 0;
            Node currentNode = head;
            while (currentNode != null)
            {
                currentNode = currentNode.Next;
                counter++;
            }
            return counter;
        }
    
    }
}
