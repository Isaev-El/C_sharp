using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            taskTen();
            Console.ReadLine();
            
        }
        static (int, int) taskTwenty(int a, int b)
        {
            return (b, a);

        }
        static void taskTwentyOne(ref int a, ref int b)
        {
            (b, a) = (a, b);
        }
        static double taskTwentyTwo(int x, int y)
        {
            if (x == 0 && y == 0)
            {
                return 0;
            }
            else if (y == 0)
            {
                return 12.0 / x;
            }
            else if (x == 0)
            {
                return 12.0 / y;
            }
            else
            {
                return 144.0 / (x * y);
            }
        }
        static int taskTwentyThree(int h, int m, int s)
        {
            if (h < 0 || h >= 24 || m < 0 || m >= 60 || s < 0 || s >= 60)
            {
                return -1;
            }

            int totalSeconds = h * 3600 + m * 60 + s;

            return totalSeconds;
        }
        static int taskTwentyFour(int m, int d)
        {
            if (m < 1 || m > 12 || d < 1 || d > 30)
            {
                return -1;
            }

            int totalDays = (m - 1) * 30 + d;

            return totalDays;
        }
        static int taskTwentyFive(int m, int d)
        {
            int[] daysInMonth = { 31, 30, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (m < 1 || m > 12 || d < 1 || d > daysInMonth[m - 1])
            {
                return -1;
            }

            int totalDays = 0;

            for (int i = 0; i < m - 1; i++)
            {
                totalDays += daysInMonth[i];
            }

            totalDays += d;

            return totalDays;
        }
        static int taskTwentySix(int m1 = 999, int m2 = 999, int m3 = 999)
        {
            if (m1 < 1 || m1 > 999) m1 = 999;
            if (m2 < 1 || m2 > 999) m2 = 999;
            if (m3 < 1 || m3 > 999) m3 = 999;

            int minNumber = m1;

            if (m2 < minNumber)
            {
                minNumber = m2;
            }
            if (m3 < minNumber)
            {
                minNumber = m3;
            }

            return minNumber;
        }
        static bool taskTwentySeven(int n)
        {
            return n % 2 == 0;
        }
        static int taskTwentyEight(int a, int b, int c)
        {

            if (a <= b && a <= c)
            {
                return a;
            }
            else if (b <= a && b <= c)
            {
                return b;
            }
            else
            {
                return c;
            }

        }
        static void taskTwentyNine()
        {
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                int grade = rand.Next(2, 6);
                string message;

                switch (grade)
                {
                    case 2:
                        message = "Неуд";
                        break;
                    case 3:
                        message = "Удовл";
                        break;
                    case 4:
                        message = "Хорошо";
                        break;
                    case 5:
                        message = "Отлично";
                        break;
                    default:
                        message = "Недопустимая оценка";
                        break;
                }

                Console.WriteLine($"Оценка: {grade}, Результат: {message}");
            }
        }
        static int taskThirty(int M, int N)
        {
            int sum = 0;

            // Проверяем, чтобы M было нечетным, иначе увеличиваем M на 1
            if (M % 2 == 0)
            {
                M++;
            }

            for (int i = M; i <= N; i += 2)
            {
                sum += i;
            }

            return sum;
        }
        static int taskThirtyOne(int N, int n)
        {

            int result = N;

            while (result % n != 0)
            {
                result++;
            }

            return result;
        }
        static void taskTen()
        {
            Console.WriteLine("Выберите задание:");
            Console.WriteLine("a) Все целые числа от 20 до 35.");
            Console.WriteLine("b) Квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры; b > 10).");
            Console.WriteLine("c) Третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a < 50).");
            Console.WriteLine("d) Все целые числа от a до b (значения a и b вводятся с клавиатуры; b > a).");

            char choice;

            while (!char.TryParse(Console.ReadLine(), out choice) || (choice != 'a' && choice != 'b' && choice != 'c' && choice != 'd'))
            {
                Console.WriteLine("Выбор задания некорректен. Попробуйте ещё раз:");
            }

            Console.WriteLine();

            switch (choice)
            {
                case 'a':
                    for (int i = 20; i <= 35; i++)
                    {
                        Console.WriteLine(i);
                    }
                    break;
                case 'b':
                    int b;
                    do
                    {
                        if (TryParseInt("Введите значение b (b > 10):", out b) && b > 10)
                        {
                            break;
                        }
                        Console.WriteLine("Значение b должно быть больше 10. Попробуйте ещё раз:");
                    } while (true);

                    for (int i = 10; i <= b; i++)
                    {
                        Console.WriteLine(i * i);
                    }
                    break;
                case 'c':
                    int a;
                    do
                    {
                        if (TryParseInt("Введите значение a (a < 50):", out a) && a < 50)
                        {
                            break;
                        }
                        Console.WriteLine("Значение a должно быть меньше 50. Попробуйте ещё раз:");
                    } while (true);

                    for (int i = a; i <= 50; i++)
                    {
                        Console.WriteLine(Math.Pow(i, 3));
                    }
                    break;
                case 'd':
                    int start, end;
                    do
                    {
                        if (TryParseInt("Введите значение a:", out start) &&
                            TryParseInt("Введите значение b:", out end) && end > start)
                        {
                            break;
                        }
                        Console.WriteLine("Значение b должно быть больше a. Попробуйте ещё раз:");
                    } while (true);

                    for (int i = start; i <= end; i++)
                    {
                        Console.WriteLine(i);
                    }
                    break;
            }
        }
        static bool TryParseInt(string message, out int result)
        {
            Console.Write(message + " ");
            return int.TryParse(Console.ReadLine(), out result);
        }
        static void taskNine()
        {
            Console.Write("Введите сопротивление для первого участка: ");
            double resistance1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите напряжение для первого участка: ");
            double voltage1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите сопротивление для второго участка: ");
            double resistance2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите напряжение для второго участка: ");
            double voltage2 = Convert.ToDouble(Console.ReadLine());

            double current1 = voltage1 / resistance1;
            double current2 = voltage2 / resistance2;

            if (current1 < current2)
            {
                Console.WriteLine("Ток на участке 1 меньше: " + current1 + " Ампер");
                Console.ReadLine();
            }
            else if (current2 < current1)
            {
                Console.WriteLine("Ток на участке 2 меньше: " + current2 + " Ампер");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Токи на обоих участках равны: " + current1 + " Ампер");
                Console.ReadLine();
            }
        }
        static void taskEight()
        {
            double massOfFirstObject = 0;
            double massOfSecondObject = 0;
            double volumeOfFirstObject = 0;
            double volumeOfSecondObject = 0;

            Console.WriteLine("Please write the value for all variable: ");
            massOfFirstObject = Convert.ToInt32(Console.ReadLine());
            massOfSecondObject = Convert.ToInt32(Console.ReadLine());
            volumeOfFirstObject = Convert.ToInt32(Console.ReadLine());
            volumeOfSecondObject = Convert.ToInt32(Console.ReadLine());

            double densityOfFirstObject = massOfFirstObject / volumeOfFirstObject;
            double densityOfSecondObject = massOfSecondObject / volumeOfSecondObject;

            if (densityOfSecondObject > densityOfFirstObject)
            {
                Console.WriteLine("densityOfSecondObject: " + densityOfSecondObject);
            }
            else if (densityOfSecondObject < densityOfFirstObject)
            {
                Console.WriteLine("densityOfFirstObject: " + densityOfFirstObject);
            }
            else
            {
                Console.WriteLine("Equals");
            }
        }
        static void taskSeven()
        {
            int squareSide = 0;
            int radius = 0;
            Console.WriteLine("Please write squareSide:");
            squareSide = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please write radius:");
            radius = Convert.ToInt32(Console.ReadLine());
            double squareOfCircle = 3.14 * radius * radius;
            if (squareSide * squareSide > squareOfCircle)
            {
                Console.WriteLine("squareOfSquare biger than squareOfCircle");
            }
            else if (squareSide * squareSide < squareOfCircle)
            {
                Console.WriteLine("squareOfCircle biger than squareOfSquare");
            }
            else
            {
                Console.WriteLine("Equal");
            }
        }
        static void taskSix()
        {
            bool a = true;
            bool b = false;
            bool c = false;
            bool d = a || b;
            bool e = a && b;
            bool f = b || c;
            Console.WriteLine(d + " " + e + " " + f);
        }
        static void taskFive()
        {
            bool flag = true;
            while (flag)
            {
                Console.Write("Введите число:");
                string a = Console.ReadLine();
                if (int.TryParse(a, out int number))
                {
                    if (number / 10>0 && number/10<10) {
                        flag = false;
                        Console.Write("Число десятков:" + number / 10);
                        Console.WriteLine();
                        Console.Write("Число единиц:" + number % 10);
                        Console.WriteLine();
                        Console.Write("Сумма цифр:" + ((number / 10) + (number % 10)));
                        Console.WriteLine();
                        Console.Write("Произведение цифр:" + ((number / 10) * (number % 10)));
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Введите двузначное число!");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка введите допустимый тип переменной! (int). Нажмите Enter");
                    Console.ReadLine();
                }
            }
        }
        static void taskFour()
        {
            int days = 234;
            Console.WriteLine(days / 7);
        }
        static int taskThree()
        {
            int santimetr = 0;
            santimetr = Convert.ToInt32(Console.ReadLine());
            return (santimetr / 100);
        }
        static void taskSecond()
        {
            Console.WriteLine(5);
            Console.WriteLine(10);
            Console.WriteLine(21);
        }
        static void taskFirst()
        {
            int a, b, c = 0;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + "  " + b + "  " + c);
        }
        static int printSum()
        {
            int i, j = 0;
            i = Convert.ToInt32(Console.ReadLine());
            j = Convert.ToInt32(Console.ReadLine());
            return i + j;
        }
        static void printName()
        {
            string name = "", surname = "";
            Console.WriteLine("What is your name?: ");
            name = Console.ReadLine();
            Console.WriteLine("What is your surname?: ");
            surname = Console.ReadLine();
            Console.WriteLine("Your name is " + name + ", Your surname is " + surname);
        }
    }
}
