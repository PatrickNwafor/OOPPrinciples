using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples.Exercise8
{
    internal class Bank
    {
        public List<IAccount> Accounts { get; }

        public Bank()
        {
            Accounts = new List<IAccount>();
        }   

        public void CreateAccount(IAccount account)
        {
            Accounts.Add(account);
        }
    }
}
