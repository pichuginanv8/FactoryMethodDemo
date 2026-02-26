using System.Windows;
using System.Windows.Controls;
using AbstractFactoryDemo.Factories;

namespace AbstractFactoryDemo
{
    public partial class MainWindow : Window
    {
        private IFigureFactory _currentFactory;

        public MainWindow()
        {
            InitializeComponent();
            _currentFactory = new RedFactory();
            UpdateFigures();
        }

        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = ColorComboBox.SelectedItem as ComboBoxItem;
            if (selectedItem == null) return;

            switch (selectedItem.Content.ToString())
            {
                case "Красный":
                    _currentFactory = new RedFactory();
                    break;
                case "Синий":
                    _currentFactory = new BlueFactory();
                    break;
                case "Зелёный":
                    _currentFactory = new GreenFactory();
                    break;
                default:
                    return;
            }

            UpdateFigures();
        }

        private void UpdateFigures()
        {
            if (FiguresPanel == null) return;

            FiguresPanel.Children.Clear();

            FiguresPanel.Children.Add(_currentFactory.CreateCircle().CreateUIElement());
            FiguresPanel.Children.Add(_currentFactory.CreateSquare().CreateUIElement());
            FiguresPanel.Children.Add(_currentFactory.CreateTriangle().CreateUIElement());
        }
    }
}