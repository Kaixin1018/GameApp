﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    public class Player
    {
        public string Name { get; set; }
        public string Choice { get; set; }
        public int Score { get; set; }

        public Player(string name)
        {
            Name = name;
            Choice = "";
            Score = 0;
        }

        public void ResetChoice()
        {
            Choice = "";
        }
    }

}
