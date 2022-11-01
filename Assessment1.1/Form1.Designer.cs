
namespace Assessment1._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonPlanMeals = new System.Windows.Forms.Button();
            this.buttonPreviousMeals = new System.Windows.Forms.Button();
            this.buttonRecipes = new System.Windows.Forms.Button();
            this.groupBoxPlanMeals = new System.Windows.Forms.GroupBox();
            this.comboBoxSunSelect = new System.Windows.Forms.ComboBox();
            this.comboBoxSatSelect = new System.Windows.Forms.ComboBox();
            this.comboBoxFriSelect = new System.Windows.Forms.ComboBox();
            this.comboBoxThuSelect = new System.Windows.Forms.ComboBox();
            this.comboBoxTueSelect = new System.Windows.Forms.ComboBox();
            this.comboBoxWedSelect = new System.Windows.Forms.ComboBox();
            this.comboBoxMonSelect = new System.Windows.Forms.ComboBox();
            this.labelSaturday = new System.Windows.Forms.Label();
            this.labelSunday = new System.Windows.Forms.Label();
            this.labelFriday = new System.Windows.Forms.Label();
            this.labelThursday = new System.Windows.Forms.Label();
            this.labelWednesday = new System.Windows.Forms.Label();
            this.labelTuesday = new System.Windows.Forms.Label();
            this.labelMonday = new System.Windows.Forms.Label();
            this.toolTipPlanMeals = new System.Windows.Forms.ToolTip(this.components);
            this.buttonAddToShoppingList = new System.Windows.Forms.Button();
            this.toolTipRecipes = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPreviousMeals = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxPlanMeals.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPlanMeals
            // 
            this.buttonPlanMeals.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPlanMeals.Location = new System.Drawing.Point(22, 30);
            this.buttonPlanMeals.Name = "buttonPlanMeals";
            this.buttonPlanMeals.Size = new System.Drawing.Size(205, 63);
            this.buttonPlanMeals.TabIndex = 0;
            this.buttonPlanMeals.Text = "Plan my meals";
            this.toolTipPlanMeals.SetToolTip(this.buttonPlanMeals, "Plan your weekly meals");
            this.buttonPlanMeals.UseVisualStyleBackColor = true;
            this.buttonPlanMeals.Click += new System.EventHandler(this.buttonPlanMeals_Click);
            // 
            // buttonPreviousMeals
            // 
            this.buttonPreviousMeals.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPreviousMeals.Location = new System.Drawing.Point(22, 168);
            this.buttonPreviousMeals.Name = "buttonPreviousMeals";
            this.buttonPreviousMeals.Size = new System.Drawing.Size(205, 63);
            this.buttonPreviousMeals.TabIndex = 2;
            this.buttonPreviousMeals.Text = "Previous meals";
            this.toolTipPreviousMeals.SetToolTip(this.buttonPreviousMeals, "See your previous weeks here");
            this.buttonPreviousMeals.UseVisualStyleBackColor = true;
            // 
            // buttonRecipes
            // 
            this.buttonRecipes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRecipes.Location = new System.Drawing.Point(22, 99);
            this.buttonRecipes.Name = "buttonRecipes";
            this.buttonRecipes.Size = new System.Drawing.Size(205, 63);
            this.buttonRecipes.TabIndex = 4;
            this.buttonRecipes.Text = "Recipes";
            this.toolTipRecipes.SetToolTip(this.buttonRecipes, "Search our receipe databse for some fantastic ideas and save your favourites\r\n\r\n");
            this.buttonRecipes.UseVisualStyleBackColor = true;
            this.buttonRecipes.Click += new System.EventHandler(this.buttonRecipes_Click);
            // 
            // groupBoxPlanMeals
            // 
            this.groupBoxPlanMeals.Controls.Add(this.comboBoxSunSelect);
            this.groupBoxPlanMeals.Controls.Add(this.comboBoxSatSelect);
            this.groupBoxPlanMeals.Controls.Add(this.comboBoxFriSelect);
            this.groupBoxPlanMeals.Controls.Add(this.comboBoxThuSelect);
            this.groupBoxPlanMeals.Controls.Add(this.comboBoxTueSelect);
            this.groupBoxPlanMeals.Controls.Add(this.comboBoxWedSelect);
            this.groupBoxPlanMeals.Controls.Add(this.comboBoxMonSelect);
            this.groupBoxPlanMeals.Controls.Add(this.labelSaturday);
            this.groupBoxPlanMeals.Controls.Add(this.labelSunday);
            this.groupBoxPlanMeals.Controls.Add(this.labelFriday);
            this.groupBoxPlanMeals.Controls.Add(this.labelThursday);
            this.groupBoxPlanMeals.Controls.Add(this.labelWednesday);
            this.groupBoxPlanMeals.Controls.Add(this.labelTuesday);
            this.groupBoxPlanMeals.Controls.Add(this.labelMonday);
            this.groupBoxPlanMeals.Location = new System.Drawing.Point(272, 15);
            this.groupBoxPlanMeals.Name = "groupBoxPlanMeals";
            this.groupBoxPlanMeals.Size = new System.Drawing.Size(541, 486);
            this.groupBoxPlanMeals.TabIndex = 5;
            this.groupBoxPlanMeals.TabStop = false;
            // 
            // comboBoxSunSelect
            // 
            this.comboBoxSunSelect.FormattingEnabled = true;
            this.comboBoxSunSelect.Items.AddRange(new object[] {
            "Please Select your Meal.."});
            this.comboBoxSunSelect.Location = new System.Drawing.Point(150, 429);
            this.comboBoxSunSelect.Name = "comboBoxSunSelect";
            this.comboBoxSunSelect.Size = new System.Drawing.Size(333, 23);
            this.comboBoxSunSelect.TabIndex = 14;
            this.comboBoxSunSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxSunSelect_SelectedIndexChanged);
            // 
            // comboBoxSatSelect
            // 
            this.comboBoxSatSelect.FormattingEnabled = true;
            this.comboBoxSatSelect.Items.AddRange(new object[] {
            "Please Select your Meal.."});
            this.comboBoxSatSelect.Location = new System.Drawing.Point(150, 370);
            this.comboBoxSatSelect.Name = "comboBoxSatSelect";
            this.comboBoxSatSelect.Size = new System.Drawing.Size(333, 23);
            this.comboBoxSatSelect.TabIndex = 13;
            this.comboBoxSatSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxSatSelect_SelectedIndexChanged);
            // 
            // comboBoxFriSelect
            // 
            this.comboBoxFriSelect.FormattingEnabled = true;
            this.comboBoxFriSelect.Items.AddRange(new object[] {
            "Please Select your Meal.."});
            this.comboBoxFriSelect.Location = new System.Drawing.Point(150, 302);
            this.comboBoxFriSelect.Name = "comboBoxFriSelect";
            this.comboBoxFriSelect.Size = new System.Drawing.Size(333, 23);
            this.comboBoxFriSelect.TabIndex = 12;
            this.comboBoxFriSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxFriSelect_SelectedIndexChanged);
            // 
            // comboBoxThuSelect
            // 
            this.comboBoxThuSelect.FormattingEnabled = true;
            this.comboBoxThuSelect.Items.AddRange(new object[] {
            "Please Select your Meal.."});
            this.comboBoxThuSelect.Location = new System.Drawing.Point(150, 243);
            this.comboBoxThuSelect.Name = "comboBoxThuSelect";
            this.comboBoxThuSelect.Size = new System.Drawing.Size(333, 23);
            this.comboBoxThuSelect.TabIndex = 11;
            this.comboBoxThuSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxThuSelect_SelectedIndexChanged);
            // 
            // comboBoxTueSelect
            // 
            this.comboBoxTueSelect.FormattingEnabled = true;
            this.comboBoxTueSelect.Items.AddRange(new object[] {
            "Please Select your Meal.."});
            this.comboBoxTueSelect.Location = new System.Drawing.Point(150, 105);
            this.comboBoxTueSelect.Name = "comboBoxTueSelect";
            this.comboBoxTueSelect.Size = new System.Drawing.Size(333, 23);
            this.comboBoxTueSelect.TabIndex = 10;
            this.comboBoxTueSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxTueSelect_SelectedIndexChanged);
            // 
            // comboBoxWedSelect
            // 
            this.comboBoxWedSelect.FormattingEnabled = true;
            this.comboBoxWedSelect.Items.AddRange(new object[] {
            "Please Select your Meal.."});
            this.comboBoxWedSelect.Location = new System.Drawing.Point(150, 174);
            this.comboBoxWedSelect.Name = "comboBoxWedSelect";
            this.comboBoxWedSelect.Size = new System.Drawing.Size(333, 23);
            this.comboBoxWedSelect.TabIndex = 9;
            this.comboBoxWedSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxWedSelect_SelectedIndexChanged);
            // 
            // comboBoxMonSelect
            // 
            this.comboBoxMonSelect.FormattingEnabled = true;
            this.comboBoxMonSelect.Items.AddRange(new object[] {
            "Please Select your Meal.."});
            this.comboBoxMonSelect.Location = new System.Drawing.Point(150, 55);
            this.comboBoxMonSelect.Name = "comboBoxMonSelect";
            this.comboBoxMonSelect.Size = new System.Drawing.Size(333, 23);
            this.comboBoxMonSelect.TabIndex = 8;
            this.comboBoxMonSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxMonSelect_SelectedIndexChanged);
            // 
            // labelSaturday
            // 
            this.labelSaturday.AutoSize = true;
            this.labelSaturday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSaturday.Location = new System.Drawing.Point(30, 360);
            this.labelSaturday.Name = "labelSaturday";
            this.labelSaturday.Size = new System.Drawing.Size(78, 19);
            this.labelSaturday.TabIndex = 7;
            this.labelSaturday.Text = "Saturday";
            // 
            // labelSunday
            // 
            this.labelSunday.AutoSize = true;
            this.labelSunday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSunday.Location = new System.Drawing.Point(35, 427);
            this.labelSunday.Name = "labelSunday";
            this.labelSunday.Size = new System.Drawing.Size(68, 19);
            this.labelSunday.TabIndex = 6;
            this.labelSunday.Text = "Sunday";
            // 
            // labelFriday
            // 
            this.labelFriday.AutoSize = true;
            this.labelFriday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFriday.Location = new System.Drawing.Point(35, 290);
            this.labelFriday.Name = "labelFriday";
            this.labelFriday.Size = new System.Drawing.Size(57, 19);
            this.labelFriday.TabIndex = 4;
            this.labelFriday.Text = "Friday";
            // 
            // labelThursday
            // 
            this.labelThursday.AutoSize = true;
            this.labelThursday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelThursday.Location = new System.Drawing.Point(35, 222);
            this.labelThursday.Name = "labelThursday";
            this.labelThursday.Size = new System.Drawing.Size(78, 19);
            this.labelThursday.TabIndex = 3;
            this.labelThursday.Text = "Thursday";
            // 
            // labelWednesday
            // 
            this.labelWednesday.AutoSize = true;
            this.labelWednesday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWednesday.Location = new System.Drawing.Point(35, 153);
            this.labelWednesday.Name = "labelWednesday";
            this.labelWednesday.Size = new System.Drawing.Size(101, 19);
            this.labelWednesday.TabIndex = 2;
            this.labelWednesday.Text = "Wednesday";
            // 
            // labelTuesday
            // 
            this.labelTuesday.AutoSize = true;
            this.labelTuesday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTuesday.Location = new System.Drawing.Point(35, 84);
            this.labelTuesday.Name = "labelTuesday";
            this.labelTuesday.Size = new System.Drawing.Size(73, 19);
            this.labelTuesday.TabIndex = 1;
            this.labelTuesday.Text = "Tuesday";
            // 
            // labelMonday
            // 
            this.labelMonday.AutoSize = true;
            this.labelMonday.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMonday.Location = new System.Drawing.Point(35, 36);
            this.labelMonday.Name = "labelMonday";
            this.labelMonday.Size = new System.Drawing.Size(70, 18);
            this.labelMonday.TabIndex = 0;
            this.labelMonday.Text = "Monday";
            // 
            // buttonAddToShoppingList
            // 
            this.buttonAddToShoppingList.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddToShoppingList.Location = new System.Drawing.Point(608, 507);
            this.buttonAddToShoppingList.Name = "buttonAddToShoppingList";
            this.buttonAddToShoppingList.Size = new System.Drawing.Size(205, 63);
            this.buttonAddToShoppingList.TabIndex = 6;
            this.buttonAddToShoppingList.Text = "Add to Shopping List";
            this.toolTipPlanMeals.SetToolTip(this.buttonAddToShoppingList, "Plan your weekly meals");
            this.buttonAddToShoppingList.UseVisualStyleBackColor = true;
            this.buttonAddToShoppingList.Click += new System.EventHandler(this.buttonAddToShoppingList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 580);
            this.Controls.Add(this.buttonAddToShoppingList);
            this.Controls.Add(this.groupBoxPlanMeals);
            this.Controls.Add(this.buttonRecipes);
            this.Controls.Add(this.buttonPreviousMeals);
            this.Controls.Add(this.buttonPlanMeals);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Meal Allocator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxPlanMeals.ResumeLayout(false);
            this.groupBoxPlanMeals.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPlanMeals;
        private System.Windows.Forms.Button buttonPreviousMeals;
        private System.Windows.Forms.Button buttonRecipes;
        private System.Windows.Forms.GroupBox groupBoxPlanMeals;
        private System.Windows.Forms.Label labelSaturday;
        private System.Windows.Forms.Label labelSunday;
        private System.Windows.Forms.Label labelFriday;
        private System.Windows.Forms.Label labelThursday;
        private System.Windows.Forms.Label labelWednesday;
        private System.Windows.Forms.Label labelTuesday;
        private System.Windows.Forms.Label labelMonday;
        private System.Windows.Forms.ComboBox comboBoxSunSelect;
        private System.Windows.Forms.ComboBox comboBoxSatSelect;
        private System.Windows.Forms.ComboBox comboBoxFriSelect;
        private System.Windows.Forms.ComboBox comboBoxThuSelect;
        private System.Windows.Forms.ComboBox comboBoxTueSelect;
        private System.Windows.Forms.ComboBox comboBoxWedSelect;
        private System.Windows.Forms.ComboBox comboBoxMonSelect;
        private System.Windows.Forms.ToolTip toolTipPlanMeals;
        private System.Windows.Forms.ToolTip toolTipRecipes;
        private System.Windows.Forms.ToolTip toolTipPreviousMeals;
        private System.Windows.Forms.Button buttonAddToShoppingList;
    }
}

