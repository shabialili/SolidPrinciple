using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
    public class BankAccount
    {
        public BankAccount() { }
        public string AccountNumber { get; set; }
        public string AccountHolderNumber { get; set; }
        public decimal AccountBalance { get; set; }
    }
    public class InterestCalculate
    {
        public decimal CalculateInterest(BankAccount account)
        {
            return 2;
        }
    }
}
