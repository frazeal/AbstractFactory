using AbstractFactoryProject.Classes.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryProject
{
    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(string choice)
        {
            if (choice.ToUpper().Equals("SHAPE"))
            {
                return new ShapeFactory();
            }
            else if (choice.ToUpper().Equals("COLOUR"))
            {
                return new ColourFactory();
            }

            return null;
        }
    }
}
