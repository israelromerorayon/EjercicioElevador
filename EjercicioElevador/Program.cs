using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioElevador
{
    internal class Program
    {

        static int currentPosition = 1;
        static int myCurrentFloor = 5;
        static int destination = 0;

        static DoorStatus doorStatus = DoorStatus.Close;
        static Direction direction;

        static bool excecuteProgram = true;

        static void Main(string[] args)
        {
            
            Console.WriteLine("ELEVATOR CONTROL");
            Console.WriteLine("- Elevator is in floor - " + currentPosition.ToString());
            Console.WriteLine("- My current floor is - " + myCurrentFloor.ToString());

            while (excecuteProgram)
            {
                ExcecutionFlow();
            }
        }

        public static void ExcecutionFlow()
        {
            //Call elevator
            var outBB = new OutButtonBox(myCurrentFloor);
            outBB.RunPanelProcess();
            direction = outBB.Direction;

            //Close Doors
            doorStatus = new DoorsControl(doorStatus).OpenCloseDoors();
            
            //Moving Elevator
            new Moving(currentPosition, myCurrentFloor).ShowMovement();

            //Open Doors
            doorStatus = new DoorsControl(doorStatus).OpenCloseDoors();

            //Select floor
            var intBB = new InButtonBox(myCurrentFloor, direction);
            intBB.RunPanelProcess();
            destination = intBB.SelectedFloor;
            

            //Close Doors
            doorStatus = new DoorsControl(doorStatus).OpenCloseDoors();

            //Moving Elevator
            new Moving(myCurrentFloor, destination).ShowMovement();

            //Setting the new position
            currentPosition = intBB.SelectedFloor;
            myCurrentFloor = intBB.SelectedFloor;

            //Open Doors
            doorStatus = new DoorsControl(doorStatus).OpenCloseDoors();

            Console.WriteLine(" ----------------------");
            Console.WriteLine("Yo are in floor " + myCurrentFloor);
            Console.WriteLine(" ----------------------");
            Console.WriteLine("");

            Main(null);

            Console.ReadKey();

        }

    }
}
