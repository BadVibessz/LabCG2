using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;

namespace paintTry3
{
    public class Painter
    {
        private Bitmap _img;
        private Size _imgSize;
        private readonly Graphics _graphics;
        private bool _isSaved = false;
        private string _savedPath;


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


        public Painter(Size size)
        {
            _imgSize = size;
            var img = new Bitmap(_imgSize.Width, _imgSize.Height);
            var g = Graphics.FromImage(img);
            _graphics = g;
            g.Clear(Color.White);
            _img = img;
        }

        public Bitmap Image
        {
            get => this._img;
            set { this._img = value; }
        }

        public Size Size
        {
            get => this._imgSize;
            set
            {
                this._imgSize = value;
                var img = new Bitmap(_imgSize.Width, _imgSize.Height);
                var g = Graphics.FromImage(img);
                g.Clear(Color.White);
                if (_img != null)
                    g.DrawImage(_img, 0, 0);
                _img = img;
            }
        }

        // public bool Open()
        // {
        //     var dialog = new OpenFileDialog { Filter = "Image (*.jpg)|*.jpg|Image (*.png)|*.png" };
        //
        //    Image.FromFile(Text)
        //         var img = Image.fr
        //     
        //     
        //     return true;
        // }

        public bool SaveAs()
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "Image (*.jpg) | *.jpg  | Image (*.png) | *.png";
            dialog.ShowDialog();
            //dialog.FileName = "Sample.png";
            this._img.Save(dialog.FileName);
            this._isSaved = true;
            this._savedPath = dialog.FileName;
            return true;
        }

        public bool Save()
        {
            if (!_isSaved)
                SaveAs();
            else
                this._img.Save(_savedPath);
            return true;
        }

        private double Lenght(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
        }


