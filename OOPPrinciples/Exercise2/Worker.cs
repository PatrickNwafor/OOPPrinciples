using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples.Exercise2
{
    internal class Worker: Human
    {
        public double Wages { get; set; }
        public double HoursWorked { get; set; }

        public Worker(string firstName, string lastName, double wages, double hoursWorked)
            : base(firstName, lastName)
        {
            this.Wages = wages;
            this.HoursWorked = hoursWorked;
        }

        public double CalculateHourlyWage()
        {
            return Wages / HoursWorked;
        }
    }
}
