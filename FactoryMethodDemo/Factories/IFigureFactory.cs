using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryDemo.Models;

namespace AbstractFactoryDemo.Factories
{
    public interface IFigureFactory
    {
        Circle CreateCircle();
        Square CreateSquare();
        Triangle CreateTriangle();
    }
}
