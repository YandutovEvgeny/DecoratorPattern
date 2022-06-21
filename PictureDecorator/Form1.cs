using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureDecorator
{
    public partial class Form1 : Form
    {
        Picture picture;
        public Form1()
        {
            InitializeComponent();
            picture = new Picture
                (pictureBox1.CreateGraphics(), "C:\\Users\\Admin\\Figures\\bird.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            picture.Draw();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            picture = new FrameDecorator(picture);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            picture = new GlassDecorator(picture);
        }
    }
}
