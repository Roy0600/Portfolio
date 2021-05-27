using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kleurvakken
{
    public partial class Form1 : Form
    {
        Random heyhallo;
        List<Kleurvlak> lstKleurvlak = new List<Kleurvlak>();

        public Form1()
        {
            InitializeComponent();
            heyhallo = new Random();
            for(int i = 0; i < 5; i++)
            {
                Kleurvlak Tussenvlak = new Kleurvlak();
                Tussenvlak.Location = new Point(10+i*100, 10);
                Tussenvlak.Show();

                Controls.Add(Tussenvlak);

                lstKleurvlak.Add(Tussenvlak);
            }
        }

        private void btnKleurAanpassen_Click(object sender, EventArgs e)
        {
            foreach(Kleurvlak MijnVlak in lstKleurvlak)
            {
                MijnVlak.Kleur = heyhallo.Next(3);
            }
        }

    }
}
