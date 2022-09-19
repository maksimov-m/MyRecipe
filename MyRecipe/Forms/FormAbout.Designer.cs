namespace MyRecipe.Forms
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelSmile1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSmile2 = new System.Windows.Forms.Label();
            this.labelSmile3 = new System.Windows.Forms.Label();
            this.labelSmile4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 159);
            this.label1.TabIndex = 0;
            this.label1.Text = "Приложение создано 08.2022\r\n\r\nДанное приложение по возможности будет развиваться," +
    " но не обещаю))\r\n\r\nПо каким либо вопросам обращаться в Telegram: @maks_maks1\r\n\r\n" +
    "Спасибо за внимание!\r\n\r\n\r\n\r\n";
            // 
            // labelSmile1
            // 
            this.labelSmile1.Image = global::MyRecipe.Properties.Resources.icons8_показать_язык_801;
            this.labelSmile1.Location = new System.Drawing.Point(674, 167);
            this.labelSmile1.Name = "labelSmile1";
            this.labelSmile1.Size = new System.Drawing.Size(104, 104);
            this.labelSmile1.TabIndex = 3;
            this.labelSmile1.Visible = false;
            // 
            // label2
            // 
            this.label2.Image = global::MyRecipe.Properties.Resources.icons8_спасибо_150;
            this.label2.Location = new System.Drawing.Point(12, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 104);
            this.label2.TabIndex = 1;
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label2_MouseUp);
            // 
            // labelSmile2
            // 
            this.labelSmile2.Image = global::MyRecipe.Properties.Resources.icons8_показать_язык_801;
            this.labelSmile2.Location = new System.Drawing.Point(447, 167);
            this.labelSmile2.Name = "labelSmile2";
            this.labelSmile2.Size = new System.Drawing.Size(105, 94);
            this.labelSmile2.TabIndex = 4;
            this.labelSmile2.Visible = false;
            // 
            // labelSmile3
            // 
            this.labelSmile3.Image = global::MyRecipe.Properties.Resources.icons8_показать_язык_801;
            this.labelSmile3.Location = new System.Drawing.Point(558, 259);
            this.labelSmile3.Name = "labelSmile3";
            this.labelSmile3.Size = new System.Drawing.Size(110, 91);
            this.labelSmile3.TabIndex = 5;
            this.labelSmile3.Visible = false;
            // 
            // labelSmile4
            // 
            this.labelSmile4.Image = global::MyRecipe.Properties.Resources.icons8_показать_язык_801;
            this.labelSmile4.Location = new System.Drawing.Point(674, 350);
            this.labelSmile4.Name = "labelSmile4";
            this.labelSmile4.Size = new System.Drawing.Size(114, 91);
            this.labelSmile4.TabIndex = 6;
            this.labelSmile4.Visible = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSmile4);
            this.Controls.Add(this.labelSmile3);
            this.Controls.Add(this.labelSmile2);
            this.Controls.Add(this.labelSmile1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAbout";
            this.Text = "О приложении";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSmile1;
        private System.Windows.Forms.Label labelSmile2;
        private System.Windows.Forms.Label labelSmile3;
        private System.Windows.Forms.Label labelSmile4;
    }
}