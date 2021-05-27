using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Themaweek7
{
    public partial class UCProducten : UserControl
    {
        // Variable's (LOCAL)
        private string _productNaam;
        private string _imageLocation;
        private string _prijs;
        // Varibal's (PUBLIC)


        // Construct
        public UCProducten(Form1 main)
        {
            InitializeComponent();
            this.main = main;

        }
        Form1 main;

        //Property voor NAAM
        public string Prijs
        {
            get
            {
                return _prijs;
            }
            set
            {
                _prijs = value;
                lblprijs.Text = _prijs;
            }
            
        }
        public string ProductNaam
        {
            get
            {
                return _productNaam;
            }

            set
            {
                _productNaam = value;
                lblProductNaam.Text = _productNaam;
            }
        }
        public string Imagelocation
        {
            get
            {
                return _imageLocation;
            }
            set
            {
                _imageLocation = value;
                pb1.ImageLocation = _imageLocation;
            }
        }

        private void pb1_Click(object sender, EventArgs e)
        {

        }
    }
}



