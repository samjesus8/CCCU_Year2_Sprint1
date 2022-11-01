using Assessment1._1.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Assessment1._1
{
    public partial class FormRecipes : Form
    {
        public int CurrentAllRecipeID = 1;
        public Dictionary<int, MealBuilder1> mBuilder = Program.mStorage.RecipeList;
        public Dictionary<int, MealBuilder1> FilteredRecipes = new Dictionary<int, MealBuilder1>();
        public Dictionary<int, MealBuilder1> TempRecipes = new Dictionary<int, MealBuilder1>();
        public MealStorage mStorage = Program.mStorage;

        public bool isAllRecipe = true;
        public bool isCorrectTag = true;
        public bool isFiltered = false;

        public int CurrentSavedRecipeID = 1;
        public int CurrentFilteredRecipeID = 1;
        public int SavedCount = 1;
        public int Clearcount = 0;

        public FormRecipes()
        {
            InitializeComponent();
            groupBoxRecipes.Visible = false;
        }

        private void buttonAllRecipes_Click(object sender, EventArgs e)
        {
            isAllRecipe = true;
            buttonSaveRecipe.Visible = true;
            groupBoxRecipes.Visible = true;
            UpdateRecipe();
        }

        public void UpdateRecipeByFilter() 
        {
            if (isFiltered == true)
            {

                int count = 1;
                string filterName = comboBoxFilter.Text.ToString();

                if (Program.mStorage.tagsList.Contains(filterName)) //Checks if the selected filter is in the TagList
                {
                    if (FilteredRecipes.Count == 0)
                    {
                        foreach (var recipe in Program.mStorage.RecipeList) //Loops through all the recipes in the Dictionary
                        {
                            MealBuilder1 Recipe = recipe.Value; //Getting an instance of the Builder and getting the Value key
                            List<string> Tags = Recipe.Tags; //Getting tags

                            if (Tags != null)
                            {
                                if (Tags.Contains(filterName))
                                {
                                    FilteredRecipes.Add(count, Recipe); //If it contains the filter, add it to a temporary dictionary
                                    count++;
                                    isFiltered = true;
                                    isAllRecipe = false;
                                }
                            }
                            else
                            {
                                //Exits the Filter and returns to normal
                            }

                        }
                    }
                    
                    UpdateRecipe();
                }
                UpdateLabel();
            }
            else 
            {
                UpdateRecipe();
            }
        }

        public void UpdateRecipe()
        {
            int UpdateRecipeID = 1;

            if (isAllRecipe == true)
            {
                UpdateRecipeID = CurrentAllRecipeID;
                TempRecipes = Program.mStorage.RecipeList;
            }
            else if (isFiltered == true) 
            {
                UpdateRecipeID = CurrentFilteredRecipeID;
                TempRecipes = FilteredRecipes;
            }
            else
            {
                UpdateRecipeID = CurrentSavedRecipeID;
                TempRecipes = Program.mStorage.RecipeList;
            }

            // Code to get list from Mealbuilder and get the recipe depending on Id.
            
            var mealBuilder = TempRecipes[UpdateRecipeID];

            // Code to create a text preset which contains all the information about Recipes That the user needs.
            string textMealBuilder = "Name: " + mealBuilder.Name + "\r\n" +
                                     "Source: " + mealBuilder.Source + "\r\n" +
                                     "Servings: " + mealBuilder.Servings + "\r\n" +
                                     "Comments: " + mealBuilder.Comments + "\r\n" +
                                     "Calories: " + mealBuilder.Calories + "\r\n" +
                                     "Fat: " + mealBuilder.Fat + "\r\n" +
                                     "Saturated Fat: " + mealBuilder.Satfat + "\r\n" +
                                     "Carbohydrates: " + mealBuilder.Carbs + "\r\n" +
                                     "Fiber: " + mealBuilder.Fiber + "\r\n" +
                                     "Sugar: " + mealBuilder.Sugar + "\r\n" +
                                     "Protein: " + mealBuilder.Protein + "\r\n" +
                                     "Instructions: " + mealBuilder.Instructions + "\r\n" +
                                     "Ingredients: " + String.Join(" - ", mealBuilder.Ingredients) + "\r\n" +
                                     "Tags: " + String.Join(", ", mealBuilder.Tags) + "\r\n" +
                                     "ID: " + mealBuilder.MealID;

            // Takes Text preset from above and outputs it into a Rich text box.
            richTextBoxRecipes.Text = textMealBuilder;
            UpdateLabel();
        }

        public void UpdateLabel()
        {
            if (isAllRecipe == true)
            {
                labelAllRecipes.Text = "All Recipes  |  " + CurrentAllRecipeID + " / " + mBuilder.Count();
            }
            else if (isFiltered == true) 
            {
                labelAllRecipes.Text = "Filtered Recipes  |  " + CurrentFilteredRecipeID + " / " + FilteredRecipes.Count();
            }
            else
            {
                labelAllRecipes.Text = "Saved Recipes  |  " + CurrentSavedRecipeID + " / " + Program.mStorage.SavedRecipeList.Count();
            }
        }

        public void UpdateFilterDropDown()
        {
            foreach (string tag in mStorage.tagsList)
            {
                comboBoxFilter.Items.Add(tag);
            }
        }



        private void buttonSaveRecipe_Click(object sender, EventArgs e)
        {
            // saves current recipe to saved recipes
            MealBuilder1 CurrentRecipe = Program.mStorage.RecipeList[CurrentAllRecipeID];
            if (Program.mStorage.SavedRecipeList.ContainsKey(CurrentAllRecipeID))
            {
                MessageBox.Show("Recipe Already Saved! ");
            }
            else
            {
                Program.mStorage.SavedRecipeList.Add(SavedCount, CurrentRecipe);
                SavedCount++;
            }            
        }

        private void buttonPreviousRecipe_Click(object sender, EventArgs e)
        {
            if (isAllRecipe == true)
            {
                // openes a previous recipe
                if (CurrentAllRecipeID == 1)
                {
                    CurrentAllRecipeID = mBuilder.Count;
                    UpdateRecipe();
                }
                else
                {
                    CurrentAllRecipeID--;
                    UpdateRecipe();
                }
            }
            else if (isFiltered == true)
            {
                if (CurrentFilteredRecipeID == 1)
                {
                    CurrentFilteredRecipeID = FilteredRecipes.Count;
                    UpdateRecipeByFilter();
                }
                else
                {
                    CurrentFilteredRecipeID--;
                    UpdateRecipeByFilter();
                }
            }
            else
            {
                if (CurrentSavedRecipeID == 1)
                {
                    CurrentSavedRecipeID = Program.mStorage.SavedRecipeList.Count;
                    UpdateRecipe();
                }
                else
                {
                    CurrentSavedRecipeID--;
                    UpdateRecipe();
                }
            }

        }

        private void buttonNextRecipe_Click(object sender, EventArgs e)
        {
            if (isAllRecipe == true)
            {
                // opens a new recipe
                if (CurrentAllRecipeID == mBuilder.Count)
                {
                    CurrentAllRecipeID = 1;
                    UpdateRecipe();
                }
                else
                {
                    CurrentAllRecipeID++;
                    UpdateRecipe();
                }
            }
            else if (isFiltered == true)
            {
                if (CurrentFilteredRecipeID == FilteredRecipes.Count)
                {
                    CurrentFilteredRecipeID = 1;
                    UpdateRecipeByFilter();
                }
                else 
                {
                    CurrentFilteredRecipeID++;
                    UpdateRecipeByFilter();
                }
            }
            else
            {
                if (CurrentSavedRecipeID == Program.mStorage.SavedRecipeList.Count)
                {
                    CurrentSavedRecipeID = 1;
                    UpdateRecipe();
                }
                else
                {
                    CurrentSavedRecipeID++;
                    UpdateRecipe();
                }
            }          
        }

        private void FormRecipes_Load(object sender, EventArgs e)
        {
            UpdateLabel();
            UpdateFilterDropDown();
            CreateFilteredRecipeList();

            if (Clearcount == 0)
            {
                Clearcount++;
            }
            else
            {
                FilteredRecipes.Clear();
                Clearcount = 1;
            }
        }

        private void buttonSavedRecipes_Click(object sender, EventArgs e)
        {
            if (Program.mStorage.SavedRecipeList.Count > 0)
            {
                isAllRecipe = false;
                isFiltered = false;
                buttonSaveRecipe.Visible = false;
                // Code to get list from Mealbuilder and get the recipe depending on Id.
                var mealBuilder = Program.mStorage.SavedRecipeList[CurrentSavedRecipeID];

                // Code to create a text preset which contains all the information about Recipes That the user needs.
                string textMealBuilder = "Name: " + mealBuilder.Name + "\r\n" +
                                         "Source: " + mealBuilder.Source + "\r\n" +
                                         "Servings: " + mealBuilder.Servings + "\r\n" +
                                         "Comments: " + mealBuilder.Comments + "\r\n" +
                                         "Calories: " + mealBuilder.Calories + "\r\n" +
                                         "Fat: " + mealBuilder.Fat + "\r\n" +
                                         "Saturated Fat: " + mealBuilder.Satfat + "\r\n" +
                                         "Carbohydrates: " + mealBuilder.Carbs + "\r\n" +
                                         "Fiber: " + mealBuilder.Fiber + "\r\n" +
                                         "Sugar: " + mealBuilder.Sugar + "\r\n" +
                                         "Protein: " + mealBuilder.Protein + "\r\n" +
                                         "Instructions: " + mealBuilder.Instructions + "\r\n" +
                                         "Ingredients: " + String.Join(" - ", mealBuilder.Ingredients) + "\r\n" +
                                         "Tags: " + String.Join(", ", mealBuilder.Tags) + "\r\n" +
                                         "ID: " + mealBuilder.MealID;

                // Takes Text preset from above and outputs it into a Rich text box.
                richTextBoxRecipes.Text = textMealBuilder;
                UpdateLabel();
            }
            else
            {
                MessageBox.Show("No Saved Recipes!");
            }
        }
        public void CreateFilteredRecipeList()
        {
            string filterName = comboBoxFilter.Text;
            int count = 1;
            foreach (var recipe in Program.mStorage.RecipeList) //Loops through all the recipes in the Dictionary
            {
                MealBuilder1 Recipe = recipe.Value; //Getting an instance of the Builder and getting the Value key
                List<string> Tags = Recipe.Tags; //Getting tags

                if (Tags != null)
                {
                    if (Tags.Contains(filterName))
                    {
                        FilteredRecipes.Add(count, Recipe); //If it contains the filter, add it to a temporary dictionary
                        count++;
                        isFiltered = true;
                        isAllRecipe = false;
                    }
                }
                else
                {
                    //Exits the Filter and returns to normal
                }

            }
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            isFiltered = true;
            isAllRecipe = false;
            FilteredRecipes.Clear(); //Clears the temporary filter to get it ready for a new selection
            richTextBoxRecipes.Clear();

            UpdateRecipeByFilter();
        }
    }
}
