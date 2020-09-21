using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apu_s_Cook_Book
{
    public partial class MainForm : Form
    {
        // Defines number of ingredients and recipes
        private const int numOfIngredients = 20; 
        private const int maxNumOfElements = 30; 

        // new current recipe based on max number of allowed ingredients
        Recipe currRecipe = new Recipe(numOfIngredients);  

        // new recipe manager based on max number of allowed recipes
        RecipeManager recipeMngr = new RecipeManager(maxNumOfElements);

        public MainForm() 
        {
            InitializeComponent();
            InitializeGUI();
        }
        private void InitializeGUI()
        {
            this.Text = "Apu's Cook Book";

            cmboBoxTypeRecipe.Items.AddRange(Enum.GetNames(typeof(FoodCategory))); // Adds items from enum FoodCategory
            cmboBoxTypeRecipe.SelectedIndex = (int) FoodCategory.Vegetarian; // Default food category at start
            lblNumItemsShow.Text = "0";

        }

        // Add ingredient button that opens another form
        private void bttnAddIngred_Click(object sender, EventArgs e) 
        {
            FormIngredient dlg = new FormIngredient(currRecipe);
            DialogResult dialogResult = dlg.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {
                if (currRecipe.GetCurrentNumOfIngred() <= 0)
                {
                    MessageBox.Show("No ingredients added!");
                    recipeMngr.Add(currRecipe);
                    UpdateGUI();
                }
            }
        }
        public void UpdateGUI()
        {
            string[] recipeListToString = recipeMngr.RecipeListToString();
            listBoxMainRecipe.Items.Clear();
            listBoxMainRecipe.Items.AddRange(recipeListToString);
            cmboBoxTypeRecipe.SelectedIndex = (int)FoodCategory.Vegetarian;
            txtBoxNameOfRecipe.Clear();
            txtBoxDesc.Clear();
            int currnum = recipeMngr.CurrentNumOfItems();
            lblNumItemsShow.Text = currnum.ToString();


        }
        // Add Recipe button
        private void bttnAddRecipe_Click(object sender, EventArgs e)
        {

            currRecipe.Category = (FoodCategory)cmboBoxTypeRecipe.SelectedIndex;
            currRecipe.Name = txtBoxNameOfRecipe.Text.Trim();
            currRecipe.Description = txtBoxDesc.Text.Trim();

            recipeMngr.Add(currRecipe);

            currRecipe = new Recipe(numOfIngredients);

            UpdateGUI();

            currRecipe.DefaultValues();

        }

        // Delete recipe button
        private void bttnDeleteRecipe_Click(object sender, EventArgs e)
        {
            if (listBoxMainRecipe.SelectedIndex >= 0)
            {
                int index = listBoxMainRecipe.Items.IndexOf(listBoxMainRecipe.SelectedItem);
                listBoxMainRecipe.Items.RemoveAt(listBoxMainRecipe.SelectedIndex);
                recipeMngr.DeleteElementAt(index);
                currRecipe = new Recipe(numOfIngredients);
            }
            currRecipe.DefaultValues();

            int currnum = recipeMngr.CurrentNumOfItems();
            lblNumItemsShow.Text = currnum.ToString();
        }
    }
}
