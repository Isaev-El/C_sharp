using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Practice5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CallMethodThatThrowsException();
            }

            catch (CustomException ex)
            {
                Console.WriteLine("Исключение перехвачено в методе Main:");
                Console.WriteLine(ex.Message);
            }
        }
        static void CallMethodThatThrowsException()
        {
            Console.WriteLine("Вызывающий метод: начало выполнения");

            try
            {
                // Вызываем метод, который сгенерирует исключение
                ThrowCustomException();
            }
            catch (CustomException ex)
            {
                Console.WriteLine("Исключение перехвачено в вызывающем методе:");
                Console.WriteLine(ex.Message);
                throw; // Поднимаем исключение выше
            }

            Console.WriteLine("Вызывающий метод: конец выполнения");
        }

        static void ThrowCustomException()
        {
            Console.WriteLine("Метод, который генерирует исключение: начало выполнения");
            throw new CustomException("Произошла пользовательская ошибка");
        }
    }
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {

        }
    }
}
