using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class Form1 : Form
    {

        private static readonly string uri =
           System.Configuration.ConfigurationManager.AppSettings["URI"];

        private static readonly string primaryKey =
            System.Configuration.ConfigurationManager.AppSettings["PrimaryKey"];


        private Microsoft.Azure.Cosmos.CosmosClient myClient;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_CosmosClient_Click(object sender, EventArgs e)
        {
            try
            {
                myClient = new Microsoft.Azure.Cosmos.CosmosClient(uri, primaryKey);

                MessageBox.Show(" Create Cosmos Client object was created",
                                "creating cosmos client",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                btn_CreateClient_Click.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Unabled to create Cosmos Client object",
                                "Error creating cosmos client",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }




        private void Form1_Load_1(object sender, EventArgs e)
        {
            textBox1_URI.Text = uri;
            textBox1_PrimaryKey.Text = primaryKey;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
                //Read the information from the screen.
                string dbName = textBox1_DBtoCreate.Text;
                string tableName = textBox2_tableToCreate.Text;

               await CreateDatabaseAndTable(dbName, tableName);
           
        }

        private async Task CreateDatabaseAndTable(string dbName, string tableName)
        {
            Microsoft.Azure.Cosmos.DatabaseResponse dbResult = 
                await myClient.CreateDatabaseIfNotExistsAsync(dbName);

            System.Net.HttpStatusCode statusCodeFromDBCreation = dbResult.StatusCode;

            if (statusCodeFromDBCreation == System.Net.HttpStatusCode.Created)
            {
                MessageBox.Show("the database " + dbName + " was successufly created" , 
                                "DB created! " ,
                                MessageBoxButtons.OK ,
                                MessageBoxIcon.Information);
            }
            else if (statusCodeFromDBCreation == System.Net.HttpStatusCode.OK )
            {
                MessageBox.Show("the database " + dbName + " already Exists",
                                "DB already Exists! ",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("the database " + dbName + " was not creates , we got :" + statusCodeFromDBCreation,
                                "Failure! ",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Stop);

                return;
            }
        }
    }
}
