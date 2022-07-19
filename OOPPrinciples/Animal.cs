﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples
{
    public abstract class Animal
    {
        public void PrintInformation()
        {
            Console.WriteLine("I am a {0}.", this.GetType().Name);
            Console.WriteLine(GetTypicalSound());
        }

        protected abstract String GetTypicalSound();
    }
}
