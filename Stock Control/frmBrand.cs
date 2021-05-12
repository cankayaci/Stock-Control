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
    public partial class frmBrand : Form
    {
        public frmBrand()
        {
            InitializeComponent();
        }
        
        private void btnBrandAdd_Click(object sender, EventArgs e)
        {
            bool result = IsCategoryBrandExists(cmbCategory.Text, txtBrand.Text);
            if(!result)
            { 
                var connectionString = Properties.Settings.Default.connection;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("insert into brandinformation(category,brand) values(@category,@brand)", conn))
                        {

                            cmd.Parameters.Add(new SqlParameter("brand", txtBrand.Text));
                            cmd.Parameters.Add(new SqlParameter("category", cmbCategory.Text));

                            var insert = cmd.ExecuteNonQuery();
                            if (insert > 0)
                            {
                                MessageBox.Show("Brand has been added.");
                                txtBrand.Text = string.Empty;
                                cmbCategory.Text = string.Empty;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occured during adding brand...");
                    }
                }
            }
            else
            {
                MessageBox.Show("Category : "+ cmbCategory.Text + " and Brand : "+ txtBrand.Text+" already exists....");
            }
        }

        private void frmBrand_Load(object sender, EventArgs e)
        {

            var connectionString = Properties.Settings.Default.connection;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("select * from categoryinformation", conn))
                    {                       

                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            cmbCategory.Items.Add(reader["category"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured during loading brands...");
                }
            }
        }

        private bool IsCategoryBrandExists(string category,string brand)
        {
            bool IsExists = false;

            var connectionString = Properties.Settings.Default.connection;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("select * from brandinformation where category like @category and brand like @brand", conn))
                    {

                        cmd.Parameters.AddWithValue("@brand", "%" + txtBrand.Text + "%");
                        cmd.Parameters.AddWithValue("@category", "%" + cmbCategory.Text + "%");

                        var reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            IsExists = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured during adding brand...");
                }
            }

            return IsExists;
        }
    }
}
