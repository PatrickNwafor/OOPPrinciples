using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples.Exercise2
{
    internal class Student: Human, IComparable<Student>
    {
        private double mark;

        public double Mark { get { return mark; } set { mark = value; } }

        public Student(string firstName, string lastName, double mark)
            : base(firstName, lastName)
        {
            this.mark = mark;
        }

        public int CompareTo(Student? other)
        {
            if(this.mark == other.mark)
            {
                return 0;
            }
            else if(this.mark < other.mark)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

        public override string? ToString()
        {
            return String.Format("First name: {0}, Last Name: {1}, Score: {2}", base.FirstName, base.LastName, Mark);
        }
    }
}
