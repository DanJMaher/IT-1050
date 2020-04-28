using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam
{
    class Passenger
    {
        private string Name;
        private double Weight;

        public Passenger(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string GetName()
        {
            return Name;
        }

        public double GetWeight()
        {
            return Weight;
        }
    }
}