        private static void DrawRhombus(Graphics g, Pen pen, Point origin, int width, int height)
        {
            int edge = (int)Math.Sqrt(width * width + height * height);
            Point center = new Point(origin.X + width / 2, origin.Y);

            Point a = origin;
            Point b = new Point(origin.X + width / 2, origin.Y - height / 2);
            Point c = new Point(origin.X + width, origin.Y);
            Point d = new Point(origin.X + width / 2, origin.Y + height / 2);

            g.DrawLine(pen, a, b);
            g.DrawLine(pen, b, c);
            g.DrawLine(pen, c, d);
            g.DrawLine(pen, d, a);
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

        private void Paint(Graphics g, bool isShift)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            switch (State)
            {
                case "free":
                    for (int i = 0; i < Curve.Count - 1; i++)
                        g.DrawLine(Pen, Curve.ElementAt(i), Curve.ElementAt(i + 1));
                    break;
                case "text":
                    g.DrawString(Text, new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point),
                        new SolidBrush(Pen.Color), Beg.X, Beg.Y);
                    break;
                case "rhombus":
                    if (isShift)
                        DrawRhombus(g, Pen, Beg, End.X - Beg.X, End.X - Beg.X);
                    else
                        DrawRhombus(g, Pen, Beg, End.X - Beg.X, End.Y - Beg.Y);
                    break;
                case "ellipse":
                    if (isShift)
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

                    //_buffer.Add(new Ellipse(_clickLoc, drawPanel.Size, _width, _height));
                    break;

                case "rectangle":
                    if (isShift)
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

                    //_buffer.Add(new Rectangle(_clickLoc, drawPanel.Size, _width, _height));
                    break;
                case "arrow":
                    Pen r = new Pen(new SolidBrush(Pen.Color), Pen.Width + 5);
                    r.EndCap = LineCap.ArrowAnchor;
                    if (isShift)
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
                    if (isShift)
                    {
                        Point origin = new Point(End.X - Beg.X, End.Y - Beg.Y);
                        Point norm = new Point(Beg.X, End.Y);
                        var sin = Math.Sin(Math.Abs(Lenght(Beg, norm) / Lenght(Beg, End)));
                        Shifted(origin, sin);
                        g.DrawLine(Pen, Beg, End);

                        // //new Point(Beg.X - End.X, Beg.Y
                        // Vector v1 = new Vector(Beg, new Point(Beg.X + End.X, Beg.Y));
                        // Vector v2 = new Vector(Beg, End);
                        // Angle a = new Angle(v1, v2);
                        //
                        // int sgn = 1;
                        // if (Beg.Y < End.Y)
                        //     sgn = -1;
                        // if (Beg.Y > End.Y)
                        //     sgn = 1;
                        //
                        // if (a.Deg % 45 == 0)
                        //     g.DrawLine(Pen, Beg, End);
                        // else
                        // {
                        //     //todo: maybe loop
                        //
                        //     var alpha = sgn * a.Deg;
                        //
                        //     var temp = new[]
                        //     {
                        //         Math.Abs(alpha),
                        //         Math.Abs(alpha - 45),
                        //         Math.Abs(alpha - 90),
                        //         Math.Abs(alpha - 135),
                        //         Math.Abs(alpha - 180),
                        //         Math.Abs(alpha + 135),
                        //         Math.Abs(alpha + 90),
                        //         Math.Abs(alpha + 45)
                        //     };
                        //     var x = temp.Min();
                        //
                        //     int i = 0;
                        //     foreach (var d in temp)
                        //     {
                        //         if (d == x)
                        //             break;
                        //         i++;
                        //     }
                        //
                        //
                        //     Point end = new Point();
                        //     // Vector v = v2.Rotate(x);
                        //     //
                        //     // g.DrawLine(Pen, v.Beg, v.End);
                        //
                        //     switch (i) //todo: 
                        //     {
                        //         case 0:
                        //             end = Angle.GetPointByDeg(Beg, End, 360);
                        //             break;
                        //         case 1:
                        //             end = Angle.GetPointByDeg(Beg, End, 315);
                        //             break;
                        //         case 2:
                        //             end = Angle.GetPointByDeg(Beg, End, 270);
                        //             break;
                        //         case 3:
                        //             end = Angle.GetPointByDeg(Beg, End, 225); //wrong
                        //             break;
                        //         case 4:
                        //             end = Angle.GetPointByDeg(Beg, End, 180);
                        //             break;
                        //         case 5:
                        //             end = Angle.GetPointByDeg(Beg, End, 135);
                        //             break;
                        //         case 6:
                        //             end = Angle.GetPointByDeg(Beg, End, 90);
                        //             break;
                        //         case 7:
                        //             end = Angle.GetPointByDeg(Beg, End, 45); //wrong
                        //             break;
                        //     }
                        //
                        //     g.DrawLine(new Pen(Color.Red), v1.Beg, v1.End);
                        //     g.DrawLine(new Pen(Color.Red), v2.Beg, v2.End);
                        //     g.DrawLine(Pen, Beg, end);
                        // }
                    }
                    else
                        g.DrawLine(Pen, Beg, End);

                    //_buffer.Add(new Line(drawPanel.Size, _clickLoc, _mouseLoc));
                    break;
            }
        }

        public void Preview(Graphics g, bool isShift)
        {
            BufferedGraphics bg = BufferedGraphicsManager.Current.Allocate(g, Rectangle.Round(g.VisibleClipBounds));
            bg.Graphics.DrawImage(_img, 0, 0);
            Paint(bg.Graphics, isShift);
            bg.Render(g);
            bg.Dispose();
        }

        public void PaintVoid(bool isShift)
        {
            Graphics g = Graphics.FromImage(_img);
            Paint(g,isShift);
        }

        public void Show(Graphics g)
        {
            g.DrawImage(_img, 0, 0);
            //this.Curve.Clear();
        }

        public void Clear()
        {
            this._graphics.Dispose();
            this._img.Dispose();
        }
    }
}