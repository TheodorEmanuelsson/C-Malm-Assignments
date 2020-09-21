using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_s_Cook_Book
{
    public class RecipeManager
    {
        // declaration new list of recipes
        private Recipe[] recipeList;

        public RecipeManager(int maxNumOfElements)
        {
            recipeList = new Recipe[maxNumOfElements];
        }

        // Finds vacant position in recipe array
        private int FindVacantPos()
        {
            for (int index = 0; index < recipeList.Length; index ++)
            {
                if (recipeList[index] == null)
                {
                    return index;
                }
            }
            return -1;
        }

        // Bool for checking index in recipe array
        public bool CheckIndex(int index)
        {
            bool ok = true;

            if (index >= 0 && index < recipeList.Length)
            {
                return ok;
            }
            else
                return false;
        }

        // Get recipe at array index; Returns: Name, No ingred, Category and Description.
        public Recipe GetRecipeAt (int index)
        {
            if (CheckIndex(index))
                return recipeList[index];
            else
                return null;
        }

        // Add recipe new method
        public bool Add(Recipe newRecipe)
        {
            bool ok = true;
            int vacantPos = FindVacantPos();

            if (vacantPos != -1)
            {
                recipeList[vacantPos] = newRecipe;
            }
            else
                return false;

            return ok;
        }
        
        // Add values related to recipe
        public bool Add(string name, FoodCategory category, string[] ingredients)
        {
            bool ok = false;

            int index = FindVacantPos();

            if(index >= 0)
            {
                Recipe recipe = new Recipe(ingredients.Length);
                recipe.Name = name;
                recipe.Ingredients = ingredients;
                recipe.Category = category;

                recipeList[index] = recipe;
                ok = true;
            }
            return ok;
        }

        // Bool for changing recipe at index, specific recipe
        public bool ChangeElementAt(int index, Recipe recipe)
        {
            bool ok = true;

            if (CheckIndex(index))
                recipeList[index] = recipe;
            else
                ok = false;

            return ok;
        }

        // Bool for deleting recipe at index
       public bool DeleteElementAt(int index)
        {
            bool ok = true;

            if (CheckIndex(index))
                recipeList[index] = null;
            else
                ok = false;
 
            return ok;
         }

        // Returns number of recipes
        public int CurrentNumOfItems()
        {
            int currNum = 0;

            for( int index = 0; index < recipeList.Length; index++)
            {
                if (recipeList[index] != null)
                    currNum++;
            }
            return currNum;
        }

        // Converts recipelist to string
        public string[] RecipeListToString()
        {
            string[] output = new string[recipeList.Length];
            for (int index = 0; index < recipeList.Length; index++)
            {
                if (recipeList[index] != null)
                    output[index] = recipeList[index].ToString();
                else
                    output[index] = string.Empty;
            }
            return output;
        }

    }
}
