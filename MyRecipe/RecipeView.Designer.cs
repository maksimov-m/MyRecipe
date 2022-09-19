namespace MyRecipe
{
    partial class RecipeView
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
            this.recipe_read = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // recipe_read
            // 
            this.recipe_read.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.recipe_read.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipe_read.Location = new System.Drawing.Point(0, 0);
            this.recipe_read.Name = "recipe_read";
            this.recipe_read.ReadOnly = true;
            this.recipe_read.Size = new System.Drawing.Size(800, 450);
            this.recipe_read.TabIndex = 0;
            this.recipe_read.Text = "";
            // 
            // RecipeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.recipe_read);
            this.Name = "RecipeView";
            this.Text = "Супер поиск";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox recipe_read;
    }
}