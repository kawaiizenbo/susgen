using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace susgen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            SolidBrush bgbrush = new SolidBrush(Color.Black);
            SolidBrush imposter = new SolidBrush(RandomColor(Color.Red));
            SolidBrush sussy = new SolidBrush(Color.Cyan);

            // background
            RectangleF bg = new Rectangle(0, 0, 300, 300);

            // body
            RectangleF r1 = new Rectangle(30, 50, 120, 100);
            RectangleF r2 = new Rectangle(115, 150, 35, 50);
            RectangleF r3 = new Rectangle(50, 150, 35, 50);

            RectangleF e1 = new Rectangle(50, 0, 100, 100);

            // visor
            RectangleF vr1 = new Rectangle(105, 35, 35, 35);

            RectangleF ve2 = new Rectangle(85, 35, 35, 35);
            RectangleF ve3 = new Rectangle(125, 35, 35, 35);


            //draw them
            g.FillRectangle(bgbrush, bg);

            g.FillRectangle(imposter, r1);
            g.FillRectangle(imposter, r2);
            g.FillRectangle(imposter, r3);
            g.FillEllipse(imposter, e1);

            g.FillRectangle(sussy, vr1);
            g.FillEllipse(sussy, ve2);
            g.FillEllipse(sussy, ve3);
        }

        private Color RandomColor(Color preferred)
        {
            Random r = new Random();

            List<Color> colorlist = new List<Color>();
            colorlist.Add(Color.Red);
            colorlist.Add(Color.Blue);
            colorlist.Add(Color.Green);
            colorlist.Add(Color.Yellow);
            colorlist.Add(Color.Orange);
            colorlist.Add(Color.Purple);
            colorlist.Add(Color.DarkCyan);
            colorlist.Add(Color.Pink);
            colorlist.Add(Color.DarkGray);
            colorlist.Add(Color.White);
            colorlist.Add(preferred);
            colorlist.Add(preferred);
            colorlist.Add(preferred);
            colorlist.Add(preferred);
            colorlist.Add(preferred);

            return colorlist[r.Next(0, colorlist.Count)];
        }
    }
}
