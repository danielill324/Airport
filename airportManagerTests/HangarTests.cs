using Microsoft.VisualStudio.TestTools.UnitTesting;
using airportManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airportManager.Tests
{
    [TestClass()]
    public class HangarTests
    { 
        [TestMethod()]
        public void isFullTest()
        {
            //assert 
            Hangar hangar = new Hangar(4);
            hangar.addPlane(new Plane(2));
            bool actualval = hangar.isFull();
            //Assert
            Assert.IsFalse(actualval);
        }

        [TestMethod()]
        public void isFullTest2()
        {
            //assert 
            Hangar hangar = new Hangar(4);
            hangar.addPlane(new Plane(4));
            bool actualval = hangar.isFull();
            //Assert
            Assert.IsTrue(actualval);
        }
        [TestMethod()]
        public void hangar_total_place()
        {
            //arrange
            Hangar hangarTest = new Hangar(4);
            hangarTest.addPlane(new Plane(2));
            int actualval = hangarTest.place_sum();

            //act
            int expected = 2;
            Assert.AreEqual(expected, actualval);
        }
        [TestMethod()]
        public void addPlaneTest()
        {
            //arrange
            Hangar hangarTest = new Hangar(1);
            Plane p = new Plane(4);
            bool actualval = hangarTest.addPlane(p);
            //assert
            Assert.IsFalse(actualval);
        }
        public void addPlaneTest2()
        {
            //arrange
            Hangar hangarTest = new Hangar(4);
            Plane p = new Plane(1);
            bool actualval = hangarTest.addPlane(p);
            //assert
            Assert.IsTrue(actualval);
        }
        [TestMethod()]
        public void find_planeTest()
        {
            //arrange
            Plane p = new Plane(1);
            Hangar hangarTest = new Hangar(2);
            bool actualVal = hangarTest.find_plane(p);
            //assert
            Assert.IsFalse(actualVal);
        }

        [TestMethod()]
        public void find_planeTest2()
        {
            //arrange
            Plane p = new Plane(1);
            Hangar hangarTest = new Hangar(2);
            bool actualVal = hangarTest.find_plane(p);
            //assert
            Assert.IsFalse(actualVal);
        }
        [TestMethod()]
        public void remove_planeTest()
        {
            //arrange
            Plane p = new Plane(2);
            Hangar hangarTest = new Hangar(2);
            bool actualVal = hangarTest.remove_plane(p);

            //act


            //assert
            Assert.IsFalse(actualVal);
        }
        public void remove_planeTest2()
        {
            //arrange
            Plane p = new Plane(2);
            Hangar hangarTest = new Hangar(2);
            hangarTest.addPlane(p);
            bool actualVal = hangarTest.remove_plane(p);

            //act


            //assert
            Assert.IsTrue(actualVal);
        }

    }
}