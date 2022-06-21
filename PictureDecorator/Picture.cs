using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureDecorator
{
    class Picture
    {
        public Graphics graphics;
        public string picturePath;

        public Picture(Graphics graphics, string picturePath)
        {
            this.graphics = graphics;
            this.picturePath = picturePath;
        }

        public void Draw()
        {
            graphics.DrawImage(Image.FromFile(picturePath), 0, 0, 500, 400);
        }
    }
}
