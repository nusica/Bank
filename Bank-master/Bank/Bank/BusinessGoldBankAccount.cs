using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class BusinessGoldBankAccount : Account
    {
        public override void Withdraw(decimal withDrawSum)
        {
            base.Withdraw(withDrawSum);
        }

        public override void ShowAccountDetails()
        {
            Console.WriteLine("Account type is: '{0}'", AccountsType.BusinessGoldBankAccount);
            Console.WriteLine("Account name is: '{0}' and has the IBAN no: '{1}'", AccountName.ToUpper(), IBAN);
            Console.WriteLine("The account sum is: '{0}' and has '0' comisions ", AccountSum);
            
        }
    }
}
