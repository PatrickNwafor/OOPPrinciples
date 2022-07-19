using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples
{
    public class Lion : Felidae, Reproducible<Lion>
    {
        private int weight;
        // Keyword "base" will be explained in the next paragraph
        public Lion(bool male, int weight) 
            : base(male)
        {
            // Compiler error – base.male is not visible in Lion
            // base.male = male;
            this.weight = weight;
        }
        public int Weight
        {
            get { return weight; }
            set { this.weight = value; }
        }

        private Paw frontLeft;
        private Paw frontRight;
        private Paw bottomLeft;
        private Paw bottomRight;

        private void MovePaw(Paw paw)
        {
            // …
        }

        public override void Walk()
        {
            this.MovePaw(frontLeft);
            this.MovePaw(frontRight);
            this.MovePaw(bottomLeft);
            this.MovePaw(bottomRight);
        }

        public Lion[] Reproduce(Lion mate)
        {
            return new Lion[] { new Lion(true, 12), new Lion(false, 10) };
        }

        protected void Ambush()
        {
            // …
        }

        public override bool CatchPrey(object prey)
        {
            base.Hide();
            this.Ambush();
            base.Run();
            Console.WriteLine("Lion.CatchPrey");
            // …
            return false;
        }
    }
}
