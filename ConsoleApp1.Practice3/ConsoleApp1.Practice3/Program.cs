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
            Console.WriteLine("***StrF11***");
            StrF11();

            Console.WriteLine("***StrF12***");
            StrF12();

            Console.WriteLine("***StrF13***");
            StrF13();

            Console.WriteLine("***F10***");
            F10();

            Console.WriteLine("***CountWordsWithMatchingFirstLastChar***");
            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();

            int count = CountWordsWithMatchingFirstLastChar(input);

            Console.WriteLine($"Количество слов с совпадающими первым и последним символами: {count}");
            Console.ReadLine();
        }

        /*
         Написать программу, в которой по малой русской букве выводится соответствующая большая.
         */
        static void F10()
        {
            char a = '0';
            Console.WriteLine("Введите букву:");
            while (a != 'q')
            {
                a = char.Parse(Console.ReadLine());
                Console.WriteLine(a + " -> " + char.ToUpper(a));
            }
        }

        /*
         Дано предложение из 10 слов. Заполнить ими массив из 10 элементов.
         */
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
        /*
         Дан текст. Найти сумму всех имеющихся в нем чисел
         */
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

        /*
         Дан текст. Определить количество цифр в нем.
         */
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
        /*
         Дана строка символов длиной не более 255 символов. Группы символов, разделенные пробелами и 
        не содержащие пробелов внутри себя, будем называть словами. 
        Найти количество слов, у которых первый и последний символы совпадают между собой.*/
        static int CountWordsWithMatchingFirstLastChar(string input)
        {
            int count = 0;

            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                if (word.Length >= 2 && word[0] == word[word.Length - 1])
                {
                    count++;
                }
            }

            return count;
        }
    }
}
