using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 
Написать программу, рассчитывающую сумму коммунальных платежей: есть базовые тарифы на отопление (на 1 м2 площади), 
на воду (на 1 чел), на газ (на 1 чел), на текущий ремонт (на 1 м2 площади). Задается метраж помещения, количество проживающих людей, 
сезон (осенью и зимой отопление дороже), наличие льгот (ветеран труда– 30 % от его части; ветеран войны- 50% от его части). 
Вывести таблицу со столбцами: Вид платежа, Начислено, Льготная скидка, Итого. Посчитать итоговую сумму.
 
 */

namespace Home.Work8.Ex2
{
    public class Bill
    {
        public int Square { get; set; }
        public int QuantityOfPeople { get; set; }
        public string Season { get; set; }
        public Dictionary<string, double> KindOfBill { get; set; }
        public List<Human> Humans { get; set; }

        public Bill(int square, int quantity, string season)
        {
            Square = square;
            QuantityOfPeople = quantity;
            Season = season;
            KindOfBill = new Dictionary<string, double>()
            {
                { "Отопление", 5.0 }, // базовый тариф на 1 м2
                { "Вода", 4.0 },      // базовый тариф на 1 человека
                { "Газ", 3.0 },       // базовый тариф на 1 человека
                { "Ремонт", 6.0 }
            };

            Humans = new List<Human>();
            Humans.Add(new Human() { Name = "Evgeny", Surname = "Gertsen", IsVeteran = true });
            Humans.Add(new Human() { Name = "Stepan", Surname = "Stepanov", IsVeteran = false });
            Humans.Add(new Human() { Name = "Elkhan", Surname = "Isaev", IsVeteran = true });
            Humans.Add(new Human() { Name = "Ivan", Surname = "Ivanov", IsVeteran = false });
            Humans.Add(new Human() { Name = "Musa", Surname = "Musaev", IsVeteran = true });
        }

        public double CalculateBill(string billType)
        {
            double amount = 0;

            if (billType == "Отопление")
            {
                if (Season == "осень" || Season == "зима")
                    amount = KindOfBill[billType] * Square;
                else
                    amount = KindOfBill[billType] * 0.8 * Square;
            }
            else
            {
                amount = KindOfBill[billType] * (billType == "Вода" ? QuantityOfPeople : Square);
            }

            double discount = 0;

            foreach (var human in Humans)
            {
                if (human.IsVeteran)
                {
                    if (human.Name == "Evgeny") // Предположим, что "Evgeny" является ветераном труда
                    {
                        discount -= 0.3 * amount;
                    }
                    else if (human.Name == "Elkhan") // Предположим, что "Elkhan" является ветераном войны
                    {
                        discount -= 0.5 * amount;
                    }
                }
            }

            return amount - discount;
        }

        public void PrintBillTable()
        {
            Console.WriteLine("Вид платежа\t\tНачислено\tЛьготная скидка\tИтого");
            Console.WriteLine("-----------------------------------------------");

            foreach (var billType in KindOfBill.Keys)
            {
                double calculatedAmount = CalculateBill(billType);
                double discount = 0;

                foreach (var human in Humans)
                {
                    if (human.IsVeteran)
                    {
                        if (human.Name == "Evgeny")
                        {
                            discount += 0.3 * CalculateBill(billType);
                        }
                        else if (human.Name == "Elkhan")
                        {
                            discount += 0.5 * CalculateBill(billType);
                        }
                    }
                }

                Console.WriteLine($"{billType}\t\t{CalculateBill(billType):C}\t\t{discount:C}\t\t{calculatedAmount + discount:C}");
            }
        }
    }
}
