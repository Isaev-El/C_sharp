using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Home._5
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("***Задача 1***");

            string url = "https://example.com/cheto_tam";

            try
            {
                string response = PerformWebRequest(url);
                Console.WriteLine("Запрос выполнен успешно:");
                Console.WriteLine(response);
            }
            catch (WebException ex)
            {
                HandleWebException(ex);
            }

            Console.WriteLine("***Задача 2***");
            ArrayElementsOutOfCapacity();

            Console.WriteLine("***Задача 3***");
            try
            {
                CallMethodThatThrowsException();
            }
            catch(CustomException ex)
            {
                Console.WriteLine("Исключение перехвачено в методе Main:");
                Console.WriteLine(ex.Message);
            }
        }

        /*
         PerformWebRequest - Этот метод выполняет HTTP-запрос к указанному URL 
        с использованием класса WebClient. 
        Он загружает содержимое веб-ресурса и возвращает его в виде строки.
        HandleWebException - Этот метод обрабатывает исключения типа WebException, 
        которые могут возникнуть при выполнении запроса. 
         */
        static string PerformWebRequest(string url)
        {
            using (WebClient client = new WebClient())
            {
                return client.DownloadString(url);
            }
        }

        static void HandleWebException(WebException ex)
        {
            if (ex.Status == WebExceptionStatus.ProtocolError)
            {
                var response = ex.Response as HttpWebResponse;
                if (response != null && (int)response.StatusCode == 404)
                {
                    Console.WriteLine("Ошибка 404: Ресурс не найден");
                }
                else
                {
                    Console.WriteLine("Произошла ошибка при запросе: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Произошла ошибка при запросе: " + ex.Message);
            }
        }

        /*
         Задачка 2 
         */
        static void ArrayElementsOutOfCapacity()
        {
            int[] array = { 1, 2, 3, 4, 5 };

            try
            {
                for (int i = 0; i <= array.Length; i++)
                {
                    int value = array[i];
                    Console.WriteLine($"Элемент {i}: {value}");
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Произошло исключение IndexOutOfRangeException: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Завершение обработки массива.");
            }
        }

        /*
         Задача 3
         */
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

    /*
     Задача 3
     */
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {
         
        }
    }
}
