using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AdminApp
{
    public partial class Form1 : Form
    {
        private static readonly Connection Connection = new Connection();
        private List<ProductInfo> producten = new List<ProductInfo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            producten.Clear();
            flowLayoutPanel1.Controls.Clear();
            try
            {

                Connection.CreateConnection();
                const string query = "SELECT * FROM product";

                var command = new MySqlCommand(query, Connection.DatabaseConnection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var Product = new ProductInfo(this);
                    Product.Name = reader.GetString("naam");
                    Product.Stock = reader.GetInt32("voorraad");
                    Product.Sold = reader.GetInt32("aantalkeerverkocht");
                    flowLayoutPanel1.Controls.Add(Product);
                    producten.Add(Product);
                    if(Product.Stock <= 3)
                    {
                        MessageBox.Show("Er zijn nog maar " + Product.Stock + " stuks van " + Product.Name + " in voorraad");
                    }
                }


            }
            finally
            {
                Connection.DatabaseConnection.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Connection.DatabaseConnection.Open();
            foreach (ProductInfo pi in producten)
            {
                string query = "UPDATE product SET voorraad = " + pi.GetVoorraad() + " WHERE naam = '" + pi.Name + "'; ";
                var command = new MySqlCommand(query, Connection.DatabaseConnection);
                command.ExecuteNonQuery();
            }
            MessageBox.Show("De voorraad is met succes veranderd!");
            Connection.DatabaseConnection.Close();

        }
    }

}
