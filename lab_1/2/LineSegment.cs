using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Swift;

namespace ConsoleApp2
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
    }
}
