using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomWhatever
{
    public class CustomSortedList
    {
       public SortedList<int,ICustomString> ListofCustomStringObjects;
        public CustomSortedList()
        {
            ListofCustomStringObjects = new SortedList<int, ICustomString>();
        }

        public void addToList(ICustomString customObject)
        {
            int length = customObject.length();

            ListofCustomStringObjects.Add(length,customObject);
        }

    }
}
