using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy_robot.Interfaces
{
    public interface ICommandExecutor
    {
        void ExecuteCommand(string command);
    }
}