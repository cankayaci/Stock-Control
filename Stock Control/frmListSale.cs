using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stock_Control
{
    public partial class frmListSale : Form
    {
        public frmListSale()
        {
            InitializeComponent();
        }

        private void frmListSale_Load(object sender, EventArgs e)
        {
            var connectionString = Properties.Settings.Default.connection;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter("select * from sale", conn))
                    {

                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "sale");
                        dataGridView1.DataSource = dataSet.Tables["sale"];

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured during adding sale...");
                }
            }
        }
    }
}
