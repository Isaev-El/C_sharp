using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Work8
{
    public class RangeOfArray
    {
        public int[] arr;
        public int size;

        Random rand= new Random();

        public RangeOfArray(int size)
        {
            this.size = size;
            arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(10,15); 
            }
        }

        public int this[int index]
        {
            get {
                try
                {
                    return arr[index - 1];

                }
                catch (Exception)
                {

                    throw new IndexOutOfRangeException("Будь в границе массива!");
                }
            }
            set {
                arr[index] = value;
            }
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
                result += ' ';
            }

            return result;
        }
    }

    public class Product
    {
        public int category { get; set; }
        public string name { get; set; }
        public int price { get; set; }

    }

    public class Supermarket
    {
        List<Product> products = null;
        public Supermarket()
        {
            products = new List<Product>();
            products.Add(new Product() { price = 1000, name="Ilya1", category=1});
            products.Add(new Product() { price = 2000, name="Ilya2", category=1});
            products.Add(new Product() { price = 3000, name="Ilya3", category=1});

        }

        public double this[int category]
        {
            get
            {
                double sum = 0;
                TimeSpan start = new TimeSpan(8,0,0);
                TimeSpan end = new TimeSpan(12,0,0);

                foreach (Product item in products)
                {
                    sum += item.price;
                }
                if (start < DateTime.Now.TimeOfDay && end > DateTime.Now.TimeOfDay)
                    return sum*0.95;
                else
                    return sum;                     
            }
            set
            {

            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Supermarket supermarket = new Supermarket();
            Console.WriteLine(supermarket[1]);
        }
    }
}
