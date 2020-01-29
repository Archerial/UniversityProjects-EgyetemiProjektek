using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;


namespace WCF_Cars
{
    public class DatbaseConnection
    {
        MySqlConnection connectionString = new MySqlConnection("server=localhost;user id=root;database=cars");

        public void OpenConnection()
        {
            connectionString.Open();
        }

        public void CloseConnection()
        {
            connectionString.Close();
        }

    }
}