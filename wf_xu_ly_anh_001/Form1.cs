using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_xu_ly_anh_001
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        public Form1()
        {
            InitializeComponent();
        }
        // Buoc 3b
        unsafe
        private void btn001_Click(object sender, EventArgs e)
        {
            // Buoc 2
            BitmapData bmData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, bitmap.PixelFormat); // LockBit de Program khac khon try cap

            // Buoc 3
            // Buoc 3a
            int offset = bmData.Stride - bitmap.Width * 3;

            byte* p = (byte*)bmData.Scan0;

            // Buoc 4
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    int a = p[0];
                    int b = p[1];
                    int c = p[2];

                    int t = (p[0] + p[1] + p[2]) / 3;
                    p[0] = (byte)t;
                    p[1] = (byte)t;
                    p[2] = (byte)t;

                    p += 3;
                }
                p += offset;
            }

            // Buoc 5
            bitmap.UnlockBits(bmData);
            pictureBox1.Image = bitmap;

            // Buoc 3
            // Buoc 3
            // Buoc 3
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Buoc 1
                bitmap = new Bitmap(open.FileName);
                pictureBox1.Image = bitmap;
            }
        }
    }
}
