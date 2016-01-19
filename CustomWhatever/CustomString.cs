using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomWhatever
{
   public class CustomString:ICustomString
    {
        string StringToConvert;
        public CustomString(string item)
        {
            StringToConvert = item;
        }
        public void insert(string stringToInsert)
        {
            int index = 0;
            StringToConvert.Insert(index, stringToInsert);
        }

        public void remove(int startIndex, int numCharsToRemovre)
        {
            StringToConvert.Remove(startIndex, numCharsToRemovre);
        }

        public int length()
        {
            return StringToConvert.Count();
        }
    }
}
