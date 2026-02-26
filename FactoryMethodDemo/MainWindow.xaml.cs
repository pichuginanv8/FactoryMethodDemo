using System.Windows;
using System.Windows.Controls;
using FactoryMethodDemo.Creators;
using FactoryMethodDemo.Models;
//халлоу
namespace FactoryMethodDemo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            UpdateFigures();
        }

        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateFigures();
        }

        private void UpdateFigures()
        {
            if (FiguresPanel == null) return;

            FiguresPanel.Children.Clear();

            var selectedItem = ColorComboBox.SelectedItem as ComboBoxItem;
            if (selectedItem == null) return;

            CircleCreator circleCreator;
            SquareCreator squareCreator;
            TriangleCreator triangleCreator;

            switch (selectedItem.Content.ToString())
            {
                case "Красный":
                    circleCreator = new RedCircleCreator();
                    squareCreator = new RedSquareCreator();
                    triangleCreator = new RedTriangleCreator();
                    break;
                case "Синий":
                    circleCreator = new BlueCircleCreator();
                    squareCreator = new BlueSquareCreator();
                    triangleCreator = new BlueTriangleCreator();
                    break;
                case "Зелёный":
                    circleCreator = new GreenCircleCreator();
                    squareCreator = new GreenSquareCreator();
                    triangleCreator = new GreenTriangleCreator();
                    break;
                default:
                    return;
            }

            FiguresPanel.Children.Add(circleCreator.CreateCircle().CreateUIElement());
            FiguresPanel.Children.Add(squareCreator.CreateSquare().CreateUIElement());
            FiguresPanel.Children.Add(triangleCreator.CreateTriangle().CreateUIElement());
        }
    }
}