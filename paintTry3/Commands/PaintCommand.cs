using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Input;

namespace paintTry3
{
    public class PaintCommand : ICommand
    {
        private Painter _painter;
        private Graphics _graphics;


        public PaintCommand(Painter painter, Graphics graphics)
        {
            this._painter = painter;
            this._graphics = graphics;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _graphics.SmoothingMode = SmoothingMode.AntiAlias;
            _painter.Pen.EndCap = LineCap.Round;
            switch (_painter.State)
            {
                case "free":
                    for (int i = 0; i < _painter.Curve.Count - 1; i++)
                        _graphics.DrawLine(_painter.Pen, _painter.Curve.ElementAt(i), _painter.Curve.ElementAt(i + 1));
                    break;
                case "erase":
                    for (int i = 0; i < _painter.Curve.Count - 1; i++)
                        _graphics.DrawLine(_painter.Pen, _painter.Curve.ElementAt(i), _painter.Curve.ElementAt(i + 1));
                    break;
                case "text":
                    _graphics.DrawString(_painter.Text, new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point),
                        new SolidBrush(_painter.Pen.Color), _painter.Beg.X, _painter.Beg.Y);
                    break;
                case "rhombus":
                    if (_painter.IsShift)
                        if (_painter.IsFillNeeded)
                            new Rhombus(_painter.Beg, _painter.End.X - _painter.Beg.X, _painter.End.X - _painter.Beg.X).Fill(_graphics, _painter.Pen);
                        else
                            new Rhombus(_painter.Beg, _painter.End.X - _painter.Beg.X, _painter.End.X - _painter.Beg.X).Draw(_graphics, _painter.Pen);
                    else if (_painter.IsFillNeeded)
                        new Rhombus(_painter.Beg, _painter.End.X - _painter.Beg.X, _painter.End.Y - _painter.Beg.Y).Fill(_graphics, _painter.Pen);
                    else
                        new Rhombus(_painter.Beg, _painter.End.X - _painter.Beg.X, _painter.End.Y - _painter.Beg.Y).Draw(_graphics, _painter.Pen);
                    break;
                case "ellipse":
                    if (_painter.IsShift)
                        if (_painter.IsFillNeeded)
                            _graphics.FillEllipse(new SolidBrush(_painter.Pen.Color), _painter.Beg.X, _painter.Beg.Y, _painter.End.X - _painter.Beg.X, _painter.End.X - _painter.Beg.X);
                        else
                            _graphics.DrawEllipse(_painter.Pen, _painter.Beg.X, _painter.Beg.Y, _painter.End.X - _painter.Beg.X, _painter.End.X - _painter.Beg.X);
                    else
                    {
                        if (_painter.IsFillNeeded)
                            _graphics.FillEllipse(new SolidBrush(_painter.Pen.Color), _painter.Beg.X, _painter.Beg.Y, _painter.End.X - _painter.Beg.X, _painter.End.Y - _painter.Beg.Y);
                        else
                            _graphics.DrawEllipse(_painter.Pen, _painter.Beg.X, _painter.Beg.Y, _painter.End.X - _painter.Beg.X, _painter.End.Y - _painter.Beg.Y);
                    }

                    break;

                case "rectangle":
                    if (_painter.IsShift)
                        if (_painter.IsFillNeeded)
                            _graphics.FillRectangle(new SolidBrush(_painter.Pen.Color), _painter.Beg.X, _painter.Beg.Y, _painter.End.X - _painter.Beg.X, _painter.End.X - _painter.Beg.X);
                        else
                            _graphics.DrawRectangle(_painter.Pen, _painter.Beg.X, _painter.Beg.Y, _painter.End.X - _painter.Beg.X, _painter.End.X - _painter.Beg.X);
                    else
                    {
                        if (_painter.IsFillNeeded)
                            _graphics.FillRectangle(new SolidBrush(_painter.Pen.Color), _painter.Beg.X, _painter.Beg.Y, _painter.End.X - _painter.Beg.X, _painter.End.Y - _painter.Beg.Y);
                        else _graphics.DrawRectangle(_painter.Pen, _painter.Beg.X, _painter.Beg.Y, _painter.End.X - _painter.Beg.X, _painter.End.Y - _painter.Beg.Y);
                    }

                    break;
                case "arrow":
                    Pen r = new Pen(new SolidBrush(_painter.Pen.Color), _painter.Pen.Width + 5);
                    r.EndCap = LineCap.ArrowAnchor;
                    if (_painter.IsShift)
                    {
                        Point origin = new Point(_painter.End.X - _painter.Beg.X, _painter.End.Y - _painter.Beg.Y);
                        Point norm = new Point(_painter.Beg.X, _painter.End.Y);
                        var sin = Math.Sin(Math.Abs(Lenght(_painter.Beg, norm) / Lenght(_painter.Beg, _painter.End)));
                        Shifted(origin, sin);
                        _graphics.DrawLine(r, _painter.Beg, _painter.End);
                    }
                    else
                        _graphics.DrawLine(r, _painter.Beg, _painter.End);

                    break;

                case "line":
                    if (_painter.IsShift)
                    {
                        Point origin = new Point(_painter.End.X - _painter.Beg.X, _painter.End.Y - _painter.Beg.Y);
                        Point norm = new Point(_painter.Beg.X, _painter.End.Y);
                        var sin = Math.Sin(Math.Abs(Lenght(_painter.Beg, norm) / Lenght(_painter.Beg, _painter.End)));
                        Shifted(origin, sin);
                        _graphics.DrawLine(_painter.Pen, _painter.Beg, _painter.End);
                    }
                    else
                        _graphics.DrawLine(_painter.Pen, _painter.Beg, _painter.End);

                    break;
            }
        }

