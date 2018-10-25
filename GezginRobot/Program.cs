using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GezginRobot
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Dikdörtgenin sağ üst köşe koordinatlarını alıyoruz.
            Console.WriteLine("Dikdörtgen için X koordinatını giriniz: ");
            int dikdortgenX = int.Parse(Console.ReadLine());

            Console.WriteLine("Dikdörtgen için Y koordinatını giriniz: ");
            int dikdortgenY = int.Parse(Console.ReadLine());
            Dikdortgen dikdortgen = new Dikdortgen(dikdortgenX, dikdortgenY);

            Console.WriteLine("--------------------------------------------");

            //1.gezgin robotumuzun başlangıç konumunu alıyoruz.
            Console.WriteLine("Robot1 için X koordinatını giriniz: ");
            int robot1X = int.Parse(Console.ReadLine());
            Console.WriteLine("Robot1 için Y koordinatını giriniz: ");
            int robot1Y = int.Parse(Console.ReadLine());
            Console.WriteLine("Robot1 için Yön giriniz: ");
            string robot1Yon = Console.ReadLine();

            Console.WriteLine("Robot1 için Harf katarını giriniz: ");
            string dizge = Console.ReadLine();
            Console.WriteLine("--------------------------------------------");
            string[] hareket = new string[dizge.Length];

            for (int i = 0; i < dizge.Length; i++)
            {
                hareket[i] = dizge[i].ToString();
            }

            //gezgin robotun başlangıç konumunun dikdörtgen sınırlarını aşmadığı kontrol ediliyor.
            if (dikdortgenX < robot1X)
                robot1X = dikdortgenX;
            if (dikdortgenY < robot1Y)
                robot1Y = dikdortgenY;

            //2.gezgin robotumuzun başlangıç konumunu alıyoruz.
            Console.WriteLine("Robot2 için X koordinatını giriniz: ");
            int robot2X = int.Parse(Console.ReadLine());
            Console.WriteLine("Robot2 için Y koordinatını giriniz: ");
            int robot2Y = int.Parse(Console.ReadLine());
            Console.WriteLine("Robot2 için Yön giriniz: ");
            string robot2Yon = Console.ReadLine();

            Console.WriteLine("Robot2 için Harf katarını giriniz: ");
            string dizge2 = Console.ReadLine();
            Console.WriteLine("--------------------------------------------");

            string[] hareket2 = new string[dizge2.Length];

            for (int i = 0; i < dizge2.Length; i++)
            {
                hareket2[i] = dizge2[i].ToString();
            }

            //gezgin robotun başlangıç konumunun dikdörtgen sınırlarını aşmadığı kontrol ediliyor.
            if (dikdortgenX < robot2X)
                robot2X = dikdortgenX;
            if (dikdortgenY < robot2Y)
                robot2Y = dikdortgenY;

            Robot r1 = new Robot(robot1X, robot1Y, robot1Yon, hareket, dikdortgenX, dikdortgenY);
            Robot r2 = new Robot(robot2X, robot2Y, robot2Yon, hareket2, dikdortgenX, dikdortgenY);
            Console.ReadKey();
        }
    }
}