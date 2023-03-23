﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectSquareChaserAdvanced
{   internal class Players
    {
        public int x, y;
        public int speed = 6;
        public int width = 30;
        public int height = 10;
        public Players(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        public void Move(string direction)
        {
            if (direction == "up")
            {
                y -= speed;
            }
            if (direction == "down")
            {
                y += speed;
            }
            if (direction == "left")
            {
                x -= speed;
            }
            if (direction == "right")
            {
                x += speed;
            }
        }
    }
}
