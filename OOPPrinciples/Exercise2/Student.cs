using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples.Exercise2
{
    internal class Student: Human
    {
        private double mark;

        public double Mark { get { return mark; } set { mark = value; } }

        public Student(string firstName, string lastName, double mark)
            : base(firstName, lastName)
        {
            this.mark = mark;
        }
    }
}
