using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples.Exercise
{
    internal class Class
    {
        private string uniqueTextIdentifier;
        private List<People> peoples;

        public string UniqueTextIdentifier { get { return uniqueTextIdentifier; } }
        public List<People> Peoples { get { return peoples; } set { peoples = value; } }

        public Class(string uniqueTextIdentifier, List<People> peoples)
        {
            this.uniqueTextIdentifier = uniqueTextIdentifier;
            this.peoples = peoples;
        }
    }
}
