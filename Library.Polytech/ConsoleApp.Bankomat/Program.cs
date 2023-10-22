using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Bankomat.services;

namespace ConsoleApp.Bankomat
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Зарегестрируйтесь, чтобы открыть счет!");
            Client client = new Client();
            bool flag=ClientService.Registration(client);

            string results=ClientService.ObtainingPasswordAndAccountNumber(client,flag);
            Console.WriteLine("Данные о карте - \n"+results);

            ClientService.TopUpYourAccount(client);

            Console.WriteLine("Введите пароль для дальнейших действий! Ваш пароль:"+client.Accounts[0].PasswordOfAccount);
            ClientService.CheckPassword(client);

            ClientService.FirstMenu(client);
            Console.ReadLine();
        }
    }
}
