using AbstractFactoryProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryProject.Classes.colours
{
    public class Blue : IColour
    {
        public void Fill()
        {
            Console.WriteLine("Inside Blue::Fill() method");
        }
    }
}
