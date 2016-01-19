using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomWhatever
{
    class CustomArray:ICustomString 
    {
        string ConvertedString;
        string[] ConvertedArray;
        char[] ArrayToConvert;
        public CustomArray(char[] Array)
        {
            ArrayToConvert = Array;
        }

        public void insert(string stringToInsert)
        {
            int index = 0;
            char[] ArrayToConvert = ConvertedString.Insert(index, stringToInsert).ToArray();
            ConvertedString = new string(ArrayToConvert);
        }

        public void remove(int startIndex, int numCharsToRemove)
        {

            ConvertedString = new string(ArrayToConvert).Remove(startIndex, numCharsToRemove);
            
        }

        public int length()
        {
            return ArrayToConvert.Count();
        }
    }
}
