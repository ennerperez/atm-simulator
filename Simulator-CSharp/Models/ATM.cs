using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM.Models
{
    public class ATM
    {
                
        public TimeSpan Alive { get; set; }
        public TimeSpan StandBy { get; set; }

        public String Bank { get; set; }
        public String Code { get; set; }

        public List<Box> Boxes { get; set; }

        public int Receipts { get; set; }

        public override string ToString()
        {
            return Bank + ": " + Code;
        }

    }
}
