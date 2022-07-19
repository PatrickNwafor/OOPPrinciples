using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples
{
    public class Cat : Animal
    {
        protected override String GetTypicalSound()
        {
            return "Meoooow!";
        }
    }
}
