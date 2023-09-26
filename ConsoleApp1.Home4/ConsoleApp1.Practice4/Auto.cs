using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Practice4
{
    public partial class Car
    {
        // Закрытые поля
        private string brand;
        private string model;
        private int year;
        private double price;
        private bool isAvailable;

        // Статические поля
        private static int totalCarsSold;
        private static double totalRevenue;

        // Конструктор по умолчанию
        public Car()
        {
            brand = "Unknown";
            model = "Unknown";
            year = DateTime.Now.Year;
            price = 0.0;
            isAvailable = true;
        }

        // Перегруженный конструктор
        public Car(string brand, string model, int year, double price, bool isAvailable)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.price = price;
            this.isAvailable = isAvailable;
        }

        // Геттеры и сеттеры для закрытых полей
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public bool IsAvailable
        {
            get { return isAvailable; }
            set { isAvailable = value; }
        }

        // Метод управления классом: Продажа автомобиля
        public void SellCar()
        {
            if (isAvailable)
            {
                isAvailable = false;
                totalCarsSold++;
                totalRevenue += price;
                Console.WriteLine($"Car sold: {brand} {model}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Car is not available for sale.");
                Console.ReadLine(); 
            }
        }

        // Статический метод: Получение общего количества проданных автомобилей
        public static int GetTotalCarsSold()
        {
            return totalCarsSold;
        }

        // Статический метод: Получение общей выручки
        public static double GetTotalRevenue()
        {
            return totalRevenue;
        }

        // Метод с передачей аргументов по ссылке: Применение скидки
        public void Discount(ref double discountAmount)
        {
            if (isAvailable)
            {
                price -= discountAmount;
                Console.WriteLine($"Discount applied: {discountAmount:C}");
            }
            else
            {
                Console.WriteLine("Car is not available for discount.");
            }
        }

        // Статический конструктор
        static Car()
        {
            totalCarsSold = 0;
            totalRevenue = 0.0;
        }

    }
}
