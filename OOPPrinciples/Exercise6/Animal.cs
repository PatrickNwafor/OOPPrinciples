using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples.Exercise6
{
    internal class Animal
    {
        private string name;
        private int age;
        private Gender gender;

        public string Name { get { return name; } } 
        public int Age { get { return age; } }
        public Gender Gender { get { return gender; } } 

        public Animal(string name, int age, Gender gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }   

        public virtual string MakeSound()
        {
            return "Animal sound";
        }
    }
}
