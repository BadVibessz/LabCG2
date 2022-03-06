using System;
using System.Drawing;

namespace paintTry3
{
    public struct Angle
    {
        private double _deg;

        public Angle(Vector v1, Vector v2)
        {
            this._deg = Math.Acos(Math.Abs(v1 * v2) / (v1.Lenght * v2.Lenght)) * 180.0 / Math.PI;
        }

        public static Point GetPointByDeg(Point origin, Point mousLoc, double deg) //todo:
        {
            var x = deg * Math.PI / 180;
            
            var temp = new Point(mousLoc.X, origin.Y);
            
            // var X = origin.X + (temp.X * Math.Cos(x) - temp.Y * Math.Sin(x));
            // var Y = origin.Y - (temp.X * Math.Sin(x) + temp.Y * Math.Cos(x));

            var X = origin.X + (temp.X - origin.X) * Math.Cos(x) - (temp.Y - origin.Y) * Math.Sin(x);
            var Y = origin.Y + (temp.X - origin.X) * Math.Sin(x) + (temp.Y - origin.Y) * Math.Cos(x);

            return new Point((int)X, (int)Y);
        }

        public double Deg
        {
            set { }
            get { return this._deg; }
        }
    }
}