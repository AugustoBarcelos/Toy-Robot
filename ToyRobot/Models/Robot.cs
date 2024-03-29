
using Toy_robot.Enums;
using Toy_robot.Interfaces;

namespace Toy_robot.Models
{
    public class Robot : IRobot
    {

        public int X { get; set; }
        public int Y { get; set; }
        public Direction F { get; set; }
        public bool IsPlaced { get; set; } = false;

        public void Place (int x, int y, Direction f)
        {
            if( x >=0 && x < 5 && y>=0 && y< 5) 
            {
                X = x;
                Y = y;
                F = f;
                IsPlaced = true;
            }
        }

        public void Move()
        {
            if (!IsPlaced) return;

            int newX = X;
            int newY = Y;

            if (F == Direction.NORTH)
            {
                newY++;
            } 
            else if (F == Direction.SOUTH)
            {
                newY--;
            }
            else if (F == Direction.WEST)
            {
                newX--;
            }
            else if (F == Direction.EAST)
            {
                newX++;
            }

            if (newX >= 0 && newX < 5 && newY >= 0 && newY < 5)
            {
                X = newX;
                Y = newY;
            }
            else
            {
                Console.WriteLine("Move ignored to prevent falling.");
            }
        }
        public void TurnLeft()
        {
            if (!IsPlaced) return;
            F = (Direction)(((int)F + 3) % 4);
        }
        public void TurnRight()
        {
            if (!IsPlaced) return;
            F = (Direction)(((int)F + 1) % 4);
        }

        public string Report()
        {
            return IsPlaced ? $"{X},{Y},{F}" : "Robot not placed.";
        }

    }
}
