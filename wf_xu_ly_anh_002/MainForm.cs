using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_xu_ly_anh_002
{
    public partial class MainForm : Form
    {
        int a = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void pnTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMainIMG_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDg = new FolderBrowserDialog();
            folderBrowserDg.SelectedPath = Settings1.Default.MainFolderPath;
            if (folderBrowserDg.ShowDialog() == DialogResult.OK)
            {
                txtMainIMG.Text = folderBrowserDg.SelectedPath;
            }
        }

        private void btnSubIMG_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDg = new FolderBrowserDialog();
            folderBrowserDg.SelectedPath = Settings1.Default.SubFolderPath;
            if (folderBrowserDg.ShowDialog() == DialogResult.OK)
            {
                txtSubIMG.Text = folderBrowserDg.SelectedPath;
            }
        }

        private void btnResultIMG_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDg = new FolderBrowserDialog();
            folderBrowserDg.SelectedPath = Settings1.Default.ResultFolderPath;
            if (folderBrowserDg.ShowDialog() == DialogResult.OK)
            {
                txtResultIMG.Text = folderBrowserDg.SelectedPath;
            }
        }

        private void btnMergeIMG_Click(object sender, EventArgs e)
        {
            if (btnMergeIMG_Check())
            {
                Settings1.Default.MainFolderPath = txtMainIMG.Text;
                Settings1.Default.SubFolderPath = txtSubIMG.Text;
                Settings1.Default.ResultFolderPath = txtResultIMG.Text;
                Settings1.Default.Save();

                backgroundWorkerIMG.RunWorkerAsync();
                btnMergeIMG_GUIEnable(false);
            }
            else
            {
                MessageBox.Show("");
            }
        }

        private void btnMergeIMG_GUIEnable(bool v)
        {
            btnMainIMG.Enabled = v;
            btnSubIMG.Enabled = v;
            btnResultIMG.Enabled = v;
            btnMergeIMG.Enabled = v;
            txtMainIMG.Enabled = v;
            txtSubIMG.Enabled = v;
            txtResultIMG.Enabled = v;
            txtXpos.Enabled = v;
            txtYpos.Enabled = v;
            btnMergeIMG.Enabled = v;
            cbType.Enabled = v;
        }

        private bool btnMergeIMG_Check()
        {
            return false;
        }

        private void backgroundWorkerIMG_DoWork(object sender, DoWorkEventArgs e)
        {
            dosomething();
        }

        private void backgroundWorkerIMG_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            prbMergeIMG.Value = e.ProgressPercentage;
            Application.DoEvents();
        }

        private void backgroundWorkerIMG_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Hoàn thành tiến trình", "Tiến trình kết thức", MessageBoxButtons.OK, MessageBoxIcon.Information);
            prbMergeIMG.Value = 0;
            btnMergeIMG_GUIEnable(true);
            txtMainIMG.Text = "";
            txtSubIMG.Text = "";
            txtResultIMG.Text = "";
        }






        private void dosomething()
        {
            //for (int i = 0; i <= 100; i++)
            //{
            //    a += 1;
            //    Thread.Sleep(500);
            //    backgroundWorkerIMG.ReportProgress(i);
            //}

            List<string> mainFolder;
            List<string> subFolder;
            string resultFolder;

            mainFolder = Directory.GetFiles(txtMainIMG.Text).ToList();
            subFolder = Directory.GetFiles(txtSubIMG.Text).ToList();
            resultFolder = txtResultIMG.Text;

            int xPos = Int32.Parse(txtXpos.Text);
            int yPos = Int32.Parse(txtYpos.Text);

            //int i, j;
            int minMainSub = Math.Min(mainFolder.Count, subFolder.Count);
            for (int i = 0,j = 0; i < minMainSub && j < minMainSub; i++, j++)
            {
                //// B1
                //Image img = Image.FromFile(mainFolder.ElementAt(i));

                //// B2
                //Graphics g = Graphics.FromImage(img);

                //// B3
                //// Place sub-img
                //g.DrawImage(Image.FromFile(subFolder.ElementAt(j)), new Point(xPos, yPos));

                //// B4
                //int type = cbType.SelectedIndex;
                //ImageFormat imgFormat;
                //switch (type)
                //{
                //    case 1:
                //        imgFormat = ImageFormat.Png;
                //        break;
                //    case 2:
                //        imgFormat = ImageFormat.Jpeg;
                //        break;
                //    default:
                //        imgFormat = ImageFormat.Png;
                //        break;
                //}
                //Directory.CreateDirectory(resultFolder);
                //string ResultFileName = Path.GetFileName(mainFolder.ElementAt(i)) + "_" + Path.GetFileName(subFolder.ElementAt(i));
                //img.Save(resultFolder + "\\" + ResultFileName, imgFormat);

                backgroundWorkerIMG.ReportProgress(i / minMainSub * 100);
            }
        }

        

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
