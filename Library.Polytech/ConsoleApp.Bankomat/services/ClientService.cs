using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Bankomat.services
{
    public class ClientService
    {
        public static bool Registration(Client client)
        {
            try
            {
                Console.Write("Введите Имя:");
                client.Name = Console.ReadLine();
                Console.Write("Введите Фамилию:");
                client.Surname = Console.ReadLine();
                Console.Write("Введите Email:");
                client.Email = Console.ReadLine();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Получение пароля и номера счета после успешной регистрации
        public static string ObtainingPasswordAndAccountNumber(Client client, bool flag)
        {
            string numberOfAccount = "";
            string passwordOfAccount = "";
            client.Accounts = new Account[1];
            if (flag == true)
            {
                for (int i = 0; i < client.Accounts.Length; i++)
                {
                    client.Accounts[i] = new Account();
                    client.Accounts[i].NumberOfAccount = "54684564";
                    client.Accounts[i].PasswordOfAccount = GenerateRandomNumber();

                    numberOfAccount = client.Accounts[i].NumberOfAccount;
                    passwordOfAccount = client.Accounts[i].PasswordOfAccount;
                }
                return $"Пароль от карты:{passwordOfAccount}, Номер карты:{numberOfAccount}";
            }
            else
            {
                return "Forbidden!";
            }
        }

        //Пополнение суммы.
        public static void TopUpYourAccount(Client client)
        {
            bool flag = true;
            while (flag)
            {
                if (client.Accounts[0].NumberOfRequests == 0)
                {
                    Console.WriteLine("Введите сумму для пополнения (не менее 50 000!):");
                    int sum = int.Parse(Console.ReadLine());
                    if (sum < 50000)
                    {
                        Console.WriteLine("Введите сумму превышающую 50 000!");
                    }
                    else
                    {
                        flag = false;
                        for (int i = 0; i < client.Accounts.Length; i++)
                        {
                            client.Accounts[i].SumInTheAccount += sum;
                        }
                        Console.WriteLine($"Пополнение прошло успешно! Ваш счет составляет:{client.Accounts[0].SumInTheAccount}");

                        client.Accounts[0].NumberOfRequests += 1;
                    }
                }
                else if (client.Accounts[0].NumberOfRequests > 0)
                {
                    flag = false;
                    Console.WriteLine("Введите сумму для пополнения:");
                    int sum = int.Parse(Console.ReadLine());
                    for (int i = 0; i < client.Accounts.Length; i++)
                    {
                        client.Accounts[i].SumInTheAccount += sum;
                    }
                    Console.WriteLine($"Пополнение прошло успешно! Ваш счет составляет:{client.Accounts[0].SumInTheAccount}");

                    Console.WriteLine("1) Вернуться на главное меню");
                    Console.WriteLine("2) Выйти");
                    int temp = int.Parse(Console.ReadLine());
                    switch (temp)
                    {
                        case 1:
                            FirstMenu(client);
                            break;
                        case 2:
                            Environment.Exit(0);
                            break;
                    }
                }
            }
        }

        //Проверка пароля
        public static bool CheckPassword(Client client)
        {
            int kolichestvoPopytok = 3;

            for (int i = 0; i < kolichestvoPopytok; i++)
            {
                string password = Console.ReadLine();
                if (client.Accounts[0].PasswordOfAccount == password)
                {
                    return true; // Пароль совпал, возвращаем true
                }
                else
                {
                    Console.WriteLine("Пароли не совпадают!");
                }
                
            }

            Console.WriteLine("Неверный пароль!");
            return false; // Все попытки неудачны, возвращаем false
        }

        //Выбор меню
        public static void FirstMenu(Client client)
        {
            Console.WriteLine("1) Вывод баланса на экран");
            Console.WriteLine("2) Пополнение счета");
            Console.WriteLine("3) Снять деньги со счета");
            Console.WriteLine("4) Выход");
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    ShowBalance(client);
                    Console.WriteLine("1) Вернуться на главное меню");
                    Console.WriteLine("2) Выйти");
                    int temp = int.Parse(Console.ReadLine());
                    switch (temp)
                    {
                        case 1:
                            FirstMenu(client);
                            break;
                        case 2:
                            Environment.Exit(0);
                            break;
                    }
                    break;
                case 2:
                    TopUpYourAccount(client);
                    break;
                case 3:
                    TakeMoney(client);
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }
        }

        public static void ShowBalance(Client client)
        {
            for(int i = 0; i < client.Accounts.Length; i++)
            {
                Console.WriteLine("Сумма на вашем счету:"+client.Accounts[i].SumInTheAccount);             }
        }

        //Снимаем деньги
        public static void TakeMoney(Client client)
        {
            Console.WriteLine("Введите сумму для снятия - ");
            int minus = int.Parse(Console.ReadLine());
            if (minus>client.Accounts[0].SumInTheAccount)
            {
                Console.WriteLine($"Сумма снятия превышает количество средств на карте! Ваша сумма на " +
                    $"карте:{client.Accounts[0].SumInTheAccount}");

                Console.WriteLine("1) Вернуться на главное меню");
                Console.WriteLine("2) Выйти");
                int temp = int.Parse(Console.ReadLine());
                switch (temp)
                {
                    case 1:
                        FirstMenu(client);
                        break;
                    case 2:
                        Environment.Exit(0);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Операция выполнена успешно!");
                client.Accounts[0].SumInTheAccount -= minus;
                Console.WriteLine($"Сумма снятия:{minus}, сумма на карте:{client.Accounts[0].SumInTheAccount}");

                Console.WriteLine("1) Вернуться на главное меню");
                Console.WriteLine("2) Выйти");
                int temp = int.Parse(Console.ReadLine());
                switch (temp)
                {
                    case 1:
                        FirstMenu(client);
                        break;
                    case 2:
                        Environment.Exit(0);
                        break;
                }
            }

        }

        //Случайные числа для карты 
        public static string GenerateRandomNumber()
        {
            Random random = new Random();
            string number = "";

            for (int i = 0; i < 5; i++)
            {
                // Генерация случайной цифры от 0 до 9 и добавление ее к строке
                number += random.Next(10).ToString();
            }

            return number;
        }

    }
}
