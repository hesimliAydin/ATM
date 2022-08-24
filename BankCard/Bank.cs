using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCard
{

    public class Bank
    {
        public Client[] Clients { get; set; }
        public string Name { get; set; }

        public void Expense(double money, string pin)
        {
            var client = CheckPin(pin);
            if (client != null)
            {
                if (client.Bankcard.Balance<money)
                    throw new  ArgumentException ("There is not enough money");
                else
                {
                    client.Bankcard.Balance -= money;
                }
            }
        }

        public void Income(double money,string pin)
        {
            var client = CheckPin(pin);
            if (client != null)
            {
                client.Bankcard.Balancee += money;
            }
        }
        public Client CheckPin(string pin)
        {
            foreach (var client in Clients)
            {
                if (client.Bankcard.PIN == pin)
                    return client;
            }
            return null;
        }

        public bool CardToCard(string pan)
        {
            foreach (var client in Clients)
            {
                if (client.Bankcard.PAN == pan)
                    return true;
            }
            Console.WriteLine("PAN is wrong");
            return false;
        }
    }
}
