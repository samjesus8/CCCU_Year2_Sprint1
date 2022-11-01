namespace Assessment1._1
{
    partial class FormRecipes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecipes));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSavedRecipes = new System.Windows.Forms.Button();
            this.buttonAllRecipes = new System.Windows.Forms.Button();
            this.groupBoxRecipes = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.richTextBoxRecipes = new System.Windows.Forms.RichTextBox();
            this.labelAllRecipes = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.buttonSaveRecipe = new System.Windows.Forms.Button();
            this.buttonNextRecipe = new System.Windows.Forms.Button();
            this.buttonPreviousRecipe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxRecipes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(943, 785);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonSavedRecipes
            // 
            this.buttonSavedRecipes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSavedRecipes.Location = new System.Drawing.Point(14, 120);
            this.buttonSavedRecipes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSavedRecipes.Name = "buttonSavedRecipes";
            this.buttonSavedRecipes.Size = new System.Drawing.Size(234, 84);
            this.buttonSavedRecipes.TabIndex = 1;
            this.buttonSavedRecipes.Text = "Saved Recipes";
            this.buttonSavedRecipes.UseVisualStyleBackColor = true;
            this.buttonSavedRecipes.Click += new System.EventHandler(this.buttonSavedRecipes_Click);
            // 
            // buttonAllRecipes
            // 
            this.buttonAllRecipes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAllRecipes.Location = new System.Drawing.Point(14, 28);
            this.buttonAllRecipes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAllRecipes.Name = "buttonAllRecipes";
            this.buttonAllRecipes.Size = new System.Drawing.Size(234, 84);
            this.buttonAllRecipes.TabIndex = 2;
            this.buttonAllRecipes.Text = "All Recipes";
            this.buttonAllRecipes.UseVisualStyleBackColor = true;
            this.buttonAllRecipes.Click += new System.EventHandler(this.buttonAllRecipes_Click);
            // 
            // groupBoxRecipes
            // 
            this.groupBoxRecipes.Controls.Add(this.label1);
            this.groupBoxRecipes.Controls.Add(this.comboBoxFilter);
            this.groupBoxRecipes.Controls.Add(this.richTextBoxRecipes);
            this.groupBoxRecipes.Controls.Add(this.labelAllRecipes);
            this.groupBoxRecipes.Location = new System.Drawing.Point(282, 28);
            this.groupBoxRecipes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxRecipes.Name = "groupBoxRecipes";
            this.groupBoxRecipes.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxRecipes.Size = new System.Drawing.Size(630, 632);
            this.groupBoxRecipes.TabIndex = 3;
            this.groupBoxRecipes.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(411, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter";
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "none"});
            this.comboBoxFilter.Location = new System.Drawing.Point(459, 29);
            this.comboBoxFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(138, 28);
            this.comboBoxFilter.TabIndex = 2;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // richTextBoxRecipes
            // 
            this.richTextBoxRecipes.Location = new System.Drawing.Point(22, 69);
            this.richTextBoxRecipes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBoxRecipes.Name = "richTextBoxRecipes";
            this.richTextBoxRecipes.Size = new System.Drawing.Size(575, 531);
            this.richTextBoxRecipes.TabIndex = 1;
            this.richTextBoxRecipes.Text = "";
            // 
            // labelAllRecipes
            // 
            this.labelAllRecipes.AutoSize = true;
            this.labelAllRecipes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAllRecipes.Location = new System.Drawing.Point(22, 25);
            this.labelAllRecipes.Name = "labelAllRecipes";
            this.labelAllRecipes.Size = new System.Drawing.Size(119, 23);
            this.labelAllRecipes.TabIndex = 0;
            this.labelAllRecipes.Text = "All Recipes";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // buttonSaveRecipe
            // 
            this.buttonSaveRecipe.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveRecipe.Location = new System.Drawing.Point(304, 680);
            this.buttonSaveRecipe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSaveRecipe.Name = "buttonSaveRecipe";
            this.buttonSaveRecipe.Size = new System.Drawing.Size(182, 71);
            this.buttonSaveRecipe.TabIndex = 4;
            this.buttonSaveRecipe.Text = "Save";
            this.buttonSaveRecipe.UseVisualStyleBackColor = true;
            this.buttonSaveRecipe.Click += new System.EventHandler(this.buttonSaveRecipe_Click);
            // 
            // buttonNextRecipe
            // 
            this.buttonNextRecipe.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNextRecipe.Location = new System.Drawing.Point(730, 680);
            this.buttonNextRecipe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonNextRecipe.Name = "buttonNextRecipe";
            this.buttonNextRecipe.Size = new System.Drawing.Size(182, 71);
            this.buttonNextRecipe.TabIndex = 5;
            this.buttonNextRecipe.Text = "Next";
            this.buttonNextRecipe.UseVisualStyleBackColor = true;
            this.buttonNextRecipe.Click += new System.EventHandler(this.buttonNextRecipe_Click);
            // 
            // buttonPreviousRecipe
            // 
            this.buttonPreviousRecipe.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPreviousRecipe.Location = new System.Drawing.Point(513, 680);
            this.buttonPreviousRecipe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPreviousRecipe.Name = "buttonPreviousRecipe";
            this.buttonPreviousRecipe.Size = new System.Drawing.Size(182, 71);
            this.buttonPreviousRecipe.TabIndex = 6;
            this.buttonPreviousRecipe.Text = "Previous";
            this.buttonPreviousRecipe.UseVisualStyleBackColor = true;
            this.buttonPreviousRecipe.Click += new System.EventHandler(this.buttonPreviousRecipe_Click);
            // 
            // FormRecipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 780);
            this.Controls.Add(this.buttonPreviousRecipe);
            this.Controls.Add(this.buttonNextRecipe);
            this.Controls.Add(this.buttonSaveRecipe);
            this.Controls.Add(this.groupBoxRecipes);
            this.Controls.Add(this.buttonAllRecipes);
            this.Controls.Add(this.buttonSavedRecipes);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormRecipes";
            this.Text = "FormRecipes";
            this.Load += new System.EventHandler(this.FormRecipes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxRecipes.ResumeLayout(false);
            this.groupBoxRecipes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSavedRecipes;
        private System.Windows.Forms.Button buttonAllRecipes;
        private System.Windows.Forms.GroupBox groupBoxRecipes;
        private System.Windows.Forms.RichTextBox richTextBoxRecipes;
        private System.Windows.Forms.Label labelAllRecipes;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Button buttonPreviousRecipe;
        private System.Windows.Forms.Button buttonNextRecipe;
        private System.Windows.Forms.Button buttonSaveRecipe;
    }
}