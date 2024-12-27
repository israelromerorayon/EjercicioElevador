using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EjercicioElevador
{
    /// <summary>
    /// Class that creat and control the external panel for call the elevator from any floor and to know the direction
    /// </summary>
    public class OutButtonBox
    {
        int currentFloor = 0;
        string input;
        int pressed;

        public Direction Direction { get; set; }

        public OutButtonBox(int currentFloor)
        {
            this.currentFloor = currentFloor;

            //Console.WriteLine("-- Out Control -- ");
            Console.WriteLine("-- Call the elevator  -- ");

        }

        public void RunPanelProcess()
        {
            ShowOutPanel();
        }

        /// <summary>
        /// Creat options panel for call the elevator depending the current floor
        /// </summary>
        public void ShowOutPanel()
        {
            //Console.WriteLine("---- Control Box ---- ");
            Console.WriteLine("---- Options ----");

            if (currentFloor == 5)
            {
                Console.WriteLine("------ 2. Down");
            }
            else if (currentFloor == 1)
            {
                Console.WriteLine("------ 1. Up");
            }
            else
            {
                Console.WriteLine("------ 1. Up");
                Console.WriteLine("------ 2. Down");
            }

            if (InputIsValid())
            {
                OutCall();
            }
            else
            {
                ShowOutPanel();
            }

        }

        /// <summary>
        /// Determinate the direccion of the elevator goint to follow
        /// </summary>
        public void OutCall()
        {

            if (currentFloor == 1)
            {
                //If current floor is 1 we just can go up
                if (pressed == 1)
                {
                    Direction = Direction.Up;
                }
                else
                {
                    Console.WriteLine("-------- Enter a valid option --------");
                    ShowOutPanel();
                }
            }
            else if (currentFloor == 5)
            {
                //If current floor is 5 just can down
                if (pressed == 2)
                {
                    Direction = Direction.Down;
                }
                else
                {
                    Console.WriteLine("-------- Enter a valid option --------");
                    ShowOutPanel();
                }
            }
            else
            {
                //In any other floor we can select any direction
                if (pressed == 1)
                {
                    Direction = Direction.Up;
                }
                if (pressed == 2)
                {
                    Direction = Direction.Down;
                }
            }
        }

        public bool InputIsValid()
        {
            bool valid = true;

            input = Console.ReadLine();

            if (int.TryParse(input, out pressed))
            {
                if (!Enum.IsDefined(typeof(Direction), pressed))
                {
                    Console.WriteLine("-------- Enter a valid option --------");
                    valid = false;
                }
            }
            else
            {
                Console.WriteLine("-------- Enter a valid option --------");
                valid = false;
            }

            return valid;
        }
    }

    public enum Direction
    {
        Up = 1,
        Down = 2,
    }
}
