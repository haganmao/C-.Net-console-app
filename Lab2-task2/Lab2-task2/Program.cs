using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task2.1
            //#######################################################################################################################################################     
            // String temp;
            // double currentBalance;
            //Create one object of Account
            // Account account = new Account();


            //Initial balance
            //account.SetBalance(100.0);

            //read user input
            // Console.WriteLine("please enter your balance: ");
            // temp = Console.ReadLine();
            // account.Balance = double.Parse(temp);
            // currentBalance = account.Balance;
            // Console.WriteLine("Your current balance is: " + currentBalance);


            //Once withdraw get currentBalance
            //Console.WriteLine("Your balance is: " + account.getCurrentBalance());

            // Console.WriteLine("Please enter withdraw amount: ");
            // temp = Console.ReadLine();
            // currentBalance = account.getCurrentBalance() - double.Parse(temp);
            // Console.WriteLine("your current balance is: " + currentBalance);

            //Once add get currentBalance
            // Console.WriteLine("Please enter add amount: ");
            // temp = Console.ReadLine();
            // currentBalance = currentBalance + double.Parse(temp);
            // Console.WriteLine("your current balance is: " + currentBalance);

            //Once add interest get currentBalance
            // Console.WriteLine("Please enter your interest rate: ");
            // temp = Console.ReadLine();
            // currentBalance = currentBalance + (currentBalance * double.Parse(temp));
            // Console.WriteLine("your current balance including interest is: " + currentBalance);
            //#######################################################################################################################################################     


            //Task2.2
            String temp;
            double checkingBalance,savingBalance,transferAmount,totalAmount;
            //create objects
            // Bank bankaccount = new Bank();
            // Account account = new Account(100, "MAO");

            //get user input
            // Console.WriteLine("please enter your account name: ");
            // bankaccount.checking.accountName = Console.ReadLine();
            
            //initial checking and saving blance
            // bankaccount.checking.SetBalance(123);
            // bankaccount.savings.SetBalance(10000);

            //checking deposit
            // if (account.accountName == bankaccount.checking.accountName){
            //     Console.WriteLine("welcome come to bank: " + bankaccount.checking.accountName + "!");
            //     Console.WriteLine("Your current bank checking balance : " + bankaccount.checking.balance);
            //     Console.WriteLine("How much would you like to deposit today: ");
            //     temp = Console.ReadLine();
            //     checkingBalance = bankaccount.checking.balance + double.Parse(temp);
            //     bankaccount.deposit(checkingBalance, "Mao");            
            //     Console.WriteLine("Your checking balance now is: " + checkingBalance);
            // }

            // Console.WriteLine("please enter your savings account name: ");
            // bankaccount.savings.accountName = Console.ReadLine();


            //saving withdraw
            // if (account.accountName == bankaccount.savings.accountName){
            //     Console.WriteLine("welcome come to bank: " + bankaccount.savings.accountName + "!");
            //     Console.WriteLine("Your current saving balance : " + bankaccount.savings.balance);
            //     Console.WriteLine("How much would you like to withdraw today: ");
            //     temp = Console.ReadLine();
            //     savingBalance = bankaccount.savings.balance - double.Parse(temp);
            //     bankaccount.withdraw(savingBalance, "Mao");            
            //     Console.WriteLine("Your checking balance now is: " + savingBalance);
            // }

            //#################################################################################################################################################
            //transfer
                Bank bankaccount = new Bank();
                bankaccount.checking.SetBalance(456.62);
                bankaccount.savings.SetBalance(1000.88);
                bankaccount.checking.accountName="MAO";
                Console.WriteLine("Your current checking balance is:" + bankaccount.checking.balance);
                Console.WriteLine("Your current savings balance is:" + bankaccount.savings.balance);

                Console.WriteLine("How much would you like to transfer today: ");
                temp = Console.ReadLine();
                transferAmount = double.Parse(temp);
                bankaccount.transfer(transferAmount,"MAO");
                checkingBalance = bankaccount.checking.balance;
                savingBalance = bankaccount.savings.balance;
                totalAmount =  bankaccount.printBalances(checkingBalance,savingBalance);
                Console.WriteLine("You total balances is: " + totalAmount);
                
                Console.ReadKey();
                

            
            //print balances
                
            //#################################################################################################################################################
           


        }

    }
}
