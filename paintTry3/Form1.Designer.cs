using System;
using System.Drawing;
using System.Windows.Forms;

namespace paintTry3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pencilBtn = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.blackBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.whiteBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ocridBtn = new System.Windows.Forms.Button();
            this.colorDialogBtn = new System.Windows.Forms.Button();
            this.purrpBtn = new System.Windows.Forms.Button();
            this.darkBlueBtn = new System.Windows.Forms.Button();
            this.lightBlueBtn = new System.Windows.Forms.Button();
            this.greenBtn = new System.Windows.Forms.Button();
            this.yellowBtn = new System.Windows.Forms.Button();
            this.darkOrangeBtn = new System.Windows.Forms.Button();
            this.orangeRedBtn = new System.Windows.Forms.Button();
            this.darkRedBtn = new System.Windows.Forms.Button();
            this.grayBtn = new System.Windows.Forms.Button();
            this.backColBtn = new System.Windows.Forms.Button();
            this.foreColBtn = new System.Windows.Forms.Button();
            this.eraseBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rhombusBtn = new System.Windows.Forms.Button();
            this.arrowBtn = new System.Windows.Forms.Button();
            this.lineBtn = new System.Windows.Forms.Button();
            this.rectBtn = new System.Windows.Forms.Button();
            this.ellipseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pipetteBtn = new System.Windows.Forms.Button();
            this.textBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.foreBackColPanel = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.foreBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.clearBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.foreBackColPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(175, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 1080);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // pencilBtn
            // 
            this.pencilBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pencilBtn.BackgroundImage")));
            this.pencilBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pencilBtn.FlatAppearance.BorderSize = 0;
            this.pencilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pencilBtn.Location = new System.Drawing.Point(15, 37);
            this.pencilBtn.Name = "pencilBtn";
            this.pencilBtn.Size = new System.Drawing.Size(26, 29);
            this.pencilBtn.TabIndex = 1;
            this.pencilBtn.UseVisualStyleBackColor = true;
            this.pencilBtn.Click += new System.EventHandler(this.pencilBtn_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(11, 113);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(145, 56);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // blackBtn
            // 
            this.blackBtn.BackColor = System.Drawing.Color.Black;
            this.blackBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.blackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blackBtn.ForeColor = System.Drawing.Color.Red;
            this.blackBtn.Location = new System.Drawing.Point(0, 72);
            this.blackBtn.Name = "blackBtn";
            this.blackBtn.Size = new System.Drawing.Size(30, 30);
            this.blackBtn.TabIndex = 7;
            this.blackBtn.UseVisualStyleBackColor = false;
            this.blackBtn.Click += new System.EventHandler(this.blackBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.whiteBtn);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.ocridBtn);
            this.panel2.Controls.Add(this.colorDialogBtn);
            this.panel2.Controls.Add(this.purrpBtn);
            this.panel2.Controls.Add(this.darkBlueBtn);
            this.panel2.Controls.Add(this.lightBlueBtn);
            this.panel2.Controls.Add(this.greenBtn);
            this.panel2.Controls.Add(this.yellowBtn);
            this.panel2.Controls.Add(this.darkOrangeBtn);
            this.panel2.Controls.Add(this.orangeRedBtn);
            this.panel2.Controls.Add(this.darkRedBtn);
            this.panel2.Controls.Add(this.grayBtn);
            this.panel2.Controls.Add(this.blackBtn);
            this.panel2.Location = new System.Drawing.Point(0, 402);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(1);
            this.panel2.Size = new System.Drawing.Size(175, 139);
            this.panel2.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.PaleGreen;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(72, 108);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 30);
            this.button5.TabIndex = 29;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.blackBtn_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DeepPink;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(36, 108);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 30);
            this.button4.TabIndex = 28;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.blackBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Cyan;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(0, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 27;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.blackBtn_Click);
            // 
            // whiteBtn
            // 
            this.whiteBtn.BackColor = System.Drawing.Color.White;
            this.whiteBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.whiteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.whiteBtn.ForeColor = System.Drawing.Color.Red;
            this.whiteBtn.Location = new System.Drawing.Point(72, 72);
            this.whiteBtn.Name = "whiteBtn";
            this.whiteBtn.Size = new System.Drawing.Size(30, 30);
            this.whiteBtn.TabIndex = 26;
            this.whiteBtn.UseVisualStyleBackColor = false;
            this.whiteBtn.Click += new System.EventHandler(this.blackBtn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(36, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 30);
            this.button3.TabIndex = 25;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.blackBtn_Click);
            // 
            // ocridBtn
            // 
            this.ocridBtn.BackColor = System.Drawing.Color.MediumOrchid;
            this.ocridBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ocridBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ocridBtn.ForeColor = System.Drawing.Color.Red;
            this.ocridBtn.Location = new System.Drawing.Point(0, 0);
            this.ocridBtn.Name = "ocridBtn";
            this.ocridBtn.Size = new System.Drawing.Size(30, 30);
            this.ocridBtn.TabIndex = 24;
            this.ocridBtn.UseVisualStyleBackColor = false;
            this.ocridBtn.Click += new System.EventHandler(this.blackBtn_Click);
            // 
            // colorDialogBtn
            // 
            this.colorDialogBtn.BackColor = System.Drawing.Color.Transparent;
            this.colorDialogBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("colorDialogBtn.BackgroundImage")));
            this.colorDialogBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.colorDialogBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.colorDialogBtn.FlatAppearance.BorderSize = 0;
            this.colorDialogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorDialogBtn.ForeColor = System.Drawing.Color.Red;
            this.colorDialogBtn.Location = new System.Drawing.Point(108, 72);
            this.colorDialogBtn.Name = "colorDialogBtn";
            this.colorDialogBtn.Size = new System.Drawing.Size(63, 63);
            this.colorDialogBtn.TabIndex = 23;
            this.colorDialogBtn.UseVisualStyleBackColor = false;
            this.colorDialogBtn.Click += new System.EventHandler(this.colorDialogBtn_Click);
            // 
            // purrpBtn
            // 
            this.purrpBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.purrpBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.purrpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purrpBtn.ForeColor = System.Drawing.Color.Red;
            this.purrpBtn.Location = new System.Drawing.Point(144, 36);
            this.purrpBtn.Name = "purrpBtn";
            this.purrpBtn.Size = new System.Drawing.Size(30, 30);
            this.purrpBtn.TabIndex = 16;
            this.purrpBtn.UseVisualStyleBackColor = false;
            this.purrpBtn.Click += new System.EventHandler(this.blackBtn_Click);
            // 
            // darkBlueBtn
            // 
            this.darkBlueBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.darkBlueBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.darkBlueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.darkBlueBtn.ForeColor = System.Drawing.Color.Red;
            this.darkBlueBtn.Location = new System.Drawing.Point(108, 36);
            this.darkBlueBtn.Name = "darkBlueBtn";
            this.darkBlueBtn.Size = new System.Drawing.Size(30, 30);
            this.darkBlueBtn.TabIndex = 15;
            this.darkBlueBtn.UseVisualStyleBackColor = false;
            this.darkBlueBtn.Click += new System.EventHandler(this.blackBtn_Click);
            // 
            // lightBlueBtn
            // 
            this.lightBlueBtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lightBlueBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.lightBlueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lightBlueBtn.ForeColor = System.Drawing.Color.Red;
            this.lightBlueBtn.Location = new System.Drawing.Point(72, 36);
            this.lightBlueBtn.Name = "lightBlueBtn";
            this.lightBlueBtn.Size = new System.Drawing.Size(30, 30);
            this.lightBlueBtn.TabIndex = 14;
            this.lightBlueBtn.UseVisualStyleBackColor = false;
            this.lightBlueBtn.Click += new System.EventHandler(this.blackBtn_Click);
            // 
            // greenBtn
            // 
            this.greenBtn.BackColor = System.Drawing.Color.GreenYellow;
            this.greenBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.greenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greenBtn.ForeColor = System.Drawing.Color.Red;
            this.greenBtn.Location = new System.Drawing.Point(36, 36);
            this.greenBtn.Name = "greenBtn";
            this.greenBtn.Size = new System.Drawing.Size(30, 30);
            this.greenBtn.TabIndex = 13;
            this.greenBtn.UseVisualStyleBackColor = false;
            this.greenBtn.Click += new System.EventHandler(this.blackBtn_Click);
            // 
            // yellowBtn
            // 
            this.yellowBtn.BackColor = System.Drawing.Color.Gold;
            this.yellowBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.yellowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yellowBtn.ForeColor = System.Drawing.Color.Red;
            this.yellowBtn.Location = new System.Drawing.Point(0, 36);
            this.yellowBtn.Name = "yellowBtn";
            this.yellowBtn.Size = new System.Drawing.Size(30, 30);
            this.yellowBtn.TabIndex = 12;
            this.yellowBtn.UseVisualStyleBackColor = false;
            this.yellowBtn.Click += new System.EventHandler(this.blackBtn_Click);
            // 
            // darkOrangeBtn
            // 
            this.darkOrangeBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.darkOrangeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.darkOrangeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.darkOrangeBtn.ForeColor = System.Drawing.Color.Red;
            this.darkOrangeBtn.Location = new System.Drawing.Point(144, 0);
            this.darkOrangeBtn.Name = "darkOrangeBtn";
            this.darkOrangeBtn.Size = new System.Drawing.Size(30, 30);
            this.darkOrangeBtn.TabIndex = 11;
            this.darkOrangeBtn.UseVisualStyleBackColor = false;
            this.darkOrangeBtn.Click += new System.EventHandler(this.blackBtn_Click);
            // 
            // orangeRedBtn
            // 
            this.orangeRedBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.orangeRedBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.orangeRedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orangeRedBtn.ForeColor = System.Drawing.Color.Red;
            this.orangeRedBtn.Location = new System.Drawing.Point(108, 0);
            this.orangeRedBtn.Name = "orangeRedBtn";
            this.orangeRedBtn.Size = new System.Drawing.Size(30, 30);
            this.orangeRedBtn.TabIndex = 10;
            this.orangeRedBtn.UseVisualStyleBackColor = false;
            this.orangeRedBtn.Click += new System.EventHandler(this.blackBtn_Click);
            // 
            // darkRedBtn
            // 
            this.darkRedBtn.BackColor = System.Drawing.Color.DarkRed;
            this.darkRedBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.darkRedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.darkRedBtn.ForeColor = System.Drawing.Color.Red;
            this.darkRedBtn.Location = new System.Drawing.Point(72, 0);
            this.darkRedBtn.Name = "darkRedBtn";
            this.darkRedBtn.Size = new System.Drawing.Size(30, 30);
            this.darkRedBtn.TabIndex = 9;
            this.darkRedBtn.UseVisualStyleBackColor = false;
            this.darkRedBtn.Click += new System.EventHandler(this.blackBtn_Click);
            // 
            // grayBtn
            // 
            this.grayBtn.BackColor = System.Drawing.Color.Gray;
            this.grayBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.grayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grayBtn.ForeColor = System.Drawing.Color.Red;
            this.grayBtn.Location = new System.Drawing.Point(36, 72);
            this.grayBtn.Name = "grayBtn";
            this.grayBtn.Size = new System.Drawing.Size(30, 30);
            this.grayBtn.TabIndex = 8;
            this.grayBtn.UseVisualStyleBackColor = false;
            this.grayBtn.Click += new System.EventHandler(this.blackBtn_Click);
            // 
            // backColBtn
            // 
            this.backColBtn.FlatAppearance.BorderSize = 0;
            this.backColBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backColBtn.Location = new System.Drawing.Point(53, 153);
            this.backColBtn.Name = "backColBtn";
            this.backColBtn.Size = new System.Drawing.Size(31, 27);
            this.backColBtn.TabIndex = 8;
            this.backColBtn.UseVisualStyleBackColor = true;
            // 
            // foreColBtn
            // 
            this.foreColBtn.FlatAppearance.BorderSize = 0;
            this.foreColBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.foreColBtn.Location = new System.Drawing.Point(15, 153);
            this.foreColBtn.Name = "foreColBtn";
            this.foreColBtn.Size = new System.Drawing.Size(31, 27);
            this.foreColBtn.TabIndex = 7;
            this.foreColBtn.UseVisualStyleBackColor = true;
            // 
            // eraseBtn
            // 
            this.eraseBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eraseBtn.BackgroundImage")));
            this.eraseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eraseBtn.FlatAppearance.BorderSize = 0;
            this.eraseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eraseBtn.Location = new System.Drawing.Point(50, 37);
            this.eraseBtn.Name = "eraseBtn";
            this.eraseBtn.Size = new System.Drawing.Size(26, 29);
            this.eraseBtn.TabIndex = 10;
            this.eraseBtn.UseVisualStyleBackColor = true;
            this.eraseBtn.Click += new System.EventHandler(this.eraseBtn_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.rhombusBtn);
            this.panel3.Controls.Add(this.arrowBtn);
            this.panel3.Controls.Add(this.lineBtn);
            this.panel3.Controls.Add(this.rectBtn);
            this.panel3.Controls.Add(this.ellipseBtn);
            this.panel3.Location = new System.Drawing.Point(8, 186);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(148, 74);
            this.panel3.TabIndex = 11;
            // 
            // rhombusBtn
            // 
            this.rhombusBtn.BackColor = System.Drawing.Color.Transparent;
            this.rhombusBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rhombusBtn.BackgroundImage")));
            this.rhombusBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rhombusBtn.FlatAppearance.BorderSize = 0;
            this.rhombusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rhombusBtn.Location = new System.Drawing.Point(3, 39);
            this.rhombusBtn.Name = "rhombusBtn";
            this.rhombusBtn.Size = new System.Drawing.Size(32, 35);
            this.rhombusBtn.TabIndex = 4;
            this.rhombusBtn.UseVisualStyleBackColor = false;
            this.rhombusBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // arrowBtn
            // 
            this.arrowBtn.BackColor = System.Drawing.Color.Transparent;
            this.arrowBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("arrowBtn.BackgroundImage")));
            this.arrowBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.arrowBtn.FlatAppearance.BorderSize = 0;
            this.arrowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arrowBtn.Location = new System.Drawing.Point(113, 3);
            this.arrowBtn.Name = "arrowBtn";
            this.arrowBtn.Size = new System.Drawing.Size(32, 35);
            this.arrowBtn.TabIndex = 3;
            this.arrowBtn.UseVisualStyleBackColor = false;
            this.arrowBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // lineBtn
            // 
            this.lineBtn.BackColor = System.Drawing.Color.Transparent;
            this.lineBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lineBtn.BackgroundImage")));
            this.lineBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lineBtn.FlatAppearance.BorderSize = 0;
            this.lineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lineBtn.Location = new System.Drawing.Point(76, 3);
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.Size = new System.Drawing.Size(32, 35);
            this.lineBtn.TabIndex = 2;
            this.lineBtn.UseVisualStyleBackColor = false;
            this.lineBtn.Click += new System.EventHandler(this.lineBtn_Click_1);
            // 
            // rectBtn
            // 
            this.rectBtn.BackColor = System.Drawing.Color.Transparent;
            this.rectBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rectBtn.BackgroundImage")));
            this.rectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rectBtn.FlatAppearance.BorderSize = 0;
            this.rectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectBtn.Location = new System.Drawing.Point(38, 3);
            this.rectBtn.Name = "rectBtn";
            this.rectBtn.Size = new System.Drawing.Size(32, 35);
            this.rectBtn.TabIndex = 1;
            this.rectBtn.UseVisualStyleBackColor = false;
            this.rectBtn.Click += new System.EventHandler(this.rectBtn_Click_1);
            // 
            // ellipseBtn
            // 
            this.ellipseBtn.BackColor = System.Drawing.Color.Transparent;
            this.ellipseBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ellipseBtn.BackgroundImage")));
            this.ellipseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ellipseBtn.FlatAppearance.BorderSize = 0;
            this.ellipseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ellipseBtn.Location = new System.Drawing.Point(3, 3);
            this.ellipseBtn.Name = "ellipseBtn";
            this.ellipseBtn.Size = new System.Drawing.Size(32, 35);
            this.ellipseBtn.TabIndex = 0;
            this.ellipseBtn.UseVisualStyleBackColor = false;
            this.ellipseBtn.Click += new System.EventHandler(this.ellipseBtn_Click);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(21, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Инструменты";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pipetteBtn
            // 
            this.pipetteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pipetteBtn.BackgroundImage")));
            this.pipetteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pipetteBtn.FlatAppearance.BorderSize = 0;
            this.pipetteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pipetteBtn.Location = new System.Drawing.Point(88, 37);
            this.pipetteBtn.Name = "pipetteBtn";
            this.pipetteBtn.Size = new System.Drawing.Size(32, 29);
            this.pipetteBtn.TabIndex = 13;
            this.pipetteBtn.UseVisualStyleBackColor = true;
            this.pipetteBtn.Click += new System.EventHandler(this.pippetBtn_Click);
            // 
            // textBtn
            // 
            this.textBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBtn.BackgroundImage")));
            this.textBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.textBtn.FlatAppearance.BorderSize = 0;
            this.textBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textBtn.Location = new System.Drawing.Point(126, 37);
            this.textBtn.Name = "textBtn";
            this.textBtn.Size = new System.Drawing.Size(32, 29);
            this.textBtn.TabIndex = 14;
            this.textBtn.UseVisualStyleBackColor = true;
            this.textBtn.Click += new System.EventHandler(this.textBtn_Click);
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(1, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 30);
            this.label2.TabIndex = 15;
            this.label2.Text = "Толщина";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(15, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Фигуры";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // foreBackColPanel
            // 
            this.foreBackColPanel.Controls.Add(this.backBtn);
            this.foreBackColPanel.Controls.Add(this.foreBtn);
            this.foreBackColPanel.Location = new System.Drawing.Point(18, 296);
            this.foreBackColPanel.Name = "foreBackColPanel";
            this.foreBackColPanel.Size = new System.Drawing.Size(129, 47);
            this.foreBackColPanel.TabIndex = 17;
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(76, 0);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(50, 47);
            this.backBtn.TabIndex = 1;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // foreBtn
            // 
            this.foreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.foreBtn.Location = new System.Drawing.Point(0, 0);
            this.foreBtn.Name = "foreBtn";
            this.foreBtn.Size = new System.Drawing.Size(52, 47);
            this.foreBtn.TabIndex = 0;
            this.foreBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(15, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 27);
            this.label4.TabIndex = 18;
            this.label4.Text = "Цвет 1";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(88, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 27);
            this.label5.TabIndex = 19;
            this.label5.Text = "Цвет 2";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(32, 19);
            this.toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.открытьToolStripMenuItem, this.сохранитьToolStripMenuItem, this.сохранитьКакToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1902, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.сохранитьToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBox1.Location = new System.Drawing.Point(181, 45);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(135, 20);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Залить фигуру";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Transparent;
            this.clearBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clearBtn.BackgroundImage")));
            this.clearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Location = new System.Drawing.Point(322, 36);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(37, 29);
            this.clearBtn.TabIndex = 22;
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.foreBackColPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.textBtn);
            this.Controls.Add(this.pipetteBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.eraseBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pencilBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(15, 15);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.foreBackColPanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button rhombusBtn;

        private System.Windows.Forms.Button clearBtn;

        private System.Windows.Forms.CheckBox checkBox1;

        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;

        private System.Windows.Forms.Button whiteBtn;

        private System.Windows.Forms.Button ocridBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.Button colorDialogBtn;

        private System.Windows.Forms.Button purrpBtn;

        private System.Windows.Forms.Button darkBlueBtn;

        private System.Windows.Forms.Button lightBlueBtn;

        private System.Windows.Forms.Button greenBtn;

        private System.Windows.Forms.Button yellowBtn;

        private System.Windows.Forms.Button darkOrangeBtn;

        private System.Windows.Forms.Button grayBtn;
        private System.Windows.Forms.Button darkRedBtn;
        private System.Windows.Forms.Button orangeRedBtn;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Button backBtn;

        private System.Windows.Forms.Button foreBtn;

        private System.Windows.Forms.Panel foreBackColPanel;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button arrowBtn;

        private System.Windows.Forms.Button textBtn;

        private System.Windows.Forms.Button pipetteBtn;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button lineBtn;

        private System.Windows.Forms.Button rectBtn;

        private System.Windows.Forms.Button ellipseBtn;

        private System.Windows.Forms.Panel panel3;

        private System.Windows.Forms.Button eraseBtn;

        // private System.Windows.Forms.Button eraseBtn;

       // private System.Windows.Forms.Button eraseBtn;

       private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button pencilBtn;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button blackBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button backColBtn;
        private System.Windows.Forms.Button foreColBtn;

        #endregion
    }
}