using System;

namespace Home.Work8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите размер массива (целое число!):");
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите index для которого хотите установить значение:");
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите значение для индекса:");
        int value = int.Parse(Console.ReadLine());

        Index arr = new Index(size,index,value);

        Console.WriteLine($"Текущее значение по индексу:{index}:{arr[index]}");
    }
}
