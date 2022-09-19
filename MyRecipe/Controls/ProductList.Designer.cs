namespace MyRecipe.Controls
{
    partial class ProductList
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.product_txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "x";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // product_txt
            // 
            this.product_txt.AutoSize = true;
            this.product_txt.Location = new System.Drawing.Point(1, 8);
            this.product_txt.Name = "product_txt";
            this.product_txt.Size = new System.Drawing.Size(52, 16);
            this.product_txt.TabIndex = 2;
            this.product_txt.Text = "product";
            // 
            // ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.product_txt);
            this.Name = "ProductList";
            this.Size = new System.Drawing.Size(121, 33);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label product_txt;
    }
}
