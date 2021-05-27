using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace usercontrolldobbelsteen
{
    public partial class ucDobbelsteen : UserControl
    {
        static Random steen = new Random();
        public ucDobbelsteen()
        {
            InitializeComponent();
        }

        private void ucDobbelsteen_Load(object sender, EventArgs e)
        {

        }
        public void Gooi()
        {
            if (!cbHold.Checked)
            {
                int random = steen.Next(1, 7);
                switch (random)
                {
                    case 1:
                        pbDobbelsteen.Image = usercontrolldobbelsteen.Properties.Resources.img1;
                        break;
                    case 2:
                        pbDobbelsteen.Image = usercontrolldobbelsteen.Properties.Resources.img2;
                        break;
                    case 3:
                        pbDobbelsteen.Image = usercontrolldobbelsteen.Properties.Resources.img3;
                        break;
                    case 4:
                        pbDobbelsteen.Image = usercontrolldobbelsteen.Properties.Resources.img4;
                        break;
                    case 5:
                        pbDobbelsteen.Image = usercontrolldobbelsteen.Properties.Resources.img5;
                        break;
                    case 6:
                        pbDobbelsteen.Image = usercontrolldobbelsteen.Properties.Resources.img6;
                        break;
                }
            }
        }
    }
}
