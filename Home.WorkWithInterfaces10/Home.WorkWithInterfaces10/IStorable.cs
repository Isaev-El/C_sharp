using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.WorkWithInterfaces10
{
    public interface IStorable
    {
        void SaveToFile(string fileName);
        void LoadFromFile(string fileName);
    }
}
