using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week9_ProjectDay
{
    class Account
    {
        // Fields
        private double balance;
        private double newBal;
        private double putIN;
        private double takeOut;

        // Properties
        public double Balance { get; set; }
        public double NewAccBal { get; set; }
        public double Deposited { get; set; }
        public double Withdrew { get; set; }

        // Constructor
        public Account()
        {
            Balance = balance;
            NewAccBal = newBal;
            Deposited = putIN;
            Withdrew = takeOut;
        }

        public void AccountsDeposit(Checking CA, Reserve RA, Savings SA, Clients client, Account account)
        {
            List<string> choose = new List<string>() { "\n\t 1. Checking", "\n\t 2. Reserve", "\n\t 3. Savings" };
            Console.WriteLine("Choose which account you would like to deposit to: ");
            foreach (string option in choose)
            {
                Console.WriteLine(option);
            }
            string decide = Console.ReadLine().ToLower();
            switch (decide)
            {
                case "1":
                case "checking":
                    Console.Clear();
                    Console.WriteLine("*****Checking Account*****");
                    DepositCheck(CA, client);
                    Program.Menu(client, account, CA, RA, SA);
                    break;
                case "2":
                case "reserve":
                    Console.Clear();
                    Console.WriteLine("*****Reserve Account*****");
                    DepositReserve(RA, client);
                    Program.Menu(client, account, CA, RA, SA);
                    break;
                case "3":
                case "savings":
                    Console.Clear();
                    Console.WriteLine("*****Savings Account*****");
                    DepositSavings(SA, client);
                    Program.Menu(client, account, CA, RA, SA);
                    break;
                default:
                    Console.Clear();
                    AccountsDeposit(CA, RA, SA, client, account);
                    Program.Menu(client, account, CA, RA, SA);
                    break;
            }
        }

        //Methods
        public void DepositCheck(Checking CA, Clients client)
        {
            Clients file = new Clients();
            Console.WriteLine("Enter amount to deposit: ");
            Deposited = double.Parse(Console.ReadLine());
            CA.Check = CA.Check + Deposited;
            Console.WriteLine("Current Balance: " + CA.Check);

            StreamWriter write = new StreamWriter(CA.Filename, true);
            StringBuilder depo = new StringBuilder();
            string now1 = DateTime.Now.ToString();
            using (write)
            {
                write.WriteLine(client.ClientInfo());
                write.WriteLine();
                write.Write(now1);
                write.Write("\t+");
                write.Write("\t$");
                write.Write(Deposited);
                write.Write("\t$");
                write.Write(CA.Check);
                write.WriteLine();
            }
        }

        public void DepositReserve(Reserve RA, Clients client)
        {
            Clients file = new Clients();
            Console.WriteLine("Enter amount to deposit: ");
            Deposited = double.Parse(Console.ReadLine());
            RA.Reserving = RA.Reserving + Deposited;
            Console.WriteLine("Current Balance: " + RA.Reserving);

            StreamWriter write = new StreamWriter(RA.FileName, true);
            StringBuilder depo = new StringBuilder();
            string now1 = DateTime.Now.ToString();
            using (write)
            {
                write.WriteLine(client.ClientInfo());
                write.WriteLine();
                write.Write(now1);
                write.Write("\t+");
                write.Write("\t$");
                write.Write(Deposited);
                write.Write("\t$");
                write.Write(RA.Reserving);
                write.WriteLine();
            }
        }

        public void DepositSavings(Savings SA, Clients client)
        {
            Clients file = new Clients();
            Console.WriteLine("Enter amount to deposit: ");
            Deposited = double.Parse(Console.ReadLine());
            SA.Saving = SA.Saving + Deposited;
            Console.WriteLine("Current Balance: " + SA.Saving);

            StreamWriter write = new StreamWriter(SA.FileName, true);
            StringBuilder depo = new StringBuilder();
            string now1 = DateTime.Now.ToString();
            using (write)
            {
                write.WriteLine(client.ClientInfo());
                write.WriteLine();
                write.Write(now1);
                write.Write("\t+");
                write.Write("\t$");
                write.Write(Deposited);
                write.Write("\t$");
                write.Write(SA.Saving);
                write.WriteLine();
            }
        }

        public void AccountsWithdraw(Checking CA, Reserve RA, Savings SA, Clients client, Account account)
        {
            List<string> choose = new List<string>() { "\n\t 1. Checking", "\n\t 2. Reserve", "\n\t 3. Savings" };
            Console.WriteLine("Choose which account you would like to withdraw from: ");
            foreach(string option in choose)
            {
                Console.WriteLine(option);
            }
            string decide = Console.ReadLine().ToLower();
            switch (decide)
            {
                case "1":
                case "checking":
                    Console.Clear();
                    Console.WriteLine("*****Checking Account*****");
                    WithdrawCheck(CA);
                    Program.Menu(client, account, CA, RA, SA);
                    break;
                case "2":
                case "reserve":
                    Console.Clear();
                    Console.WriteLine("*****Reserve Account*****");
                    WithdrawReserve(RA);
                    Program.Menu(client, account, CA, RA, SA);
                    break;
                case "3":
                case "savings":
                    Console.Clear();
                    Console.WriteLine("*****Savings Account*****");
                    WithdrawSaving(SA);
                    Program.Menu(client, account, CA, RA, SA);
                    break;
                default:
                    Console.Clear();
                    AccountsWithdraw(CA, RA, SA, client, account);
                    Program.Menu(client, account, CA, RA, SA);
                    break;
            }
        }

        public void WithdrawCheck(Checking CA)
        {
            Clients file = new Clients();
            Console.WriteLine("Enter amount to withdraw: ");
            Withdrew = double.Parse(Console.ReadLine());
            CA.Check = CA.Check - Withdrew;
            Console.WriteLine("Current Balance: " + CA.Check);

            StreamWriter write = new StreamWriter(CA.Filename, true);
            StringBuilder with = new StringBuilder();
            string now = DateTime.Now.ToString();
            using (write)
            {
                write.Write(now);
                write.Write("\t-");
                write.Write("\t$");
                write.Write(Withdrew);
                write.Write("\t$");
                write.Write(CA.Check);
            }
        }

        public void WithdrawReserve(Reserve RA)
        {
            Clients file = new Clients();
            Console.WriteLine("Enter amount to withdraw: ");
            Withdrew = double.Parse(Console.ReadLine());
            RA.Reserving = RA.Reserving - Withdrew;
            Console.WriteLine("Current Balance: " + RA.Reserving);

            StreamWriter write = new StreamWriter(RA.FileName, true);
            StringBuilder with = new StringBuilder();
            string now = DateTime.Now.ToString();
            using (write)
            {
                write.Write(now);
                write.Write("\t-");
                write.Write("\t$");
                write.Write(Withdrew);
                write.Write("\t$");
                write.Write(RA.Reserving);
            }
        }

        public void WithdrawSaving(Savings SA)
        {
            Clients file = new Clients();
            Console.WriteLine("Enter amount to withdraw: ");
            Withdrew = double.Parse(Console.ReadLine());
            SA.Saving = SA.Saving - Withdrew;
            Console.WriteLine("Current Balance: " + SA.Saving);

            StreamWriter write = new StreamWriter(SA.FileName, true);
            StringBuilder with = new StringBuilder();
            string now = DateTime.Now.ToString();
            using (write)
            {
                write.Write(now);
                write.Write("\t-");
                write.Write("\t$");
                write.Write(Withdrew);
                write.Write("\t$");
                write.Write(SA.Saving);
            }
        }
        public void AccountBal(Clients client, Account account, Checking CA, Reserve RA, Savings SA)
        {
            List<string> choose = new List<string>() { "\n\t 1. Checking", "\n\t 2. Reserve", "\n\t 3. Savings" };
            Console.WriteLine("Choose which account you would like to view: ");
            foreach(string option in choose)
            {
                Console.WriteLine(option);
            }
            string decide = Console.ReadLine().ToLower();
            switch (decide)
            {
                case "1":
                case "checking":
                    Console.Clear();
                    Console.WriteLine("*****Checking Account*****");
                    Console.WriteLine("Acount Balance: $" + CA.Check);
                    Program.Menu(client, account, CA, RA, SA);
                    break;
                case "2":
                case "reserve":
                    Console.Clear();
                    Console.WriteLine("*****Reserve Account*****");
                    Console.WriteLine("Acount Balance: $" + RA.Reserving);
                    Program.Menu(client, account, CA, RA, SA);
                    break;
                case "3":
                case "savings":
                    Console.Clear();
                    Console.WriteLine("*****Savings Account*****");
                    Console.WriteLine("Acount Balance: $" + SA.Saving);
                    Program.Menu(client, account, CA, RA, SA);
                    break;
                default:
                    Console.Clear();
                    AccountBal(client, account, CA, RA, SA);
                    Program.Menu(client, account, CA, RA, SA);
                    break;
            }
            Console.WriteLine("Acount Balance: $" + Balance);
        }
    }
}
