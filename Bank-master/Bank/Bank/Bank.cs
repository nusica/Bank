using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Bank:IBankcs
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
        private Account FindAccount(int ibanNr)
        {
            foreach (Account account in Accounts)
            {
                if (account.IBAN == ibanNr)
                {
                    return account;
                }
            }
            return null;
        }

        public void Withdraw(int ibanNr, decimal withdrawSum)
        {
            Account account = FindAccount(ibanNr);
            account.Withdraw(withdrawSum);
        }

        public void Deposit(int ibanNr, decimal DepositSum)
        {
            Account account = FindAccount(ibanNr);
            account.Deposit(DepositSum);
        }

        public void ShowBalance(int ibanNr)
        {
            Account account = FindAccount(ibanNr);
            Console.WriteLine("The account total amount is: {0}", account.AccountSum);

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

        public void ShowDetailsAccount(int IBAN)
        {
            Account account = FindAccount(IBAN);
            account.ShowAccountDetails();
        }

         private static void SortDes(Bank bank)
        {
            for (int i = 0; i <bank.Accounts.Count-1; i++)
            {
                for (int j = i+1; j < bank.Accounts.Count; j++)
                {
                    if (bank.Accounts[i].AccountSum < bank.Accounts[j].AccountSum)
                    {
                        Account temp;
                        temp = bank.Accounts[i];
                        bank.Accounts[i] = bank.Accounts[j];
                        bank.Accounts[j] = temp;

                    }
                }
            }
        }
     
    }
}


