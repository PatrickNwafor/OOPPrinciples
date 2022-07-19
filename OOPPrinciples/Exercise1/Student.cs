using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples.Exercise
{
    internal class Student: People
    {
        private int uniqueNumber;

        public int UniqueNumber { get { return uniqueNumber; } } 

        public Student(int uniqueNumber, string name)
            : base(name)
        {
            this.uniqueNumber = uniqueNumber;
        }
    }
}
