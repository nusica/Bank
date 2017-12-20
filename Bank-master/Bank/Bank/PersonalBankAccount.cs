using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class PersonalBankAccount:Account
    {
        decimal comisionDepunere;
        
        public override void Withdraw(decimal withDrawSum)
        {            
            if (withDrawSum > AccountSum)
            {
                Console.WriteLine(string.Format("Insufficient funds. Your account sum is {0}", AccountSum));
            }
            else
            {
                ComisionWithdraw = (withDrawSum * 0.02M) / 100;
                AccountSum -= withDrawSum-ComisionWithdraw;
                Console.WriteLine("Withdraw has been succesfull. Total amount is: {0} and the withdraw sum is {1}", AccountSum, ComisionWithdraw);
            }
       }

        public override void Deposit(decimal DepositSum)
        {
            comisionDepunere = (DepositSum * 0.05M) / 100;
            AccountSum += DepositSum-comisionDepunere;
            Console.WriteLine("Deposit has been succesfull. Total amount is: {0} and comision is {1}", AccountSum,comisionDepunere);
        }
       
        public override void ShowAccountDetails()
        {
            Console.WriteLine("Account type is: {0}", AccountsType.PersonalBankAccount);
            Console.WriteLine("Account name is: {0} and has the IBAN no: {1}", AccountName, IBAN);
            Console.WriteLine("The account sum is: {0} and the has: {1} the withdraw comisions and {2} the deposit comision ", AccountSum,ComisionWithdraw, comisionDepunere);

        }
    }   
}
