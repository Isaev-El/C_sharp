using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Home.Work11.Enum;
using Home.Work11.Model;

namespace Home.Work11.Repository
{
    interface IEmployeeRepository
    {
         void GetAll();
        void GetByPosition(string position);
        void GetBySex(int sex);
        void GetByJoinDate(string date);
        void GetByAverageSalary();
    }
}
