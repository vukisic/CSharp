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

namespace DB_Intro
{
    public partial class Main : Form
    {
        string ConnectionString;
        SqlConnection sql;
        public Main()
        {
            InitializeComponent();
            ConnectionString = ConfigurationManager.ConnectionStrings["DB_Intro.Properties.Settings.DB_TransformerConnectionString"].ConnectionString;

        }

        private void Main_Load(object sender, EventArgs e)
        {
            PopulateTransformers();
            PopulateAllPlaces();
        }

        private void PopulateTransformers()
        {
            using (sql = new SqlConnection(ConnectionString))
            using(SqlDataAdapter adapter=new SqlDataAdapter("Select * from Transformers",sql))
            {
                DataTable TransformerTable = new DataTable();
                adapter.Fill(TransformerTable);

                listBoxTransfromer.DisplayMember = "Name";
                listBoxTransfromer.ValueMember = "Id";
                listBoxTransfromer.DataSource = TransformerTable;

            }
        }

        private void PopulateAllPlaces()
        {
            using (sql = new SqlConnection(ConnectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("Select * from Place", sql))
            {
                DataTable PlaceTable = new DataTable();
                adapter.Fill(PlaceTable);

                listBoxNewPlaces.DisplayMember = "Place";
                listBoxNewPlaces.ValueMember = "Id";
                listBoxNewPlaces.DataSource = PlaceTable;

            }
        }

        private void PopulatePlaces()
        {
            string query = "Select a.Place from Place a Inner Join TransPlace b ON a.Id = b.PlaceId where b.TransformerId = @param";


            using (sql = new SqlConnection(ConnectionString))
            using (SqlCommand command=new SqlCommand(query,sql))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@param", listBoxTransfromer.SelectedValue);

                DataTable PlaceTable = new DataTable();
                adapter.Fill(PlaceTable);

                listBoxPlace.DisplayMember = "Place";
                listBoxPlace.ValueMember = "Id";
                listBoxPlace.DataSource = PlaceTable;

            }
        }

        private void ShowInfo()
        {
            string query = "Select * from Transformers where Id=@param1";


            using (sql = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand(query, sql))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@param1", listBoxTransfromer.SelectedValue);

                DataTable InfoTable = new DataTable();
                adapter.Fill(InfoTable);

                DataRow row = InfoTable.Rows[0];

                textBoxPPower.Text = row["Power"].ToString();
                textBoxPAddition.Text = row["Additionl"].ToString();

            }
        }

        private void listBoxTransfromer_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulatePlaces();
            ShowInfo();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string query = "Insert into Transformers Values(@param1,@param2,@param3)";

            //SqlDataReader reader;

            using (sql = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand(query, sql))
            {
                sql.Open();

                command.Parameters.AddWithValue("@param1",textBoxName.Text);
                command.Parameters.AddWithValue("@param2",PowerUpDown.Value);
                command.Parameters.AddWithValue("@param3",textBoxAdditional.Text);

                command.ExecuteScalar();
                //reader = command.ExecuteReader();
            }

            PopulateTransformers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "Insert into Place Values(@param1)";
            using (sql = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand(query, sql))
            {
                sql.Open();

                command.Parameters.AddWithValue("@param1", textBoxPName.Text);

                command.ExecuteScalar();
            }

            PopulateAllPlaces();
        }

        private void AddPlaceBtn_Click(object sender, EventArgs e)
        {
            string query = "Insert into TransPlace Values(@param1,@param2)";
            using (sql = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand(query, sql))
            {
                sql.Open();

                command.Parameters.AddWithValue("@param1", listBoxTransfromer.SelectedValue);
                command.Parameters.AddWithValue("@param2", listBoxNewPlaces.SelectedValue);

                command.ExecuteScalar();
            }

            PopulateTransformers();

        }
    }
}
