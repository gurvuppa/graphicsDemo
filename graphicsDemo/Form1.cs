using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphicsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Text = "Graphics Examples";

            Graphics g = this.CreateGraphics();
            Pen bluePen = new Pen(Color.Blue, 5);
            SolidBrush blueBrush = new SolidBrush(Color.MediumBlue);
            SolidBrush yellowBrush = new SolidBrush(Color.Gold);
            Font drawFont = new Font("IMPACT", 60, FontStyle.Bold);
            Font tmFont = new Font("Noto", 10, FontStyle.Bold);

            g.Clear(Color.White);

            g.DrawRectangle(bluePen, 30, 30, 300, 100);
            g.FillRectangle(blueBrush, 30, 30, 300, 100);

            g.DrawEllipse(bluePen, 35, 35, 290, 90);
            g.FillEllipse(yellowBrush, 35, 35, 290, 90);

            g.DrawString("I", drawFont, blueBrush, 80, 33);
            g.DrawString("K", drawFont, blueBrush, 115, 33);
            g.DrawString("E", drawFont, blueBrush, 170, 33);
            g.DrawString("A", drawFont, blueBrush, 215, 33);

            g.TranslateTransform(290, 110);
            g.RotateTransform(-30);
            g.DrawString("T", tmFont, yellowBrush, 0, 0);

            g.TranslateTransform(7, 0);
            g.RotateTransform(0);
            g.DrawString("M", tmFont, yellowBrush, 0, 0);
        }
    }
}
