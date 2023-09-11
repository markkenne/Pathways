using Microsoft.VisualStudio.TestTools.UnitTesting;
using HouseBuilder;
//using System;



namespace HouseBuilder.Tests
{
    [TestClass]
    public class DoorTests
    {
        [TestMethod]
        public void GetCost_ShouldReturnCorrectCost()
        {
            // Arrange
            Door door = new Door(2, 200);

            // Act
            double cost = door.GetCost();

            // Assert
            Assert.AreEqual(400, cost);
        }
    }
}