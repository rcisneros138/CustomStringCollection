using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomWhatever
{
    class SweepstakeStackManager:ISweepStakesManager
    {
       public Stack<Sweepstakes> sweepstakesStack;

        public SweepstakeStackManager()
        {
            sweepstakesStack = new Stack<Sweepstakes>();
        }
       public void InsertSweepstakes(Sweepstakes sweepstake)
        {
            sweepstakesStack.Push(sweepstake);
        }

       public Sweepstakes GetNextSweepstakesWinner()
        {
            return sweepstakesStack.Pop();

        }
    }
}
