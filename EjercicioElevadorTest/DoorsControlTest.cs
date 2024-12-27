using EjercicioElevador;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EjercicioElevadorTest
{
    [TestClass]
    public class DoorsControlTest
    {
        [TestMethod]
        public void CloseDoors()
        {

            DoorsControl dc = new DoorsControl(DoorStatus.Open);
            
            Assert.AreEqual(DoorStatus.Close, dc.OpenCloseDoors());

        }

        [TestMethod]
        public void OpenDoors()
        {

            DoorsControl dc = new DoorsControl(DoorStatus.Close);

            Assert.AreEqual(DoorStatus.Open, dc.OpenCloseDoors());

        }
    }
}
