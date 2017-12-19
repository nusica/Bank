using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Bank
    {
        public string BankName { get; set; }
        public string BankAdress { get; set; }
        public List<Account> Accounts { get; set; }
      

        public delegate decimal DoSomething(decimal suma);

        public event DoSomething OnWithdraw;

        public int _ibanCount = 0;

        public Bank()
        {
            Accounts = new List<Account>();
        }

        public int GenerateIbanNr()
        {
            return ++_ibanCount;
        }

        public void Withdraw(int ibanNr, decimal withdrawSum)
        {
            foreach (Account account in Accounts)
            {
                if (account.IBAN == ibanNr)
                {
                    account.Withdraw(withdrawSum);
                }
            }
        }

        private void Bank_OnWithdraw(decimal suma)
        {
            throw new NotImplementedException();
        }

        public void Deposit(int ibanNr, decimal DepositSum)
        {
            foreach (Account account in Accounts)
            {
                if (account.IBAN == ibanNr)
                {
                    account.Deposit(DepositSum);
                }

            }
        }

        public void ShowBalance(int ibanNr)
        {
            foreach (Account account in Accounts)
            {
                if (account.IBAN == ibanNr)
                {
                    Console.WriteLine("The account total amount is: {0}", account.AccountSum);
                }
            }
        }

        public void ChangeUserAddress(string accountName, string accountAddress)
        {
            foreach (Account account in Accounts)
            {
                if (account.AccountName == accountName)
                {
                    account.AccountAdress = accountAddress;
                    Console.WriteLine("The new address is: {0}", account.AccountAdress);
                }
            }
        }
    }
}
