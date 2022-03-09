using System.Drawing;
using System.Windows.Forms;

namespace paintTry3
{
    public class SaveOpenManager
    {
        private Bitmap _img;
        private Painter _painter;

        public Image Image
        {
            get => this._img;
        }

        public Painter Painter
        {
            get => this._painter;
        }

        public SaveOpenManager(Painter painter)
        {
            this._painter = painter;
            this._img = painter.Image;
        }

        public bool Save()
        {
            if (!_painter.IsSaved)
                SaveAs();
            else
                this._img.Save(_painter.SavedPath);
            return true;
        }

        public bool SaveAs()
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "Image (*.jpg) | *.jpg  | Image (*.png) | *.png";
            dialog.ShowDialog();
            //dialog.FileName = "Sample.png";
            if (dialog.FileName == "") return false;
            this._img.Save(dialog.FileName);
            this._painter.IsSaved = true;
            this._painter.SavedPath = dialog.FileName;
            return true;
        }

        public bool Open(Size size)
        {
            Size oldSize = size;
            var dialog = new OpenFileDialog { Filter = "Image (*.jpg)|*.jpg|Image (*.png)|*.png" };
            dialog.ShowDialog();
            
            if (dialog.FileName == "") return false;
            this._painter.Clear();
            this._painter.Image = (Bitmap)Image.FromFile(dialog.FileName);
            this._painter.Size = oldSize;
            return true;
        }
    }
}