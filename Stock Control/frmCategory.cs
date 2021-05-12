using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Stock_Control
{
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }


        private void frmCategory_Load(object sender, EventArgs e)
        {

        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {

            bool result = IsCategoryExists(txtCategory.Text);
            if (result)
            {
                MessageBox.Show("Category already exists....");
            }
            else
            {

                var connectionString = Properties.Settings.Default.connection;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("insert into categoryinformation(category) values(@category)", conn))
                        {

                            cmd.Parameters.Add(new SqlParameter("category", txtCategory.Text));

                            var insert = cmd.ExecuteNonQuery();
                            if (insert > 0)
                            {
                                MessageBox.Show("Category has been added.");
                                txtCategory.Text = string.Empty;
                                txtCategory.Text = "";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occured during adding category...");
                    }
                }
            }
        }
        private bool IsCategoryExists(string category)
        {
            bool IsExists = false;
            var connectionString = Properties.Settings.Default.connection;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("select * from categoryinformation where category like @SEARCH", conn))
                    {
                        
                        cmd.Parameters.AddWithValue("@SEARCH", "%" + txtCategory.Text + "%");

                        var reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            IsExists = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured during adding category...");
                }
            }

            return IsExists;
        }
    }
}
