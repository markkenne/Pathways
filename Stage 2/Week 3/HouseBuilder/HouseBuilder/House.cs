using System;

namespace HouseBuilder
{
    public class House // Parent class
    {
        private IComponent[] components;

        public House(IComponent[] components)
        {
            this.components = components;
        }

        public double GetTotalCost() // using array total the costs of each component
        {
            var totalCost = 0.0;
            for (var i = 0; i < components.Length; i++)
            {
                totalCost += components[i].GetCost();
            }
            return totalCost;
        }
    }
}

