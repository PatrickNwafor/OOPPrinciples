using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples
{
    public class AfricanLion : Lion
    {
        // …
        // If we comment out the ": base(male, weight)" line
        // the class will not compile. Try it.
        public AfricanLion(bool male, int weight)
            : base(male, weight)
        { }

        public new string ToString()
        {
            return string.Format("(AfricanLion, male: {0}, weight: {1})", this.Male, this.Weight);
        }
        // …

        public override bool CatchPrey(object prey)
        {
            Console.WriteLine("AfricanLion.CatchPrey");
            Console.WriteLine("calling base.CatchPrey");
            Console.Write("\t");
            base.CatchPrey(prey);
            Console.WriteLine("...end of call."); 
            return false;
        }
    }
}
