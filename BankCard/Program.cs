using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCard
{
    public class Program
    {
        static void Main()
        {
            var kapital = new Bank()
            {
                Name = "Kapital",
                Clients = new Client[]
                {
                    new Client
                    {
                        Id = 1,
                        Name = "Aydin",
                        Surname = "Hesimli",
                        Age = 18,
                        Salary = 2500,
                        Bankcard = new BankCard
                        {
                           BankName = "Kapital Bank",
                           PAN = "2345679876543256",
                           PIN = "1234",
                           CVC = "456",
                           Balance=1000,
                           ExpiredDate = new DateTime(2025, 12, 7)
                        }
                    },
                    new Client
                    {
                         Id = 2,
                         Name = "Omer",
                         Surname = "Cavansirli",
                         Age = 27,
                         Salary = 2500,
                         Bankcard = new BankCard
                         {
                             BankName = "Kapital Bank",
                             PAN = "1234567890123456",
                             PIN = "6574",
                             CVC = "354",
                             Balance=1500,
                             ExpiredDate = new DateTime(2025, 10, 10)
                         }
                    },
                    new Client
                    {
                        Id=3,
                        Name="Kamran",
                        Surname="Kerimzade",
                        Age=24,
                        Salary=2500,
                        Bankcard=new BankCard
                        {
                            BankName="Kapital Bank",
                            PAN="1234567809876369",
                            PIN="8976",
                            CVC="678",
                            Balance=800,
                            ExpiredDate=new DateTime(2025,11,27)
                        }

                    }
                }
            };

            Console.Write("Enter Pin: ");
            string pin = Console.ReadLine();
            var client = kapital.CheckPin(pin);
            if (client!=null)
            {
                Console.Clear();
                while (true)
                {
                    Console.WriteLine("\n[1] Balance");
                    Console.WriteLine("[2] İncome"); //medaxil
                    Console.WriteLine("[3] Expense"); // mexaric
                    Console.WriteLine("[4] Card to Card");
                    Console.WriteLine("[5] Exit");
                    
                    Console.Write("\t\nEnter choice: ");
                    int choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                    { 
                        Console.Clear();
                        Console.WriteLine(client.Bankcard.Balance + "AZN");
                        
                    }
                    else if (choice == 2)
                    {
                        Console.Clear();
                        Console.Write("\tEnter Money: ");
                        double money = double.Parse(Console.ReadLine());
                        kapital.Income(money, pin);
                    }
                    else if (choice == 3)
                    {
                        Console.Clear();
                        Console.Write("\tEnter Money: ");
                        int money = int.Parse(Console.ReadLine());
                        kapital.Expense(money, pin);
                    }
                }
            }
        }
    }
}
