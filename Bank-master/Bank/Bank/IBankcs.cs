using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public interface IBankcs
    {
       
        int GenerateIbanNr();
        void Withdraw(int ibanNr, decimal withdrawSum);
        void Bank_OnWithdraw(decimal suma);
        void Deposit(int ibanNr, decimal DepositSum);
        void ShowBalance(int ibanNr);
        void ChangeUserAddress(string accountName, string accountAddress);
        void ShowDetailsAccount(int IBAN);
    }
}
