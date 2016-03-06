using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week9_ProjectDay
{
    class Savings : Account
    {
        private double saving;
        private string filename = "Savings.txt";

        public double Saving { get; set; }
        public string FileName { get; set; }

        public Savings()
        {
            Saving = saving;
            FileName = filename;
        }
    }
}
