using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace FactoryMethodDemo.Models
{
    public abstract class Figure
    {
        public Color Color { get; set; }
        public abstract UIElement CreateUIElement(double size = 50);
    }

    public class Circle : Figure
    {
        public override UIElement CreateUIElement(double size = 50)
        {
            return new Ellipse
            {
                Width = size,
                Height = size,
                Fill = new SolidColorBrush(Color),
                Margin = new Thickness(5)
            };
        }
    }

    public class Square : Figure
    {
        public override UIElement CreateUIElement(double size = 50)
        {
            return new Rectangle
            {
                Width = size,
                Height = size,
                Fill = new SolidColorBrush(Color),
                Margin = new Thickness(5)
            };
        }
    }

    public class Triangle : Figure
    {
        public override UIElement CreateUIElement(double size = 50)
        {
            var polygon = new Polygon
            {
                Points = new PointCollection
                {
                    new Point(size / 2, 0),
                    new Point(0, size),
                    new Point(size, size)
                },
                Fill = new SolidColorBrush(Color),
                Margin = new Thickness(5),
                Width = size,
                Height = size,
                Stretch = Stretch.Fill
            };
            return polygon;
        }
    }
}