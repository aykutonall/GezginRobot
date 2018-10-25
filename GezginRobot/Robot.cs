using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GezginRobot
{
    class Robot
    {
        //Fields
        private int x, y;
        private int dX, dY;
        private string robotYon;
        private string[] hareket;
        //Robot Constructor 
        public Robot(int konumX, int konumY, string yon, string[] hareketKatar, int dikX, int dikY)
        {
            this.X = konumX;
            this.Y = konumY;
            this.RobotYon = yon;
            this.Hareket = hareketKatar;
            this.DX= dikX;
            this.DY = dikY;

            HareketEt();
        }
        //Fields Getter and Setter
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public string RobotYon { get => robotYon; set => robotYon = value; }
        public string[] Hareket { get => hareket; set => hareket = value; }
        public int DX { get => dX; set => dX = value; }
        public int DY { get => dY; set => dY = value; }

        //Robotların hareketlerinin kontrolü
        public void HareketEt()
        {
            for (int i = 0; i < Hareket.Length; i++)
            {
                if (Hareket[i].Equals("M"))
                {
                    switch (robotYon)
                    {
                        case "N":
                            y++;
                            break;
                        case "E":
                            x++;
                            break;
                        case "S":
                            y--;
                            break;
                        case "W":
                            x--;
                            break;
                    }
                }
                else
                {
                    if (robotYon.Equals("N") && Hareket[i].Equals("L"))
                    {
                        robotYon = "W";
                    }
                    else if (robotYon.Equals("N") && Hareket[i].Equals("R"))
                    {
                        robotYon = "E";
                    }
                    else if (robotYon.Equals("W") && Hareket[i].Equals("L"))
                    {
                        robotYon = "S";
                    }
                    else if (robotYon.Equals("W") && Hareket[i].Equals("R"))
                    {
                        robotYon = "N";
                    }
                    else if (robotYon.Equals("S") && Hareket[i].Equals("L"))
                    {
                        robotYon = "E";
                    }
                    else if (robotYon.Equals("S") && Hareket[i].Equals("R"))
                    {
                        robotYon = "W";
                    }
                    else if (robotYon.Equals("E") && Hareket[i].Equals("L"))
                    {
                        robotYon = "N";
                    }
                    else if (robotYon.Equals("E") && Hareket[i].Equals("R"))
                    {
                        robotYon = "S";
                    }
                }

            }
            //Robotların son konumlarının dikdörtgen sınırlarını aşıp aşmadığının kontrolü.
            if (dX < x)
                x = dX;
            if (dY < y)
                y = dY;

            Console.WriteLine("Sonuçlar: ");
            Console.WriteLine("X, Y, Yon : " + x + " " + y + " " + robotYon);
        }
    }
}
