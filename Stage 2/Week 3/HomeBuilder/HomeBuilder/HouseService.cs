using System;
using System.ComponentModel;

namespace HomeBuilder
{
    public class HouseService
    {
        private IComponents[] components;

        public HouseService(IComponents[] components)
        {
            this.components = components;
        }

        public double GetTotalCost() // using array total the costs of each component
        {
            var totalCost = 0.0;
            for (var i = 0; i < components.Length; i++)
            {
                totalCost += components[i].GetCost();  // add individual component costs to total Cost
            }
            return totalCost;
        }
    }
}
