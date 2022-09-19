using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRecipe.Controls
{
    public partial class ProductList : UserControl
    {
        public ProductList()
        {
            InitializeComponent();
            Count++;
        }

        public static AutoCompleteStringCollection mas_string = new AutoCompleteStringCollection();


        #region Properties

        private string _recipe;

        [Category("Custom properties")]
        public string Product
        {
            get { return _recipe; }
            set { _recipe = value; product_txt.Text = value; }
        }

        private static int count;

        [Category("Custom properties")]
        public static int Count
        {
            get { return count; }
            set { count = value; }
        }
        private string count_id = mas_string[Count];

        public string Count_id
        {
            get { return count_id; }
        }

        #endregion

        private void button1_Click_1(object sender, EventArgs e)
        {
            mas_string.Remove(this.Count_id.ToString());
            this.Dispose();
            Count--;
        }
    }
}
