using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomWhatever
{
   public class Sweepstakes
    {
        Random randomNumber = new Random();
        public string SweepstakesName;
        public string ContestantInformation;
        List<Contestant> Contestants;
        
        public Sweepstakes(string name)
        {
            SweepstakesName = name;
            Contestants = new List<Contestant>();
        }

        public List<Contestant> contestantList
        {
            get { return Contestants; }
        }

        public void RegisterContestant(Contestant contestant)
        {
            Contestants.Add(contestant);
        }

        public string pickWinner()
        {
           
            int indexOfWinner = randomNumber.Next(0, Contestants.Count()-1);
            return Contestants[indexOfWinner].name; 
        }
        
        public void PrintContestantInfo(Contestant contestant)
        {
            ContestantInformation = String.Format("Name: {0}, Age: {1} ,HomeTown: {2}",contestant.name, contestant.age, contestant.homeTown);
            Console.WriteLine(ContestantInformation);
        }




    }
}
