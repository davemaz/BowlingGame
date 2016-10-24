using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }

    public class Game
    {
        private int[] rolls = new int[21];
        private int currentRoll = 0;


        public void Roll(int pins)
        {
            rolls[currentRoll++] = pins;           
        }

        public int Score()
        {
            int score = 0;
            int firstInFrame = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (IsSpare(firstInFrame))
                {
                    score += 10 + rolls[firstInFrame + 2];
                    firstInFrame += 2;
                }
                else
                {
                    score += rolls[firstInFrame] + rolls[firstInFrame + 1];
                    firstInFrame += 2;
                }
            }
            return score;
        }

        private bool IsSpare(int firstInFrame)
        {
            return rolls[firstInFrame] + rolls[firstInFrame + 1] == 10;
        }
    }

    [TestClass]
    public class BowlingTest
    {
        private Game g = new Game();

        private void RollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
            {
                g.Roll(pins);
            }
        }
        private void RollSpare()
        {
            g.Roll(5);
            g.Roll(5);
        }

        [TestMethod]
        public void gutterGame()
        {
            RollMany(20, 0);
            Assert.AreEqual(0, g.Score());
        }

        [TestMethod]
        public void allOnes()
        {
            RollMany(20, 1);
            Assert.AreEqual(20, g.Score());
        }

        [TestMethod]
        public void oneSpare()
        {
            RollSpare();
            g.Roll(3);
            RollMany(17, 0);
            Assert.AreEqual(16, g.Score());
        }

        [TestMethod]
        public void oneStrike()
        {
            g.Roll(10); // strike
            g.Roll(3);
            g.Roll(4);
            RollMany(16, 0);
            Assert.AreEqual(24, g.Score());
        }
    }
}
