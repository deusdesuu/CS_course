using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Swift;

namespace ConsoleApp3
{
    internal class LineSegment
    {
        private double _x;
        private double _y;

        public LineSegment()
        {
            this._x = 0;
            this._y = 0;
        }
        public LineSegment(double dot)
        {
            this._x = dot;
            this._y = dot;
        }

        public LineSegment(double x, double y)
        {
            if (x <= y)
            {
                this._x = x;
                this._y = y;
            }
            else
            {
                this._x = y;
                this._y = x;
            }
        }

        public double X
        {
            get { return _x; }
            set { _x = value; }
        }
        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public override string ToString()
        {
            return "[" + this._x + ", " + this._y + "]";
        }
        private static double Min(double a, double b)
        {
            return (a < b) ? a : b;
        }
        private static double Max(double a, double b)
        {
            return (a < b) ? b : a;
        }
        public static LineSegment Intersection(LineSegment a, LineSegment b)
        {
            double x = Max(a.X, b.X);
            double y = Min(a.Y, b.Y);
            return (x <= y) ? new LineSegment(x, y) : null;
        }
        /*
         * Если отрезок левее 0: дополняем его до нуля направо
         * Если правее 0: дополняем его до нуля налево
         * Если пересекает 0: отсекаем меньшую часть
         */
        public static LineSegment operator !(LineSegment obj)
        {
            if (obj.X > 0)
            {
                return new LineSegment(0, obj.Y);
            }
            if (obj.Y < 0)
            {
                return new LineSegment(obj.X, 0);
            }
            if (obj.Y > -obj.X)
            {
                return new LineSegment(0, obj.Y);
            }
            else
            {
                return new LineSegment(obj.X, 0);
            }
        }
        public static implicit operator int(LineSegment obj)
        {
            return (obj == null) ? 0 : (int)(obj.Y);
        }
        public static explicit operator double(LineSegment obj)
        {
            return (obj == null) ? 0 : obj.X;
        }
        public static LineSegment operator +(LineSegment obj, int value)
        {
            return new LineSegment(obj.X + value, obj.Y);
        }
        public static LineSegment operator + (int value, LineSegment obj)
        {
            return new LineSegment(obj.X, obj.Y + value);
        }
        public static bool operator > (LineSegment a, LineSegment b)
        {
            return (a.X < b.X && a.Y > b.Y) ? true : false;
        }
        public static bool operator < (LineSegment a, LineSegment b)
        {
            return b > a;
        }
    }
}
