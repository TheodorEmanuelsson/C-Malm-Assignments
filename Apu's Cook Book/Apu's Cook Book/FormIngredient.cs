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
    public partial class FormIngredient : Form
    {
        Recipe m_recipe;
        public FormIngredient(Recipe recipe)
        {
            InitializeComponent();

            m_recipe = recipe;

            if (string.IsNullOrEmpty(recipe.Name))
                this.Text = "No Recipe Name";
            else
                this.Text = "Add ingredients to " + recipe.Name;

            InitializeGUI();
        }

        public void InitializeGUI()
        {
            if (m_recipe.Ingredients == null)
                m_recipe.Ingredients = new string[m_recipe.MaxNumOfIngred];

            listBoxIngredSub.Items.Clear();
            lblCurrNoIngredSub.Text = m_recipe.GetCurrentNumOfIngred().ToString();

        }
        // Adds a new ingredient(string) to the listbox
        private void bttnAddIngredSub_Click(object sender, EventArgs e)
        {
            if(txtBoxAddIngredSub.Text.Length > 0)
            {
                m_recipe.AddIngred(txtBoxAddIngredSub.Text);
                listBoxIngredSub.Items.Add(txtBoxAddIngredSub.Text);
                txtBoxAddIngredSub.Clear();
            }

            UpdateGUI();

        }

        // Edits the selected row in the listbox with text that is in textbox
        private void bttnEditIngredSub_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxIngredSub.SelectedIndex;

            if (selectedIndex >= 0)
                listBoxIngredSub.Items[selectedIndex] = txtBoxAddIngredSub.Text;

            txtBoxAddIngredSub.Clear();

        }
        // Deletes the selected row in the listbox
        private void bttnDelIngredSub_Click(object sender, EventArgs e)
        {
            if (listBoxIngredSub.SelectedIndex >= 0)
            {
                int index = listBoxIngredSub.Items.IndexOf(listBoxIngredSub.SelectedItem);
                m_recipe.DeleteIngredientAt(index);
                listBoxIngredSub.Items.RemoveAt(listBoxIngredSub.SelectedIndex);
            }
           
            UpdateGUI();
        }

        // Makes the txt of selected row in the listbox show in the txtbox for adding ingredients.
        // In order to edit
        private void listBoxIngredSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxIngredSub.SelectedIndex >= 0)
                txtBoxAddIngredSub.Text = listBoxIngredSub.Text;
            else
                txtBoxAddIngredSub.Text = "";
        }


        public void UpdateGUI()
        {
          listBoxIngredSub.Items.Clear();

          for (int index = 0; index < m_recipe.MaxNumOfIngred; index++)
             if (!string.IsNullOrEmpty(m_recipe.Ingredients[index]))
                listBoxIngredSub.Items.Add(m_recipe.Ingredients[index]);

            lblCurrNoIngredSub.Text = m_recipe.GetCurrentNumOfIngred().ToString();

        }
    }
}
