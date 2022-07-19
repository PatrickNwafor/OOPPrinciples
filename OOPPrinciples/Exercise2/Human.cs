using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples.Exercise2
{
    internal class Human
    {
        private string firstName;
        private string lastName;

        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
