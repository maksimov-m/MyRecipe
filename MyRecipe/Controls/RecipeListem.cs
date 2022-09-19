using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Resources;
using MyRecipe.Controls;
using MySql.Data.MySqlClient;
using System.Reflection;
using MyRecipe.Forms;

namespace MyRecipe
{
    public partial class RecipeListem : UserControl
    {

        bool expectation;
        bool inner;

        public RecipeListem()
        {
            
            InitializeComponent();
            

        }

        #region Properties

        private string _recipe;
        private int _time;
        private string _desc;

        [Category("Custom properties")]
        public string Recipe
        {
            get { return _recipe; }
            set { _recipe = value; title.Text = value; }
        }

        [Category("Custom properties")]
        public int Time
        {
            get { return _time; }
            set { _time = value; time.Text = Convert.ToString(value); }
        }

        [Category("Custom properties")]
        public string Desc
        {
            get { return _desc; }
            set { _desc = value; labeldesc.Text = value; }
        }

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _favorutes = null;

        public string Favorites
        {
            get { return _favorutes; }
            set { _favorutes = value; }
        }

        #endregion




        private void RecipeListem_MouseUp(object sender, MouseEventArgs e)
        {

            RecipeView form2 = new RecipeView(Id);
            form2.ShowDialog();

        }

        private void RecipeListem_MouseEnter_1(object sender, EventArgs e)
        {

            favoritesCheck();
            this.BackColor = Color.Silver;
            title.BackColor = Color.Silver;
            time.BackColor = Color.Silver;

            inner = true;
            animation_on(panelRight);


        }


        private void button1_MouseEnter(object sender, EventArgs e)
        {

            if (Favorites == "0")
                button1.Image = Image.FromFile("C:\\Users\\Maksim\\source\\repos\\MyRecipe\\MyRecipe\\Resources\\icons8-звезда (2).png");
            inner = true;
            animation_on(panelRight);

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            if (Favorites == "0")
                button1.Image = Image.FromFile("C:\\Users\\Maksim\\source\\repos\\MyRecipe\\MyRecipe\\Resources\\icons8-звезда-32.png");
        }

        
        

        private void panelRight_MouseEnter(object sender, EventArgs e)
        {
            favoritesCheck();

            inner = true;
            animation_on(panelRight);

        }


        private void time_MouseEnter(object sender, EventArgs e)
        {
            inner = true;
            animation_on(panelRight);
        }

        private void title_MouseEnter(object sender, EventArgs e)
        {
            inner = true;
            animation_on(panelRight);
        }


        private void RecipeListem_MouseLeave(object sender, EventArgs e)
        {
            inner = false;
            animation_off(panelRight);
        }

        private void panelRight_MouseLeave(object sender, EventArgs e)
        { 
            inner = false;
            animation_off(panelRight);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Favorites == "0")
            {
                button1.Image = Image.FromFile("C:\\Users\\Maksim\\source\\repos\\MyRecipe\\MyRecipe\\Resources\\icons8-морская-звезда-30.png");
                Favorites = "1";
                DB db = new DB();

                MySqlCommand command = new MySqlCommand($"UPDATE recipes SET favorite = 1 WHERE id = {Id};", db.getConnection());

                db.openConnection();

                MySqlDataReader reader = command.ExecuteReader();

                db.CloseConnection();
            }
            else
            {

                Favorites = "0";
                button1.Image = Image.FromFile("C:\\Users\\Maksim\\source\\repos\\MyRecipe\\MyRecipe\\Resources\\icons8-звезда-32.png");
                DB db = new DB();

                MySqlCommand command = new MySqlCommand($"UPDATE recipes SET favorite = 0 WHERE id = {Id};", db.getConnection());

                db.openConnection();

                MySqlDataReader reader = command.ExecuteReader();

                db.CloseConnection();
            }
        }


        private async void animation_on(Panel _panel)
        {

                while (!expectation && _panel.Size.Width < 220)
                {
                    expectation = true;
                    await Task.Delay(3);
                    _panel.Size = new Size(_panel.Size.Width + 10, _panel.Size.Height);
                    expectation = false;
                }

            //await Task.Delay(100);
            animation_off(_panel);
        }

        private async void animation_off(Panel _panel)
        {
            await Task.Delay(3);
            
            while (!expectation && _panel.Size.Width > 10)
            {
                if (inner) break;
                expectation = true;
                await Task.Delay(3);
                _panel.Size = new Size(_panel.Size.Width - 10, _panel.Size.Height);
                expectation = false;

            }

            if(_panel.Size.Width < 10)
            {
                this.BackColor = Color.White;
                title.BackColor = Color.White;
                time.BackColor = Color.White;
            }
        }


        private void favoritesCheck()
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand($"SELECT * FROM recipes WHERE id = {Id};", db.getConnection());

            db.openConnection();

            MySqlDataReader reader = command.ExecuteReader();

            string check = null;
            while (reader.Read())
            {
                check = reader["favorite"].ToString();
            }

            if(check == "True")
            {
                button1.Image = Image.FromFile("C:\\Users\\Maksim\\source\\repos\\MyRecipe\\MyRecipe\\Resources\\icons8-морская-звезда-30.png");
                Favorites="1";
            }
            else
            {
                Favorites = "0";
                
            }
            db.CloseConnection();
        }

        
    }

}
