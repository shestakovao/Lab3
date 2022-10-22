using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число в диапазоне 20–69, определяющее возраст (в годах)");
            int age = Convert.ToByte(Console.ReadLine());
            if (age >= 20 && age <= 69)
            {
                string partOne = "";
                string partTwo = "";

                switch (age / 10)
                {
                    case 2: 
                        { 
                            partOne = "двадцать ";
                            break;
                        }
                    case 3:
                        {
                            partOne = "тридцать ";
                            break;
                        }
                    case 4:
                        {
                            partOne = "сорок ";
                            break;
                        }
                    case 5:
                        {
                            partOne = "пятьдесят ";
                            break;
                        }
                    case 6:
                        {
                            partOne = "шестьдесят ";
                            break;
                        }
                }

                switch (age % 10)
                {
                    case 0:
                        {
                            partTwo = "лет";
                            break;
                        }
                    case 1:
                        {
                            partTwo = "один год";
                            break;
                        }
                    case 2:
                        {
                            partTwo = "два года";
                            break;
                        }
                    case 3:
                        {
                            partTwo = "три года";
                            break;
                        }
                    case 4:
                        {
                            partTwo = "четыре года";
                            break;
                        }
                    case 5:
                        {
                            partTwo = "пять лет";
                            break;
                        }
                    case 6:
                        {
                            partTwo = "шесть лет";
                            break;
                        }
                    case 7:
                        {
                            partTwo = "семь лет";
                            break;
                        }
                    case 8:
                        {
                            partTwo = "восемь лет";
                            break;
                        }
                    case 9:
                        {
                            partTwo = "девять лет";
                            break;
                        }
                }



                        Console.WriteLine("Возраст: {0}{1}",partOne,partTwo);

            }
            else
            { Console.WriteLine("Не верный возраст, число должно быть в интервале 20–69"); }
            Console.ReadKey();
        }
    }
}
