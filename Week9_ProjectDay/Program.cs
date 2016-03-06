using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week9_ProjectDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Clients client = new Clients();
            Account account = new Account();
            Checking check = new Checking();
            Reserve reserve = new Reserve();
            Savings save = new Savings();

            Menu(client, account, check, reserve, save);
        }

        public static void Menu(Clients client, Account account, Checking check, Reserve reserve, Savings save)
        {
            List<string> Menu1 = new List<string>() { "\n\t1. Client Info", "\n\t2. View Account Balance", "\n\t3. Deposit", "\n\t4. Withdraw", "\n\t5. Exit" };
            List<string> Menu2 = new List<string>() { "\n\t1. Checking Account", "\n\t2. Reserve Account", "\n\t 3. Savings Account" };
            string[] menu = Menu1.ToArray();
            string[] menu2 = Menu2.ToArray();

            Console.WriteLine("********** Bank Account System **********");
            Console.WriteLine("*****Please choose one of the following \"Menu Items\"*****");
            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine("\t" + menu[i]);
            }

            string optionMenu = Console.ReadLine().ToLower();
            switch (optionMenu)
            {
                case "1":
                case "client info":
                    Console.Clear();
                    client.ClientInfo();
                    Menu(client, account, check, reserve, save);
                    break;
                case "2":
                case "view account balance":
                    Console.Clear();
                    Console.WriteLine("Choose an account to view: ");
                    account.AccountBal(client, account, check, reserve, save);
                    Menu(client, account, check, reserve, save);
                    break;
                case "3":
                case "deposit":
                    Console.Clear();
                    account.AccountsDeposit(check, reserve, save, client, account);
                    Menu(client, account, check, reserve, save);
                    break;
                case "4":
                case "withdraw":
                    Console.Clear();
                    account.AccountsWithdraw(check, reserve, save, client, account);
                    Menu(client, account, check, reserve, save);
                    break;
                case "5":
                case "exit":
                    Console.Clear();
                    Exit();
                    break;
                default:
                    Console.Clear();
                    Menu(client, account, check, reserve, save);
                    break;
            }
        }

        static void Exit()
        {
            Console.WriteLine("Thank you for banking with, MMM Bank. Have a wonderful day!");
            Console.ReadKey();
        }
        
    }
}
