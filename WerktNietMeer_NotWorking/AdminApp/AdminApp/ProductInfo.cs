using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminApp
{
    public partial class ProductInfo : UserControl
    {

        private string _Name;
        private int _Stock;
        private int _Sold;

        public ProductInfo(Form1 form1)
        {
            InitializeComponent();
            this.Main = Main;
        }

        public Form1 Main;

        public new string Name
        {
            get => _Name;
            set
            {
                _Name = value;
                label1.Text = _Name;
            }
        }

        public string GetVoorraad()
        {
            return textBox1.Text;
        }

        public int Stock
        {
            get => _Stock;
            set
            {
                _Stock = value;
                textBox1.Text = _Stock.ToString();
            }
        }

        public int Sold
        {
            get => _Sold;
            set
            {
                _Sold = value;
                textBox8.Text = _Sold.ToString();
            }
        }

    }
}
