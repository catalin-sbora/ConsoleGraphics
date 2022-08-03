using DynamicApp.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGraphics.DynamicCommands
{
    internal class AddSquareCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Adaugare patrat");
            Console.ReadLine();
        }
    }
}
