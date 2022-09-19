namespace MyRecipe
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFavorite = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.titleCollection = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.panelMenu.Controls.Add(this.btnAdd);
            this.panelMenu.Controls.Add(this.btnFavorite);
            this.panelMenu.Controls.Add(this.btnAbout);
            this.panelMenu.Controls.Add(this.btnSearch);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(236, 564);
            this.panelMenu.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.Color.DimGray;
            this.btnAdd.Image = global::MyRecipe.Properties.Resources.icons8_плюс_32;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(0, 200);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(236, 60);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "  Добавить ";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFavorite
            // 
            this.btnFavorite.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFavorite.FlatAppearance.BorderSize = 0;
            this.btnFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavorite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFavorite.ForeColor = System.Drawing.Color.DimGray;
            this.btnFavorite.Image = ((System.Drawing.Image)(resources.GetObject("btnFavorite.Image")));
            this.btnFavorite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFavorite.Location = new System.Drawing.Point(0, 140);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnFavorite.Size = new System.Drawing.Size(236, 60);
            this.btnFavorite.TabIndex = 5;
            this.btnFavorite.Text = "  Избранное";
            this.btnFavorite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFavorite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFavorite.UseVisualStyleBackColor = true;
            this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAbout.ForeColor = System.Drawing.Color.DimGray;
            this.btnAbout.Image = global::MyRecipe.Properties.Resources.icons8_о_нас_32;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(0, 504);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(236, 60);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "  О приложении";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.ForeColor = System.Drawing.Color.DimGray;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(0, 80);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSearch.Size = new System.Drawing.Size(236, 60);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = " Супер поиск";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(204)))), ((int)(((byte)(198)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(236, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(55, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Recipes";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.panelTitleBar.Controls.Add(this.button3);
            this.panelTitleBar.Controls.Add(this.btnSize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(236, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(779, 80);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(693, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 30);
            this.button3.TabIndex = 5;
            this.button3.Text = "O";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSize
            // 
            this.btnSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSize.FlatAppearance.BorderSize = 0;
            this.btnSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSize.ForeColor = System.Drawing.Color.Black;
            this.btnSize.Location = new System.Drawing.Point(720, 0);
            this.btnSize.Name = "btnSize";
            this.btnSize.Size = new System.Drawing.Size(30, 30);
            this.btnSize.TabIndex = 4;
            this.btnSize.Text = "O";
            this.btnSize.UseVisualStyleBackColor = true;
            this.btnSize.Click += new System.EventHandler(this.btnSize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(749, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "O";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = global::MyRecipe.Properties.Resources.icons8_x_50;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(48, 80);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Visible = false;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Location = new System.Drawing.Point(43, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(707, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Коллекция рецептов";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Controls.Add(this.titleCollection);
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(236, 80);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(779, 484);
            this.panelDesktopPanel.TabIndex = 2;
            // 
            // titleCollection
            // 
            this.titleCollection.AutoScroll = true;
            this.titleCollection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleCollection.Location = new System.Drawing.Point(0, 0);
            this.titleCollection.Name = "titleCollection";
            this.titleCollection.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.titleCollection.Size = new System.Drawing.Size(779, 484);
            this.titleCollection.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1015, 564);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1015, 564);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelDesktopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnFavorite;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.FlowLayoutPanel titleCollection;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSize;
        private System.Windows.Forms.Button btnClose;
    }
}

