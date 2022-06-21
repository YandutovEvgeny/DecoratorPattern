using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureDecorator
{
    class GlassDecorator : Picture
    {
        Picture picture;

        public GlassDecorator(Picture picture) : base(picture.graphics, picture.picturePath)
        {
            this.picture = picture;
            picture.Draw();
            picture.graphics.DrawImage
                (Image.FromFile("C:\\Users\\Admin\\Figures\\steklo3.png"), 0, 0, 500, 400);
        }
    }
}