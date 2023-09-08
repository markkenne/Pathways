using System;

namespace HouseBuilder
{
    public class Floor : IComponent
    {
        private int number = 1;
        private double cost = 10200;

        public Floor()  //default constructor
        {
        }

        public Floor(int number, double cost) 
        {
            this.number = number;
            this.cost = cost;
        }

        public int GetNumber()
        {
            return number;
        }

        public double GetCost()
        {
            return cost * number;
        }
    }
}
