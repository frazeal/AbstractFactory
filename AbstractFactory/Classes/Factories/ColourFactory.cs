using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryProject.Classes.colours;
using AbstractFactoryProject.Interfaces;

namespace AbstractFactoryProject.Classes.Factories
{
    public class ColourFactory : AbstractFactory
    {
        public override IColour GetColour(string colour)
        {
            if (colour == null) return null;

            switch (colour.ToUpper())
            {
                case "RED":
                    return new Red();
                case "BLUE":
                    return new Blue();
                case "GREEN":
                    return new Green();
                default:
                    break;
            }

            return null;
        }

        public override IShape GetShape(string shapeType)
        {
            return null;
        }
    }
}
