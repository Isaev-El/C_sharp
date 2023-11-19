using Home.Work11.Model;
using Home.Work11.Service;

namespace Home.Work11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employeeServiceImpl = new EmployeeServiceImpl();

            Console.WriteLine("Введите количество сотрудников:");
            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                
                Employee employee = new Employee();
                Console.Write("Введите имя:");
                employee.Name = Console.ReadLine();
                Console.Write("Введите фамилию:");
                employee.Surname = Console.ReadLine();
                Console.Write("Введите должность:");
                employee.Position = Console.ReadLine();
                Console.Write("Введите зарплату:");
                employee.Salary = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Выберите гендер 1 - мужична, 2 - женщина:");
                int choiseOfSex = Convert.ToInt32(Console.ReadLine());
                if (choiseOfSex==1)
                {
                    employee.Sex = Enum.Sex.ERADAM;
                }
                else if(choiseOfSex==2)
                {
                    employee.Sex = Enum.Sex.QATYN;
                }
                Console.Write("Дата присоединения, формат ввода (dd-mm-yy):");
                employee.JoiningDate = Convert.ToDateTime(Console.ReadLine());

                employeeServiceImpl.AddEmployee(employee);
                Console.WriteLine();
            }
            Console.WriteLine("Выберите действия:");
            Console.WriteLine("1) Получить полную информацию о всех сотрудниках:");
            Console.WriteLine("2) Получить полную информацию о сотрудниках выбранной должности:");
            Console.WriteLine("3) Найти в массиве всех менеджеров, зарплата которых больше средней " +
                                "зарплаты всех клерков, вывести на экран полную информацию о таких " +
                                "менеджерах отсортированной по их фамилии:");
            Console.WriteLine("4) Найти всех сотрудников присоедившийхся после указанной даты:");
            Console.WriteLine("5) Вывод информации о сотрудниках по гендеру или всех сотрудников в " +
                              "случае если гендер не указан:");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    employeeServiceImpl.GetAll();
                    break;
                case 2:
                    Console.Write("Введите должность:");
                    string position=Console.ReadLine();
                    employeeServiceImpl.GetByPosition(position);
                    break;
                case 3:
                    employeeServiceImpl.GetByAverageSalary();
                    break;
                case 4:
                    Console.Write("Введите дату, формат ввода (dd-mm-yy):");
                    string date = Console.ReadLine();
                    employeeServiceImpl.GetByJoinDate(date);
                    break;
                case 5:
                    Console.WriteLine("Введите 1(мужчина) или 2(женщина) для вывода сотрудников по гендеру " +
                                      "или введите 0 для получения информации обо всех сотрудниках");
                    string inputSex = Console.ReadLine();
                    int sex;

                    if (!int.TryParse(inputSex, out sex) || (sex != 0 && sex != 1 && sex != 2))
                    {
                        Console.WriteLine("Некорректный ввод.");
                        employeeServiceImpl.GetAll();
                    }
                    else
                    {
                        employeeServiceImpl.GetBySex(sex);
                    }

                    break;
            }

            
        }
    }
}
