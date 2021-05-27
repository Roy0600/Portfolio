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
namespace Themaweek7
{
    public partial class Form1 : Form
    {
            string connectionString =
                "Server = localhost; Database = themaweek; Uid = root; SslMode = none;"; // connectie leggen met de database 
            MySqlConnection connection;
            decimal HuidigePrijs;
            decimal TotaalPrijs;

        public Form1()
        {
            InitializeComponent();
        }


        private void btnToonGroente_Click(object sender, EventArgs e)
        {
            try
            {
                flpProducten.Controls.Clear();
                createConnection();
                string query = "SELECT * FROM product where Catagory_Name = 'groenten'";

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    UCProducten mijnproduct = new UCProducten(this);
                    mijnproduct.ProductNaam = reader.GetString("name");
                    mijnproduct.Imagelocation = reader.GetString("afbeelding");
                    mijnproduct.Prijs = reader.GetString("prijs");
                    flpProducten.Controls.Add(mijnproduct);
                }
            }
            catch (MySqlException exception)
            {
                catchExeption(exception);
            }
            finally
            {
                connection.Close();
            }
        }

        public void catchExeption(MySqlException exception)
        {
            int foutcode = exception.Number;

            switch (foutcode)
            {
                case 0:
                    MessageBox.Show("Cannot connect to server. Contact administrator");
                    break;
                case 1045:
                    MessageBox.Show("Invalid username/password, please try again");
                    break;
                default:
                    MessageBox.Show(exception.Message);
                    break;
            }
        }

        public void createConnection()
        {
            if (connection == null)
            {
                connection = new MySqlConnection(connectionString);
            }

            connection.Open();
        }

        private void btnToonFruit_Click(object sender, EventArgs e)
        {
            try
            {
                flpProducten.Controls.Clear();
                createConnection();
                string query = "SELECT * FROM product where Catagory_Name = 'fruit'";

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    UCProducten mijnproduct = new UCProducten(this);
                    string name = reader.GetString("name");
                    mijnproduct.ProductNaam = name.ToLower();
                    mijnproduct.Imagelocation = reader.GetString("afbeelding");
                    mijnproduct.Prijs = reader.GetString("prijs");
                    flpProducten.Controls.Add(mijnproduct);
                }
            }
            catch (MySqlException exception)
            {
                catchExeption(exception);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnToonOverige_Click(object sender, EventArgs e)
        {
            try
            {
                flpProducten.Controls.Clear();
                createConnection();
                string query = "SELECT * FROM product where Catagory_Name = 'overigen'";

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    UCProducten mijnproduct = new UCProducten(this);
                    string name = reader.GetString("name");
                    mijnproduct.ProductNaam = name.ToLower();
                    mijnproduct.Imagelocation = reader.GetString("afbeelding");
                    mijnproduct.Prijs = reader.GetString("prijs");
                    flpProducten.Controls.Add(mijnproduct);
                }
            }
            catch (MySqlException exception)
            {
                catchExeption(exception);
            }
            finally
            {
                connection.Close();
            }
        }

        public void getInfo(string Productnaam, string Prijs)
        {
            lstbon.Items.Add(Prijs + " " + Productnaam);
            HuidigePrijs = Convert.ToDecimal(Prijs);
            TotaalPrijs = TotaalPrijs + HuidigePrijs;
            lblTotaalPrijs.Text = TotaalPrijs.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            lstbon.Items.Remove(lstbon.SelectedItem);

            TotaalPrijs = TotaalPrijs - HuidigePrijs;
            lblTotaalPrijs.Text = TotaalPrijs.ToString();
        }

        private void btnverwijder_Click(object sender, EventArgs e)
        {
            lstbon.Items.Clear();
            TotaalPrijs = 0;
            HuidigePrijs = 0;
            lblTotaalPrijs.Text = TotaalPrijs.ToString();
        }

        private void btnBon_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO `bon`(`prijs`) VALUES (" + TotaalPrijs.ToString().Replace(",", ".") + ")";
                createConnection();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
            }
            catch (MySqlException exception)
            {
                catchExeption(exception);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}


