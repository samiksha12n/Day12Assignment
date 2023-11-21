using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount transaction1 = new BankAccount(582457824975,"Sam",0);
            transaction1.Deposite();
            Console.WriteLine("----------------Withdraw Method------------");
            Console.WriteLine("\n");
            transaction1.Withdraw();
            Console.ReadKey();

        }
    }
}
