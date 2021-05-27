using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static WindowsFormsApp1.Properties.Resources;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public List<string> Images;
        public int Counter; 

        public Form1()
        {
            InitializeComponent();
        }

        //selecteer foto
        private void BtnSelectPicture_Click(object sender, EventArgs e)
        {
            if (ofdShowDialog.ShowDialog() != DialogResult.OK) return;
            var filePath = ofdShowDialog.FileName;
            var directoryPath = Path.GetDirectoryName(filePath);
            if (directoryPath != null)
                Images = Directory.GetFiles(directoryPath, "*.*", SearchOption.TopDirectoryOnly).ToList();
                
            picBoxShowPicture.Image = Image.FromFile(filePath);
            picBoxShowPicture.SizeMode = PictureBoxSizeMode.CenterImage;
            var i = Images.IndexOf(filePath);
            Counter = i;
        }

        //verwijder foto
        private void BtnRemovePicture_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(BtnRemovePictureDeleteMessage, BtnRemovePictureDeleteCaption,
                    MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            Images.RemoveAt(Counter);
            if (Counter >= Images.Count)
            {
                Counter--;
            }

            if (Counter < 0)
            {
                Counter = 0;
                Images = null;
            }
            if (Images != null)
            {

                picBoxShowPicture.Image = Image.FromFile(Images.ElementAt(Counter));
            }
        }

        //vorige foto functie
        private void BtnPreviousPicture_Click(object sender, EventArgs e)
        {
            if(Counter > 0)
            {
                Counter--;
                picBoxShowPicture.Image = Image.FromFile(Images.ElementAt(Counter));
            }
        }

        //volgende foto functiel    
        private void BtnNextPicture_Click(object sender, EventArgs e)
        {
            if (Images  == null)
            {
                return;
            }
            if(Counter < Images.Count - 1)
            {
                Counter++;
                picBoxShowPicture.Image = Image.FromFile(Images.ElementAt(Counter));
            }
        }

        //vergroten/verkleinen foto
        private void CbZoom_CheckedChanged(object sender, EventArgs e)
        {
            if (cbZoom.Checked)
                picBoxShowPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                picBoxShowPicture.SizeMode = PictureBoxSizeMode.CenterImage;
        }
    }
}
