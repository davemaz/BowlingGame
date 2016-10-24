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
        public void Roll(int pins)
        {
        }

        public int Score()
        {
            return 0;
        }
    }

    [TestClass]
    public class BowlingTest
    {
        private Game g;

        [TestMethod]
        public void canRoll()
        {
            g = new Game();
            g.Roll(0);
        }

        [TestMethod]
        public void gutterGame()
        {
            g = new Game();
            for (int i = 0; i < 20; i++)
            {
                g.Roll(0);
            }
            Assert.AreEqual(0, g.Score());
        }
    }
}
