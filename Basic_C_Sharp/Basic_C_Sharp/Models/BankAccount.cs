using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_Sharp.Models
{
    public class BankAccount
    {
        public string Number { get; } //thuộc tính - property
        public string Owner { get; set; }
        public decimal Balance { get; }


        public BankAccount(string name, decimal initialBalance) //Constructor
        {
            this.Owner = name;
            this.Balance = initialBalance;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note) // phương thức - method
        {
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
        }
    }
}
