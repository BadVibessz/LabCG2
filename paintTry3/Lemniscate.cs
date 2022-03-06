using System;
using System.Drawing;

namespace paintTry3
{
    public class Lemniscate
    {
        private float _a = 100;
        public Point Origin;
        public PointF Beg, End;


        private double p(double phi) //p=a*sqrt(cos(2*phi))
        {
            return _a * Math.Sqrt(Math.Cos(2 * phi));
        }

        public void Draw(Graphics g)
        {
            // for(double phi=0.1; phi<2*Math.PI; phi+=0.0002)
            //     try
            //     {
            //         
            //         Beg = new PointF(Origin.X + (float)(p(phi) * Math.Cos(phi)),
            //             Origin.Y - (float)(p(phi) * Math.Sin(phi)));
            //         
            //         g.DrawLine(Pens.Black, Beg, End);
            //         
            //         End = Beg;
            //     }
            // finally{}


            double phi = 0.1;
            Beg = new PointF(Origin.X + (float)(p(phi) * Math.Cos(phi)),
                Origin.Y - (float)(p(phi) * Math.Sin(phi)));
            g.DrawLine(Pens.Black, Beg, End);

            End = Beg;
        }
    }
}