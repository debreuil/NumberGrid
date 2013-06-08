using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DDW.Numberline
{
    public partial class Form1 : Form
    {
        private Numberline _numberline;
        public Numberline Numberline
        {
            get
            {
                return _numberline;
            }
            set
            {
                _numberline = value;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void ShowDefault()
        {
            Numberline.SetState(DisplayState.Full);
            Redraw();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Numberline.SetState(DisplayState.Full);
            Redraw();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Numberline.SetState(DisplayState.EvenOnly);
            Redraw();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Numberline.SetState(DisplayState.StepsFromEdge);
            Redraw();
        }
        
        private void buttonUniqeX_Click(object sender, EventArgs e)
        {
            Numberline.SetState(DisplayState.UniqueX);
            Redraw();
        }

        private void Redraw()
        {
            pictureBox1.Image = Numberline.Bitmap;
        }

        static int capIndex = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            Numberline.Bitmap.Save("capture" + capIndex++ + ".png");
        }

    }
}
