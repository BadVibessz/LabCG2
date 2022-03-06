using System;
using System.Drawing;

namespace paintTry3
{
    public struct Vector
    {
        private double _x, _y;
        private double _lenght;
        private Point _beg, _end;
        
        public double X
        {
            get { return _x; }
        }

        public double Y
        {
            get { return _y; }
        }

        public Point Beg
        {
            get { return this._beg; }
            set { this._beg = value; }
        }

        public Point End
        {
            get { return this._end; }
            set { this.End = value; }
        }

        public Vector Rotate(double degree)
        {
            var x = degree * Math.PI / 180;
            
            Vector v = new Vector();
            // v._x = this.X * Math.Cos(x) - this.Y * Math.Sin(x);
            // v._y = this.X * Math.Sin(x) + this.Y * Math.Cos(x);

            v._beg = this.Beg;
            
            var X = this.Beg.X + (this._end.X * Math.Cos(x) - this._end.Y * Math.Sin(x));
            var Y = this.Beg.Y - (this._end.X * Math.Sin(x) + this._end.Y * Math.Cos(x));
            v._end = new Point((int)X, (int)Y);
            
            return v;
        }

        public Vector(Point beg, Point end)
        {
            this._x = end.X - beg.X;
            this._y = end.Y - beg.Y;

            this._beg = beg;
            this._end = end;

            this._lenght = Math.Sqrt(Math.Pow(this._x, 2) + Math.Pow(this._y, 2));
        }


       


        public static double operator *(Vector v1, Vector v2) // scalar prod
        {
            return v1._x * v2._x + v1._y * v2._y;
        }


        public double Lenght
        {
            get => _lenght;
        }
    }
}