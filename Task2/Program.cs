using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точек A,B,C");
            double xA = Convert.ToInt32(Console.ReadLine());
            double yA = Convert.ToInt32(Console.ReadLine());
            double xB = Convert.ToInt32(Console.ReadLine());
            double yB = Convert.ToInt32(Console.ReadLine());
            double xC = Convert.ToInt32(Console.ReadLine());
            double yC = Convert.ToInt32(Console.ReadLine());
            
            if (xB == xC && yB == yC && xB == xA && yB == yA)
            {
                Console.WriteLine("Координаты точек A, B и C совпадают");
            }
            else if (xB == xC && yB == yC)
            {
                Console.WriteLine("Координаты точек B и C совпадают"); 
            }
            else if (xB == xA && yB == yA)
            {
                Console.WriteLine("Координаты точек A и B совпадают");
            }
            else if (xC == xA && yC == yA)
            {
                Console.WriteLine("Координаты точек A и C совпадают");
            } 
            else if (Math.Sqrt(Math.Pow(xA-xB,2)+Math.Pow(yA - yB, 2)) == Math.Sqrt(Math.Pow(xA - xC, 2) + Math.Pow(yA - yC, 2)))
            {
                Console.WriteLine("Точки B и C равно удалены от точки A, расстояние равно {0}", Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2)));
            }
            else if (Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2)) > Math.Sqrt(Math.Pow(xA - xC, 2) + Math.Pow(yA - yC, 2)))
            {
                Console.WriteLine("Точка B удалена от точки A, на расстоянии равном {0}", Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2)));
            }
            else 
            {
                Console.WriteLine("Точка C удалена от точки A, на расстоянии равном {0}", Math.Sqrt(Math.Pow(xA - xC, 2) + Math.Pow(yA - yC, 2)));
            }

            Console.ReadKey();
        }
    }
}
