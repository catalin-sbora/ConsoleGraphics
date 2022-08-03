using DynamicApp.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGraphics.Commands
{
    internal class RemoveShapeCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Stergere forma");
            Console.ReadLine();
        }
    }
}
