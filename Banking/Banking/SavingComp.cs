using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class SavingComp
    {

        private Account account = new();

        public int AccountNo 
        { 
            get {return account.AccountNo; } 
            set {account.AccountNo = value;}

        }
        public decimal Balance
        {
            get { return account.Balance; }
            set {account.Balance = value;}
        }
        public bool Deposit(decimal Amount)
        {
            Balance += Amount;
            return true;
        }
    }
}
