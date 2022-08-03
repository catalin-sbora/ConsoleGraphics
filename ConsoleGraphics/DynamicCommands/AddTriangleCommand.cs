using DynamicApp.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGraphics.DynamicCommands
{
    internal class AddTriangleCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Adaugare triunghi");
            Console.ReadLine();
        }
    }
}
