using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите координаты трёх точек прямоугольника");
            int tempX1 = Convert.ToInt32(Console.ReadLine());
            int tempY1 = Convert.ToInt32(Console.ReadLine());
            int tempX2 = Convert.ToInt32(Console.ReadLine());
            int tempY2 = Convert.ToInt32(Console.ReadLine());
            int tempX3 = Convert.ToInt32(Console.ReadLine());
            int tempY3 = Convert.ToInt32(Console.ReadLine());

            //находим min и max X и Y
            int maxX = tempX1;
            int maxY = tempY1;
            int minX = tempX1;
            int minY = tempY1;
            maxX = (tempX2 > maxX) ? tempX2 : maxX;
            maxY = (tempY2 > maxY) ? tempY2 : maxY;
            maxX = (tempX3 > maxX) ? tempX3 : maxX;
            maxY = (tempY3 > maxY) ? tempY3 : maxY;

            minX = (tempX2 < minX) ? tempX2 : minX;
            minY = (tempY2 < minY) ? tempY2 : minY;
            minX = (tempX3 < minX) ? tempX3 : minX;
            minY = (tempY3 < minY) ? tempY3 : minY;
            //находим min и max X и Y    

            //проверка парралельности осям координат
            //Координата X должна быть равна либо Xmin либо Xmax иначе не парралельно
            //Координата Y должна быть равна либо Ymin либо Ymax иначе не парралельно
            bool parallelСondition = true;
            if ((tempX1 != minX && tempX1 != maxX) || (tempX2 != minX && tempX2 != maxX) || (tempX3 != minX && tempX3 != maxX))
            { parallelСondition = false; }
            if ((tempY1 != minY && tempY1 != maxY) || (tempY2 != minY && tempY2 != maxY) || (tempY3 != minY && tempY3 != maxY))
            { parallelСondition = false; }
            // также будет ошибкой если координаты 2 или 3 точек будут совпадать
            if ((tempX1 == tempX2 && tempY1 == tempY2) || (tempX2 == tempX3 && tempY2 == tempY3) || (tempX1 == tempX3 && tempY1 == tempY3))
            { parallelСondition = false; }
            if ((tempX1 == tempX2 && tempX1 == tempX3) || (tempY1 == tempY2 && tempY1 == tempY3))
            { parallelСondition = false; }
            //проверка парралельности осям координат




            if (parallelСondition)//определение координат 4 точки
            {
                int tempX4 = 0;
                if (tempX1 == tempX2 || tempX1 == tempX3)
                {
                    if (tempX1 == maxX) { tempX4 = minX; }
                    else { tempX4 = maxX; }
                }
                else //tempX2 == tempX3
                {
                    if (tempX2 == maxX) { tempX4 = minX; }
                    else { tempX4 = maxX; }
                }
                int tempY4 = 0;
                if (tempY1 == tempY2 || tempY1 == tempY3)
                {
                    if (tempY1 == maxY) { tempY4 = minY; }
                    else { tempY4 = maxY; }
                }
                else //tempY2 == tempY3
                {
                    if (tempY2 == maxY) { tempY4 = minY; }
                    else { tempY4 = maxY; }
                }
                Console.WriteLine("Координаты четвёртой точки X4 = {0} Y4 = {1}", tempX4, tempY4);
            }
            else
            {
                Console.WriteLine("Стороны прямоугольника не парралельны осям координат либо допущена ошибка ввода координат"); 
            }
            Console.ReadKey(); 

        }
    }
}
