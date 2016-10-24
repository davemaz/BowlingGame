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

    }

    [TestClass]
    public class BowlingTest
    {
        [TestMethod]
        public void canCreateGame()
        {
            Game g = new Game();
        }
    }
}
