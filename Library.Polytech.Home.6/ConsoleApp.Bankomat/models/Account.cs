using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Bankomat
{
    public class Account
    {
        public string PasswordOfAccount { get; set; }
        public string NumberOfAccount { get; set; }
        public int SumInTheAccount { get; set; }
        public int ClientId { get; set; }
        public int NumberOfRequests { get; set; } = 0;

    }
}
