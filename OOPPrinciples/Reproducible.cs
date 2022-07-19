using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples
{
    internal interface Reproducible<T> where T : Felidae
    {
        T[] Reproduce(T mate);
    }
}
