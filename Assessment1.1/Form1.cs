using Assessment1._1.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        object myRecipeMonday;
        object myRecipeTuesday;
        object myRecipeWednesday;
        object myRecipeThursday;
        object myRecipeFriday;
        object myRecipeSaturday;
        object myRecipeSunday;




        public List<string> shoppingList = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBoxPlanMeals.Visible = false;

            /// need to load recipe data & add to the combo box selection
            ShowSelectedMeal();

            
        }

        /// <summary>
        /// code to show which meal has been selected 
        /// </summary>
        private void ShowSelectedMeal()
        {
            Dictionary<int, MealBuilder1> RecipeList = Program.mStorage.RecipeList;
            
            // to add a random number selecter
            foreach (var Meal in RecipeList)
            {
                MealBuilder1 meal = Meal.Value;
                comboBoxMonSelect.Items.Add(meal.Name);
                comboBoxTueSelect.Items.Add(meal.Name);
                comboBoxWedSelect.Items.Add(meal.Name);
                comboBoxThuSelect.Items.Add(meal.Name);
                comboBoxFriSelect.Items.Add(meal.Name);
                comboBoxSatSelect.Items.Add(meal.Name);
                comboBoxSunSelect.Items.Add(meal.Name);
                

            }
        }

        private void buttonPlanMeals_Click(object sender, EventArgs e)
        {
            groupBoxPlanMeals.Visible=true;
        }

        private void buttonRecipes_Click(object sender, EventArgs e)
        {
            FormRecipes recform = new FormRecipes();
            recform.Show();
            
            
        }

        /// <summary>
        /// when Add to shopping list is pressed, adds the ingrediants to the shoppinglist and a message box pops up and shows the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddToShoppingList_Click(object sender, EventArgs e)
        {
            Dictionary<int, MealBuilder1> RecipeList = Program.mStorage.RecipeList;


            string ingredientList ="";

            foreach (string str in shoppingList)
            {
                // to add a random number selecter
                foreach (var Meal in RecipeList)
                {
                    MealBuilder1 meal = Meal.Value;
                    if (meal.Name == str)
                    {
                        ingredientList = ingredientList + "\n\n" + str + (String.Join("\n", meal.Ingredients).ToString());
                        break;
                    }
                }
            }
            MessageBox.Show("This is your shopping list: \n" + ingredientList);
           
        }

        /// <summary>
        /// selected item becomes object??? where we can take the ingredients  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxMonSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            // check the selected item & add to shoppinglist (need to change to ingredients only)
            Dictionary<int, MealBuilder1> RecipeList = Program.mStorage.RecipeList;

            if (comboBoxMonSelect.SelectedItem != null)
            {
                shoppingList.Add((comboBoxMonSelect.Text).ToString());                 
            }



            
        }

        private void comboBoxTueSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTueSelect.SelectedItem != null)
            {
                shoppingList.Add((string)comboBoxTueSelect.Text);
            }
        }

        private void comboBoxWedSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxWedSelect.SelectedItem != null)
            {
                shoppingList.Add((string)comboBoxWedSelect.Text);
            }
        }
        private void comboBoxThuSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxThuSelect.SelectedItem != null)
            {
                shoppingList.Add((string)comboBoxThuSelect.Text);
            }
        }
        private void comboBoxFriSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFriSelect.SelectedItem != null)
            {
                shoppingList.Add((string)comboBoxFriSelect.Text);
            }
        }

        private void comboBoxSatSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSatSelect.SelectedItem != null)
            {
                shoppingList.Add((string)comboBoxSatSelect.Text);
            }
        }

        private void comboBoxSunSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSunSelect.SelectedItem != null)
            {
                shoppingList.Add((string)comboBoxSunSelect.Text);
            }
        }

        
    }
}
