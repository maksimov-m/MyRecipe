using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRecipe.Forms
{
    public partial class FormFavorites : Form
    {
        public FormFavorites()
        {
            InitializeComponent();
        }

        int i;

        private void FormFavorites_Load(object sender, EventArgs e)
        {
            population();
        }

        

        private void population()
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("SELECT * FROM recipes WHERE favorite = 1;", db.getConnection());

            db.openConnection();

            MySqlDataReader reader = command.ExecuteReader();



            RecipeListem[] recipeListItem = new RecipeListem[10];
            i = 0;
            while (reader.Read())
            {

                recipeListItem[i] = new RecipeListem();
                recipeListItem[i].Id = reader.GetInt32(0);
                recipeListItem[i].Recipe = reader.GetString(1);
                recipeListItem[i].Time = reader.GetInt32(2);
                recipeListItem[i].Desc = reader.GetString(5);
                recipeListItem[i].Favorites = reader["favorite"].ToString();
                flowLayoutPanel1.Controls.Add(recipeListItem[i]);

                i++;

            }
            db.CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            population();
        }
    }
}
