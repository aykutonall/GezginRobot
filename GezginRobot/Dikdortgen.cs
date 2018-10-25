using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GezginRobot
{
    class Dikdortgen
    {
        //Fields
        private int x, y;

        //Dikdortgen Constructor 
        public Dikdortgen(int dikX, int dikY)
        {
            this.X = dikX;
            this.Y = dikY;
        }
        //Fields Getter and Setter
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
    }
}
