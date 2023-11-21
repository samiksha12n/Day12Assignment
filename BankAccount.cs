using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12Assignment
{
    public class BankAccount
    {
        readonly long AccountNumber;
        public long AccountNumber1 { get { return AccountNumber; } }
        string AccountHolderName;
        double balance;
        public  BankAccount(long AccountNumber,string AccountHolderName,double balance)
        {
            Console.WriteLine("Bank Account Constructor");
            this.AccountNumber=AccountNumber;
            AccountHolderName = "not given";
            balance = 0.00;
            

        }

      

        public void Deposite()
        {
            double depAmt;
            Console.WriteLine("Enter the name of account holder");
            AccountHolderName = Console.ReadLine();
            Console.WriteLine("Enter the Amount you want to deposite in your Account");
            depAmt=double.Parse(Console.ReadLine());
            balance += depAmt;
            Console.WriteLine("Account Details");
            Console.WriteLine("Account Number: \t"+AccountNumber1);
            Console.WriteLine("Account Holder Name: \t"+AccountHolderName);
            Console.WriteLine("The balance After deposite: " + balance);
           
        }
        public void Withdraw()
        {
            double wAmt;
            Console.WriteLine("Enter the name of account holder");
            AccountHolderName=Console.ReadLine();
            Console.WriteLine("Enter the Amount you want to Withdraw from your Account");
            wAmt=double.Parse(Console.ReadLine());
            balance -= wAmt;
            Console.WriteLine("Account Number: \t"+AccountNumber1);
            Console.WriteLine("Account Holder Name: \t" + AccountHolderName);
            Console.WriteLine("The balance after withdraw: "+balance);
        }
    }
}
