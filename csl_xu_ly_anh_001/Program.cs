using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csl_xu_ly_anh_001
{
    class Program
    {
        static void Main(string[] args)
        {
            // B1
            Image img = Image.FromFile(@"G:\K-2-2019-2020\MyTool\img-green-jpeg.jpg");

            // B2
            Graphics g = Graphics.FromImage(img);

            // B3
            // Place sub-img
            g.DrawImage(Image.FromFile(@"G:\K-2-2019-2020\MyTool\a-1.png"), new Point(10, 10));

            // B4
            img.Save(@"G:\K-2-2019-2020\MyTool\a-2.jpg", ImageFormat.Jpeg);

        }
    }
}
