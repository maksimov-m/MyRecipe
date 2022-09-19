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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            populateItem();
        }

        //Вывод всех рецептов
        private void populateItem()
        {
            DB db = new DB();


            MySqlCommand command = new MySqlCommand("SELECT * FROM recipes", db.getConnection());

            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();


            RecipeListem[] recipeListItem = new RecipeListem[10];
            int i = 0;
            while (reader.Read())
            {

                recipeListItem[i] = new RecipeListem();
                recipeListItem[i].Id = reader.GetInt32(0);
                recipeListItem[i].Recipe = reader.GetString(1);
                recipeListItem[i].Time = reader.GetInt32(2);
                recipeListItem[i].Desc = reader.GetString(5);
                flowLayoutPanel1.Controls.Add(recipeListItem[i]);
                i++;

            }
            db.CloseConnection();

        }
    }
}
