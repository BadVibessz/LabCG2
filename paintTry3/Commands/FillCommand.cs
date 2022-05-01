using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Input;

namespace paintTry3
{
    public class FillCommand : ICommand
    {
        public Bitmap _bitmap;
        private Point _mousLoc;
        private Color _color;
        
        
        public FillCommand(Point mousLoc, Bitmap bitmap, Color color)
        {
            this._bitmap = bitmap;
            this._mousLoc = mousLoc;
            this._color = color;
        }
        
        
        public bool CanExecute(object parameter)
        {
            return true;
        }

        
        public void Execute(object parameter)
        {
            Color oldColor = this._bitmap.GetPixel(_mousLoc.X, _mousLoc.Y);
            
            if(oldColor == _color) return;
            
            Stack<Point> pixels = new Stack<Point>(4);
            pixels.Push(_mousLoc);
            
            while (pixels.Count > 0)
            {
                Point p = pixels.Pop();

                // foreach (var i in pixels)
                // {
                //     if(_bitmap.GetPixel(i.X,i.Y) == _color)
                //         pixels.
                // }

                if (p.X > 0 && p.X < _bitmap.Width && p.Y > 0 && p.Y < _bitmap.Height)
                    if (_bitmap.GetPixel(p.X, p.Y) == oldColor)
                    {
                        _bitmap.SetPixel(p.X,p.Y, _color);
                        pixels.Push(new Point(p.X - 1, p.Y)); //validate?
                        pixels.Push(new Point(p.X + 1, p.Y));
                        pixels.Push(new Point(p.X, p.Y - 1));
                        pixels.Push(new Point(p.X, p.Y + 1));
                    }
            }

        }

        public event EventHandler CanExecuteChanged;
    }
}