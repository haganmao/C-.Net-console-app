using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_task2
{
    class Bank
    {   
        //creating two objects of Account
        public Account checking = new Account();
        public Account savings = new Account();

        public void deposit(double amount, String aName){
            checking.add();
        }
        public void withdraw(double amount, String aName){
            savings.witdraw();
        }
        public void transfer(double amount, String aName){
            if (checking.accountName == aName || amount >= 0 ){
                checking.balance = checking.balance - amount;
                Console.WriteLine("Congradulations, Transfer success! You current checking blance is:" + checking.balance);
                savings.balance = savings.balance  + amount;
                Console.WriteLine("Congradulations, Transfer success! You current saving blance is: " + savings.balance);
            }
        }
        public double printBalances(double sb, double cb){       
            return cb + sb;
        }  
    }
}
