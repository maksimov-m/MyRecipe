﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRecipe
{
    internal class DB
    {

        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=Vfrcbv250500!;database=myrecipesdb");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed) connection.Open();

        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open) connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
    }

}
