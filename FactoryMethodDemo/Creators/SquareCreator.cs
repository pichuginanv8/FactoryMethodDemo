using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodDemo.Models;
using System.Windows.Media; // Добавьте эту строку

namespace FactoryMethodDemo.Creators
{
    // абстрактный создатель для квадратов
    public abstract class SquareCreator
    {
        public abstract Square CreateSquare();
    }

    public class RedSquareCreator : SquareCreator
    {
        public override Square CreateSquare() => new Square { Color = Colors.Red };
    }

    public class BlueSquareCreator : SquareCreator
    {
        public override Square CreateSquare() => new Square { Color = Colors.Blue };
    }

    public class GreenSquareCreator : SquareCreator
    {
        public override Square CreateSquare() => new Square { Color = Colors.Green };
    }
}