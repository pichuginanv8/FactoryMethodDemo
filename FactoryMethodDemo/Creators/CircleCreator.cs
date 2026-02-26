using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using FactoryMethodDemo.Models;

namespace FactoryMethodDemo.Creators
{
    public abstract class CircleCreator
    {
        public abstract Circle CreateCircle();
    }

    public class RedCircleCreator : CircleCreator
    {
        public override Circle CreateCircle() => new Circle { Color = Colors.Red };
    }

    public class BlueCircleCreator : CircleCreator
    {
        public override Circle CreateCircle() => new Circle { Color = Colors.Blue };
    }

    public class GreenCircleCreator : CircleCreator
    {
        public override Circle CreateCircle() => new Circle { Color = Colors.Green };
    }
}