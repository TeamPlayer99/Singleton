using System;
using SingletonApp.Lib;

namespace SingletonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CashRegister a = new CashRegister();
            CashRegister b = new CashRegister();
            CashRegister c = new CashRegister();
            CashRegister d = new CashRegister();

            a.Deposit(100);
            Console.WriteLine(a.PrintRegister());

            b.Withdraw(20);
            Console.WriteLine(b.PrintRegister());

            c.Withdraw(30);
            Console.WriteLine(c.PrintRegister());

            d.Deposit(130);
            Console.WriteLine(d.PrintRegister());
        }
    }
}
