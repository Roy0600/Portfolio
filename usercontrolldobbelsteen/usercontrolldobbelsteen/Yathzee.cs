using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace usercontrolldobbelsteen
{
    public partial class Yathzee : Form
    {
        public Yathzee()
        {
            InitializeComponent();
        }

        private void btnGooi_Click(object sender, EventArgs e)
        {
            ucDobbelsteen1.Gooi();
            ucDobbelsteen2.Gooi();
            ucDobbelsteen3.Gooi();
            ucDobbelsteen4.Gooi();
            ucDobbelsteen5.Gooi();
        }

    }
}
