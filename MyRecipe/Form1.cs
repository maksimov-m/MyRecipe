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

namespace MyRecipe
{
    public partial class Form1 : Form
    {

        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        

        public Form1()
        {
            InitializeComponent();
            random = new Random();

            this.FormBorderStyle = FormBorderStyle.None;
            
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSearch(), sender);
            
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormFavorites(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAdd(), sender);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAbout(), sender);

        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void PressButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;

                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(242, 243, 244);
                    previousBtn.ForeColor = Color.DimGray;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            PressButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text; 
            titleCollection.Visible = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
                titleCollection.Controls.Add(recipeListItem[i]);
                i++;

            }
            db.CloseConnection();

        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
            
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "Коллекция рецептов";
            currentButton = null;
            btnCloseChildForm.Visible = false;
            OpenChildForm(new Forms.FormMain(), null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_SIZEBOX = 0x40005;

                var cp = base.CreateParams;
                cp.Style |= WS_SIZEBOX;

                return cp;
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }


}
