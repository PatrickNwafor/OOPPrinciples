using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples.Exercise6
{
    internal class Kitten : Animal
    {
        public Kitten(string name, int age, Gender gender) 
            : base(name, age, gender)
        {
        }

        public override string MakeSound()
        {
            return "Kitten Sound";
        }
    }
}
