using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples.Exercise
{
    internal class School
    {
        private Class @class;

        public Class Class { get { return @class; } }

        public School(Class @class)
        {
            this.@class = @class;
        }
    }
}
