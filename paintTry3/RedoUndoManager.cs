using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace paintTry3
{
    public class RedoUndoManager
    {
        public List<Bitmap> Buffer = new List<Bitmap>();
        public List<int> Ids = new List<int>();
        private Painter _painter;

        public RedoUndoManager(Painter painter)
        {
            this._painter = painter;
            this.Buffer.Add(_painter.Image);
            this.Ids.Add(_painter.Image.GetHashCode());
        }

        public Painter Painter
        {
            get => this._painter;
            set
            {
                this._painter = value;
            }
        }


        public bool Undo()
        {
            this._painter.Image = Buffer.ElementAt(Buffer.Count-1);
            return true;
        }
        
    }
}