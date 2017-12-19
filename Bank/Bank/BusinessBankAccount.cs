using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class BusinessBankAccount:Account
    {
        public override void Withdraw(decimal withDrawSum)
        {
			
			
            decimal comision= (withDrawSum * 0.01M) / 100;
            AccountSum = withDrawSum - comision;
			
			
            Console.WriteLine("Withdraw has been succesfull. Total amount is: {0} and the withdraw sum is {1}", AccountSum, comision);
        }
    }
}
