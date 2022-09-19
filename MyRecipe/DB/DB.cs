using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRecipe
{
    internal class DB
    {
        //Вводим данные для подключения к базе данны
        MySqlConnection connection = new MySqlConnection("server= ;port= ;username=  ;password= ;database= ");

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
