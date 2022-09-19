namespace MyRecipe.Forms
{
    partial class FormAdd
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
            this.components = new System.ComponentModel.Container();
            this.richTextBoxDesc = new System.Windows.Forms.RichTextBox();
            this.checkBoxVegan = new System.Windows.Forms.CheckBox();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonReomoveProducts = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.flowLayoutPanelProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.textProducts = new System.Windows.Forms.TextBox();
            this.buttonAddRecipe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxMinDesc = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBoxDesc
            // 
            this.richTextBoxDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxDesc.Location = new System.Drawing.Point(12, 239);
            this.richTextBoxDesc.Name = "richTextBoxDesc";
            this.richTextBoxDesc.Size = new System.Drawing.Size(496, 179);
            this.richTextBoxDesc.TabIndex = 0;
            this.richTextBoxDesc.Text = "";
            // 
            // checkBoxVegan
            // 
            this.checkBoxVegan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxVegan.AutoSize = true;
            this.checkBoxVegan.Location = new System.Drawing.Point(545, 92);
            this.checkBoxVegan.Name = "checkBoxVegan";
            this.checkBoxVegan.Size = new System.Drawing.Size(137, 20);
            this.checkBoxVegan.TabIndex = 16;
            this.checkBoxVegan.Text = "Вегетарианские";
            this.checkBoxVegan.UseVisualStyleBackColor = true;
            // 
            // labelType
            // 
            this.labelType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(542, 17);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(69, 16);
            this.labelType.TabIndex = 15;
            this.labelType.Text = "Тип блюд";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(545, 40);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(137, 24);
            this.comboBoxType.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(545, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 1);
            this.panel2.TabIndex = 23;
            // 
            // buttonReomoveProducts
            // 
            this.buttonReomoveProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReomoveProducts.AutoSize = true;
            this.buttonReomoveProducts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReomoveProducts.Location = new System.Drawing.Point(516, 244);
            this.buttonReomoveProducts.Name = "buttonReomoveProducts";
            this.buttonReomoveProducts.Size = new System.Drawing.Size(23, 26);
            this.buttonReomoveProducts.TabIndex = 18;
            this.buttonReomoveProducts.Text = "x";
            this.buttonReomoveProducts.UseVisualStyleBackColor = true;
            this.buttonReomoveProducts.Visible = false;
            this.buttonReomoveProducts.Click += new System.EventHandler(this.buttonReomoveProducts_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddProduct.Location = new System.Drawing.Point(545, 192);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(91, 23);
            this.buttonAddProduct.TabIndex = 22;
            this.buttonAddProduct.Text = "Добавить";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // flowLayoutPanelProducts
            // 
            this.flowLayoutPanelProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelProducts.AutoScroll = true;
            this.flowLayoutPanelProducts.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanelProducts.Location = new System.Drawing.Point(545, 244);
            this.flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
            this.flowLayoutPanelProducts.Size = new System.Drawing.Size(163, 77);
            this.flowLayoutPanelProducts.TabIndex = 21;
            this.flowLayoutPanelProducts.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelProducts_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Входят ингридиенты";
            // 
            // textProducts
            // 
            this.textProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textProducts.BackColor = System.Drawing.Color.White;
            this.textProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textProducts.Location = new System.Drawing.Point(544, 163);
            this.textProducts.Name = "textProducts";
            this.textProducts.Size = new System.Drawing.Size(150, 15);
            this.textProducts.TabIndex = 19;
            // 
            // buttonAddRecipe
            // 
            this.buttonAddRecipe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddRecipe.Location = new System.Drawing.Point(545, 343);
            this.buttonAddRecipe.Name = "buttonAddRecipe";
            this.buttonAddRecipe.Size = new System.Drawing.Size(198, 59);
            this.buttonAddRecipe.TabIndex = 24;
            this.buttonAddRecipe.Text = "Добавить рецепт";
            this.buttonAddRecipe.UseVisualStyleBackColor = true;
            this.buttonAddRecipe.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Описание";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(16, 42);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(192, 22);
            this.textBoxName.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Название";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Краткое описание";
            // 
            // richTextBoxMinDesc
            // 
            this.richTextBoxMinDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxMinDesc.Location = new System.Drawing.Point(12, 115);
            this.richTextBoxMinDesc.Name = "richTextBoxMinDesc";
            this.richTextBoxMinDesc.Size = new System.Drawing.Size(496, 79);
            this.richTextBoxMinDesc.TabIndex = 29;
            this.richTextBoxMinDesc.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(266, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Время готовки";
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(270, 42);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(192, 22);
            this.textBoxTime.TabIndex = 31;
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBoxMinDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddRecipe);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonReomoveProducts);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.flowLayoutPanelProducts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textProducts);
            this.Controls.Add(this.checkBoxVegan);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.richTextBoxDesc);
            this.Name = "FormAdd";
            this.Text = "Добавь свой рецепт";
            this.Load += new System.EventHandler(this.FormAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxDesc;
        private System.Windows.Forms.CheckBox checkBoxVegan;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonReomoveProducts;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProducts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textProducts;
        private System.Windows.Forms.Button buttonAddRecipe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBoxMinDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTime;
    }
}