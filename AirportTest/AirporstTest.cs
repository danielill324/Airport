using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using airportManager;

namespace AirportTest
{
    [TestClass]
    public class AirporstTest
    {
        [TestMethod]
        public void find_place()//check if the method return true when there is place for plane
        {
            //arrange
            Manager managerTest = new Manager();
            bool actualVal = managerTest.find_place(new Plane(1));

            //act
            bool expected = true;

            //assert
            Assert.AreEqual(expected, actualVal);
            
        }
        [TestMethod]
        public void getPlaneById()//check if there isnt such id in the list of planes returns null
        {
            //arrange
            Manager managerTest = new Manager();
            Plane actualVal = managerTest.getPlaneById("plane id");

            //act
            Plane expected = null;

            //assert
            Assert.IsNull(expected);

        }
        [TestMethod]
        public void getPlaneById2()//check if the rigth object returns by his given id
        {
            //arrange
            Manager managerTest = new Manager();
            Plane plane = new Plane(1);
            managerTest.planeList.Add(plane);
            Plane actualVal = managerTest.getPlaneById(plane.id);

            //act
            Plane expected = plane ;

            //assert
            Assert.ReferenceEquals(expected,actualVal);

        }
        [TestMethod]
        public void removePlane()//check if the rigth object returns by his given id
        {
            //arrange
            Manager managerTest = new Manager();
            
            bool actualVal = managerTest.removePlane("id");

            //act
            

            //assert
            Assert.IsFalse(actualVal);

        }
        [TestMethod]
        public void removePlane2()//check if the rigth object returns by his given id
        {
            //arrange
            Manager managerTest = new Manager();
            Plane p = new Plane(2);
            managerTest.find_place(p);
            managerTest.planeList.Add(p);
            bool actualVal = managerTest.removePlane(p.id);

            //act


            //assert
            Assert.IsTrue(actualVal);

        }
        [TestMethod]
        public void remove_plane()//check if the rigth object returns by his given id
        {
            //arrange
            Manager managerTest = new Manager();
            Plane p = new Plane(2);
            managerTest.find_place(p);
            managerTest.planeList.Add(p);
            bool actualVal = managerTest.remove_plane(p);

            //act


            //assert
            Assert.IsTrue(actualVal);

        }
        public void remove_plane2()//check if the rigth object returns by his given id
        {
            //arrange
            Manager managerTest = new Manager();

            bool actualVal = managerTest.remove_plane(new Plane(2));

            //act


            //assert
            Assert.IsFalse(actualVal);

        }
    }
}
