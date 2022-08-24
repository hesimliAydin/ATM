using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCard
{
    public class BankCard
    {
        public string BankName { get; set; }
        public string PAN { get; set; }
        public string PIN { get; set; }
        public string CVC { get; set; }
        public DateTime ExpiredDate { get; set; }
        


        public double Balance;
        public double Balancee
        {
            get { return Balance; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Error!!!");

                }

                Balance = value;
            }
        }
        


    }
}
