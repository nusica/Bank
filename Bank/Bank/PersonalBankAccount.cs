using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class PersonalBankAccount:Account
    {
        public override void Withdraw(decimal withDrawSum)
        {            
            if (withDrawSum > AccountSum)
            {
                Console.WriteLine(string.Format("Insufficient funds. Your account sum is {0}", AccountSum));
            }
            else
            {
                decimal comision = (withDrawSum * 0.02M) / 100;
                AccountSum -= withDrawSum-comision;
                Console.WriteLine("Withdraw has been succesfull. Total amount is: {0} and the withdraw sum is {1}", AccountSum, comision);
            }
       }

        public override void Deposit(decimal DepositSum)
        {
            decimal comision = (DepositSum * 0.05M) / 100;
            AccountSum += DepositSum-comision;
            Console.WriteLine("Deposit has been succesfull. Total amount is: {0} and comision is {1}", AccountSum,comision);
        }
    }



   
}
