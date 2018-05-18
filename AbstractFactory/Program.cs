using AbstractFactoryProject.Classes.Factories;
using AbstractFactoryProject.Interfaces;
using System;

namespace AbstractFactoryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //get shape factory
            AbstractFactory shapeFactory = FactoryProducer.GetFactory("SHAPE");

            //get an object of Shape Circle
            IShape shape1 = shapeFactory.GetShape("CIRCLE");

            //call draw method of Shape Circle
            shape1.Draw();

            //get an object of Shape Rectangle
            IShape shape2 = shapeFactory.GetShape("RECTANGLE");

            //call draw method of Shape Rectangle
            shape2.Draw();

            //get an object of Shape Square 
            IShape shape3 = shapeFactory.GetShape("SQUARE");

            //call draw method of Shape Square
            shape3.Draw();

            //get colour factory
            AbstractFactory colourFactory = FactoryProducer.GetFactory("colour");

            //get an object of colour Red
            IColour colour1 = colourFactory.GetColour("RED");

            //call fill method of Red
            colour1.Fill();

            //get an object of colour Green
            IColour colour2 = colourFactory.GetColour("Green");

            //call fill method of Green
            colour2.Fill();

            //get an object of colour Blue
            IColour colour3 = colourFactory.GetColour("BLUE");

            //call fill method of colour Blue
            colour3.Fill();

            Console.ReadKey();
        }
    }
}
