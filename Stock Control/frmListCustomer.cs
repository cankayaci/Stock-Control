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
    public partial class frmListCustomer : Form
    {
        public frmListCustomer()
        {
            InitializeComponent();
        }

        private void frmListCustomer_Load(object sender, EventArgs e)
        {
            LoadAllCustomers();
        }

        private void customerDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAdress.Text = customerDataGrid.CurrentRow.Cells["adress"].Value.ToString();
            txtEmail.Text = customerDataGrid.CurrentRow.Cells["email"].Value.ToString();
            txtNameSurname.Text = customerDataGrid.CurrentRow.Cells["namesurname"].Value.ToString();
            txtPhone.Text = customerDataGrid.CurrentRow.Cells["phone"].Value.ToString();
            txtId.Text = customerDataGrid.CurrentRow.Cells["Id"].Value.ToString();
        }


        private void LoadAllCustomers()
        {
            var connectionString = Properties.Settings.Default.connection;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter("select * from customer", conn))
                    {

                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "customers");
                        customerDataGrid.DataSource = dataSet.Tables["customers"];

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured during listing customers...");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
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
                        using (SqlCommand cmd = new SqlCommand("update customer set namesurname = @namesurname, phone = @phone , adress = @adress, email = @email where Id = @Id", conn))
                        {

                            cmd.Parameters.Add(new SqlParameter("namesurname", txtNameSurname.Text));
                            cmd.Parameters.Add(new SqlParameter("phone", txtPhone.Text));
                            cmd.Parameters.Add(new SqlParameter("adress", txtAdress.Text));
                            cmd.Parameters.Add(new SqlParameter("email", txtEmail.Text));
                            cmd.Parameters.Add(new SqlParameter("Id", txtId.Text));
                            var update = cmd.ExecuteNonQuery();
                            if (update > 0)
                            {
                                MessageBox.Show("Customer Updated Successfully...");
                                txtNameSurname.Text = string.Empty;
                                txtPhone.Text = string.Empty;
                                txtAdress.Text = string.Empty;
                                txtEmail.Text = string.Empty;
                                txtId.Text = string.Empty;
                                LoadAllCustomers();
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

        private void frmListCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            var form2 = new frmSales();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure delete customer?", "Deleting Customer", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                var connectionString = Properties.Settings.Default.connection;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("delete customer where Id = @Id", conn))
                        {
                            
                            cmd.Parameters.Add(new SqlParameter("Id", txtId.Text));
                            var delete = cmd.ExecuteNonQuery();
                            if (delete > 0)
                            {
                                MessageBox.Show("Customer Deleted Successfully...");
                                txtNameSurname.Text = string.Empty;
                                txtPhone.Text = string.Empty;
                                txtAdress.Text = string.Empty;
                                txtEmail.Text = string.Empty;
                                txtId.Text = string.Empty;
                                LoadAllCustomers();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        
                    }
                }
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtId.Text))
            {
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false ;
                btnEdit.Enabled = false;
            }
        }

        private void txtIdSearch_TextChanged(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtIdSearch.Text))
            {
                MessageBox.Show("Id Field cannot be empty");
            }
            else
            {
                var connectionString = Properties.Settings.Default.connection;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("select * from customer  where Id like @Id", conn))
                        {

                            cmd.Parameters.AddWithValue("@Id", "%" + txtIdSearch.Text + "%");
                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                DataSet dataSet = new DataSet();
                                adapter.Fill(dataSet, "customers");
                                customerDataGrid.DataSource = dataSet.Tables["customers"];
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occured during listing customers...");
                    }
                }
            }
        }
    }
}
