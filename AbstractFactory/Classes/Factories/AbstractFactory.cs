using AbstractFactoryProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryProject.Classes.Factories
{
    public abstract class AbstractFactory
    {
        public abstract IColour GetColour(String colour);
        public abstract IShape GetShape(String shapeType);
    }
}
