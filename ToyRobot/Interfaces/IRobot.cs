using Toy_robot.Enums;

namespace Toy_robot.Interfaces
{
    public interface IRobot
    {
        bool IsPlaced { get; }
        void Place(int x, int y, Direction f);
        void Move();
        void TurnLeft();
        void TurnRight();
        string Report();
    }
}
