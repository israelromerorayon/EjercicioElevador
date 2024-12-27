using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioElevador
{
    /// <summary>
    /// Class that creat and in door control panel for go to any floor
    /// </summary>
    public class InButtonBox
    {

        int[] floors;
        int[] validFloors;
        int numberFloors;

        int currentFloor = 0;
        Direction direction;

        public int SelectedFloor { get; set; }

        public int[] Floors { get { return floors; } }


        public InButtonBox(int currentFloor, Direction direction, int numFloors = 5)
        {
            floors = new int[numFloors];
            validFloors = new int[numFloors];
            numberFloors = numFloors;

            this.currentFloor = currentFloor;
            this.direction = direction;

        }

        public void RunPanelProcess()
        {
            LoadFloors(numberFloors);

            ShowInPanel();

            ValidFloor();
        }

        /// <summary>
        /// Create the panel with the number of floors setted
        /// </summary>
        /// <param name="numberFloors"></param>
        public void LoadFloors(int numberFloors)
        {
            for (int i = 1; i < numberFloors; i++)
            {
                floors[i] = i;
            }   
        }

        /// <summary>
        /// Creat options panel for move the elevator to any floor
        /// </summary>
        public void ShowInPanel()
        {
            Console.WriteLine("---- Select destination floor ----");

            Console.WriteLine("---- Options ----");


            //Just show the options valid for the current floor and direction
            if (direction == Direction.Up)
            {
                for (int i = currentFloor; i <= floors.Length; i++)
                {
                    Console.WriteLine("------ " + i + " ------");
                    validFloors[i - 1] = i; 
                }
            }

            if (direction == Direction.Down)
            {
                for (int i = currentFloor; i >= 1; i--)
                {
                    Console.WriteLine("------ " + i + " ------");
                    validFloors[i - 1] = i;
                }
            }
        }

        /// <summary>
        /// Validate the input
        /// </summary>
        public void ValidFloor()
        {

            Boolean wating = true;
            
            string input = Console.ReadLine();

            while (wating)
            {
                if (int.TryParse(input, out int selected))
                {
                    bool existe = validFloors.Contains(selected);

                    if (existe)
                    {
                        currentFloor = selected;
                        SelectedFloor = selected;
                        wating = false;
                    }
                    else 
                    {
                        Console.WriteLine("-------- Enter a valid option --------");
                    }
                }
                else
                {
                    Console.WriteLine("-------- Enter a valid option --------");
                }
            }
        }
    }
}
