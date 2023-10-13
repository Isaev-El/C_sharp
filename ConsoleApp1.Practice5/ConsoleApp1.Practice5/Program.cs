using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Practice5
{
    public class Program
    {
        static void Main()
        {
            try
            {
                Worker.DoWork();
            }
            catch (CustomException ex)
            {
                Console.WriteLine("Исключение было обработано в методе Main:");
                Console.WriteLine(ex.Message);
            }
        }
    }

    public class Worker
    {
        public static void DoWork()
        {
            Console.WriteLine("Метод DoWork: начало выполнения");
            try
            {
                Helper.PerformTask();
            }
            catch (CustomException ex)
            {
                Console.WriteLine("Исключение было обработано в методе DoWork:");
                Console.WriteLine(ex.Message);
                throw; // Поднимаем исключение выше
            }
            Console.WriteLine("Метод DoWork: конец выполнения");
        }
    }

    public class Helper
    {
        public static void PerformTask()
        {
            Console.WriteLine("Метод PerformTask: начало выполнения");
            throw new CustomException("Произошла пользовательская ошибка в PerformTask");
        }
    }

    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {
        }
    }
}
