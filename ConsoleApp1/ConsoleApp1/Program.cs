using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            Task3();
        }

        public static void Task1() { 
            List<int> list = Input<int>();

            int max1 = 0;
            int max2 = 0;
            int index1 = 0;
            int index2 = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > max1)
                {
                    max2 = max1;
                    max1 = list[i];
                    
                    index2 = index1;
                    index1 = i;
                }
            }

            Console.WriteLine($"max1:{max1}\nmax2:{max2}\nindex1:{index1}\nindex2{index2}");

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i]%2!=0)
                {
                    list.RemoveAt(i);
                }
            }

            foreach (var item in list)
            {
                Console.WriteLine(item+" ");

            }
        }

        public static List<T> Input<T>() {
            Random rnd = new Random();
            List<T> list = new List<T>();

            for (int i = 0; i < rnd.Next(10,20); i++)
            {
                var val = (T) Convert.ChangeType(rnd.Next(10,90), typeof(T));

                list.Add(val);
            }
            return list;
        }

        public static void Task2()
        {
            List<double> list = Input<double>();

            double sum = 0;
            int count = 0;

            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
               
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > sum/list.Count) {
                    Console.WriteLine($"{i}\n");
                }
            }
        }

        public static void Task3()
        {
            List<double> list1 = Input<double>();

            Stack<double> stack = new Stack<double>(list1);

            list1.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();


            foreach (var item in stack)
                Console.Write(item + " ");

            
        }


    }
}