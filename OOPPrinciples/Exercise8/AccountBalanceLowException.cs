using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples.Exercise8
{
    internal class AccountBalanceLowException: Exception
    {
        public AccountBalanceLowException(string message)
            : base(message, new ArgumentOutOfRangeException())
        {
        }
    }
}
