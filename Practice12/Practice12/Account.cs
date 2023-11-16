using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice12
{
    public delegate void AccountStateHandler(string message);

    public class Account
    {
        int _sum = 0;
        public Account(int _sum) {
            this._sum = _sum;
        }


        AccountStateHandler del;

        public void RegisterHandler(AccountStateHandler del)
        {
            this.del = del;
        }
            
        public int CurrentSum { get { return _sum; } }   
        /**/
        public void Withdraw(int sum)
        {
            if (sum <= _sum)
            {
                _sum -= sum;
                this.del("Сумма снята со счета");
            }
            else {
                this.del("Недостаточно средств");
            }
        }
           
    }
}
