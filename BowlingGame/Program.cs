﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }

    [TestClass]
    public class BowlingTest
    {
        [TestMethod]
        public void canCreateGame()
        {
            Game g = new Game();
        }

        [TestMethod]
        public void canRoll()
        {
            Game g = new Game();
            g.Roll(0);
        }
    }
}
