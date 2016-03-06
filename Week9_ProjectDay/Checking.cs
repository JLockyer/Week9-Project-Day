using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week9_ProjectDay
{
    class Checking : Account
    {
        private double check;
        private string filename = "Checking.txt";

        public double Check { get; set; }
        public string Filename { get; set; }

        public Checking()
        {
            Check = check;
            Filename = filename;
        }
    }
}
