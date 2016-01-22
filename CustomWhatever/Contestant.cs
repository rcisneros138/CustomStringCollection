using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomWhatever
{
    public class Contestant
    {
        public string name;
        public int age;
        public string homeTown;
        public Contestant(string contestantName, int contestantAge, string contestantHomeTown)
        {
            name = contestantName;
            age = contestantAge;
            homeTown = contestantHomeTown;

        }
       
        
    }
}
