﻿using System;

namespace HomeBuilder
{
    public class Window : IComponents
    {
        private int number = 5;
        private double cost = 500;

        public Window()
        {
        }

        public Window(int number, double cost)
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