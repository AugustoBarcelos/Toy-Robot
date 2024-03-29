using Toy_robot.Interfaces;
using Toy_robot.Models;
using Toy_robot.Services;

class Program
{
    static void Main(string[] args)
    {
        IRobot robot = new Robot();
        ICommandExecutor commandExecutor = new CommandExecutor(robot);

        Console.WriteLine("Let's beggin. Enter a command, 'Exit' to end.");
        string input;
        while ((input = Console.ReadLine()!) != null && input.ToUpper() != "EXIT")
        {
            commandExecutor.ExecuteCommand(input);
        }
    }
}