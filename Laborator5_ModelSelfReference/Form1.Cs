  
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorul5
{
    public partial class Form1 : Form
    {

        string connectionString = @"data source=JARVICE;initial catalog=SelfReference_DB;integrated security=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'selfReference_DBDataSet.SelfReference' table. You can move, or remove it, as needed.
            this.selfReferenceTableAdapter.Fill(this.selfReference_DBDataSet.SelfReference);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from SelfReference", sqlCon);

                DataTable dataTable = new DataTable();
                sqlDa.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }

        }
    }
}