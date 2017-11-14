using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using airportManager;

namespace AirportTest
{
    [TestClass]
    public class AirporstTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            Manager managerTest = new Manager();
            bool actualVal = managerTest.find_place(new Plane(1));

            //act
            bool expected = true;

            //assert
            Assert.AreEqual(expected, actualVal);
            
        }

    }
}
