using System.Windows;
using System.Windows.Controls;
using AbstractFactoryDemo.Factories;
using System.Windows.Media; // Добавьте если используете Colors где-то

namespace AbstractFactoryDemo
{
    public partial class MainWindow : Window
    {
        private IFigureFactory _currentFactory;

        public MainWindow()
        {
            InitializeComponent(); // ВАЖНО: сначала инициализация компонентов
            _currentFactory = new RedFactory(); // По умолчанию
            UpdateFigures(); // Теперь можно обращаться к FiguresPanel
        }

        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = ColorComboBox.SelectedItem as ComboBoxItem;
            if (selectedItem == null) return;

            // Выбираем фабрику в зависимости от цвета
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
            // Проверка на случай, если метод вызван до инициализации
            if (FiguresPanel == null) return;

            // Очищаем панель
            FiguresPanel.Children.Clear();

            // Создаём фигуры через текущую фабрику
            FiguresPanel.Children.Add(_currentFactory.CreateCircle().CreateUIElement());
            FiguresPanel.Children.Add(_currentFactory.CreateSquare().CreateUIElement());
            FiguresPanel.Children.Add(_currentFactory.CreateTriangle().CreateUIElement());
        }
    }
}