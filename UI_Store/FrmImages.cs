using DataAccess.Concrete;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Store
{
    public partial class FrmImages : Form
    {
        int i=1;
        public string[] filenames;
        public byte[] image1, image2, image3;
        
        public FrmImages()
        {
            InitializeComponent();
        }
        private void FrmImages_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromStream(Alternating(i).ConMemoryStream());
            //this.pictureBox1.MouseWheel += PictureBox1_MouseWheel;
        }

        private void PictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            //if (e.Delta > 0)
            //{                
            //    pictureBox1.Width = pictureBox1.Width + 50;
            //    pictureBox1.Height = pictureBox1.Height + 50;   
                
            //    this.Width = pictureBox1.Width + 50;
            //    this.Width = pictureBox1.Height + 50;
            //}
            //else
            //{
            //    pictureBox1.Width = pictureBox1.Width - 50;
            //    pictureBox1.Height = pictureBox1.Height - 50;
            //}
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            i++;
            //pictureBox1.Image.Dispose();
            if (Alternating(i) != null)
            {               
                pictureBox1.Image = Image.FromStream(Alternating(i).ConMemoryStream());
                if (i == 3)
                {
                    i = 0;
                }
            }
            else
            {
                i = 1;
                pictureBox1.Image = Image.FromStream(Alternating(i).ConMemoryStream());
            }                        
        }

        byte[] Alternating(int j)
        {
            if (j == 1)
            {
                if (image1 == null)
                {
                    return null;
                }
                return image1;
            }else if (j == 2)
            {
                if (image2 == null)
                {
                    return null;
                }
                return image2;
            }
            else
            {
                if (image3 == null)
                {
                    return null;
                }
                return image3;
            }

        }
    }
}
