using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_s_Cook_Book
{
    public class Recipe
    {
        
        private string[] ingredientArray;  // The array for ingredients
        private string name;               // The string for name of recipe
        private FoodCategory category;      // The category for recipe
        private string description;         // The string for description of recipe
        private const int maxNumOfIngred = 20;  // The max number of ingredients

        // Get max number of ingredients
        public int MaxNumOfIngred  
        {
            get { return ingredientArray.Length; }
        }
        //Get and Set name of recepie
        public string Name  
        {
            get { return name; }
            set { name = value; }
        }
        //Get and Set description
        public string Description  
        {
            get { return description; }
            set 
            { 
                if(!string.IsNullOrEmpty(value))
                    description = value;
            }
        }
        //Get and Set Category
        public FoodCategory Category  
        {
            get { return category; }
            set { category = value; }
        }
        // Get and Set Ingredient array
        public string[] Ingredients  
        {
            get { return ingredientArray; }
            set { ingredientArray = value;  }
        }

        // Recipe takes in input of max allowed number of ingredients and creates a new array
        public Recipe(int maxNumOfIngred)  
        {
            ingredientArray = new string[maxNumOfIngred];
            DefaultValues();
        }

        public void DefaultValues()  
        {
            for (int index = 0; index < ingredientArray.Length; index++)
            {
                ingredientArray[index] = string.Empty;
                name = string.Empty;
                category = FoodCategory.Vegetarian;
                description = string.Empty;
            }
        }
        // Looks for a vacant position in the array
        private int FindVacantPos()  
        {
            int vacantPos = -1;

            for (int i = 0; i < ingredientArray.Length; i++)
            {
                if (string.IsNullOrEmpty(ingredientArray[i]))
                {
                    vacantPos = i;
                    break;
                }
            }
            return vacantPos;
        }

        // Add ingredient method
        public bool AddIngred(string value) 
        {
            bool ok = true;
            int vacantPos = FindVacantPos();

            if (vacantPos != -1)
            {
                ingredientArray[vacantPos] = value;
            }
            else
                return false;

            return ok;
        }

        // Get Current number of ingredients method
        public int GetCurrentNumOfIngred()
        {
            int currNum = 0;

            for (int i = 0; i < ingredientArray.Length; i++)
            {
                if(!string.IsNullOrEmpty(ingredientArray[i]))
                {
                    currNum++;
                }
            }
            return currNum;
        }

        // Bool that checks the index of the array
        public bool CheckIndex(int index)  
        {

            if (index >= 0 && index <= ingredientArray.Length)
            {
                return true;
            }
            else
                return false;
        }
        

        public override string ToString()  
        {
            int CurrentNumOfIngred = GetCurrentNumOfIngred();
            int charsDesc = Math.Min(description.Length, 15);
            int charsName = Math.Min(name.Length, 12);
            string descriptionText = description.Substring(0, charsDesc);
            string nameText = name.Substring(0, charsName);

            if (string.IsNullOrEmpty(descriptionText))
                descriptionText = "No Description";

            string textOut = string.Format("{0, -20} {1,4}      {2, -12}    {3, -15}",
                nameText.ToString(), CurrentNumOfIngred.ToString(), category.ToString(), descriptionText); ;

            return textOut; 
        }
        // Bool change ingredient at index method
        public bool ChangeIngredientAt(int index, string value)  
        {
            bool ok = true;

            if (CheckIndex(index))
                ingredientArray[index] = value;
            else
                ok = false;

            return ok;
        }
        // Bool delete ingredient at index method
        public bool DeleteIngredientAt(int index)  
        {
            bool ok = true;

            if (CheckIndex(index))
                ingredientArray[index] = null; 
            else
                ok = false;

            return ok;
        }
    
    }
}
