using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRecipe
{
    public partial class RecipeView : Form
    {
        public RecipeView(int comm)
        {
            InitializeComponent();
            print_recipe(comm);
        }

        private void print_recipe(int id)
        {
            DB db = new DB();
            string com = $"SELECT * FROM rec_read WHERE id = {id};";
            MySqlCommand comman = new MySqlCommand(com, db.getConnection());
            db.openConnection();
            MySqlDataReader reader = comman.ExecuteReader();

            if (reader.Read())
                recipe_read.Text = reader.GetString(1);
            db.CloseConnection();
        }


        private void changeButton_Click_1(object sender, EventArgs e)
        {
            recipe_read.ReadOnly = false;
        }
    }
}
