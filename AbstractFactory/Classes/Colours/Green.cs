using AbstractFactoryProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryProject.Classes.colours
{
    public class Green : IColour
    {
        public void Fill()
        {
            Console.WriteLine("Inside Green::Fill() method");
        }
    }
}
