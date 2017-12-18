namespace Cookbook2
{
    partial class Form1
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
            this.lstRecipes = new System.Windows.Forms.ListBox();
            this.lstRecipeIngredients = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.btnUpdateRecipeName = new System.Windows.Forms.Button();
            this.listAllIngredients = new System.Windows.Forms.ListBox();
            this.btnAddToRecipe = new System.Windows.Forms.Button();
            this.btnRemoveFromRecipe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recipe";
            // 
            // lstRecipes
            // 
            this.lstRecipes.FormattingEnabled = true;
            this.lstRecipes.Location = new System.Drawing.Point(34, 214);
            this.lstRecipes.Name = "lstRecipes";
            this.lstRecipes.Size = new System.Drawing.Size(120, 160);
            this.lstRecipes.TabIndex = 1;
            this.lstRecipes.SelectedIndexChanged += new System.EventHandler(this.lstRecipes_SelectedIndexChanged);
            // 
            // lstRecipeIngredients
            // 
            this.lstRecipeIngredients.FormattingEnabled = true;
            this.lstRecipeIngredients.Location = new System.Drawing.Point(179, 214);
            this.lstRecipeIngredients.Name = "lstRecipeIngredients";
            this.lstRecipeIngredients.Size = new System.Drawing.Size(143, 160);
            this.lstRecipeIngredients.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Recipe Ingredients";
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Location = new System.Drawing.Point(45, 64);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(75, 23);
            this.btnAddRecipe.TabIndex = 4;
            this.btnAddRecipe.Text = "Add Recipe";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Location = new System.Drawing.Point(45, 38);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(227, 20);
            this.txtRecipeName.TabIndex = 5;
            // 
            // btnUpdateRecipeName
            // 
            this.btnUpdateRecipeName.Location = new System.Drawing.Point(137, 64);
            this.btnUpdateRecipeName.Name = "btnUpdateRecipeName";
            this.btnUpdateRecipeName.Size = new System.Drawing.Size(135, 23);
            this.btnUpdateRecipeName.TabIndex = 6;
            this.btnUpdateRecipeName.Text = "Update Reccipe Name";
            this.btnUpdateRecipeName.UseVisualStyleBackColor = true;
            this.btnUpdateRecipeName.Click += new System.EventHandler(this.btnUpdateRecipeName_Click);
            // 
            // listAllIngredients
            // 
            this.listAllIngredients.FormattingEnabled = true;
            this.listAllIngredients.Location = new System.Drawing.Point(395, 214);
            this.listAllIngredients.Name = "listAllIngredients";
            this.listAllIngredients.Size = new System.Drawing.Size(154, 160);
            this.listAllIngredients.TabIndex = 7;
            // 
            // btnAddToRecipe
            // 
            this.btnAddToRecipe.Location = new System.Drawing.Point(395, 380);
            this.btnAddToRecipe.Name = "btnAddToRecipe";
            this.btnAddToRecipe.Size = new System.Drawing.Size(154, 23);
            this.btnAddToRecipe.TabIndex = 8;
            this.btnAddToRecipe.Text = "Add To Reccipe";
            this.btnAddToRecipe.UseVisualStyleBackColor = true;
            this.btnAddToRecipe.Click += new System.EventHandler(this.btnAddToRecipe_Click);
            // 
            // btnRemoveFromRecipe
            // 
            this.btnRemoveFromRecipe.Location = new System.Drawing.Point(179, 380);
            this.btnRemoveFromRecipe.Name = "btnRemoveFromRecipe";
            this.btnRemoveFromRecipe.Size = new System.Drawing.Size(143, 23);
            this.btnRemoveFromRecipe.TabIndex = 9;
            this.btnRemoveFromRecipe.Text = "Remove From Reccipe";
            this.btnRemoveFromRecipe.UseVisualStyleBackColor = true;
            this.btnRemoveFromRecipe.Click += new System.EventHandler(this.btnRemoveFromRecipe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 547);
            this.Controls.Add(this.btnRemoveFromRecipe);
            this.Controls.Add(this.btnAddToRecipe);
            this.Controls.Add(this.listAllIngredients);
            this.Controls.Add(this.btnUpdateRecipeName);
            this.Controls.Add(this.txtRecipeName);
            this.Controls.Add(this.btnAddRecipe);
            this.Controls.Add(this.lstRecipeIngredients);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstRecipes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cookbook2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstRecipes;
        private System.Windows.Forms.ListBox lstRecipeIngredients;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.Button btnUpdateRecipeName;
        private System.Windows.Forms.ListBox listAllIngredients;
        private System.Windows.Forms.Button btnAddToRecipe;
        private System.Windows.Forms.Button btnRemoveFromRecipe;
    }
}

