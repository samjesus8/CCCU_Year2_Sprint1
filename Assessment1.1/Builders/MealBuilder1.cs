using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Assessment1._1.Builders
{
    public class MealStorage
    {
        public Dictionary<int, MealBuilder1> RecipeList = new Dictionary<int, MealBuilder1>();
        public Dictionary<int, MealBuilder1> SavedRecipeList = new Dictionary<int, MealBuilder1>();

        public List<string> TagList = new List<string>();
        public List<string> tagsList = new List<string>();

        private static readonly MealStorage instance = new MealStorage();

        public static MealStorage Instance
        {
            get
            {
                return instance;
            }
        }

        public bool loop = false;

        // Code to take all recipes out from Json file and save them into a dictionary for later use.
        public void CreateAllMeals()
        {
            int count = 1;

            var recipe = new MealBuilder1();
            RecipeList.Add(count, recipe);
            

            while (count < MealBuilder1.JsonLength)
            {
                count++;
                recipe = new MealBuilder1();


                foreach (string tag in recipe.Tags)
                {
                    if (instance.tagsList.Contains(tag))
                    {
                    }
                    else
                    {
                        instance.tagsList.Add(tag);
                    }
                }

                RecipeList.Add(count, recipe);
                
            }


        }
    }
    

    public class MealBuilder1
    {
        public static int JsonLength;
        public static int Count = 0;
        public string MealID { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }
        public string Servings { get; set; }
        public string Comments { get; set; }
        public string Calories { get; set; }
        public string Fat { get; set; }
        public string Satfat { get; set; }
        public string Carbs { get; set; }
        public string Fiber { get; set; }
        public string Sugar { get; set; }
        public string Protein { get; set; }
        public string Instructions { get; set; }
        public List<string> Ingredients { get; set; }
        public List<string> Tags { get; set; }
        public string myJsonResponse { get; }

        public MealBuilder1()
        {

            using (StreamReader r = new StreamReader("recipes.json")) 
            {
                string json = r.ReadToEnd(); //Reading the JSON file
                JSONObject obj = JsonConvert.DeserializeObject<JSONObject>(json); //Filtering out all the properties inside the JSON File

                JsonLength = obj.members.Count();

                if (Count < JsonLength)
                {
                    var data = obj.members[Count];

                    MealID = (Count + 1).ToString();
                    Name = data.name;
                    Source = data.source;
                    Servings = data.servings;
                    Comments = data.comments;
                    Calories = data.calories;
                    Fat = data.fat;
                    Satfat = data.satfat;
                    Carbs = data.carbs;
                    Fiber = data.fiber;
                    Protein = data.protein;
                    Instructions = data.instructions;
                    Ingredients = data.ingredients;
                    Tags = data.tags;
                    Count = Count + 1;

                    MealStorage ms = new MealStorage();

                }
                else
                {
                }

            }
        }

    }
    class JSONObject 
    {
        public string recipesList { get; set; } //Getting the information from the JSON File
        public Member[] members { get; set; } //Stores each property of each member of the JSON file
    }

    class Member 
    {
        public string id { get; set; } //Assigning each property of the JSON file in code to be used in the constructor
        public string name { get; set; }
        public string source { get; set; }
        public string servings { get; set; }
        public string comments { get; set; }
        public string calories { get; set; }
        public string fat { get; set; }
        public string satfat { get; set; }
        public string carbs { get; set; }
        public string fiber { get; set; }
        public string sugar { get; set; }
        public string protein { get; set; }
        public string instructions { get; set; }
        public List<string> ingredients { get; set; }
        public List<string> tags { get; set; }
    }

}
