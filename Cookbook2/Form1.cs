using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Cookbook2
{
    public partial class Form1 : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Cookbook2.Properties.Settings.Cookbook2ConnectionString"].ConnectionString;

        SqlConnection connection;

        public Form1()
        {
            InitializeComponent();

            DisplayRecipe();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void DisplayRecipe()
        {

            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Recipe ORDER BY Recipe ", connection))
            {
                DataTable data = new DataTable();

                adapter.Fill(data);

                lstRecipes.DisplayMember = "Recipe";
                lstRecipes.ValueMember = "RecipeId";
                lstRecipes.DataSource = data;
            }
        }

        private void lstRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(lstRecipes.SelectedValue.ToString());
            DisplayRecipeIngredients();
            DisplayAllIngredients();
        }

        private void DisplayRecipeIngredients()
        {
            string query = "SELECT a.Ingredient, a.IngredientId FROM Ingredient a INNER JOIN RecipeIngredient b " +
                " ON (a.IngredientId = b.IngredientId) WHERE b.RecipeId = @RecipeId ORDER BY a.Ingredient";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@RecipeId", lstRecipes.SelectedValue);

                DataTable data = new DataTable();

                adapter.Fill(data);

                lstRecipeIngredients.DisplayMember = "Ingredient";
                lstRecipeIngredients.ValueMember = "IngredientId";
                lstRecipeIngredients.DataSource = data;
            }
        }

        private void DisplayAllIngredients()
        {

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT * FROM Ingredient", connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {

                DataTable ingredientTable = new DataTable();
                adapter.Fill(ingredientTable);
                listAllIngredients.DisplayMember = "Ingredient";
                listAllIngredients.ValueMember = "IngredientId";
                listAllIngredients.DataSource = ingredientTable;
            }
        }



        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Recipe VALUES (@RecipeName)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@RecipeName", txtRecipeName.Text);
                command.ExecuteNonQuery();

                DisplayRecipe();
            }
        }

        private void btnUpdateRecipeName_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("UPDATE Recipe SET Recipe = @RecipeName WHERE RecipeId = @RecipeId" , connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@RecipeId", lstRecipes.SelectedValue);
                command.Parameters.AddWithValue("@RecipeName", txtRecipeName.Text);

                command.ExecuteNonQuery();

                DisplayRecipe();
            }
        }



        private void btnAddToRecipe_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("INSERT INTO RecipeIngredient VALUES (@RecipeId, @IngredientId)", connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@RecipeId", lstRecipes.SelectedValue);
                command.Parameters.AddWithValue("@IngredientId", listAllIngredients.SelectedValue);

              //  int selectedRecipeId = (Int32)lstRecipes.SelectedItem;

                command.ExecuteScalar();

                DisplayRecipeIngredients();

              //  selectedRecipeId = 0;

            }
        }

        private void btnRemoveFromRecipe_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM RecipeIngredient WHERE RecipeId = @RecipeId AND IngredientId = @IngredientId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@RecipeId", lstRecipes.SelectedValue);
                command.Parameters.AddWithValue("@IngredientId", lstRecipeIngredients.SelectedValue);

                command.ExecuteNonQuery();

                DisplayRecipeIngredients();
            }

        }
    }
    
}
