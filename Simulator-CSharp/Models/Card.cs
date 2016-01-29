using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM.Models
{
    public class Card
    {

        public string Number { get; set; }
        public string Password { get; set; }

        public string Bank { get; set; }

        public System.DateTime Exp { get; set; }

        public bool Locked { get; set; }

        public bool IsExpired()
        {
            return Exp.Date.Subtract(DateTime.Now.Date).Days <= 0;
        }

        public string Account1 { get; set; }
        public string Account2 { get; set; }

    }
}
