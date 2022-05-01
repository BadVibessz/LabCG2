using System.Collections.Generic;
using System.Drawing;

namespace paintTry3
{
    public class Rhombus
    {
        private List<Point> _points;
        
        public Rhombus(Point origin, int width, int height)
        {
            this._points = new List<Point>
            {
                origin,
                new Point(origin.X + width / 2, origin.Y - height / 2),
                new Point(origin.X + width, origin.Y),
                new Point(origin.X + width / 2, origin.Y + height / 2)
            };
        }

        public void Draw(Graphics g, Pen pen)
        {
            g.DrawPolygon(pen, this._points.ToArray());
        }

        public void Fill(Graphics g, Pen pen)
        {
            g.FillPolygon(new SolidBrush(pen.Color), _points.ToArray());
        }
    }
}