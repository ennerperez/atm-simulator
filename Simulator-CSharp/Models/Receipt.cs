using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM.Models
{
    public class Receipt
    {

        public string Bank { get; set; }

        public string ATM { get; set; }

        public string Code { get; set; }

        public string Card { get; set; }

        public string Operation { get; set; }

        public string Account { get; set; }

        public DateTime Date { get; set; }

        public string Detail { get; set; }


    }
}
