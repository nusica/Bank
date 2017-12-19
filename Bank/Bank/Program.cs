using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{

    class Program
    {
        public static Bank bank = new Bank();
        static void Main(string[] args)
        {
            Console.Write("Please enter the bank name: ");
            string bankName = Console.ReadLine();

            

            

            bank.OnWithdraw +=new Bank.DoSomething(Bank_OnWithdraw2);
            


            Console.WriteLine();
            Console.WriteLine("********************************");

            string option=null;

            while (option!="8")
            {
                Console.WriteLine("1. Create account"); 
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Show balance");
                Console.WriteLine("5. Show the three accounts with the bigger sum");
                Console.WriteLine("6. Delete an account");
                Console.WriteLine("7. Change the user adress");
                Console.WriteLine("8. Exit");
                
                Console.WriteLine(" ");

                Console.Write("Please choose an option: ");
                option = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("********************************");

                switch (option)
                {
                    case "1":
                        CreateAccount(bank);
                        break;
                    case "2":
                        Deposit(bank);
                        break;
                    case "3":
                        Withdraw(bank);
                        break;
                    case "4":
                        ShowBalance(bank);
                        break;
                    case "5":
                        ShowAccountsBiggerSum(bank);
                        break;
                    case "6":
                        DeleteAccount(bank);
                        break;
                    case "7":
                        ChangeUserAdress(bank);
                        break;
                    default:
                        break;
                }
            }       
            Console.Write("Press enter to exit");
            Console.ReadLine();
        }

        private static decimal Bank_OnWithdraw2(decimal suma)
        {
          suma =(suma * 5) / 100;
            return suma;
        }

        private static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        private static void ChangeUserAdress(Bank bank)
        {
            Console.Write("Please enter the account name: ");
            string accountName = Console.ReadLine();
            Console.Write("Please enter the new address: ");
            string accountAddress = Console.ReadLine();

            bank.ChangeUserAddress(accountName, accountAddress);

            Console.WriteLine();
            Console.WriteLine("********************************");

        }

        private static void DeleteAccount(Bank bank)
        {
            Console.Write("Please enter the IBAN: ");
            int ibanNr = Convert.ToInt32(Console.ReadLine());

            for (int i = bank._ibanCount - 1; i>=0; i--)
            {
                
            }
            Console.WriteLine();
            Console.WriteLine("********************************");
        }

        private static void ShowAccountsBiggerSum(Bank bank)
        {
            SortDes(bank);
            Show(bank, 3);
        }

        private static void Show(Bank bank, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Name: {0}, sallary: {1}", bank.Accounts[i].AccountName, bank.Accounts[i].AccountSum);
            }
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

        private static void ShowBalance(Bank bank)
        {
            Console.Write("Please enter the IBAN: ");
            int ibanNr = Convert.ToInt32(Console.ReadLine());

            bank.ShowBalance(ibanNr);

            Console.WriteLine();
            Console.WriteLine("********************************");
        }

        private static void Withdraw(Bank bank)
        {
            Console.Write("Please enter the IBAN: ");
            int ibanNr = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the sum: ");
            decimal accountSum = Convert.ToDecimal(Console.ReadLine());

            bank.Withdraw(ibanNr, accountSum);
          
            Console.WriteLine();
            Console.WriteLine("********************************");
        }

        private static void Deposit(Bank bank)
        {
            Console.Write("Please enter the IBAN: ");
            int ibanNr = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the sum: ");
            decimal accountSum = Convert.ToDecimal(Console.ReadLine());

            bank.Deposit(ibanNr, accountSum);

            Console.WriteLine();
            Console.WriteLine("********************************");
        }

        private static void CreateAccount(Bank bank)
        {
            Account account;
            Console.WriteLine("The available bank types are: ");
            Console.WriteLine("0. Business Gold Bank Account");
            Console.WriteLine("1. Business Bank Account");
            Console.WriteLine("2. Personal Bank Account");
            Console.WriteLine();
            Console.Write("Please choose a type account: ");
            int type = Convert.ToInt32(Console.ReadLine());

            switch (type)
            {
                case (int)AccountsType.BusinessGoldBankAccount:
                    account = new BusinessGoldBankAccount();               
                    break;
                case (int)AccountsType.BusinessBankAccount:
                    account = new BusinessBankAccount();
                    break;
                case (int)AccountsType.PersonalBankAccount:
                    account = new PersonalBankAccount();
                    break;
                default:
                    account = null;
                    break;      
            }
            
            Console.Write("Please enter your account name: ");
            string accountname = Console.ReadLine();
            
            account.AccountName = accountname;

            account.IBAN = bank.GenerateIbanNr();

            bank.Accounts.Add(account);

            Console.WriteLine("Account created successfully with the name {0} and IBAN: {1}", account.AccountName,account.IBAN);
            Console.WriteLine();
            Console.WriteLine("********************************");

        }
    }
}
