
namespace Stock_Control
{
    partial class frmListProduct
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
            this.productdataGrid = new System.Windows.Forms.DataGridView();
            this.lblListSale = new System.Windows.Forms.Label();
            this.lblListPurchase = new System.Windows.Forms.Label();
            this.txtListSale = new System.Windows.Forms.TextBox();
            this.txtListPurchase = new System.Windows.Forms.TextBox();
            this.txtListQuantity = new System.Windows.Forms.TextBox();
            this.txtListProductName = new System.Windows.Forms.TextBox();
            this.txtListBrand = new System.Windows.Forms.TextBox();
            this.txtListCategory = new System.Windows.Forms.TextBox();
            this.txtListBarcode = new System.Windows.Forms.TextBox();
            this.lblListQuantity = new System.Windows.Forms.Label();
            this.lblListProductName = new System.Windows.Forms.Label();
            this.lblListBrand = new System.Windows.Forms.Label();
            this.lblListCategory = new System.Windows.Forms.Label();
            this.lblListBarcode = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearchBarcode = new System.Windows.Forms.TextBox();
            this.lblSearchBarcode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productdataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // productdataGrid
            // 
            this.productdataGrid.BackgroundColor = System.Drawing.Color.White;
            this.productdataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productdataGrid.Location = new System.Drawing.Point(238, 55);
            this.productdataGrid.Name = "productdataGrid";
            this.productdataGrid.RowTemplate.Height = 25;
            this.productdataGrid.Size = new System.Drawing.Size(550, 246);
            this.productdataGrid.TabIndex = 0;
            this.productdataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDataGrid_CellDoubleClick);
            // 
            // lblListSale
            // 
            this.lblListSale.AutoSize = true;
            this.lblListSale.Location = new System.Drawing.Point(11, 238);
            this.lblListSale.Name = "lblListSale";
            this.lblListSale.Size = new System.Drawing.Size(57, 15);
            this.lblListSale.TabIndex = 25;
            this.lblListSale.Text = "Sale Price";
            // 
            // lblListPurchase
            // 
            this.lblListPurchase.AutoSize = true;
            this.lblListPurchase.Location = new System.Drawing.Point(11, 208);
            this.lblListPurchase.Name = "lblListPurchase";
            this.lblListPurchase.Size = new System.Drawing.Size(84, 15);
            this.lblListPurchase.TabIndex = 24;
            this.lblListPurchase.Text = "Purchase Price";
            // 
            // txtListSale
            // 
            this.txtListSale.Location = new System.Drawing.Point(111, 235);
            this.txtListSale.Name = "txtListSale";
            this.txtListSale.Size = new System.Drawing.Size(115, 23);
            this.txtListSale.TabIndex = 17;
            // 
            // txtListPurchase
            // 
            this.txtListPurchase.Location = new System.Drawing.Point(111, 205);
            this.txtListPurchase.Name = "txtListPurchase";
            this.txtListPurchase.Size = new System.Drawing.Size(115, 23);
            this.txtListPurchase.TabIndex = 18;
            // 
            // txtListQuantity
            // 
            this.txtListQuantity.Location = new System.Drawing.Point(111, 175);
            this.txtListQuantity.Name = "txtListQuantity";
            this.txtListQuantity.Size = new System.Drawing.Size(115, 23);
            this.txtListQuantity.TabIndex = 19;
            // 
            // txtListProductName
            // 
            this.txtListProductName.Location = new System.Drawing.Point(111, 145);
            this.txtListProductName.Name = "txtListProductName";
            this.txtListProductName.Size = new System.Drawing.Size(115, 23);
            this.txtListProductName.TabIndex = 20;
            // 
            // txtListBrand
            // 
            this.txtListBrand.Location = new System.Drawing.Point(111, 115);
            this.txtListBrand.Name = "txtListBrand";
            this.txtListBrand.Size = new System.Drawing.Size(115, 23);
            this.txtListBrand.TabIndex = 21;
            // 
            // txtListCategory
            // 
            this.txtListCategory.Location = new System.Drawing.Point(111, 85);
            this.txtListCategory.Name = "txtListCategory";
            this.txtListCategory.Size = new System.Drawing.Size(115, 23);
            this.txtListCategory.TabIndex = 23;
            // 
            // txtListBarcode
            // 
            this.txtListBarcode.Location = new System.Drawing.Point(111, 55);
            this.txtListBarcode.Name = "txtListBarcode";
            this.txtListBarcode.Size = new System.Drawing.Size(115, 23);
            this.txtListBarcode.TabIndex = 22;
            this.txtListBarcode.TextChanged += new System.EventHandler(this.txtListBarcode_TextChanged);
            // 
            // lblListQuantity
            // 
            this.lblListQuantity.AutoSize = true;
            this.lblListQuantity.Location = new System.Drawing.Point(11, 178);
            this.lblListQuantity.Name = "lblListQuantity";
            this.lblListQuantity.Size = new System.Drawing.Size(53, 15);
            this.lblListQuantity.TabIndex = 16;
            this.lblListQuantity.Text = "Quantity";
            // 
            // lblListProductName
            // 
            this.lblListProductName.AutoSize = true;
            this.lblListProductName.Location = new System.Drawing.Point(11, 148);
            this.lblListProductName.Name = "lblListProductName";
            this.lblListProductName.Size = new System.Drawing.Size(84, 15);
            this.lblListProductName.TabIndex = 15;
            this.lblListProductName.Text = "Product Name";
            // 
            // lblListBrand
            // 
            this.lblListBrand.AutoSize = true;
            this.lblListBrand.Location = new System.Drawing.Point(11, 118);
            this.lblListBrand.Name = "lblListBrand";
            this.lblListBrand.Size = new System.Drawing.Size(38, 15);
            this.lblListBrand.TabIndex = 14;
            this.lblListBrand.Text = "Brand";
            // 
            // lblListCategory
            // 
            this.lblListCategory.AutoSize = true;
            this.lblListCategory.Location = new System.Drawing.Point(11, 93);
            this.lblListCategory.Name = "lblListCategory";
            this.lblListCategory.Size = new System.Drawing.Size(55, 15);
            this.lblListCategory.TabIndex = 13;
            this.lblListCategory.Text = "Category";
            // 
            // lblListBarcode
            // 
            this.lblListBarcode.AutoSize = true;
            this.lblListBarcode.Location = new System.Drawing.Point(11, 63);
            this.lblListBarcode.Name = "lblListBarcode";
            this.lblListBarcode.Size = new System.Drawing.Size(97, 15);
            this.lblListBarcode.TabIndex = 12;
            this.lblListBarcode.Text = "Barcode Number";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(139, 274);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(87, 27);
            this.btnEdit.TabIndex = 26;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(139, 308);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 27);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearchBarcode
            // 
            this.txtSearchBarcode.Location = new System.Drawing.Point(478, 22);
            this.txtSearchBarcode.Name = "txtSearchBarcode";
            this.txtSearchBarcode.Size = new System.Drawing.Size(113, 23);
            this.txtSearchBarcode.TabIndex = 28;
            this.txtSearchBarcode.TextChanged += new System.EventHandler(this.txtSearchBarcode_TextChanged);
            // 
            // lblSearchBarcode
            // 
            this.lblSearchBarcode.AutoSize = true;
            this.lblSearchBarcode.Location = new System.Drawing.Point(337, 25);
            this.lblSearchBarcode.Name = "lblSearchBarcode";
            this.lblSearchBarcode.Size = new System.Drawing.Size(135, 15);
            this.lblSearchBarcode.TabIndex = 29;
            this.lblSearchBarcode.Text = "Search Barcode Number";
            // 
            // frmListProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSearchBarcode);
            this.Controls.Add(this.txtSearchBarcode);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblListSale);
            this.Controls.Add(this.lblListPurchase);
            this.Controls.Add(this.txtListSale);
            this.Controls.Add(this.txtListPurchase);
            this.Controls.Add(this.txtListQuantity);
            this.Controls.Add(this.txtListProductName);
            this.Controls.Add(this.txtListBrand);
            this.Controls.Add(this.txtListCategory);
            this.Controls.Add(this.txtListBarcode);
            this.Controls.Add(this.lblListQuantity);
            this.Controls.Add(this.lblListProductName);
            this.Controls.Add(this.lblListBrand);
            this.Controls.Add(this.lblListCategory);
            this.Controls.Add(this.lblListBarcode);
            this.Controls.Add(this.productdataGrid);
            this.Name = "frmListProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Product Page";
            this.Load += new System.EventHandler(this.frmListProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productdataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblListSale;
        private System.Windows.Forms.Label lblListPurchase;
        private System.Windows.Forms.TextBox txtListSale;
        private System.Windows.Forms.TextBox txtListPurchase;
        private System.Windows.Forms.TextBox txtListQuantity;
        private System.Windows.Forms.TextBox txtListProductName;
        private System.Windows.Forms.TextBox txtListBrand;
        private System.Windows.Forms.TextBox txtListCategory;
        private System.Windows.Forms.TextBox txtListBarcode;
        private System.Windows.Forms.Label lblListQuantity;
        private System.Windows.Forms.Label lblListProductName;
        private System.Windows.Forms.Label lblListBrand;
        private System.Windows.Forms.Label lblListCategory;
        private System.Windows.Forms.Label lblListBarcode;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearchBarcode;
        private System.Windows.Forms.Label lblSearchBarcode;
        private System.Windows.Forms.DataGridView ProductdataGrid;
        private System.Windows.Forms.DataGridView productdataGrid;
    }
}