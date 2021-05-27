using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kleurvakken
{
    public partial class Kleurvlak : UserControl
    {
        private int _kleur;

        public Kleurvlak()
        {
            InitializeComponent();
        }

        public int Kleur
        {
            get { return _kleur; }

            set
            {
                _kleur = value;
                switch (_kleur)
                {
                    case 0:
                        BackColor = Color.Green;
                        break;
                    case 1:
                        BackColor = Color.Red;
                        break;
                    case 2:
                        BackColor = Color.Yellow;
                        break;
                    default:
                        BackColor = Color.Gray;
                        break;

                }


            }
        }

        private void klv_Click(object sender, EventArgs e)
        {
            Kleur = Kleur+1;
            if (Kleur > 3)
            {
                Kleur = 0;
            }
        }
    }
}



