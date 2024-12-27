using System;
using System.Threading;

namespace EjercicioElevador
{
    /// <summary>
    /// Class that manage the movement of elevator
    /// </summary>
    public class Moving
    {
        int currentFloor;
        int destinationFloor;
        public Moving(int current, int destination) 
        {
            currentFloor = current;
            destinationFloor = destination;

            Console.WriteLine(".. Elevator Moving ..");
        }
        
        public void ShowMovement()
        {
            if (currentFloor < destinationFloor )
            {
                for (int i = currentFloor; i <= destinationFloor; i++)
                {

                    Console.WriteLine(".. " + i.ToString() + " ..");
                    Thread.Sleep(800);
                }
            }
            else 
            {
                for (int i = currentFloor; i >= destinationFloor; i--)
                {
                    Console.WriteLine(".. " + i.ToString() + " ..");
                    Thread.Sleep(800);
                }
            }
            
        }

    }
}
