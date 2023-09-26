using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Practice4;


namespace ConsoleApp1.Home4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем массив объектов Car
            Car[] cars = new Car[5];

            // Заполняем массив экземплярами класса Car
            cars[0] = new Car("Toyota", "Camry", 2020, 25000.0, true);
            cars[1] = new Car("Ford", "Focus", 2019, 20000.0, true);
            cars[2] = new Car("Honda", "Civic", 2021, 22000.0, true);
            cars[3] = new Car("Chevrolet", "Malibu", 2018, 18000.0, true);
            cars[4] = new Car("Nissan", "Altima", 2022, 27000.0, true);

            // Выводим информацию о каждом автомобиле и вызываем методы
            foreach (Car car in cars)
            {
                Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Year: {car.Year}, Price: {car.Price}, Available: {car.IsAvailable}");

                // Продажа автомобиля
                car.SellCar();

                // Применение скидки
                double discountAmount = 1000.0;
                car.Discount(ref discountAmount);

                //представим что все машины аварийные 
                car.TheCarIsInAnEmergencyCondition(true);

                Console.WriteLine($"Total Cars Sold: {Car.GetTotalCarsSold()}");
                Console.WriteLine($"Total Revenue: {Car.GetTotalRevenue():C}");
                Console.WriteLine();

            }
        }
    }
}
