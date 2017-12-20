using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class Account
    {
        public string AccountName { get; set; }
        public decimal AccountSum { get; set; }
        public int IBAN { get; set; }
        public string AccountAdress { get; set; }
        public decimal ComisionWithdraw { get; set; }

        public abstract void ShowAccountDetails();
        

        public virtual void Withdraw(decimal withDrawSum)
        {
            if (withDrawSum > AccountSum)
            {
                Console.WriteLine(string.Format("Insufficient funds. Your account sum is {0}", AccountSum));
            }
            else
            {
                decimal comision = 0;
                AccountSum -= withDrawSum-comision;
                Console.WriteLine("Withdraw has been succesfull. Total amount is: {0} and the withdraw sum is {1}", AccountSum, comision);

            }
        }

        public virtual void Deposit(decimal DepositSum)
        {
            AccountSum += DepositSum;
            Console.WriteLine("Deposit has been succesfull. Total amount is: {0}", AccountSum);
        }

    }
}
