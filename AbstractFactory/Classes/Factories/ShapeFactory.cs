using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryProject.Interfaces;

namespace AbstractFactoryProject.Classes.Factories
{
    public class ShapeFactory : AbstractFactory
    {
        public override IColour GetColour(string colour)
        {
            return null;
        }

        public override IShape GetShape(string shapeType)
        {
            if (shapeType == null) return null;

            switch (shapeType.ToUpper())
            {
                case "CIRCLE":
                    return new Circle();
                case "SQUARE":
                    return new Square();
                case "RECTANGLE":
                    return new Rectangle();
                default:
                    break;
            }

            return null;
        }
    }
}
