using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Practice3
{
    class Program
    {
        static void Main(string[] args)
        {
            StrF11();
        }

        static void F10()
        {
            char a = '0';

            while (a != 'q')
            {
                a = char.Parse(Console.ReadLine());
                Console.WriteLine(a + " -> " + char.ToUpper(a));
            }
        }

        static void StrF13()
        {
            string str = "В лесу родилась елочка в лесу она росла зимой и летом стройная зеленая была";
            string[] arr = str.Split(' ');          

            for (int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
        }
        static void StrF12()
        {
            string num = "slsnlsj 131321 23123";
            string[] temp = num.Split(' ');
            int chislo = 0;
            int sum = 0;

            foreach (string i in temp )
            {
                if (int.TryParse(i, out chislo))
                {
                    sum += chislo;
                }
            }
            Console.WriteLine("Summa:"+sum);
            Console.ReadLine();
        }
        static void StrF11()
        {
            string a = "hsadas 1 4 asd 6 a 3";
            string[] temp = a.Split(' ');


            int count = 0;
            int chislo = 0;
            foreach (string i in temp)
            {
                if (int.TryParse(i, out chislo))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();

        }
    }
}
