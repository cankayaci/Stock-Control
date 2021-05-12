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
    public partial class frmListProduct : Form
    {
        

        public frmListProduct()
        {
            InitializeComponent();
        }
        private void frmListProduct_Load(object sender, EventArgs e)
        {
            LoadAllProducts();
        }
        private void productDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtListBarcode.Text = productdataGrid.CurrentRow.Cells["barcodenumber"].Value.ToString();
            txtListCategory.Text = productdataGrid.CurrentRow.Cells["category"].Value.ToString();
            txtListBrand.Text = productdataGrid.CurrentRow.Cells["brand"].Value.ToString();
            txtListProductName.Text = productdataGrid.CurrentRow.Cells["productname"].Value.ToString();
            txtListQuantity.Text = productdataGrid.CurrentRow.Cells["quantity"].Value.ToString();
            txtListPurchase.Text = productdataGrid.CurrentRow.Cells["purchaseprice"].Value.ToString();
            txtListSale.Text = productdataGrid.CurrentRow.Cells["quantity"].Value.ToString();
        }

        private void LoadAllProducts()
        {
            var connectionString = Properties.Settings.Default.connection;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter("select * from product", conn))
                    {

                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "products");
                        productdataGrid.DataSource = dataSet.Tables["products"];

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured during listing products...");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtListBarcode.Text))
            {
                MessageBox.Show("Barcode cannot be blank...");
            }
            else if (string.IsNullOrEmpty(txtListCategory.Text))
            {
                MessageBox.Show("Category cannot be blank...");
            }
            else if (string.IsNullOrEmpty(txtListBrand.Text))
            {
                MessageBox.Show("Brand cannot be blank...");
            }
            else if (string.IsNullOrEmpty(txtListProductName.Text))
            {
                MessageBox.Show("Product name cannot be blank...");
            }
            else if (string.IsNullOrEmpty(txtListQuantity.Text))
            {
                MessageBox.Show("Quantity cannot be blank...");
            }
            else if (string.IsNullOrEmpty(txtListPurchase.Text))
            {
                MessageBox.Show("Purchase cannot be blank...");
            }
            else if (string.IsNullOrEmpty(txtListSale.Text))
            {
                MessageBox.Show("Sale cannot be blank...");
            }
            else
            {

                var connectionString = Properties.Settings.Default.connection;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("update product set barcodenumber = @barcodenumber, category = @category , brand = @brand, productname = @productname, quantity = @quantity, purchaseprice = @purchaseprice, saleprice = @saleprice where barcodenumber = @barcodenumber", conn))
                        {

                            cmd.Parameters.Add(new SqlParameter("barcodenumber", txtListBarcode.Text));
                            cmd.Parameters.Add(new SqlParameter("category", txtListCategory.Text));
                            cmd.Parameters.Add(new SqlParameter("brand", txtListBrand.Text));
                            cmd.Parameters.Add(new SqlParameter("productname", txtListProductName.Text));
                            cmd.Parameters.Add(new SqlParameter("quantity", Convert.ToInt32(txtListQuantity.Text)));
                            cmd.Parameters.Add(new SqlParameter("purchaseprice", Convert.ToDecimal(txtListPurchase.Text)));
                            cmd.Parameters.Add(new SqlParameter("saleprice", Convert.ToDecimal(txtListSale.Text)));
                            var update = cmd.ExecuteNonQuery();
                            if (update > 0)
                            {
                                MessageBox.Show("Product Updated Successfully...");
                                txtListBarcode.Text = string.Empty;
                                txtListCategory.Text = string.Empty;
                                txtListBrand.Text = string.Empty;
                                txtListProductName.Text = string.Empty;
                                txtListQuantity.Text = string.Empty;
                                txtListPurchase.Text = string.Empty;
                                txtListSale.Text = string.Empty;
                                LoadAllProducts();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occured during edit product...");
                    }
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure delete product?", "Deleting Product", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var connectionString = Properties.Settings.Default.connection;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("delete product where barcodenumber = @barcodenumber", conn))
                        {

                            cmd.Parameters.Add(new SqlParameter("barcodenumber", txtListBarcode.Text));
                            var delete = cmd.ExecuteNonQuery();
                            if (delete > 0)
                            {
                                MessageBox.Show("Product Deleted Successfully...");
                                txtListBarcode.Text = string.Empty;
                                txtListCategory.Text = string.Empty;
                                txtListBrand.Text = string.Empty;
                                txtListProductName.Text = string.Empty;
                                txtListQuantity.Text = string.Empty;
                                txtListPurchase.Text = string.Empty;
                                txtListSale.Text = string.Empty;
                                LoadAllProducts();
                                ChangeButtonsEditable();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        
                    }
                }
            }
        }

       
        private void txtSearchBarcode_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtSearchBarcode.Text))
            {
                MessageBox.Show("Barcode Field cannot be empty");
            }
            else
            {
                var connectionString = Properties.Settings.Default.connection;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("select * from product  where barcodenumber like @barcodenumber", conn))
                        {

                            cmd.Parameters.AddWithValue("@barcodenumber", "%" + txtSearchBarcode.Text + "%");
                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                DataSet dataSet = new DataSet();
                                adapter.Fill(dataSet, "products");
                                productdataGrid.DataSource = dataSet.Tables["products"];
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occured during listing products...");
                    }
                }
            }
        }

        private void txtListBarcode_TextChanged(object sender, EventArgs e)
        {
            ChangeButtonsEditable();
        }
        
        private void ChangeButtonsEditable()
        {
            if (!string.IsNullOrEmpty(txtListBarcode.Text))
            {
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
            }
        }
    }
}
