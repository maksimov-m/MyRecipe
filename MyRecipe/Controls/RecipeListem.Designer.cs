namespace MyRecipe
{
    partial class RecipeListem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeListem));
            this.title = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.labeldesc = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(9, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(306, 60);
            this.title.TabIndex = 0;
            this.title.Text = "label1";
            this.title.MouseEnter += new System.EventHandler(this.title_MouseEnter);
            this.title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RecipeListem_MouseUp);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelRight.Controls.Add(this.button1);
            this.panelRight.Controls.Add(this.labeldesc);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(336, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(10, 147);
            this.panelRight.TabIndex = 2;
            this.panelRight.MouseEnter += new System.EventHandler(this.panelRight_MouseEnter);
            this.panelRight.MouseLeave += new System.EventHandler(this.panelRight_MouseLeave);
            this.panelRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RecipeListem_MouseUp);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(254, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 33);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // labeldesc
            // 
            this.labeldesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeldesc.Location = new System.Drawing.Point(14, 37);
            this.labeldesc.Name = "labeldesc";
            this.labeldesc.Size = new System.Drawing.Size(234, 91);
            this.labeldesc.TabIndex = 0;
            this.labeldesc.Text = "label1";
            this.labeldesc.MouseEnter += new System.EventHandler(this.panelRight_MouseEnter);
            this.labeldesc.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RecipeListem_MouseUp);
            // 
            // time
            // 
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.time.Image = global::MyRecipe.Properties.Resources.icons8_часы_48;
            this.time.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.time.Location = new System.Drawing.Point(3, 69);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(156, 59);
            this.time.TabIndex = 1;
            this.time.Text = "label1";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.time.MouseEnter += new System.EventHandler(this.time_MouseEnter);
            this.time.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RecipeListem_MouseUp);
            // 
            // RecipeListem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.time);
            this.Controls.Add(this.title);
            this.Name = "RecipeListem";
            this.Size = new System.Drawing.Size(346, 147);
            this.MouseEnter += new System.EventHandler(this.RecipeListem_MouseEnter_1);
            this.MouseLeave += new System.EventHandler(this.RecipeListem_MouseLeave);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RecipeListem_MouseUp);
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label labeldesc;
        private System.Windows.Forms.Button button1;
    }
}
