﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples.Exercise
{
    internal class People
    {
        private string name;

        public People(string name)
        {
            this.name = name;
        }

        public string Name { get { return name; } set { name = value; } }
    }
}
