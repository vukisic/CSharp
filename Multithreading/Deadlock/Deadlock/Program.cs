using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Deadlock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Started!");
            Account a1 = new Account(5000, 1);
            Account a2 = new Account(3000, 2);

            AccountManager am1 = new AccountManager(a1, a2, 1000);
            Thread t1 = new Thread(am1.Transfer);
            t1.Name = "T1";

            AccountManager am2 = new AccountManager(a2, a1, 2000);
            Thread t2 = new Thread(am2.Transfer);
            t2.Name = "T2";


            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();


            Console.WriteLine("Main Complited!");
            Console.WriteLine(a1.Balance);
            Console.WriteLine(a2.Balance);
            
        }
    }

    public class Account
    {
        private double _balance;
        private int _id;

        public double Balance { get => _balance; set => _balance = value; }
        public int Id { get => _id; set => _id = value; }

        public Account(double amount,int id)
        {
            _balance = amount;
            _id = id;
        }

       

        public void Withdraw(double amount)
        {
            _balance -= amount;
        }

        public void Deposite(double amount)
        {
            _balance += amount;
        }
    }

    public class AccountManager
    {
        Account _fromAccount;
        Account _toAccount;
        double _amount;
        public AccountManager(Account from,Account to,double amount)
        {
            _amount = amount;
            _fromAccount = from;
            _toAccount = to;
        }

        public void Transfer()
        {
            Mutex m = new Mutex(false);
            m.WaitOne();

            _fromAccount.Withdraw(_amount);
            _toAccount.Deposite(_amount);
           
            m.ReleaseMutex();
        }
    }
}
