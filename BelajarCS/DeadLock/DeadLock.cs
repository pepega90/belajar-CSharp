using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BelajarCS.DeadLock
{
    class DeadLock
    {
        static void Main()
        {
            Console.WriteLine("Main thread started");
            Account akunA = new Account(101, 5000);
            Account akunB = new Account(102, 3000);

            AccountManager akunManagerA = new AccountManager(akunA, akunB, 1000);
            Thread t1 = new Thread(akunManagerA.Transfer);
            t1.Name = "T1";

            AccountManager akunManagerB = new AccountManager(akunB, akunA, 2000);
            Thread t2 = new Thread(akunManagerB.Transfer);
            t2.Name = "T2";

            t1.Start();
            t2.Start();
            
            t1.Join();
            t2.Join();

            Console.WriteLine("Main thread completed");
        }
    }

    public class AccountManager
    {
        Account _fromAccount;
        Account _toAccount;
        double _amountTransfer;

        public AccountManager(Account from, Account to, double amountTransfer)
        {
            this._fromAccount = from;
            this._toAccount = to;
            this._amountTransfer = amountTransfer;
        }

        public void Transfer()
        {
            /* Part 96, resolve deadlock. program dibawah akan menyebabkan deadlock karena masing-masing thread berusaha untuk lock ke sumber yang berbeda sedangkan mereka sudah melakukan lock ke sumber lain sebelumnya
             * ada beberapa cara untuk menghindari dan menyelesaikan deadlock
             * 1. memperoleh lock dalam urutan tertentu yang ditentukan
             * 2. menggunakan Mutex Class
             * 3. menggunakan Monitor.TryEnter() method
             */

            object _lock1, _lock2;

            if(_fromAccount.ID < _toAccount.ID)
            {
                _lock1 = _fromAccount;
                _lock2 = _toAccount;
            }
            else
            {
                _lock1 = _toAccount;
                _lock2 = _fromAccount;
            }

            Console.WriteLine(Thread.CurrentThread.Name + " trying to acquire lock on " + ((Account)_lock1).ID.ToString());
            lock (_lock1)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " acquired lock on " + ((Account)_lock1).ID.ToString());
                Console.WriteLine(Thread.CurrentThread.Name + " suspended for 1 second");
                Thread.Sleep(1000);
                Console.WriteLine(Thread.CurrentThread.Name + " back in action and trying to acquire lock on " + ((Account)_lock2).ID.ToString());
                lock (_lock2)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " acquired lock on " + ((Account)_lock2).ID.ToString());
                    _fromAccount.WithDraw(_amountTransfer);
                    _toAccount.Deposit(_amountTransfer);
                    Console.WriteLine($"{Thread.CurrentThread.Name} transfered {_amountTransfer.ToString()} from {_fromAccount.ID.ToString()} to {_toAccount.ID.ToString()}");
                }
            }

            //Console.WriteLine(Thread.CurrentThread.Name + " trying to acquire lock on " + _fromAccount.ID.ToString());
            //lock (_fromAccount)
            //{ 
            //    Console.WriteLine(Thread.CurrentThread.Name + " acquired lock on " + _fromAccount.ID.ToString());
            //    Console.WriteLine(Thread.CurrentThread.Name + " suspended for 1 second");
            //    Thread.Sleep(1000);
            //    Console.WriteLine(Thread.CurrentThread.Name + " back in action and trying to acquire lock on " + _toAccount.ID.ToString());
            //    lock (_toAccount)
            //    {
            //        Console.WriteLine("this code will not be executed");
            //        _fromAccount.WithDraw(_amountTransfer);
            //        _toAccount.Deposit(_amountTransfer);
            //    }
            //}
        }
    }

    public class Account
    {
        double _balance;
        int id;

        public Account(int id, double balance)
        {
            this.id = id;
            this._balance = balance;
        }

        public int ID
        {
            get { return id; }
        }

        public void WithDraw(double amount)
        {
            _balance -= amount;
        }

        public void Deposit(double amount)
        {
            _balance += amount;
        }
    }
}
