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
    public partial class frmAddCustomer : Form
    {       

        public frmAddCustomer()
        {
            InitializeComponent();
        }

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNameSurname.Text))
            {
                MessageBox.Show("Name and Surname cannot be blank...");
            }
            else if (string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Phone cannot be blank...");
            }
            else if (string.IsNullOrEmpty(txtAdress.Text))
            {
                MessageBox.Show("Address cannot be blank...");
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Email address cannot be blank...");
            }
            else
            {

                var connectionString = Properties.Settings.Default.connection;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("insert into customer(namesurname,phone,adress,email) values(@namesurname,@phone,@adress,@email)", conn))
                        {

                            cmd.Parameters.Add(new SqlParameter("namesurname", txtNameSurname.Text));
                            cmd.Parameters.Add(new SqlParameter("phone", txtPhone.Text));
                            cmd.Parameters.Add(new SqlParameter("adress", txtAdress.Text));
                            cmd.Parameters.Add(new SqlParameter("email", txtEmail.Text));
                            var insert = cmd.ExecuteNonQuery();
                            if(insert > 0)
                            {
                                MessageBox.Show("Customer Added Successfully...");
                                txtNameSurname.Text = string.Empty;
                                txtPhone.Text = string.Empty;
                                txtAdress.Text = string.Empty;
                                txtEmail.Text = string.Empty;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occured during adding customer...");
                    }
                }
            }
        }
    }
}
