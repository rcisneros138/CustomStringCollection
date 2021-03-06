﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomWhatever
{
    public class SweepstakeQueManager:ISweepStakesManager
    {
        public Queue<Sweepstakes> sweepstakesQue;
        
        public SweepstakeQueManager()
        {
            sweepstakesQue = new Queue<Sweepstakes>();
        }

        public void InsertSweepstakes(Sweepstakes sweepstake)
        {
            sweepstakesQue.Enqueue(sweepstake);
        }

        public Sweepstakes GetNextSweepstakesWinner()
        {
            Sweepstakes nextSweepstake = sweepstakesQue.Dequeue();
            return nextSweepstake;
        }
    }
}
