using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM.Models
{
    public class Client
    {

        public Client()
        {
            Accounts = new List<Account>();
            Cards = new List<Card>();
        }

        public string Name { get; set; }
        public string Identification { get; set; }

        public List<Account> Accounts { get; set; }

        public List<Card> Cards { get; set; }

        public override string ToString()
        {
            return this.Name + ";" + this.Identification;
        }

    }
}
