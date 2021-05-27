using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AdminApp
{
    class Connection
    {
        public string
            ConnectionString =
                 "Server = localhost; Database = vendingmachine; Uid = root; SslMode = none;";

        public MySqlConnection DatabaseConnection;

        public void CreateConnection()
        {
            if (DatabaseConnection == null)
            {
                DatabaseConnection = new MySqlConnection(ConnectionString);
            }
            DatabaseConnection.Open();



        }
    }
}
