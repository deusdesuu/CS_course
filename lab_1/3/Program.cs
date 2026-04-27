/*
 * LineSegment
 * double x, y - stard, end
 * Intersection(LineSegment, LineSegment) -> x, y пересечения | null
 */
namespace ConsoleApp3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double x = .0;
            double y = .0;
            LineSegment lineA = new LineSegment();
            LineSegment lineB = new LineSegment();
            LineSegment intersection = new LineSegment();

            Console.WriteLine("Введите координаты первого отрезка:");
            x = Input.InputDouble("Введите х: ");
            y = Input.InputDouble("Введите у: ");
            if (x == y)
            {
                lineA = new LineSegment(x);
            }
            else
            {
                lineA = new LineSegment(x, y);
            }

            lineB = new LineSegment();
            Console.WriteLine("Введите координаты второго отрезка:");
            x = Input.InputDouble("Введите х: ");
            y = Input.InputDouble("Введите у: ");
            if (x <= y)
            {
                lineB.X = x;
                lineB.Y = y;
            }
            else
            {
                lineB.X = y;
                lineB.Y = x;
            }

            Console.WriteLine("\nПример работы '!'");
            Console.WriteLine("!lineA = " + !lineA);
            Console.WriteLine("!lineB = " + !lineB);

            int value = 0;
            Console.WriteLine("\nПример неявного приведения int:");
            value = lineA;
            Console.WriteLine("(int)lineA = " + value);
            value = lineB;
            Console.WriteLine("(int)lineB = " + value);

            Console.WriteLine("\nПример явного приведения double:");
            Console.WriteLine("(double)lineA = " + (double)lineA);
            Console.WriteLine("(double)lineB = " + (double)lineB);

            value = 5;
            Console.WriteLine("\nПример левостороннего сложения:");
            Console.WriteLine("lineA + 5 = " + (lineA + value));

            Console.WriteLine("\nПример правостороннего сложения:");
            Console.WriteLine("5 + lineB = " + (5 + lineB));

            Console.WriteLine("\nПример работы оператора >:");
            Console.WriteLine("lineA > lineB ? " + (lineA > lineB));
            Console.WriteLine("lineB > lineA ? " + (lineB > lineA));
        }
    }
}
/*
Test:
Введите координаты первого отрезка:
Введите х: -5,123
Введите у: 4,234
Введите координаты второго отрезка:
Введите х: -3,175
Введите у: 3,586

Пример работы '!'
!lineA = [-5,123, 0]
!lineB = [0, 3,586]

Пример неявного приведения int:
(int)lineA = 4
(int)lineB = 3

Пример явного приведения double:
(double)lineA = -5,123
(double)lineB = -3,175

Пример левостороннего сложения:
lineA + 5 = [-0,12300000000000022, 4,234]

Пример правостороннего сложения:
5 + lineB = [-3,175, 8,586]

Пример работы оператора >:
lineA > lineB ? True
lineB > lineA ? False
 */