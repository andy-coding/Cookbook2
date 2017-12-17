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
        string connectionString;
        SqlConnection connection;

        public Form1()
        {
            InitializeComponent();

            DisplayRecipe();

        }

        private void DisplayRecipe()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Cookbook2.Properties.Settings.Cookbook2ConnectionString"].ConnectionString;

            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Recipe", connection))
            {
                DataTable data = new DataTable();

                adapter.Fill(data);

                lstRecipes.DisplayMember = "Recipe";
                lstRecipes.ValueMember = "RecipeId";
                lstRecipes.DataSource = data;
            }
        }

        private void DisplayRecipeIngredients()
        {
            string query = "SELECT a.Ingredient FROM Ingredient a INNER JOIN RecipeIngredient b " +
                " ON (a.IngredientId = b.IngredientId) WHERE b.RecipeId = @RecipeId";

            connectionString = ConfigurationManager.ConnectionStrings["Cookbook2.Properties.Settings.Cookbook2ConnectionString"].ConnectionString;

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@RecipeId", lstRecipes.SelectedValue);

                DataTable data = new DataTable();

                adapter.Fill(data);

                lstIngredients.DisplayMember = "Ingredient";
                lstIngredients.ValueMember = "IngredientId";
                lstIngredients.DataSource = data;
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lstRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(lstRecipes.SelectedValue.ToString());
            DisplayRecipeIngredients();
        }


    }
}
