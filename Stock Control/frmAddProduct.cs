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
    public partial class frmAddProduct : Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void btnNewProductAdd_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrEmpty(txtBarcodeNumber.Text))
                {
                    MessageBox.Show("Barcode Number cannot be blank...");
                }
                else if (string.IsNullOrEmpty(cmbCategory.Text))
                {
                    MessageBox.Show("Category cannot be blank...");
                }
                else if (string.IsNullOrEmpty(cmbBrand.Text))
                {
                    MessageBox.Show("Brand cannot be blank...");
                }
                else if (string.IsNullOrEmpty(txtProductName.Text))
                {
                    MessageBox.Show("Product name cannot be blank...");
                }
                else if (string.IsNullOrEmpty(txtQuantity.Text))
                {
                    MessageBox.Show("Quantity cannot be blank...");
                }
                else if (string.IsNullOrEmpty(txtPurchasePrice.Text))
                {
                    MessageBox.Show("Purchase price cannot be blank...");
                }
                else if (string.IsNullOrEmpty(txtSalePrice.Text))
                {
                    MessageBox.Show("Sale price cannot be blank...");
                }
                else
                {

                    var connectionString = Properties.Settings.Default.connection;

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            using (SqlCommand cmd = new SqlCommand("insert into product(barcodenumber,category,brand,productname,quantity,purchaseprice,saleprice,date) values(@barcodenumber,@category,@brand,@productname,@quantity,@purchaseprice,@saleprice,@date)", conn))
                            {

                                cmd.Parameters.Add(new SqlParameter("barcodenumber", txtBarcodeNumber.Text));
                                cmd.Parameters.Add(new SqlParameter("category", cmbCategory.Text));
                                cmd.Parameters.Add(new SqlParameter("brand", cmbBrand.Text));
                                cmd.Parameters.Add(new SqlParameter("productname", txtProductName.Text));
                                cmd.Parameters.Add(new SqlParameter("quantity", int.Parse(txtQuantity.Text)));
                                cmd.Parameters.Add(new SqlParameter("purchaseprice", double.Parse(txtPurchasePrice.Text)));
                                cmd.Parameters.Add(new SqlParameter("saleprice", double.Parse(txtSalePrice.Text)));
                                cmd.Parameters.Add(new SqlParameter("date", DateTime.Now.ToString()));
                                var insert = cmd.ExecuteNonQuery();
                                if (insert > 0)
                                {
                                    MessageBox.Show("Product Added Successfully...");
                                    txtBarcodeNumber.Text = string.Empty;
                                    cmbCategory.Text = string.Empty;
                                    cmbBrand.Text = string.Empty;
                                    txtProductName.Text = string.Empty;
                                    txtQuantity.Text = string.Empty;
                                    txtPurchasePrice.Text = string.Empty;
                                    txtSalePrice.Text = string.Empty;

                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during adding product...");
                        }
                    }
                }
            }
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }
        private void LoadCategories()
        {
            cmbCategory.Items.Clear();

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
                    MessageBox.Show("An error occured during loading categories...");
                }
            }
        }

        private void cmbCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbBrand.Items.Clear();
            var connectionString = Properties.Settings.Default.connection;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("select * from brandinformation where category like @category", conn))
                    {
                        cmd.Parameters.AddWithValue("@category", "%" + cmbCategory.Text + "%");
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            cmbBrand.Items.Add(reader["brand"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured during loading brands...");
                }
            }
        }

        private void txtExistBarcodeNumber_TextChanged(object sender, EventArgs e)
        {

            lblOldQuantity.Text = "";
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox && item.Name != "txtExistBarcodeNumber")
                {
                    item.Text = "";
                }
            }

            LoadExistingProduct(txtExistBarcodeNumber.Text);



        }

        private void btnExistProductAdd_Click(object sender, EventArgs e)
        {
            var connectionString = Properties.Settings.Default.connection;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("update product set quantity = @quantity where barcodenumber =  @barcodenumber", conn))
                    {
                        cmd.Parameters.AddWithValue("@barcodenumber", txtExistBarcodeNumber.Text);
                        cmd.Parameters.AddWithValue("@quantity", txtExistQuantity.Text);
                        var insert = cmd.ExecuteNonQuery();
                        if (insert > 0)
                        {
                            MessageBox.Show("Product has been updated.");
                            LoadExistingProduct(txtExistBarcodeNumber.Text);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured during updating product...");
                }
            }
        }
        private void LoadExistingProduct(string barcodeNumber)
        {
            var connectionString = Properties.Settings.Default.connection;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("select * from product where barcodenumber = @barcodenumber", conn))
                    {
                        cmd.Parameters.AddWithValue("@barcodenumber", txtExistBarcodeNumber.Text);
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            txtExistCategory.Text = reader["category"].ToString();
                            txtExistBrand.Text = reader["brand"].ToString();
                            txtExistProductName.Text = reader["productname"].ToString();
                            lblOldQuantity.Text = reader["quantity"].ToString();
                            txtExistPurchasePrice.Text = reader["purchaseprice"].ToString();
                            txtExistSalePrice.Text = reader["saleprice"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured during loading product...");
                }
            }
        }
    }
}