        public void Undo() //todo:
        {
            
        }

        private double Lenght(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
        }
        private void Shifted(Point origin, double sin)
        {
            var l = Lenght(_painter.End, _painter.Beg);
            var sin45 = Math.Sin(Math.PI / 4);

            // I
            if (origin.X > 0 && origin.Y < 0)
            {
                if (sin >= 0 && sin <= 0.5)
                    _painter.End.Y = _painter.Beg.Y;
                if (sin > 0.5 && sin <= 0.8)
                {
                    _painter.End.X = _painter.Beg.X + (int)(l * sin45);
                    _painter.End.Y = _painter.Beg.Y - (int)(l * sin45);
                }

                if (sin > 0.8 && sin <= 1)
                    _painter.End.X = _painter.Beg.X;
            }

            // II
            if (origin.X < 0 && origin.Y < 0)
            {
                if (sin >= 0 && sin <= 0.5)
                    _painter.End.Y = _painter.Beg.Y;
                if (sin > 0.5 && sin <= 0.8)
                {
                    _painter.End.X = _painter.Beg.X - (int)(l * sin45);
                    _painter.End.Y = _painter.Beg.Y - (int)(l * sin45);
                }

                if (sin > 0.8 && sin <= 1)
                    _painter.End.X = _painter.Beg.X;
            }

            // III
            if (origin.X > 0 && origin.Y > 0)
            {
                if (sin >= 0 && sin <= 0.5)
                    _painter.End.Y = _painter.Beg.Y;
                if (sin > 0.5 && sin <= 0.8)
                {
                    _painter.End.X = _painter.Beg.X + (int)(l * sin45);
                    _painter.End.Y = _painter.Beg.Y + (int)(l * sin45);
                }

                if (sin > 0.8 && sin <= 1)
                    _painter.End.X = _painter.Beg.X;
            }

            // IV
            if (origin.X < 0 && origin.Y > 0)
            {
                if (sin >= 0 && sin <= 0.5)
                    _painter.End.Y = _painter.Beg.Y;
                if (sin > 0.5 && sin <= 0.8)
                {
                    _painter.End.X = _painter.Beg.X - (int)(l * sin45);
                    _painter.End.Y = _painter.Beg.Y + (int)(l * sin45);
                }

                if (sin > 0.8 && sin <= 1)
                    _painter.End.X = _painter.Beg.X;
            }
        }

        public event EventHandler CanExecuteChanged;
    }
}