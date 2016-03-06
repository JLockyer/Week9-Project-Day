using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week9_ProjectDay
{
    class Clients
    {
        //Fields
        private string name = "Bob Jones";
        private int accountNum = AccountGen();
        List<string> writer = new List<string> { };

        //Constructors
        public Clients()
        {
            Name = name;
            AccountNum = accountNum;
            Writer = writer;
        }

        // Properties
        public string Name { get; set; }
        public int AccountNum { get; set; }
        public List<string> Writer { get; set; }

        public static int AccountGen()
        {
            Random rand = new Random();
            int randAcc = rand.Next(100000000, 1000000000);
            return randAcc;
        }
        //Methods
        public string ClientInfo()
        {
            StringBuilder info = new StringBuilder();
            {
                info.Append("Account Name: ");
                info.Append(this.name);
                info.AppendLine();
                info.Append("Account Number: ");
                info.Append(this.accountNum);
            }
            Console.WriteLine(info);
            return info.ToString();
        }
    }
}
