using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Stock_Control
{
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
        }

        private void LoadAllBasket()
        {
            var connectionString = Properties.Settings.Default.connection;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter("select * from basket", conn))
                    {

                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "baskets");
                        saledataGrid.DataSource = dataSet.Tables["baskets"];
                        saledataGrid.Columns[0].Visible = false;
                        saledataGrid.Columns[1].Visible = false;
                        saledataGrid.Columns[2].Visible = false;

                    }
                }
                catch (Exception ex)
                {

                }
            }
        }
        private void btnListCustomer_Click(object sender, EventArgs e)
        {

            var form2 = new frmListCustomer();
            form2.Show();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddCustomer add = new frmAddCustomer();
            add.ShowDialog();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddProduct add = new frmAddProduct();
            add.ShowDialog();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            frmCategory category = new frmCategory();
            category.ShowDialog();
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            frmBrand brand = new frmBrand();
            brand.ShowDialog();
        }

        private void btnListProduct_Click(object sender, EventArgs e)
        {
            frmListProduct list = new frmListProduct();
            list.ShowDialog();
        }
        private void btnListSale_Click(object sender, EventArgs e)
        {
            frmListSale list = new frmListSale();
            list.ShowDialog();
        }
        private void calculate()
        {
            var connectionString = Properties.Settings.Default.connection;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("select sum(totalprice) from basket", conn))
                    {
                        lblGrandTotal.Text = cmd.ExecuteScalar() + " $ ";

                    }
                }
                catch (Exception ex)
                {

                }
            }

        }
        private void frmSales_Load(object sender, EventArgs e)
        {
            LoadAllBasket();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

            txtNameSurname.Text = "";
            txtPhone.Text = "";

            var connectionString = Properties.Settings.Default.connection;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("select * from customer where Id = @Id", conn))
                    {
                        cmd.Parameters.Add(new SqlParameter("Id", txtId.Text));
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            txtNameSurname.Text = reader["namesurname"].ToString();
                            txtPhone.Text = reader["phone"].ToString();
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured during listing customers...");
                }
            }

        }

        private void txtBarcodeNumber_TextChanged(object sender, EventArgs e)
        {

            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {

                    if (item != txtBarcodeNumber)
                    {
                        item.Text = "";

                    }
                }
            }

            var connectionString = Properties.Settings.Default.connection;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("select * from product where barcodenumber = @barcodenumber", conn))
                    {
                        cmd.Parameters.Add(new SqlParameter("barcodenumber", txtBarcodeNumber.Text));
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            txtProductName.Text = reader["productname"].ToString();
                            txtSalePrice.Text = reader["saleprice"].ToString();
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured during products...");
                }
            }
        }

        private void frmSale_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Multiply)
            {
                txtQuantity.Text = txtBarcodeNumber.Text.Substring(txtBarcodeNumber.Text.Length - 1);
                txtBarcodeNumber.Text = "";

            }
        }

        private bool barcodecontrol()
        {
            bool control = true;
            var connectionString = Properties.Settings.Default.connection;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {

                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("select * from basket", conn))
                    {
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            if (txtBarcodeNumber.Text == reader["barcodenumber"].ToString())
                            {
                                control = false;
                            }

                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured during listing customers...");
                }
            }

            return control;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Id cannot be blank...");
            }
            else if (string.IsNullOrEmpty(txtNameSurname.Text))
            {
                MessageBox.Show("Name and surname cannot be blank...");
            }
            else if (string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Phone cannot be blank...");
            }
            else if (string.IsNullOrEmpty(txtBarcodeNumber.Text))
            {
                MessageBox.Show("Barcode number cannot be blank...");
            }
            else if (string.IsNullOrEmpty(txtProductName.Text))
            {
                MessageBox.Show("Product name cannot be blank...");
            }
            else if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("Quantity cannot be blank...");
            }
            else if (string.IsNullOrEmpty(txtSalePrice.Text))
            {
                MessageBox.Show("Sale price cannot be blank...");
            }
            else if (string.IsNullOrEmpty(txtTotalPrice.Text))
            {
                MessageBox.Show("Total price cannot be blank...");
            }
            else
            {
                var connectionString = Properties.Settings.Default.connection;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        bool control = barcodecontrol();

                        if (control == true)
                        {

                            using (SqlCommand cmd = new SqlCommand("insert into basket(namesurname,phone,barcodenumber,productname,quantity,saleprice,totalprice,date) values(@namesurname,@phone,@barcodenumber,@productname,@quantity,@saleprice,@totalprice,@date)", conn))
                            {

                                cmd.Parameters.AddWithValue("@namesurname", txtNameSurname.Text);
                                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                                cmd.Parameters.AddWithValue("@barcodenumber", txtBarcodeNumber.Text);
                                cmd.Parameters.AddWithValue("@productname", txtProductName.Text);
                                cmd.Parameters.AddWithValue("@quantity", int.Parse(txtQuantity.Text));
                                cmd.Parameters.AddWithValue("@saleprice", double.Parse(txtSalePrice.Text));
                                cmd.Parameters.AddWithValue("@totalprice", double.Parse(txtTotalPrice.Text));
                                cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString());
                                var insert = cmd.ExecuteNonQuery();

                            }
                        }
                        else
                        {


                            using (SqlCommand cmd2 = new SqlCommand("UPDATE basket SET quantity=quantity + @quantity where barcodenumber = @barcodenumber ", conn))
                            {
                                cmd2.Parameters.AddWithValue("@quantity", int.Parse(txtQuantity.Text));
                                cmd2.Parameters.AddWithValue("@barcodenumber", txtBarcodeNumber.Text);
                                var update = cmd2.ExecuteNonQuery();

                            }

                            using (SqlCommand cmd3 = new SqlCommand("UPDATE basket SET totalprice = @quantity * @saleprice  where barcodenumber = @barcodenumber", conn))
                            {
                                cmd3.Parameters.AddWithValue("@saleprice", double.Parse(txtSalePrice.Text));
                                cmd3.Parameters.AddWithValue("@quantity", int.Parse(txtQuantity.Text));
                                cmd3.Parameters.AddWithValue("@barcodenumber", txtBarcodeNumber.Text);
                                var update = cmd3.ExecuteNonQuery();
                            }

                        }
                        LoadAllBasket();
                        calculate();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occured during adding to basket...");
                    }
                }
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtTotalPrice.Text = (double.Parse(txtQuantity.Text) * double.Parse(txtSalePrice.Text)).ToString();
            }
            catch (Exception)
            {
                ;
            }
        }

        private void txtSalePrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtTotalPrice.Text = (double.Parse(txtQuantity.Text) * double.Parse(txtSalePrice.Text)).ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var barcodeNumber = saledataGrid.CurrentRow.Cells["barcodenumber"].Value.ToString();
            DialogResult dialogResult = MessageBox.Show("Are you sure delete sale with Barcode Number : " + barcodeNumber + " ?", "Deleting Sale", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var connectionString = Properties.Settings.Default.connection;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("delete from basket where barcodenumber = @barcodenumber", conn))
                        {

                            cmd.Parameters.Add(new SqlParameter("barcodenumber", barcodeNumber));
                            var delete = cmd.ExecuteNonQuery();



                            if (delete > 0)
                            {
                                MessageBox.Show("Products Deleted Successfully...");
                                txtId.Text = string.Empty;
                                txtNameSurname.Text = string.Empty;
                                txtPhone.Text = string.Empty;
                                txtBarcodeNumber.Text = string.Empty;
                                txtProductName.Text = string.Empty;
                                txtSalePrice.Text = string.Empty;
                                LoadAllBasket();
                                calculate();

                            }

                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var barcodeNumber = saledataGrid.CurrentRow.Cells["barcodenumber"].Value.ToString();
            DialogResult dialogResult = MessageBox.Show("Are you sure cancel sales", "Canceling Sale", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var connectionString = Properties.Settings.Default.connection;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("delete from basket ", conn))
                        {

                            cmd.Parameters.Add(new SqlParameter("barcodenumber", barcodeNumber));
                            var delete = cmd.ExecuteNonQuery();



                            if (delete > 0)
                            {
                                MessageBox.Show("Products Canceled Successfully...");
                                txtId.Text = string.Empty;
                                txtNameSurname.Text = string.Empty;
                                txtPhone.Text = string.Empty;
                                txtBarcodeNumber.Text = string.Empty;
                                txtProductName.Text = string.Empty;
                                txtSalePrice.Text = string.Empty;
                                LoadAllBasket();
                                calculate();

                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            if(saledataGrid.Rows.Count == 1)
            {
                MessageBox.Show("You have to add a product to basket..");
                return;
            }
            var connectionString = Properties.Settings.Default.connection;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    for (int i = 0; i < saledataGrid.Rows.Count - 1; i++)
                    {
                        var barcodeNumber = saledataGrid.Rows[i].Cells["barcodenumber"].Value.ToString();
                        int quantity = int.Parse(saledataGrid.Rows[i].Cells["quantity"].Value.ToString());

                        int actualQuantityInDb = 0;

                        using (SqlCommand cmd3 = new SqlCommand("select quantity from product where barcodenumber = @barcodenumber", conn))
                        {
                            cmd3.Parameters.AddWithValue("@barcodenumber", barcodeNumber);
                            var reader = cmd3.ExecuteReader();
                            while (reader.Read())
                            {
                                actualQuantityInDb = int.Parse(reader["quantity"].ToString());
                            }
                        }

                        if (actualQuantityInDb >= quantity)
                        {
                            using (SqlCommand cmd = new SqlCommand("insert into sale(namesurname,phone,barcodenumber,productname,quantity,saleprice,totalprice,date) values(@namesurname,@phone,@barcodenumber,@productname,@quantity,@saleprice,@totalprice,@date)", conn))
                            {
                                cmd.Parameters.AddWithValue("@namesurname", txtNameSurname.Text);
                                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                                cmd.Parameters.AddWithValue("@barcodenumber", barcodeNumber);
                                cmd.Parameters.AddWithValue("@productname", saledataGrid.Rows[i].Cells["productname"].Value.ToString());
                                cmd.Parameters.AddWithValue("@quantity", quantity);
                                cmd.Parameters.AddWithValue("@saleprice", double.Parse(saledataGrid.Rows[i].Cells["saleprice"].Value.ToString()));
                                cmd.Parameters.AddWithValue("@totalprice", double.Parse(saledataGrid.Rows[i].Cells["totalprice"].Value.ToString()));
                                cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString());
                                var insert = cmd.ExecuteNonQuery();
                                if (insert > 0)
                                {
                                    int delete,update = 0;

                                    using (SqlCommand cmd1 = new SqlCommand("delete from basket where barcodenumber = @barcodenumber", conn))
                                    {

                                        cmd1.Parameters.Add(new SqlParameter("barcodenumber", barcodeNumber));
                                        delete = cmd1.ExecuteNonQuery();
                                    }
                                    using (SqlCommand cmd2 = new SqlCommand("update product set quantity = quantity - @quantity where barcodenumber =  @barcodenumber", conn))
                                    {
                                        cmd2.Parameters.Add(new SqlParameter("barcodenumber", barcodeNumber));
                                        cmd2.Parameters.Add(new SqlParameter("quantity", quantity));
                                        if (delete > 0)
                                        {
                                              update = cmd2.ExecuteNonQuery();
                                        }
                                    }

                                    LoadAllBasket();
                                    if(delete >0 && update >0)
                                    {
                                        MessageBox.Show("Process has done successfully..");
                                    }
                                    else
                                    {
                                        MessageBox.Show("An error occurred during selling process..");
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("You don't have enough quantity for barcode number :" + barcodeNumber + ". Current quantiy is :" + actualQuantityInDb + " in database.");
                        }

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
