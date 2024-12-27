using EjercicioElevador;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace EjercicioElevadorTest
{
    [TestClass]
    public class InButtonBoxTest
    {
        [TestMethod]
        public void TestButtonsOption()
        {
            var numberFloors = 5;

            InButtonBox inBB = new InButtonBox(1, Direction.Up, numberFloors);
            Assert.AreEqual(inBB.Floors.Length, numberFloors);
        }

        [TestMethod]
        public void TestOptionsFrom1()
        {
            var currentFloor = 1;
            var numberFloors = 5;
            InButtonBox inBB = new InButtonBox(currentFloor, Direction.Up, numberFloors);

            
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                inBB.ShowInPanel();

                var result = sw.ToString().Trim();

                Assert.AreEqual("---- Select destination floor ----\r\n---- Options ----\r\n------ 1 ------\r\n------ 2 ------\r\n------ 3 ------\r\n------ 4 ------\r\n------ 5 ------", result);
            }
        }

        [TestMethod]
        public void TestOptionsDown3()
        {
            var currentFloor = 3;
            var numberFloors = 5;
            InButtonBox inBB = new InButtonBox(currentFloor, Direction.Down, numberFloors);


            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                inBB.ShowInPanel();

                var result = sw.ToString().Trim();

                Assert.AreEqual("---- Select destination floor ----\r\n---- Options ----\r\n------ 3 ------\r\n------ 2 ------\r\n------ 1 ------", result);
            }
        }

        [TestMethod]
        public void TestOptionsDown5()
        {
            var currentFloor = 5;
            var numberFloors = 5;
            InButtonBox inBB = new InButtonBox(currentFloor, Direction.Down, numberFloors);


            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                inBB.ShowInPanel();

                var result = sw.ToString().Trim();

                Assert.AreEqual("---- Select destination floor ----\r\n---- Options ----\r\n------ 5 ------\r\n------ 4 ------\r\n------ 3 ------\r\n------ 2 ------\r\n------ 1 ------", result);
            }
        }


    }
}
