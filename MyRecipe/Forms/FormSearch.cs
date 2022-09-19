using MyRecipe.Controls;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
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
    public partial class FormSearch : Form
    {


        //Для Controls collection_product
        int p_count;
        ProductList[] productLists = new ProductList[10];

        ///Списки для всех видов поисков 
        private AutoCompleteStringCollection collection_product = new AutoCompleteStringCollection();
        private AutoCompleteStringCollection collection_type = new AutoCompleteStringCollection();
       
        //Параметры выбора поиска
        private bool _product = false;
        private bool _type = false;
        private bool _vegan = false;
        private bool _notVegan = false;


        public FormSearch()
        {
            InitializeComponent();
            flowLayoutPanel1.Controls.Remove(emptyText);
            
        }

        //Подсказка в поисковик
        private void Search()
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("SELECT * FROM products", db.getConnection());

            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();



            while (reader.Read())
            {
                collection_product.Add(reader["product"].ToString());
            }

            text_Search.AutoCompleteMode = AutoCompleteMode.Suggest;
            text_Search.AutoCompleteSource = AutoCompleteSource.CustomSource;

            text_Search.AutoCompleteCustomSource = collection_product;

            db.CloseConnection();
        }

        //Типы блюд для comboBoxType 
        private void typeRecipe()
        {

            DB db = new DB();

            MySqlCommand command = new MySqlCommand("SELECT * FROM type", db.getConnection());

            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();


            collection_type.Add("");
            while (reader.Read())
            {
                collection_type.Add(reader["type"].ToString());
            }

            for (int i = 0; i < collection_type.Count; i++)
            {
                comboBoxType.Items.Add(collection_type[i]);
            }
            

            db.CloseConnection();
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {

            Search();
            typeRecipe();

            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// Для поиска по ингридиентам в "Супер поиск" (только по ингридиентам).
        /// </summary>
        /// <param name="mas"></param>
        private void populateItem_products(AutoCompleteStringCollection mas, string type = null, string vegan = null)
        {
            flowLayoutPanel1.Controls.Clear();
            DB db = new DB();

            //sql_command
            string com_1 = "select distinct recipe from ingredients where product in (";
            com_1 += mas[0];
            for (int i = 1; i < mas.Count; i++)
            {
                com_1 += ", " + mas[i];
            }

            com_1 += ");";

            //read sql_command for recipeStart
            MySqlCommand command = new MySqlCommand(com_1, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = command.ExecuteReader();
            AutoCompleteStringCollection recipeStart = new AutoCompleteStringCollection();

            while (reader.Read())
            {

                recipeStart.Add(reader.GetString(0));

            }



            db.CloseConnection();
            AutoCompleteStringCollection result = new AutoCompleteStringCollection();
            bool res_prov1 = true;

            for (int i = 0; i < recipeStart.Count; i++)
            {
                db.openConnection();
                command = new MySqlCommand($"SELECT product FROM ingredients WHERE recipe = {recipeStart[i]}", db.getConnection());
                reader = command.ExecuteReader();

                List<int> list = new List<int>();

                while (reader.Read())
                {
                    list.Add(reader.GetInt32(0));

                }


                res_prov1 = true;
                for (int j = 0; j < list.Count; j++)
                {
                    if (res_prov1)
                    {
                        res_prov1 = false;
                        for (int k = 0; k < mas.Count; k++)
                        {
                            if (list[j] == Convert.ToInt32(mas[k]))
                            {
                                res_prov1 = true;

                            }
                        }
                    }
                    else
                    {
                        break;
                    }

                }

                if (res_prov1)
                {
                    result.Add(recipeStart[i]);
                }
                db.CloseConnection();
            }

            if (result.Count != 0)
            {
                db.openConnection();
                string res_com = "SELECT * FROM recipes WHERE id IN (";
                res_com += result[0];
                for (int i = 1; i < result.Count; i++)
                {
                    res_com += ", " + result[i];
                }
                res_com += ")";

                if(type != null)
                {
                    res_com += $" AND type = \"{type}\"";
                }

                if (vegan != null)
                {
                    if(_vegan)
                    res_com += $" AND vegan = 1";
                    else if(_notVegan)
                    res_com += $" AND vegan = 0";
                }

                res_com += ";";

                command = new MySqlCommand(res_com, db.getConnection());

                reader = command.ExecuteReader();

                RecipeListem[] recipeListItem = new RecipeListem[result.Count];
                int j = 0;

                while (reader.Read())
                {

                    recipeListItem[j] = new RecipeListem();
                    recipeListItem[j].Id = reader.GetInt32(0);
                    recipeListItem[j].Recipe = reader.GetString(1);
                    recipeListItem[j].Time = reader.GetInt32(2);
                    recipeListItem[j].Desc = reader["description"].ToString();
                    flowLayoutPanel1.Controls.Add(recipeListItem[j]);
                    j++;

                }
                db.CloseConnection();
            }

        }

        /// <summary>
        /// Для поиска по типу блюда в "Супер поиск" (только по типу).
        /// </summary>
        private void population_type(string vegan = null)
        {
            string res = comboBoxType.SelectedItem.ToString();

            DB db = new DB();

            string com = $"SELECT * FROM recipes WHERE type = \"{res}\"";

            if (vegan != null)
            {
                if (_vegan)
                    com += $" AND vegan = 1";
                else if (_notVegan)
                    com += $" AND vegan = 0";
            }

            com += ";";

            MySqlCommand command = new MySqlCommand(com, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = command.ExecuteReader();

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            RecipeListem[] recipeListItem = new RecipeListem[5];
            int j = 0;

            while (reader.Read())
            {
                collection.Add(reader["recipe"].ToString());

                recipeListItem[j] = new RecipeListem();
                recipeListItem[j].Id = reader.GetInt32(0);
                recipeListItem[j].Recipe = reader.GetString(1);
                recipeListItem[j].Time = reader.GetInt32(2);
                recipeListItem[j].Desc = reader["description"].ToString();
                flowLayoutPanel1.Controls.Add(recipeListItem[j]);
                j++;
            }

            db.CloseConnection();
        }

        /// <summary>
        ///Для поиска по вегетерианству блюда в "Супер поиск" (только по вегетарианские).
        /// </summary>
        private void population_vegan()
        {
            

            DB db = new DB();

            string comm = "SELECT * FROM recipes WHERE vegan = ";

            if (_vegan)
            {
                comm += "1;";
            }
            else if (_notVegan)
            {
                comm += "0;";
            }

            MySqlCommand command = new MySqlCommand(comm, db.getConnection());

           
            db.openConnection();

            MySqlDataReader reader = command.ExecuteReader();

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            RecipeListem[] recipeListItem = new RecipeListem[5];
            int j = 0;

            while (reader.Read())
            {
                collection.Add(reader["recipe"].ToString());

                recipeListItem[j] = new RecipeListem();
                recipeListItem[j].Id = reader.GetInt32(0);
                recipeListItem[j].Recipe = reader.GetString(1);
                recipeListItem[j].Time = reader.GetInt32(2);
                recipeListItem[j].Desc = reader["description"].ToString();
                flowLayoutPanel1.Controls.Add(recipeListItem[j]);
                j++;
            }

            db.CloseConnection();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            

            DB db = new DB();
            bool add_prov = false;


            MySqlDataReader reader = null;
            db.openConnection();

            try
            {
                MySqlCommand command = new MySqlCommand($"SELECT id, product from products where product = \"{text_Search.Text}\";", db.getConnection());

                reader = command.ExecuteReader();


                while (reader.Read())
                {
                    if (add_prov = !IdInMas(reader["id"].ToString()))
                    {
                        ProductList.mas_string.Add(reader["id"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader.HasRows && add_prov)
                {
                    p_count = ProductList.Count;
                    productLists[p_count] = new ProductList();
                    productLists[p_count].Product = text_Search.Text;

                    flowLayoutPanel2.Controls.Add(productLists[p_count]);
                    button3.Visible = true;
                    _product = true;

                }
            }

            db.CloseConnection();
            text_Search.Clear();

            
            
            
            
        }

        //Проверка повторения продуктов в списке
        bool IdInMas(string id)
        {
            for (int i = 0; i < ProductList.mas_string.Count; i++)
            {
                if (ProductList.mas_string[i] == id)
                {
                    return true;
                }
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            if (_product)
            {
                if (_type && (_vegan || _notVegan))
                {
                    flowLayoutPanel1.Controls.Clear();
                    populateItem_products(ProductList.mas_string, comboBoxType.SelectedItem.ToString(), "1");
                }
                else if (_type && !(_vegan || _notVegan))
                {
                    flowLayoutPanel1.Controls.Clear();
                    populateItem_products(ProductList.mas_string, comboBoxType.SelectedItem.ToString());
                }
                else if (!_type && (_vegan || _notVegan))
                {
                    flowLayoutPanel1.Controls.Clear();
                    populateItem_products(ProductList.mas_string,vegan : "1");
                }
                else if (!_type && !(_vegan || _notVegan))
                {
                    flowLayoutPanel1.Controls.Remove(emptyText);
                    populateItem_products(ProductList.mas_string);
                }
            }
            else
            {
                if (_type && !(_vegan || _notVegan))
                {
                    flowLayoutPanel1.Controls.Clear();
                    population_type();
                }
                else if (!_type && (_vegan || _notVegan))
                {
                    flowLayoutPanel1.Controls.Clear();
                    population_vegan();
                }
                else if (_type && (_vegan || _notVegan))
                {
                    flowLayoutPanel1.Controls.Clear();
                    population_type("1");
                }
                else if (!_type && !(_vegan || _notVegan))
                {
                    flowLayoutPanel1.Controls.Clear();
                    flowLayoutPanel1.Controls.Add(emptyText);
                    Search();
                }

            }
            //if (ProductList.mas_string.Count != 0)
            //{

            //    flowLayoutPanel1.Controls.Remove(emptyText);
            //    populateItem_products(ProductList.mas_string);

            //}
            //else
            //{

            //    flowLayoutPanel1.Controls.Clear();
            //    flowLayoutPanel1.Controls.Add(emptyText);
            //    Search();
            //}

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (ProductList.mas_string.Count == 0)
            {
                _product = false;
                button3.Visible = false;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            _product = false;
            flowLayoutPanel2.Controls.Clear();
            ProductList.mas_string.Clear();
            ProductList.Count = 0;
            flowLayoutPanel2.Controls.Add(button3);
            button3.Visible = false;
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxType.SelectedItem.ToString() == "") _type = false;
            else _type = true;

        }

        private void checkBoxVegan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVegan.Checked)
            {
                _notVegan = false;
                checkBoxNotVegan.Checked = false;
                _vegan = true;
            }
            
            else
            {
                _vegan = false;
            }
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            if(flowLayoutPanel1.Controls.Count == 0) {

                flowLayoutPanel1.Controls.Clear();
                flowLayoutPanel1.Controls.Add(emptyText);
                Search();
            }
        }

        private void checkBoxNotVegan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNotVegan.Checked)
            {
                _vegan = false;
                checkBoxVegan.Checked = false;
                _notVegan = true;
            }
            else
            {
                _notVegan = false;
            }
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            if (ProductList.mas_string.Count == 0)
            {
                _product = false;
                button3.Visible = false;
            }
        }
    }
}
