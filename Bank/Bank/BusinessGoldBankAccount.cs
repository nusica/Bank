using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class BusinessGoldBankAccount:Account
    {
        public override void Withdraw(decimal withDrawSum)
        {
            base.Withdraw(withDrawSum);
        }
    }
}
