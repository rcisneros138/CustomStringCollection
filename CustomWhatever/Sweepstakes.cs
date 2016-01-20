using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomWhatever
{
   public class Sweepstakes
    {
        public string SweepstakesName;
        List<Contestant> Contestants;
        
        public Sweepstakes(string name)
        {
            SweepstakesName = name;
            Contestants = new List<Contestant>();
        }

        void RegisterContestant(Contestant contestant)
        {
            Contestants.Add(contestant);
        }

        string pickWinner()
        {
            Random randomNumber = new Random();
            int indexOfWinner = randomNumber.Next(0, Contestants.Count()-1);
            return Contestants[indexOfWinner].name; 
        }
        
        void PrintContestantInfo(Contestant contestant)
        {
            string ContestantInformation = String.Format("Name: {0}, Age: {1} ,HomeTown: {2}",contestant.name, contestant.age, contestant.homeTown);
            Console.WriteLine(ContestantInformation);
        }




    }
}
