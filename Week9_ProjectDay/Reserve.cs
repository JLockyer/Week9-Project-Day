using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week9_ProjectDay
{
    class Reserve : Account
    {
        private double reserve;
        private string filename = "Reserve.txt";

        public double Reserving { get; set; }
        public string FileName { get; set; }

        public Reserve()
        {
            Reserving = reserve;
            FileName = filename;
        }
    }
}
