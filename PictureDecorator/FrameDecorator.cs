using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureDecorator
{
    class FrameDecorator : Picture
    {
        Picture picture;

        public FrameDecorator(Picture picture) : base(picture.graphics, picture.picturePath)
        {
            this.picture = picture;
            picture.Draw();
            picture.graphics.DrawImage(Image.FromFile("C:\\Users\\Admin\\Figures\\rama4.png"), 0, 0, 500, 400);
        }
    }
}
