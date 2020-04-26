using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_task2
{
    class Account
    {
        public double balance;
        public String accountName;

        //Property 
        public double interestRate = 0.06;

        public double Balance {
            get { return balance;}
            set {
                if (value >= 0)
                    balance = value;
                else
                    balance = 0;
            }
        }


        
        //default constructor
        public Account(){}


        //constructor
        public Account( double bl , String name){
            this.balance = bl;
            this.accountName = name;
        }

        //methods
        public String getAccoutName(){ return accountName;}
        public double add(){return balance;}
        
        public double witdraw(){return balance;}

        public double interestCount(){ return balance;}

        public double getCurrentBalance(){
            return balance;
        }
        public void SetBalance(double value){
            if (value >= 0)
                balance = value;
        }
    }
}
