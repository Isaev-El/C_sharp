using Home.Work8.Ex2;
using System;

namespace Home.Work8;

class Program
{
    static void Main(string[] args)
    {
        Bill bill = new Bill(100, 4, "осень");
        bill.PrintBillTable();

        /*Console.WriteLine("Введите размер массива (целое число!):");
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите index для которого хотите установить значение:");
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите значение для индекса:");
        int value = int.Parse(Console.ReadLine());

        Index arr = new Index(size);

        try
        {
            arr[index] = value;
            Console.WriteLine($"Текущее значение по индексу:{index} равно {arr[index]}");
        }
        catch (CustomException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
            Console.WriteLine($"Дополнительное сообщение: {ex.CustomProperty}");
        }*/


    }
}
