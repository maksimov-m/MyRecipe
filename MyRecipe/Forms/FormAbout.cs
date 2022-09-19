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
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        int count = 0;

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            count++;
            if (count == 5)
            {
                smileVisible();
                count = 0;
            }
        }

        private async void smileVisible()
        {
            await Task.Delay(100);
            labelSmile1.Visible = true;
            await Task.Delay(100);
            labelSmile2.Visible = true;
            await Task.Delay(100);
            labelSmile3.Visible = true;
            await Task.Delay(100);
            labelSmile4.Visible = true;

            await Task.Delay(100);
            labelSmile1.Visible = false;
            await Task.Delay(100);
            labelSmile2.Visible = false;
            await Task.Delay(100);
            labelSmile3.Visible = false;
            await Task.Delay(100);
            labelSmile4.Visible = false;

            await Task.Delay(100);
            labelSmile1.Visible = true;
            await Task.Delay(100);
            labelSmile2.Visible = true;
            await Task.Delay(100);
            labelSmile3.Visible = true;
            await Task.Delay(100);
            labelSmile4.Visible = true;

            await Task.Delay(1000);
            labelSmile1.Visible = false;
            await Task.Delay(1000);
            labelSmile2.Visible = false;
            await Task.Delay(1000);
            labelSmile3.Visible = false;
            await Task.Delay(1000);
            labelSmile4.Visible = false;

            await Task.Delay(1000);
            labelSmile1.Visible = true;
            await Task.Delay(1000);
            labelSmile2.Visible = true;
            await Task.Delay(1000);
            labelSmile3.Visible = true;
            await Task.Delay(1000);
            labelSmile4.Visible = true;
        }
    }
}
