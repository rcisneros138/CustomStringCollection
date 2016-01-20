using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomWhatever
{
    public interface ICustomString
    {
        string toString();
        void insert(string stringToInsert);

        void remove(int startIndex, int numCharsToRemovre);

        int length();
    }
}
