using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples.Exercise
{
    internal class Course
    {
        private string name;
        private int countOfClasses;
        private int countOfExercises;

        public Course(string name, int countOfClasses, int countOfExercises)
        {
            this.name = name;
            this.countOfClasses = countOfClasses;
            this.countOfExercises = countOfExercises;
        }

        public string Name { get { return name; } }
        public int CountOfClasses { get { return countOfClasses; } }
        public int CountOfExercise { get { return this.countOfExercises; } }
    }
}
