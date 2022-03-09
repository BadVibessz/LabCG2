using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace paintTry3
{
    public partial class Form1 : Form
    {
        private Painter _painter;
        private Size _oldFormlSize;
        private RedoUndoManager _rum; //todo: maybe store Image instead of Painter

        public Form1()
        {
            InitializeComponent();


            _painter = new Painter(this.panel1.Size);
            this._rum = new RedoUndoManager(_painter);
            this._oldFormlSize = this.Size;
            this.KeyPreview = true;
            this.foreBtn.BackColor = _painter.ForeColor;
            this.backBtn.BackColor = _painter.BackColor;
        }

        private void pencilBtn_Click(object sender, EventArgs e)
        {
            this._painter.State = "free";
        }

        private void rectBtn_Click(object sender, EventArgs e)
        {
            this._painter.State = "rectangle";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this._painter.Show(panel1.CreateGraphics());
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _painter.IsPainting = true;
            _painter.Beg = e.Location;
            this._painter.Curve.Add(e.Location);

            if (e.Button == MouseButtons.Left)
                _painter.Pen.Color = this._painter.ForeColor;
            if (e.Button == MouseButtons.Right)
                _painter.Pen.Color = this._painter.BackColor;

            if (_painter.State == "erase")
            {
                _painter.Pen.Color = this._painter.BackColor;
                _painter.Pen.Width = 25;
            }

            if (_painter.State == "text")
            {
                var tb = new TextBox() { Name = "textbox", Location = e.Location, };
                _painter.Text = tb.Text;
                this.panel1.Controls.Add(tb);
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_painter.IsPainting)
            {
                _painter.End = e.Location;

                if (_painter.State == "free" || _painter.State == "erase")
                    _painter.Curve.Add(e.Location);

                _painter.Preview(panel1.CreateGraphics());
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (_painter.IsPainting)
            {
                this._rum.Buffer.Add(this._painter.Image);
                
                _painter.PaintVoid();

                this._painter.Curve.Clear();
                _painter.End = e.Location;

                
            }

            _painter.IsPainting = false;

            if (_painter.State == "pipette")
            {
                Color c = _painter.Image.GetPixel(e.Location.X, e.Location.Y);
                this._painter.ForeColor = c;
                this.foreBtn.BackColor = c;
                _painter.State = "free";
            }

            panel1.Update();
        }

        private void EllipseBtn_Click(object sender, EventArgs e)
        {
            _painter.State = "ellipse";
        }

        private void lineBtn_Click(object sender, EventArgs e)
        {
            _painter.State = "line";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            _painter.Pen.Width = trackBar1.Value / 2;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Oemplus:
                    if (_painter.Pen.Width < 10)
                        this._painter.Pen.Width += (float)0.5;
                    break;

                case Keys.OemMinus:
                    if (_painter.Pen.Width > 1)
                        this._painter.Pen.Width -= (float)0.5;
                    break;

                case Keys.ShiftKey:
                    this._painter.IsShift = true;
                    break;
                case Keys.Alt:
                    this._painter.State = "pipette";
                    break;
                case Keys.Enter:
                    if (this._painter.State == "text")
                    {
                        _painter.Text = this.panel1.Controls[this.panel1.Controls.Count - 1].Text;
                        _painter.PaintVoid();
                        this.panel1.Controls.RemoveAt(panel1.Controls.Count - 1);
                        this._painter.State = "free";
                    }

                    break;
            }

            // CTRL
            if (e.Modifiers == Keys.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.Z:
                        this._rum.Painter = this._painter;
                        this._rum.Undo();
                        //this._painter.Image = this._rum.Buffer.ElementAt(_rum.Buffer.Count-1);
                        this.panel1.Refresh();
                        break;
                    case Keys.S:
                        new SaveOpenManager(this._painter).Save();
                        break;
                    case Keys.O:
                        new SaveOpenManager(this._painter).Open(this.panel1.Size);
                        break;
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
                this._painter.IsShift = false;
            if (e.KeyCode == Keys.Alt)
                this._painter.State = "free";
        }

        private void blackBtn_Click(object sender, EventArgs e)
        {
            if (_painter.IsBack)
            {
                this._painter.BackColor = ((Button)sender).BackColor;
                this.backBtn.BackColor = _painter.BackColor;
                this._painter.IsBack = false;
                return;
            }

            this._painter.ForeColor = ((Button)sender).BackColor;
            this.foreBtn.BackColor = _painter.ForeColor;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
        }

        private void arrowBtn_Click(object sender, EventArgs e)
        {
            this._painter.State = "arrow";
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            if (_painter == null)
                _painter = new Painter(this.panel1.Size);
            if (Size.Height < _oldFormlSize.Height || Size.Width < _oldFormlSize.Width)
                return;
            this._painter.Size = panel1.Size;
        }

        private void eraseBtn_Click_1(object sender, EventArgs e)
        {
            this._painter.State = "erase";
        }

        private void ellipseBtn_Click(object sender, EventArgs e)
        {
            this._painter.State = "ellipse";
        }


        private void rectBtn_Click_1(object sender, EventArgs e)
        {
            this._painter.State = "rectangle";
        }

        private void lineBtn_Click_1(object sender, EventArgs e)
        {
            this._painter.State = "line";
        }

        private void pippetBtn_Click(object sender, EventArgs e)
        {
            this._painter.State = "pipette";
        }


        private void textBtn_Click(object sender, EventArgs e)
        {
            this._painter.State = "text";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this._painter.State = "arrow";
        }


        private void backBtn_Click(object sender, EventArgs e)
        {
            this._painter.IsBack = true;
        }

        private void colorDialogBtn_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            c.ShowDialog();


            if (_painter.IsBack)
            {
                this._painter.BackColor = c.Color;
                this._painter.IsBack = false;
                this.backBtn.BackColor = this._painter.BackColor;
                return;
            }

            this._painter.ForeColor = c.Color;
            this.foreBtn.BackColor = this._painter.ForeColor;
        }


        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveOpenManager s = new SaveOpenManager(this._painter);
            s.Open(this.panel1.Size);
            this._painter.Image = s.Painter.Image;
            var img = this._painter.Image;

            int width = 0, height = 0;
            if (panel1.Size.Width < img.Size.Width)
                width = img.Size.Width;


            if (panel1.Size.Height < img.Size.Height)
                height = img.Size.Height;


            if (width != 0 || height != 0)
            {
                this.panel1.Size = img.Size;
                this._painter.Size = img.Size;
            }

            this.panel1.Refresh();
        }


        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SaveOpenManager(this._painter).Save();
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SaveOpenManager(this._painter).SaveAs();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this._painter.IsFillNeeded = checkBox1.Checked;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            this._painter.Clear();
            this._painter = new Painter(panel1.Size);
            this.panel1.Refresh();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _painter.State = "rhombus";
        }
    }
}