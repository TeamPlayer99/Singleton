using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonApp.Lib
{
    public sealed class CashRegister
    {
        private static int register = 0;
        private static CashRegister instance;
        public static CashRegister GetCashRegister()
        {
            if(instance == null)
                instance = new CashRegister();
            return instance;
        }

        public void Deposit(int amount)
        {
            register += amount;
        }

        public void Withdraw(int amout)
        {
            if(register >= amout)
            {
                register -= amout;
            }
            else { Console.WriteLine("Insufficent Credit"); }
                
        }

        public int PrintRegister()
        {
            return register;
        }
    }
}
