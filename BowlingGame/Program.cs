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
            int i = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (rolls[i] + rolls[i + 1] == 10) // spare
                {
                    score += 10 + rolls[i + 2];
                    i += 2;
                }
                else
                {
                    score += rolls[i] + rolls[i + 1];
                    i += 2;
                }
            }
            return score;
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
            g.Roll(5);
            g.Roll(5); // spare
            g.Roll(3);
            RollMany(17, 0);
            Assert.AreEqual(16, g.Score());
        }
    }
}
