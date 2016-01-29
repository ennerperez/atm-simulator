using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM.Models
{
    public class Box
    {

        public Box()
        {
        }

        public Box(double value, int amount)
        {
            Value = value;
            Amount = amount;
        }

        public double Value { get; set; }

        public int Amount { get; set; }

        public double SubTotal
        {
            get
            {
                return Value * Amount;
            }
            private set { }
        }

    }
}
