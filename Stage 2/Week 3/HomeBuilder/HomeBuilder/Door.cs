using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace HomeBuilder
{
    public class Door : IComponents
    {
        private int number = 2;
        private double cost = 200;

        public Door()
        {
        }

        public Door(int number, double cost)
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