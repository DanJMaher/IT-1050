using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam
{
    class Elevator
    {
        private double MaxWeight;
        private Passenger[] Occupants;

        public Elevator(int maxOccupants, double maxWeight)
        {
            Occupants = new Passenger[maxOccupants];

            MaxWeight = maxWeight;
        }

        public void AddOccupant(Passenger passenger, int index)
        {
            Occupants[index] = passenger;
        }

        public double GetCurrentWeight()
        {
            double currentWeight = 0;
            foreach (Passenger passenger in Occupants)
            {
                currentWeight += passenger.GetWeight();
            }

            return currentWeight;
        }

        public bool IsOverMaxCapacity()
        {
            if (GetCurrentWeight() > MaxWeight)
            {
                return true;
            }
            return false;
        }
    }
}
