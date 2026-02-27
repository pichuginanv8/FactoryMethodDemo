using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using FactoryMethodDemo.Models;
using AbstractFactoryDemo.Factories;

namespace AbstractFactoryDemo.Factories
{
    public class BlueFactory : IFigureFactory
    {
        public Circle CreateCircle() => new Circle { Color = Colors.Blue };
        public Square CreateSquare() => new Square { Color = Colors.Blue };
        public Triangle CreateTriangle() => new Triangle { Color = Colors.Blue };
    }
}