using System;

namespace HomeBuilder
{
    public class Wall : IComponents
    {
        private int number = 12;
        private double cost = 1000;

        public Wall()
        {
        }

        public Wall(int number, double cost)
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