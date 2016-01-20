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
       
        public CustomArray(string toBeArray)
        {
            ArrayToConvert = toBeArray.ToArray();
        }
        public string toString()
        {
            string finalString = new string(ArrayToConvert);
            return finalString;
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
