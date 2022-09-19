using MyRecipe.Controls;
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
    public partial class FormAdd : Form
    {

        //Для Controls collection_product
        int p_count;
        ProductList[] productLists = new ProductList[10];

        //Списки для всех видов поисков 
        private AutoCompleteStringCollection collection_product = new AutoCompleteStringCollection();
        private AutoCompleteStringCollection collection_type = new AutoCompleteStringCollection();

        //Проверка заполнения 
        bool name = false;
        bool desc = false;
        bool minDesc = false;
        bool type = false;
        bool vegan = false;
        bool products = false;
        bool time = false;

        public FormAdd()
        {
            InitializeComponent();
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            Search();
            typeRecipe();

            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;

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

            textProducts.AutoCompleteMode = AutoCompleteMode.Suggest;
            textProducts.AutoCompleteSource = AutoCompleteSource.CustomSource;

            textProducts.AutoCompleteCustomSource = collection_product;

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


        private void button1_Click(object sender, EventArgs e)
        {
            int time_res = -1;
            int vegan_res = 0;
            

            if (textBoxName.Text != "")
            {
                if (textBoxName.Text.Length > 5)
                {
                    name = true;
                } 
                else MessageBox.Show("Напишите более подробное название");
            }
            if (richTextBoxDesc.Text != "")
            {
                
                if (richTextBoxDesc.Text.Length > 15)
                    desc = true;
                else MessageBox.Show("Напишите более подробное описание рецепта");
            }
            if (richTextBoxMinDesc.Text != "")
            {
                
                if (richTextBoxMinDesc.Text.Length > 10)
                    minDesc = true;
                else MessageBox.Show("Напишите более подробное краткое описание рецепта");
            }
            if (comboBoxType.Text != "") type = true;
            if (checkBoxVegan.Checked) vegan = true;
            if (flowLayoutPanelProducts.Controls.Count != 0)
            {
                if (flowLayoutPanelProducts.Controls.Count != 0)
                {
                    MessageBox.Show("Проверьте, все ли ингридиенты вы добавили в список");
                    products = true;

                }
                    
            }
            if(textBoxTime.Text != "")
            {
                try
                {
                    time_res = Convert.ToInt32(textBoxTime.Text);
                    time = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Введите корректно поле \"Время\" (без букв и знаков препинания)!");
                }
                
            }

            if (vegan) vegan_res = 1;

            if(name && desc && minDesc && type && products && time)
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand($"INSERT INTO recipes (recipe, time, type, vegan, description, favorite) VALUE (\"{textBoxName.Text}\", \"{time_res}\", \"{comboBoxType.Text}\", \"{vegan_res}\", \"{richTextBoxMinDesc.Text}\", \"{0}\");", db.getConnection());

                db.openConnection();

                MySqlDataReader reader = command.ExecuteReader();

                db.CloseConnection();

                command = new MySqlCommand($"INSERT INTO rec_read (id, recipe) VALUE ((SELECT MAX(`id`) FROM recipes), \"{richTextBoxDesc.Text}\");", db.getConnection());

                db.openConnection();

                MySqlDataReader reader_rec = command.ExecuteReader();

                db.CloseConnection();


                string com_res = "INSERT INTO ingredients (recipe, product) VALUE ";

                com_res += $"((SELECT MAX(`id`) FROM recipes), {ProductList.mas_string[0]})";

                for (int i = 1; i < ProductList.mas_string.Count; i++)
                {
                    com_res += $", ((SELECT MAX(`id`) FROM recipes), {ProductList.mas_string[i]})";
                }

                com_res += ";";

               command = new MySqlCommand(com_res, db.getConnection());

                db.openConnection();

                MySqlDataReader ingredients_1 = command.ExecuteReader();

                db.CloseConnection();

                //Обнуляем
                textBoxName.Clear();
                textBoxTime.Clear();

                richTextBoxDesc.Clear();
                richTextBoxMinDesc.Clear();

                flowLayoutPanelProducts.Controls.Clear();
                ProductList.mas_string.Clear();
                ProductList.Count = 0;

                checkBoxVegan.Checked = false; 
                
                comboBoxType.SelectedIndex = 0;
                
                name = false;
                desc = false;
                minDesc = false;
                type = false;
                vegan = false;
                products = false;
                time = false;

            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }



        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {

            if(textProducts.Text == "")
            {
                MessageBox.Show("Поле не может быть пустым!");
                return;
            }else if(textProducts.Text.Length < 3)
            {
                MessageBox.Show("Поле не может быть таким коротким!");
                textProducts.Clear();
                return;
            }

            DB db = new DB();
            bool add_prov = false;
            bool hasrows = false;
            int count = 0;

            MySqlDataReader reader = null;
            db.openConnection();

            try
            {
                MySqlCommand command = new MySqlCommand($"SELECT id, product from products where product = \"{textProducts.Text}\";", db.getConnection());

                reader = command.ExecuteReader();


                while (reader.Read())
                {
                    count++;
                    if (add_prov = !IdInMas(reader["id"].ToString()))
                    {
                        ProductList.mas_string.Add(reader["id"].ToString());
                    }
                }

                hasrows = reader.HasRows;
                db.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (hasrows && add_prov)
                {
                    p_count = ProductList.Count;
                    productLists[p_count] = new ProductList();
                    productLists[p_count].Product = textProducts.Text;

                    flowLayoutPanelProducts.Controls.Add(productLists[p_count]);
                    buttonReomoveProducts.Visible = true;
                    

                }else if(!reader.HasRows && !add_prov && count == 0)
                {
                    if (MessageBox.Show($"Создать новый продукт \"{textProducts.Text}\"?", "Создание нового продукта", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MySqlCommand comm = new MySqlCommand($"INSERT INTO products (product) VALUE (\"{textProducts.Text}\")", db.getConnection());

                        db.openConnection();

                        comm.ExecuteReader();

                        db.CloseConnection();
                        MessageBox.Show("Добавлено!");

                        MySqlCommand command = new MySqlCommand($"SELECT id, product from products where product = \"{textProducts.Text.ToLower()}\";", db.getConnection());

                        db.openConnection();
                        reader = command.ExecuteReader();


                        while (reader.Read())
                        {
                            count++;
                            if (add_prov = !IdInMas(reader["id"].ToString()))
                            {
                                ProductList.mas_string.Add(reader["id"].ToString());
                            }
                        }

                        db.CloseConnection();

                        p_count = ProductList.Count;
                        productLists[p_count] = new ProductList();
                        productLists[p_count].Product = textProducts.Text;

                        flowLayoutPanelProducts.Controls.Add(productLists[p_count]);
                        buttonReomoveProducts.Visible = true;

                        textProducts.Clear();
                    }else textProducts.Clear();
                    
                    
                }
            }

            
            textProducts.Clear();


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

        private void flowLayoutPanelProducts_Paint(object sender, PaintEventArgs e)
        {
            if(flowLayoutPanelProducts.Controls.Count == 0)
            {
                buttonReomoveProducts.Visible=false;
            }
        }

        private void buttonReomoveProducts_Click(object sender, EventArgs e)
        {
            flowLayoutPanelProducts.Controls.Clear();
            ProductList.mas_string.Clear();
            ProductList.Count = 0;
            buttonReomoveProducts.Visible = false;
        }
    }
}
