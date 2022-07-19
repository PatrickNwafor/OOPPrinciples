using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples.Exercise2
{
    internal class Worker: Human, IComparable<Worker>
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

        public int CompareTo(Worker? other)
        {
            if (this.CalculateHourlyWage() == other.CalculateHourlyWage())
            {
                return 0;
            }
            else if (this.CalculateHourlyWage() < other.CalculateHourlyWage())
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

        public override string? ToString()
        {
            return String.Format("First name: {0}, Last Name: {1}, Hourly Wage: {2:C2}", base.FirstName, base.LastName, this.CalculateHourlyWage());
        }
    }
}
