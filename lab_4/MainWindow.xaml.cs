using System;
using System.Windows;

namespace lab4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Вспомогательный метод для безопасного создания отрезка из TextBox
        private bool TryGetSegment(System.Windows.Controls.TextBox xBox, System.Windows.Controls.TextBox yBox, out LineSegment segment)
        {
            segment = null;
            if (double.TryParse(xBox.Text, out double x) && double.TryParse(yBox.Text, out double y))
            {
                segment = new LineSegment(x, y);
                return true;
            }
            return false;
        }

        // 1. Обработка пересечения
        private void OnIntersectClick(object sender, RoutedEventArgs e)
        {
            if (TryGetSegment(AX, AY, out LineSegment a) && TryGetSegment(BX, BY, out LineSegment b))
            {
                LineSegment res = LineSegment.Intersection(a, b);
                ResultOutput.Text = res != null
                    ? $"Результат пересечения: {res}"
                    : "Отрезки не пересекаются (null)";
            }
            else
            {
                MessageBox.Show("Ошибка: Введите корректные числовые координаты.");
            }
        }

        // 2. Обработка оператора !
        private void OnNegateClick(object sender, RoutedEventArgs e)
        {
            if (TryGetSegment(AX, AY, out LineSegment a))
            {
                LineSegment res = !a; // Используем ваш перегруженный оператор
                ResultOutput.Text = $"Инверсия отрезка A: {res}";
            }
        }

        // 3. Сравнение отрезков (A > B)
        private void OnCompareClick(object sender, RoutedEventArgs e)
        {
            if (TryGetSegment(AX, AY, out LineSegment a) && TryGetSegment(BX, BY, out LineSegment b))
            {
                if (a > b)
                    ResultOutput.Text = "Результат: Отрезок A полностью включает в себя B";
                else if (b > a)
                    ResultOutput.Text = "Результат: Отрезок B полностью включает в себя A";
                else
                    ResultOutput.Text = "Результат: Ни один отрезок не включает в себя другой полностью";
            }
        }

        // 4. Сложение с числом (A + int)
        private void OnAddClick(object sender, RoutedEventArgs e)
        {
            if (TryGetSegment(AX, AY, out LineSegment a))
            {
                // Для примера прибавляем 5 (можно вынести в отдельное поле ввода)
                int valueToAdd = 5;
                LineSegment res = a + valueToAdd;
                ResultOutput.Text = $"К отрезку A прибавлено {valueToAdd}: {res}";
            }
        }
    }
}