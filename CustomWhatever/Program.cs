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
            #region CustomLinkedList
            //CustomLinkedList customLinkedList = new CustomLinkedList();

            //customLinkedList.Add('a');
            //customLinkedList.Add('B');
            //customLinkedList.Add('C');
            //customLinkedList.Add('D');
            //customLinkedList.Add('E');
            //customLinkedList.insert("Q");

            //Console.WriteLine("before: ");
            //customLinkedList.WriteAllValue();
            //Console.WriteLine("count: ");
            //Console.WriteLine(customLinkedList.length());

            //customLinkedList.remove(2, 2);

            //Console.WriteLine("After: ");
            //customLinkedList.WriteAllValue();

            //Console.WriteLine("Count: ");
            //Console.WriteLine(customLinkedList.length().ToString());
            #endregion
            #region sweepstakes
            //SweepstakeQueManager sweepstakesQueManager = new SweepstakeQueManager();
            //SweepstakeStackManager sweepstakesStackManager = new SweepstakeStackManager();

            //Sweepstakes probablyAScamSweepstake = new Sweepstakes("Probably A Scam Sweepstakes");
            //Sweepstakes AlsoNotAScamSweepstake = new Sweepstakes("Not A Scam Sweepstakes");

            //sweepstakesQueManager.InsertSweepstakes(probablyAScamSweepstake);
            //sweepstakesQueManager.InsertSweepstakes(AlsoNotAScamSweepstake);


            //Console.WriteLine(sweepstakesQueManager.GetNextSweepstakesWinner().SweepstakesName);

            //sweepstakesStackManager.InsertSweepstakes(probablyAScamSweepstake);

            //Console.WriteLine(sweepstakesStackManager.GetNextSweepstakesWinner().SweepstakesName);
            #endregion
            #region sortedList
            //string x = "Hello";
            //string y = "Hello0";

            //CustomArray customArray = new CustomArray(x);
            //CustomLinkedList linkedList = new CustomLinkedList(x);
            //CustomString customString = new CustomString(y);


            //CustomSortedList sortedList = new CustomSortedList();
            //sortedList.addToList(customArray);
            //sortedList.addToList(linkedList);
            //sortedList.addToList(customString);

            //foreach (KeyValuePair<int,ICustomString> item in sortedList.ListofCustomStringObjects)
            //{
            //    string itemToPrint = String.Format("{0} {1}", item.Key, item.Value);
            //    Console.WriteLine(itemToPrint);
            //}
            #endregion


            Console.ReadLine();

        }
    }
}
