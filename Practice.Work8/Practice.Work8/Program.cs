using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Work8
{
    class RangeOfArray
    {
        int[] array;
        int upperOrig;
        int lowerOrig;
        public RangeOfArray(int lower, int upper)
        {
            upperOrig = upper;
            lowerOrig = lower;
            array = new int[upper - lower + 1];
        }

        public int this[int index]
        {
            get
            {
                if (index >= lowerOrig && index <= upperOrig)
                {
                    return array[index - lowerOrig];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
            }
            set
            {
                if (index >= lowerOrig && index <= upperOrig)
                {
                    array[index - lowerOrig] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
            }
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
