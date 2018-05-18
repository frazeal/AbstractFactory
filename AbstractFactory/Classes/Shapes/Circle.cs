using AbstractFactoryProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryProject.Classes
{
    public class Circle: IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }
    }
}
