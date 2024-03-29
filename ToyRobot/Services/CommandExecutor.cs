

using Toy_robot.Enums;
using Toy_robot.Interfaces;

namespace Toy_robot.Services
{
    public class CommandExecutor : ICommandExecutor
    {
        private readonly IRobot _robot;

        public CommandExecutor(IRobot robot)
        {
            _robot = robot;
        }
        
        public void ExecuteCommand(string command)
        {
            var parts = command.Split(' ');
            switch (parts[0].ToUpper())
            {
                case "PLACE":
                    var args = parts.Length > 1 ? parts[1].Split(',') : null;
                    if (args != null && args.Length == 3)
                    {
                        var x = int.Parse(args[0]);
                        var y = int.Parse(args[1]);
                        var f = Enum.Parse<Direction>(args[2]);
                        _robot.Place(x, y, f);
                    }
                    break;
                case "MOVE":
                    _robot.Move();
                    break;
                case "LEFT":
                    _robot.TurnLeft();
                    break;
                case "RIGHT":
                    _robot.TurnRight();
                    break;
                case "REPORT":
                    Console.WriteLine(_robot.Report());
                    break;
            }
        }
    }
}
