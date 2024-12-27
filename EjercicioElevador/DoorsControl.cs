using System;
using System.Threading;
using System.Threading.Tasks;

namespace EjercicioElevador
{
    /// <summary>
    /// Class for control the elevator doors
    /// </summary>
    public class DoorsControl
    {
        DoorStatus status = new DoorStatus();
        public DoorsControl(DoorStatus currentStatus)
        {
            status = currentStatus;
        }

        /// <summary>
        /// Function that change the status of the doors
        /// </summary>
        /// <returns></returns>
        public DoorStatus OpenCloseDoors()
        {
            if (status == DoorStatus.Open)
            {
                Console.WriteLine(".. Doors Opening ..");
                Thread.Sleep(800);

                return DoorStatus.Close;
            }
            else 
            {
                Console.WriteLine(".. Doors Closing ..");
                Thread.Sleep(800);

                return DoorStatus.Open;
            }
        }
    }

    public enum DoorStatus
    {
        Open,
        Close
    }
}

