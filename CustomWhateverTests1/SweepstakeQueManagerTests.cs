using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomWhatever;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomWhatever.Tests
{
    [TestClass()]
    public class SweepstakeQueManagerTests
    {
        [TestMethod()]
        public void InsertSweepstakesTest()
        {
            SweepstakeQueManager queManager = new SweepstakeQueManager();
            Sweepstakes sweep = new Sweepstakes("testSweep");
            Queue<Sweepstakes> testQueActual = new Queue<Sweepstakes>();
            Queue<Sweepstakes> testQueExpected = new Queue<Sweepstakes>();

            testQueExpected.Enqueue(sweep);

            queManager.InsertSweepstakes(sweep);

            testQueActual = queManager.sweepstakesQue;

            Queue<Sweepstakes> actual = testQueActual;
            Queue<Sweepstakes> expected = testQueExpected;

            Assert.IsTrue(expected.SequenceEqual(actual));

        }

        [TestMethod()]
        public void GetNextSweepstakesWinnerTest()
        {
            SweepstakeQueManager queManager = new SweepstakeQueManager();
            Sweepstakes sweep = new Sweepstakes("testSweep");

            Queue<Sweepstakes> ControlQue = new Queue<Sweepstakes>();
            ControlQue.Enqueue(sweep);
            ControlQue.Dequeue();
            Queue<Sweepstakes> actualQue = queManager.sweepstakesQue;
            queManager.sweepstakesQue.Enqueue(sweep);
            queManager.GetNextSweepstakesWinner();



            Queue<Sweepstakes> expected = ControlQue;
            Queue<Sweepstakes> actual = actualQue;

            Assert.IsTrue(expected.SequenceEqual(actual));


        }
    }
}