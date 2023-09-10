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
            example8();
            Console.ReadLine();
        }

        static void example8()
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
        static void example7()
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
        static void example6()
        {
            bool a = true;
            bool b = false;
            bool c = false;
            bool d = a || b;
            bool e = a && b;
            bool f = b || c;
            Console.WriteLine(d + " " + e + " " + f);
        }
        static void periodToweeks()
        {
            int days = 234;
            Console.WriteLine(234 / 7);
        }
        static int santToMetr()
        {
            int santimetr = 0;
            santimetr = Convert.ToInt32(Console.ReadLine());
            return (santimetr / 100);
        }
        static void printJust()
        {
            int a, b, c = 0;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + " " + b + " " + c + " ");
        }
        static void converExample()
        {
            int a = Convert.ToInt32("5");

        }

        static void dateExample()
        {
            DateTime dt = new DateTime(2023, 01, 01);

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
