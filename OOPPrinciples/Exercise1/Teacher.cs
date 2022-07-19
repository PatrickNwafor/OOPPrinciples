using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples.Exercise
{
    internal class Teacher: People
    {
        private List<Course> courses;

        public List<Course> Courses { get { return courses; } }

        public Teacher(List<Course> courses, string name)
            :base(name)
        {
            this.courses = courses;
        }

    }
}
