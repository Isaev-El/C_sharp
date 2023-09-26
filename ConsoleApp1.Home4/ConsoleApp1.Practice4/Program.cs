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
            Car car = new Car("Mercedez-Benz","E200",2006,12000000,true);

            car.TheCarIsInAnEmergencyCondition(true);
            car.SellCar();

        }
    }
}
