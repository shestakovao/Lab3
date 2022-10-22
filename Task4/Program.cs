using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число в диапазоне 100–999");
            int x = Convert.ToInt16(Console.ReadLine());
            if (x >= 100 && x <= 999)
            {
                string partOne = "";
                string partTwo = "";
                string partThree = "";

                switch (x / 100)
                {
                    case 1:
                        {
                            partOne = "сто ";
                            break;
                        }
                    case 2:
                        {
                            partOne = "двести ";
                            break;
                        }
                    case 3:
                        {
                            partOne = "тристо ";
                            break;
                        }
                    case 4:
                        {
                            partOne = "четыресто ";
                            break;
                        }
                    case 5:
                        {
                            partOne = "пятьсот ";
                            break;
                        }
                    case 6:
                        {
                            partOne = "шестьсот ";
                            break;
                        }
                    case 7:
                        {
                            partOne = "семьсот ";
                            break;
                        }
                    case 8:
                        {
                            partOne = "восемьсот ";
                            break;
                        }
                    case 9:
                        {
                            partOne = "девятьсот ";
                            break;
                        }

                }

                int x_2 = x % 100;
                int x_3 = x % 10;
                if (x_2 >= 10 && x_2 <= 19)
                {
                    x_3 = 0; //обнуляем третью часть
                    switch (x_2)
                    {
                        case 10:
                            {
                                partTwo = "десять";
                                break;
                            }
                        case 11:
                            {
                                partTwo = "одинадцать";
                                break;
                            }
                        case 12:
                            {
                                partTwo = "двенадцать";
                                break;
                            }
                        case 13:
                            {
                                partTwo = "тринадцать";
                                break;
                            }
                        case 14:
                            {
                                partTwo = "четырнадцать";
                                break;
                            }
                        case 15:
                            {
                                partTwo = "пятнадцать";
                                break;
                            }
                        case 16:
                            {
                                partTwo = "шестнадцать";
                                break;
                            }
                        case 17:
                            {
                                partTwo = "семнадцать";
                                break;
                            }
                        case 18:
                            {
                                partTwo = "восемнадцать";
                                break;
                            }
                        case 19:
                            {
                                partTwo = "девятнадцать";
                                break;
                            }

                    }
                }
                else if (x_2 > 19)
                {
                    switch (x_2 / 10)
                    {
                        case 2:
                            {
                                partTwo = "двадцать ";
                                break;
                            }
                        case 3:
                            {
                                partTwo = "тридцать ";
                                break;
                            }
                        case 4:
                            {
                                partTwo = "сорок ";
                                break;
                            }
                        case 5:
                            {
                                partTwo = "пятьдесят ";
                                break;
                            }
                        case 6:
                            {
                                partTwo = "шестьдесят ";
                                break;
                            }
                        case 7:
                            {
                                partTwo = "семьдесят ";
                                break;
                            }
                        case 8:
                            {
                                partTwo = "восемьдесят ";
                                break;
                            }
                        case 9:
                            {
                                partTwo = "девяносто ";
                                break;
                            }

                    }
                }


                switch (x_3)
                {
                    case 1:
                        {
                            partThree = "один";
                            break;
                        }
                    case 2:
                        {
                            partThree = "два";
                            break;
                        }
                    case 3:
                        {
                            partThree = "три";
                            break;
                        }
                    case 4:
                        {
                            partThree = "четыре";
                            break;
                        }
                    case 5:
                        {
                            partThree = "пять";
                            break;
                        }
                    case 6:
                        {
                            partThree = "шесть";
                            break;
                        }
                    case 7:
                        {
                            partThree = "семь";
                            break;
                        }
                    case 8:
                        {
                            partThree = "восемь";
                            break;
                        }
                    case 9:
                        {
                            partThree = "девять";
                            break;
                        }

                }
                Console.WriteLine("Число прописью: {0}{1}{2}", partOne, partTwo, partThree);


            }


            else
            { Console.WriteLine("Не верное число, должно быть в интервале 100–999"); }
            Console.ReadKey();


        }
    }
}
