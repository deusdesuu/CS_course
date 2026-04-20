/*
 * LineSegment
 * double x, y - stard, end
 * Intersection(LineSegment, LineSegment) -> x, y пересечения | null
 */
namespace ConsoleApp2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double x;
            double y;
            LineSegment lineA;
            LineSegment lineB;
            LineSegment intersection;

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

            Console.Write("Пересечение первого отрезка " + lineA
                + " и второго " + lineB + " равно ");
            intersection = LineSegment.Intersection(lineA, lineB);
            Console.WriteLine((intersection == null) ? "[]" : intersection);
        }
    }
}
/*
Test 1:
Введите координаты первого отрезка:
Введите х: 1
Введите у: 2
Введите координаты второго отрезка:
Введите х: 3
Введите у: 4
Пересечение первого отрезка [1, 2] и второго [3, 4] равно []

Test2:
Введите координаты первого отрезка:
Введите х: 1
Введите у: 1
Введите координаты второго отрезка:
Введите х: -17.123
Ожидался тип double!!!
Введите х: -17,123
Введите у: 1,0001
Пересечение первого отрезка [1, 1] и второго [-17,123, 1,0001] равно [1, 1]

Test3:
Введите координаты первого отрезка:
Введите х: 5
Введите у: 3
Введите координаты второго отрезка:
Введите х: 4
Введите у: 7
Пересечение первого отрезка [3, 5] и второго [4, 7] равно [4, 5]
 */