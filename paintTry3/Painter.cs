using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace paintTry3
{
    public class Painter
    {
        private Bitmap _img;
        private Size _imgSize;
        private Graphics _graphics;
        public int Id;

        public bool IsSaved = false;
        public string SavedPath;
        public bool IsPainting = false;
        public Pen Pen = new Pen(Color.Black);
        public string State = "free";
        public Point Beg, End;
        public List<Point> Curve = new List<Point>();
        public Color BackColor = Color.White, ForeColor = Color.Black;
        public bool IsBack = false;
        public bool IsShift = false;
        public bool IsFillNeeded = false;
        public string Text;


        public Painter(Size size) //todo: remove ID
        {
            _imgSize = size;
            _img = new Bitmap(_imgSize.Width, _imgSize.Height);
            _graphics = Graphics.FromImage(_img);
            _graphics.Clear(Color.White);
            this.Id = _img.GetHashCode();
        }

        public Bitmap Image
        {
            get => this._img;
            set
            {
                this._graphics = Graphics.FromImage(value);
                if (value != null)
                    _graphics.DrawImage(value, 0, 0);
                this._img = new Bitmap(value);
            }
        }

        public Size Size
        {
            get => this._imgSize;
            set
            {
                this._imgSize = value;
                var img = new Bitmap(_imgSize.Width, _imgSize.Height);
                _graphics = Graphics.FromImage(img);
                _graphics.Clear(Color.White);
                if (_img != null)
                    _graphics.DrawImage(_img, 0, 0);
                _img = new Bitmap(img);
            }
        }

        private double Lenght(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
        }

        private void Shifted(Point origin, double sin)
        {
            var l = Lenght(End, Beg);
            var sin45 = Math.Sin(Math.PI / 4);

            // I
            if (origin.X > 0 && origin.Y < 0)
            {
                if (sin >= 0 && sin <= 0.5)
                    End.Y = Beg.Y;
                if (sin > 0.5 && sin <= 0.8)
                {
                    End.X = Beg.X + (int)(l * sin45);
                    End.Y = Beg.Y - (int)(l * sin45);
                }

                if (sin > 0.8 && sin <= 1)
                    End.X = Beg.X;
            }

            // II
            if (origin.X < 0 && origin.Y < 0)
            {
                if (sin >= 0 && sin <= 0.5)
                    End.Y = Beg.Y;
                if (sin > 0.5 && sin <= 0.8)
                {
                    End.X = Beg.X - (int)(l * sin45);
                    End.Y = Beg.Y - (int)(l * sin45);
                }

                if (sin > 0.8 && sin <= 1)
                    End.X = Beg.X;
            }

            // III
            if (origin.X > 0 && origin.Y > 0)
            {
                if (sin >= 0 && sin <= 0.5)
                    End.Y = Beg.Y;
                if (sin > 0.5 && sin <= 0.8)
                {
                    End.X = Beg.X + (int)(l * sin45);
                    End.Y = Beg.Y + (int)(l * sin45);
                }

                if (sin > 0.8 && sin <= 1)
                    End.X = Beg.X;
            }

            // IV
            if (origin.X < 0 && origin.Y > 0)
            {
                if (sin >= 0 && sin <= 0.5)
                    End.Y = Beg.Y;
                if (sin > 0.5 && sin <= 0.8)
                {
                    End.X = Beg.X - (int)(l * sin45);
                    End.Y = Beg.Y + (int)(l * sin45);
                }

                if (sin > 0.8 && sin <= 1)
                    End.X = Beg.X;
            }
        }

        private void Paint(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen.EndCap = LineCap.Round;
            switch (State)
            {
                case "free":
                    for (int i = 0; i < Curve.Count - 1; i++)
                        g.DrawLine(Pen, Curve.ElementAt(i), Curve.ElementAt(i + 1));
                    break;
                case "erase":
                    for (int i = 0; i < Curve.Count - 1; i++)
                        g.DrawLine(Pen, Curve.ElementAt(i), Curve.ElementAt(i + 1));
                    break;
                case "text":
                    g.DrawString(Text, new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point),
                        new SolidBrush(Pen.Color), Beg.X, Beg.Y);
                    break;
                case "rhombus":
                    if (IsShift)
                        if (IsFillNeeded)
                            new Rhombus(Beg, End.X - Beg.X, End.X - Beg.X).Fill(g, Pen);
                        else
                            new Rhombus(Beg, End.X - Beg.X, End.X - Beg.X).Draw(g, Pen);
                    else if (IsFillNeeded)
                        new Rhombus(Beg, End.X - Beg.X, End.Y - Beg.Y).Fill(g, Pen);
                    else
                        new Rhombus(Beg, End.X - Beg.X, End.Y - Beg.Y).Draw(g, Pen);
                    break;
                case "ellipse":
                    if (IsShift)
                        if (IsFillNeeded)
                            g.FillEllipse(new SolidBrush(Pen.Color), Beg.X, Beg.Y, End.X - Beg.X, End.X - Beg.X);
                        else
                            g.DrawEllipse(Pen, Beg.X, Beg.Y, End.X - Beg.X, End.X - Beg.X);
                    else
                    {
                        if (IsFillNeeded)
                            g.FillEllipse(new SolidBrush(Pen.Color), Beg.X, Beg.Y, End.X - Beg.X, End.Y - Beg.Y);
                        else
                            g.DrawEllipse(Pen, Beg.X, Beg.Y, End.X - Beg.X, End.Y - Beg.Y);
                    }

                    break;

                case "rectangle":
                    if (IsShift)
                        if (IsFillNeeded)
                            g.FillRectangle(new SolidBrush(Pen.Color), Beg.X, Beg.Y, End.X - Beg.X, End.X - Beg.X);
                        else
                            g.DrawRectangle(Pen, Beg.X, Beg.Y, End.X - Beg.X, End.X - Beg.X);
                    else
                    {
                        if (IsFillNeeded)
                            g.FillRectangle(new SolidBrush(Pen.Color), Beg.X, Beg.Y, End.X - Beg.X, End.Y - Beg.Y);
                        else g.DrawRectangle(Pen, Beg.X, Beg.Y, End.X - Beg.X, End.Y - Beg.Y);
                    }

                    break;
                case "arrow":
                    Pen r = new Pen(new SolidBrush(Pen.Color), Pen.Width + 5);
                    r.EndCap = LineCap.ArrowAnchor;
                    if (IsShift)
                    {
                        Point origin = new Point(End.X - Beg.X, End.Y - Beg.Y);
                        Point norm = new Point(Beg.X, End.Y);
                        var sin = Math.Sin(Math.Abs(Lenght(Beg, norm) / Lenght(Beg, End)));
                        Shifted(origin, sin);
                        g.DrawLine(r, Beg, End);
                    }
                    else
                        g.DrawLine(r, Beg, End);
                    break;

                case "line":
                    if (IsShift)
                    {
                        Point origin = new Point(End.X - Beg.X, End.Y - Beg.Y);
                        Point norm = new Point(Beg.X, End.Y);
                        var sin = Math.Sin(Math.Abs(Lenght(Beg, norm) / Lenght(Beg, End)));
                        Shifted(origin, sin);
                        g.DrawLine(Pen, Beg, End);
                    }
                    else
                        g.DrawLine(Pen, Beg, End);

                    break;
            }


            Bitmap b = new Bitmap(_imgSize.Width, _imgSize.Height, g);
        }

        public void Preview(Graphics g)
        {
            BufferedGraphics bg = BufferedGraphicsManager.Current.Allocate(g, Rectangle.Round(g.VisibleClipBounds));
            bg.Graphics.DrawImage(_img, 0, 0);
            Paint(bg.Graphics);
            bg.Render(g);
            bg.Dispose();
        }

        public void PaintVoid()
        {
            Paint(Graphics.FromImage(_img));
        }

        public void Show(Graphics g)
        {
            g.DrawImage(_img, 0, 0);
        }

        public void Clear()
        {
            this._graphics.Dispose();
            this._img.Dispose();
        }
    }
}