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
    public class SweepstakesTests
    {
        [TestMethod()]
        public void RegisterContestantTest()
        {
            Sweepstakes sweepstakes = new Sweepstakes("Test Sweepstake");

            Contestant TestContestant = new Contestant("TestyMcgee", 100, "TestTown");
            sweepstakes.RegisterContestant(TestContestant);
            List<Contestant> actual = sweepstakes.contestantList;

            List<Contestant> expected = new List<Contestant>();
            expected.Add(TestContestant);

            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        [TestMethod()]
        public void pickWinnerTest()
        {
            Sweepstakes sweepstakes = new Sweepstakes("Test Sweepstake");

            List<Contestant> expected = new List<Contestant>();

            List<Contestant> actual = sweepstakes.contestantList;

            //generates Random Number need to find work-around
        }

        [TestMethod()]
        public void PrintContestantInfoTest()
        {
            Sweepstakes sweepstakes = new Sweepstakes("Test Sweepstake");

            Contestant TestContestant = new Contestant("TestyMcgee", 100, "TestTown");
            string expected = String.Format("Name: {0}, Age: {1} ,HomeTown: {2}", TestContestant.name, TestContestant.age, TestContestant.homeTown);

            sweepstakes.PrintContestantInfo(TestContestant);
            string actual = sweepstakes.ContestantInformation;

            Assert.AreEqual(expected, actual);

        }
    }
}