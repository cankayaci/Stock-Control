
namespace Stock_Control
{
    partial class frmAddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtBarcodeNumber = new System.Windows.Forms.TextBox();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.llbBrand = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblBarcodeNumber = new System.Windows.Forms.Label();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblExistSalePrice = new System.Windows.Forms.Label();
            this.lblExistPurchasePrice = new System.Windows.Forms.Label();
            this.txtExistSalePrice = new System.Windows.Forms.TextBox();
            this.txtExistPurchasePrice = new System.Windows.Forms.TextBox();
            this.txtExistQuantity = new System.Windows.Forms.TextBox();
            this.txtExistProductName = new System.Windows.Forms.TextBox();
            this.txtExistBrand = new System.Windows.Forms.TextBox();
            this.txtExistCategory = new System.Windows.Forms.TextBox();
            this.txtExistBarcodeNumber = new System.Windows.Forms.TextBox();
            this.lblExistQuantity = new System.Windows.Forms.Label();
            this.lblExistProductName = new System.Windows.Forms.Label();
            this.lblExistBrand = new System.Windows.Forms.Label();
            this.lblExistCategory = new System.Windows.Forms.Label();
            this.lblExistBarcode = new System.Windows.Forms.Label();
            this.btnNewProductAdd = new System.Windows.Forms.Button();
            this.btnExistProductAdd = new System.Windows.Forms.Button();
            this.lblOldQuantity = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSalePrice);
            this.groupBox1.Controls.Add(this.txtPurchasePrice);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.txtBarcodeNumber);
            this.groupBox1.Controls.Add(this.cmbBrand);
            this.groupBox1.Controls.Add(this.cmbCategory);
            this.groupBox1.Controls.Add(this.lblQuantity);
            this.groupBox1.Controls.Add(this.lblProductName);
            this.groupBox1.Controls.Add(this.llbBrand);
            this.groupBox1.Controls.Add(this.lblCategory);
            this.groupBox1.Controls.Add(this.lblBarcodeNumber);
            this.groupBox1.Controls.Add(this.lblPurchasePrice);
            this.groupBox1.Controls.Add(this.lblSalePrice);
            this.groupBox1.Location = new System.Drawing.Point(74, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Product";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(129, 200);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(100, 23);
            this.txtSalePrice.TabIndex = 11;
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(129, 169);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(100, 23);
            this.txtPurchasePrice.TabIndex = 10;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(129, 138);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 23);
            this.txtQuantity.TabIndex = 9;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(129, 107);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 23);
            this.txtProductName.TabIndex = 8;
            // 
            // txtBarcodeNumber
            // 
            this.txtBarcodeNumber.Location = new System.Drawing.Point(129, 14);
            this.txtBarcodeNumber.Name = "txtBarcodeNumber";
            this.txtBarcodeNumber.Size = new System.Drawing.Size(100, 23);
            this.txtBarcodeNumber.TabIndex = 7;
            // 
            // cmbBrand
            // 
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(129, 76);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(121, 23);
            this.cmbBrand.TabIndex = 6;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(129, 45);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 23);
            this.cmbCategory.TabIndex = 5;
            this.cmbCategory.SelectedValueChanged += new System.EventHandler(this.cmbCategory_SelectedValueChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(7, 145);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(53, 15);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(7, 113);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(84, 15);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "Product Name";
            // 
            // llbBrand
            // 
            this.llbBrand.AutoSize = true;
            this.llbBrand.Location = new System.Drawing.Point(7, 81);
            this.llbBrand.Name = "llbBrand";
            this.llbBrand.Size = new System.Drawing.Size(38, 15);
            this.llbBrand.TabIndex = 2;
            this.llbBrand.Text = "Brand";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(7, 49);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(55, 15);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category";
            // 
            // lblBarcodeNumber
            // 
            this.lblBarcodeNumber.AutoSize = true;
            this.lblBarcodeNumber.Location = new System.Drawing.Point(6, 22);
            this.lblBarcodeNumber.Name = "lblBarcodeNumber";
            this.lblBarcodeNumber.Size = new System.Drawing.Size(97, 15);
            this.lblBarcodeNumber.TabIndex = 0;
            this.lblBarcodeNumber.Text = "Barcode Number";
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Location = new System.Drawing.Point(7, 177);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(84, 15);
            this.lblPurchasePrice.TabIndex = 0;
            this.lblPurchasePrice.Text = "Purchase Price";
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Location = new System.Drawing.Point(7, 209);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(57, 15);
            this.lblSalePrice.TabIndex = 1;
            this.lblSalePrice.Text = "Sale Price";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblExistSalePrice);
            this.groupBox2.Controls.Add(this.lblExistPurchasePrice);
            this.groupBox2.Controls.Add(this.txtExistSalePrice);
            this.groupBox2.Controls.Add(this.txtExistPurchasePrice);
            this.groupBox2.Controls.Add(this.txtExistQuantity);
            this.groupBox2.Controls.Add(this.txtExistProductName);
            this.groupBox2.Controls.Add(this.txtExistBrand);
            this.groupBox2.Controls.Add(this.txtExistCategory);
            this.groupBox2.Controls.Add(this.txtExistBarcodeNumber);
            this.groupBox2.Controls.Add(this.lblExistQuantity);
            this.groupBox2.Controls.Add(this.lblExistProductName);
            this.groupBox2.Controls.Add(this.lblExistBrand);
            this.groupBox2.Controls.Add(this.lblExistCategory);
            this.groupBox2.Controls.Add(this.lblExistBarcode);
            this.groupBox2.Location = new System.Drawing.Point(435, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 276);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exist Product";
            // 
            // lblExistSalePrice
            // 
            this.lblExistSalePrice.AutoSize = true;
            this.lblExistSalePrice.Location = new System.Drawing.Point(39, 212);
            this.lblExistSalePrice.Name = "lblExistSalePrice";
            this.lblExistSalePrice.Size = new System.Drawing.Size(57, 15);
            this.lblExistSalePrice.TabIndex = 11;
            this.lblExistSalePrice.Text = "Sale Price";
            // 
            // lblExistPurchasePrice
            // 
            this.lblExistPurchasePrice.AutoSize = true;
            this.lblExistPurchasePrice.Location = new System.Drawing.Point(39, 182);
            this.lblExistPurchasePrice.Name = "lblExistPurchasePrice";
            this.lblExistPurchasePrice.Size = new System.Drawing.Size(84, 15);
            this.lblExistPurchasePrice.TabIndex = 10;
            this.lblExistPurchasePrice.Text = "Purchase Price";
            // 
            // txtExistSalePrice
            // 
            this.txtExistSalePrice.Location = new System.Drawing.Point(139, 209);
            this.txtExistSalePrice.Name = "txtExistSalePrice";
            this.txtExistSalePrice.Size = new System.Drawing.Size(115, 23);
            this.txtExistSalePrice.TabIndex = 8;
            // 
            // txtExistPurchasePrice
            // 
            this.txtExistPurchasePrice.Location = new System.Drawing.Point(139, 179);
            this.txtExistPurchasePrice.Name = "txtExistPurchasePrice";
            this.txtExistPurchasePrice.Size = new System.Drawing.Size(115, 23);
            this.txtExistPurchasePrice.TabIndex = 8;
            // 
            // txtExistQuantity
            // 
            this.txtExistQuantity.Location = new System.Drawing.Point(139, 149);
            this.txtExistQuantity.Name = "txtExistQuantity";
            this.txtExistQuantity.Size = new System.Drawing.Size(115, 23);
            this.txtExistQuantity.TabIndex = 8;
            // 
            // txtExistProductName
            // 
            this.txtExistProductName.Location = new System.Drawing.Point(139, 119);
            this.txtExistProductName.Name = "txtExistProductName";
            this.txtExistProductName.Size = new System.Drawing.Size(115, 23);
            this.txtExistProductName.TabIndex = 8;
            // 
            // txtExistBrand
            // 
            this.txtExistBrand.Location = new System.Drawing.Point(139, 89);
            this.txtExistBrand.Name = "txtExistBrand";
            this.txtExistBrand.Size = new System.Drawing.Size(115, 23);
            this.txtExistBrand.TabIndex = 8;
            // 
            // txtExistCategory
            // 
            this.txtExistCategory.Location = new System.Drawing.Point(139, 59);
            this.txtExistCategory.Name = "txtExistCategory";
            this.txtExistCategory.Size = new System.Drawing.Size(115, 23);
            this.txtExistCategory.TabIndex = 9;
            // 
            // txtExistBarcodeNumber
            // 
            this.txtExistBarcodeNumber.Location = new System.Drawing.Point(139, 29);
            this.txtExistBarcodeNumber.Name = "txtExistBarcodeNumber";
            this.txtExistBarcodeNumber.Size = new System.Drawing.Size(115, 23);
            this.txtExistBarcodeNumber.TabIndex = 8;
            this.txtExistBarcodeNumber.TextChanged += new System.EventHandler(this.txtExistBarcodeNumber_TextChanged);
            // 
            // lblExistQuantity
            // 
            this.lblExistQuantity.AutoSize = true;
            this.lblExistQuantity.Location = new System.Drawing.Point(39, 152);
            this.lblExistQuantity.Name = "lblExistQuantity";
            this.lblExistQuantity.Size = new System.Drawing.Size(53, 15);
            this.lblExistQuantity.TabIndex = 6;
            this.lblExistQuantity.Text = "Quantity";
            // 
            // lblExistProductName
            // 
            this.lblExistProductName.AutoSize = true;
            this.lblExistProductName.Location = new System.Drawing.Point(39, 122);
            this.lblExistProductName.Name = "lblExistProductName";
            this.lblExistProductName.Size = new System.Drawing.Size(84, 15);
            this.lblExistProductName.TabIndex = 5;
            this.lblExistProductName.Text = "Product Name";
            // 
            // lblExistBrand
            // 
            this.lblExistBrand.AutoSize = true;
            this.lblExistBrand.Location = new System.Drawing.Point(39, 92);
            this.lblExistBrand.Name = "lblExistBrand";
            this.lblExistBrand.Size = new System.Drawing.Size(38, 15);
            this.lblExistBrand.TabIndex = 4;
            this.lblExistBrand.Text = "Brand";
            // 
            // lblExistCategory
            // 
            this.lblExistCategory.AutoSize = true;
            this.lblExistCategory.Location = new System.Drawing.Point(39, 67);
            this.lblExistCategory.Name = "lblExistCategory";
            this.lblExistCategory.Size = new System.Drawing.Size(55, 15);
            this.lblExistCategory.TabIndex = 3;
            this.lblExistCategory.Text = "Category";
            // 
            // lblExistBarcode
            // 
            this.lblExistBarcode.AutoSize = true;
            this.lblExistBarcode.Location = new System.Drawing.Point(39, 37);
            this.lblExistBarcode.Name = "lblExistBarcode";
            this.lblExistBarcode.Size = new System.Drawing.Size(97, 15);
            this.lblExistBarcode.TabIndex = 2;
            this.lblExistBarcode.Text = "Barcode Number";
            // 
            // btnNewProductAdd
            // 
            this.btnNewProductAdd.Location = new System.Drawing.Point(261, 325);
            this.btnNewProductAdd.Name = "btnNewProductAdd";
            this.btnNewProductAdd.Size = new System.Drawing.Size(75, 23);
            this.btnNewProductAdd.TabIndex = 2;
            this.btnNewProductAdd.Text = "Add";
            this.btnNewProductAdd.UseVisualStyleBackColor = true;
            this.btnNewProductAdd.Click += new System.EventHandler(this.btnNewProductAdd_Click);
            // 
            // btnExistProductAdd
            // 
            this.btnExistProductAdd.Location = new System.Drawing.Point(614, 333);
            this.btnExistProductAdd.Name = "btnExistProductAdd";
            this.btnExistProductAdd.Size = new System.Drawing.Size(75, 23);
            this.btnExistProductAdd.TabIndex = 3;
            this.btnExistProductAdd.Text = "Add";
            this.btnExistProductAdd.UseVisualStyleBackColor = true;
            this.btnExistProductAdd.Click += new System.EventHandler(this.btnExistProductAdd_Click);
            // 
            // lblOldQuantity
            // 
            this.lblOldQuantity.AutoSize = true;
            this.lblOldQuantity.Location = new System.Drawing.Point(477, 304);
            this.lblOldQuantity.Name = "lblOldQuantity";
            this.lblOldQuantity.Size = new System.Drawing.Size(0, 15);
            this.lblOldQuantity.TabIndex = 12;
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(778, 418);
            this.Controls.Add(this.lblOldQuantity);
            this.Controls.Add(this.btnExistProductAdd);
            this.Controls.Add(this.btnNewProductAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product Page";
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtBarcodeNumber;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label llbBrand;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblBarcodeNumber;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblExistSalePrice;
        private System.Windows.Forms.Label lblExistPurchasePrice;
        private System.Windows.Forms.TextBox txtExistSalePrice;
        private System.Windows.Forms.TextBox txtExistPurchasePrice;
        private System.Windows.Forms.TextBox txtExistQuantity;
        private System.Windows.Forms.TextBox txtExistProductName;
        private System.Windows.Forms.TextBox txtExistBrand;
        private System.Windows.Forms.TextBox txtExistCategory;
        private System.Windows.Forms.TextBox txtExistBarcodeNumber;
        private System.Windows.Forms.Label lblExistQuantity;
        private System.Windows.Forms.Label lblExistProductName;
        private System.Windows.Forms.Label lblExistBrand;
        private System.Windows.Forms.Label lblExistCategory;
        private System.Windows.Forms.Label lblExistBarcode;
        private System.Windows.Forms.Button btnNewProductAdd;
        private System.Windows.Forms.Button btnExistProductAdd;
        private System.Windows.Forms.Label lblOldQuantity;
    }
}