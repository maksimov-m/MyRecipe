namespace MyRecipe.Forms
{
    partial class FormSearch
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBoxNotVegan = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxVegan = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_Search = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.emptyText = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.checkBoxNotVegan);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.checkBoxVegan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.text_Search);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(13, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 1);
            this.panel2.TabIndex = 14;
            // 
            // checkBoxNotVegan
            // 
            this.checkBoxNotVegan.AutoSize = true;
            this.checkBoxNotVegan.Location = new System.Drawing.Point(454, 87);
            this.checkBoxNotVegan.Name = "checkBoxNotVegan";
            this.checkBoxNotVegan.Size = new System.Drawing.Size(79, 20);
            this.checkBoxNotVegan.TabIndex = 13;
            this.checkBoxNotVegan.Text = "Мясные";
            this.checkBoxNotVegan.UseVisualStyleBackColor = true;
            this.checkBoxNotVegan.CheckedChanged += new System.EventHandler(this.checkBoxNotVegan_CheckedChanged);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(191, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 26);
            this.button3.TabIndex = 1;
            this.button3.Text = "x";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(232, 12);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(163, 77);
            this.flowLayoutPanel2.TabIndex = 11;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(616, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxVegan
            // 
            this.checkBoxVegan.AutoSize = true;
            this.checkBoxVegan.Location = new System.Drawing.Point(454, 61);
            this.checkBoxVegan.Name = "checkBoxVegan";
            this.checkBoxVegan.Size = new System.Drawing.Size(137, 20);
            this.checkBoxVegan.TabIndex = 9;
            this.checkBoxVegan.Text = "Вегетарианские";
            this.checkBoxVegan.UseVisualStyleBackColor = true;
            this.checkBoxVegan.CheckedChanged += new System.EventHandler(this.checkBoxVegan_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Типы блюд";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(454, 32);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(137, 24);
            this.comboBoxType.TabIndex = 7;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Входят ингридиенты";
            // 
            // text_Search
            // 
            this.text_Search.BackColor = System.Drawing.Color.White;
            this.text_Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_Search.Location = new System.Drawing.Point(12, 32);
            this.text_Search.Name = "text_Search";
            this.text_Search.Size = new System.Drawing.Size(150, 15);
            this.text_Search.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Azure;
            this.flowLayoutPanel1.Controls.Add(this.emptyText);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 113);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(776, 325);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // emptyText
            // 
            this.emptyText.Location = new System.Drawing.Point(3, 0);
            this.emptyText.Name = "emptyText";
            this.emptyText.Size = new System.Drawing.Size(167, 44);
            this.emptyText.TabIndex = 0;
            this.emptyText.Text = "Ничего не найдено!";
            this.emptyText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormSearch";
            this.Text = "Супер поиск";
            this.Load += new System.EventHandler(this.FormSearch_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_Search;
        private System.Windows.Forms.CheckBox checkBoxVegan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label emptyText;
        private System.Windows.Forms.CheckBox checkBoxNotVegan;
        private System.Windows.Forms.Panel panel2;
    }
}