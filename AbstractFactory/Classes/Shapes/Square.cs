using AbstractFactoryProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryProject.Classes
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Square::draw() method");
        }
    }
}
