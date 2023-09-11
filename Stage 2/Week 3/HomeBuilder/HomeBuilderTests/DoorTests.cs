using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBuilder.Tests
{
    [TestClass()]
    public class DoorTests
    {
        [TestMethod()]
        public void Doors_GetCost_ShouldReturnCorrectCostifCountNotZero()
        {
            // Arrange - Go get variables, classes, functions etc 
            Door door = new Door(2, 200);
            double expected = 400;

            // Act - execute the function
            double cost = door.GetCost();

            // Assert
            Assert.AreEqual(expected, cost);
        }

        [TestMethod()]
        public void GetCost_ShouldReturnCorrectCostifZeroCount()
        {
            // Arrange - Go get variables, classes, functions etc 
            Door door = new Door(0, 200);
            double expected = 0;

            // Act - execute the function
            double cost = door.GetCost();

            // Assert
            Assert.AreEqual(expected, cost);
        }
        [TestMethod()]
        public void GetCost_ShouldReturnCorrectifDouble()
        {
            // Arrange - Go get variables, classes, functions etc 
            Door door = new Door(1, 200);

            // Act - execute the function
            double cost = door.GetCost();
            string numberString = cost.ToString();
            bool isInteger = int.TryParse(numberString, out int number);

            // Assert - whatever is returned is what you want
            Assert.AreEqual(200, cost);
        }



    }
}