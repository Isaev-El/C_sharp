using Home.Work11.Model;
using Home.Work11.Repository;
using System.Collections.Generic;

namespace Home.Work11.Service
{
    internal struct EmployeeServiceImpl : IEmployeeRepository
    {
        public List<Employee> employees = new List<Employee>(){};
        public void AddEmployee(Employee employee) {            
            employees.Add(employee);
        }
        public EmployeeServiceImpl()
        {
        }

        public void GetAll()
        {
            foreach (var item in employees)
            {
                Console.WriteLine(item.ToString()); 
            }
        }
        public void GetByPosition(string position)
        {
            foreach (var item in employees) { 
                if (item.Position == position)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
        public void GetByAverageSalary()
        {
            double averageSalary = employees.Where(e => e.Position == "Klerk").Average(e => e.Salary);
            List<Employee> list = employees.FindAll(e=>e.Position=="Manager" && e.Salary>averageSalary).OrderBy(e=>e.Name).ToList();
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public void GetByJoinDate(string joinDate) {
            List<Employee> list = employees.FindAll(e=>e.JoiningDate>Convert.ToDateTime(joinDate)).OrderBy(e=>e.Surname).ToList();
            foreach (var item in list) {
                Console.WriteLine(item.ToString());
            }
        }
        public void GetBySex(int sex) {
            List<Employee> list=new List<Employee> { };
            if (sex==1)
            {
                list = employees.FindAll(e => e.Sex == Enum.Sex.ERADAM);
            }
            else if (sex==2) 
            {
                list = employees.FindAll(e => e.Sex == Enum.Sex.QATYN);
            }
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
