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

        public override void ShowAccountDetails()
        {
            Console.WriteLine("Account type is: {0}", AccountsType.BusinessBankAccount);
            Console.WriteLine("Account name is: {0} and has the IBAN no: {1}", AccountName, IBAN);
            Console.WriteLine("The account sum is: {0} and the has: {1} the withdraw comisions", AccountSum, ComisionWithdraw);

        }
    }
}
