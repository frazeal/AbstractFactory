using AbstractFactoryProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryProject.Classes.colours
{
    public class Red : IColour
    {
        public void Fill()
        {
            Console.WriteLine("Inside Red::Fill() method");
        }
    }
}
