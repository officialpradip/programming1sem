namespace DashianAssignment
{
    partial class Product
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvlproducts = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnexport = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grdproductlist = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.txtunit = new System.Windows.Forms.TextBox();
            this.txtcostprice = new System.Windows.Forms.TextBox();
            this.txtsellingprice = new System.Windows.Forms.TextBox();
            this.txtproductid = new System.Windows.Forms.TextBox();
            this.lvlproductname = new System.Windows.Forms.Label();
            this.lvlunit = new System.Windows.Forms.Label();
            this.lvlsellingprice = new System.Windows.Forms.Label();
            this.lvlcostprice = new System.Windows.Forms.Label();
            this.lvlstockquantiy = new System.Windows.Forms.Label();
            this.lvlproductid = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdproductlist)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvlproducts);
            this.panel1.Location = new System.Drawing.Point(7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 57);
            this.panel1.TabIndex = 0;
            // 
            // lvlproducts
            // 
            this.lvlproducts.AutoSize = true;
            this.lvlproducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlproducts.Location = new System.Drawing.Point(25, 22);
            this.lvlproducts.Name = "lvlproducts";
            this.lvlproducts.Size = new System.Drawing.Size(57, 13);
            this.lvlproducts.TabIndex = 0;
            this.lvlproducts.Text = "Products";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnedit);
            this.panel2.Controls.Add(this.btnreset);
            this.panel2.Controls.Add(this.btnexport);
            this.panel2.Controls.Add(this.btnprint);
            this.panel2.Controls.Add(this.btnnew);
            this.panel2.Location = new System.Drawing.Point(223, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 58);
            this.panel2.TabIndex = 1;
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(133, 22);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 18;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(490, 18);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 23);
            this.btnreset.TabIndex = 17;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnexport
            // 
            this.btnexport.Location = new System.Drawing.Point(383, 18);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(75, 23);
            this.btnexport.TabIndex = 16;
            this.btnexport.Text = "Export";
            this.btnexport.UseVisualStyleBackColor = true;
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(248, 24);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(75, 23);
            this.btnprint.TabIndex = 15;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = true;
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(36, 22);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(75, 23);
            this.btnnew.TabIndex = 14;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grdproductlist);
            this.panel3.Location = new System.Drawing.Point(10, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(396, 350);
            this.panel3.TabIndex = 2;
            // 
            // grdproductlist
            // 
            this.grdproductlist.AllowUserToAddRows = false;
            this.grdproductlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdproductlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdproductlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.ProductID,
            this.ProductName,
            this.Unit,
            this.SellingPrice,
            this.CostPrice,
            this.StockQuantity});
            this.grdproductlist.Location = new System.Drawing.Point(-3, 0);
            this.grdproductlist.Name = "grdproductlist";
            this.grdproductlist.Size = new System.Drawing.Size(396, 346);
            this.grdproductlist.TabIndex = 0;
            this.grdproductlist.DoubleClick += new System.EventHandler(this.grdproductlist_DoubleClick);
            // 
            // Column7
            // 
            this.Column7.HeaderText = "S.No";
            this.Column7.Name = "Column7";
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "ID";
            this.ProductID.Name = "ProductID";
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Name";
            this.ProductName.Name = "ProductName";
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            // 
            // SellingPrice
            // 
            this.SellingPrice.DataPropertyName = "SellingPrice";
            this.SellingPrice.HeaderText = "Selling Price";
            this.SellingPrice.Name = "SellingPrice";
            // 
            // CostPrice
            // 
            this.CostPrice.DataPropertyName = "CostPrice";
            this.CostPrice.HeaderText = "Cost Price";
            this.CostPrice.Name = "CostPrice";
            // 
            // StockQuantity
            // 
            this.StockQuantity.DataPropertyName = "StockQuantity";
            this.StockQuantity.HeaderText = "Quantity";
            this.StockQuantity.Name = "StockQuantity";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btndelete);
            this.panel4.Controls.Add(this.btnsave);
            this.panel4.Controls.Add(this.txtproductname);
            this.panel4.Controls.Add(this.txtstock);
            this.panel4.Controls.Add(this.txtunit);
            this.panel4.Controls.Add(this.txtcostprice);
            this.panel4.Controls.Add(this.txtsellingprice);
            this.panel4.Controls.Add(this.txtproductid);
            this.panel4.Controls.Add(this.lvlproductname);
            this.panel4.Controls.Add(this.lvlunit);
            this.panel4.Controls.Add(this.lvlsellingprice);
            this.panel4.Controls.Add(this.lvlcostprice);
            this.panel4.Controls.Add(this.lvlstockquantiy);
            this.panel4.Controls.Add(this.lvlproductid);
            this.panel4.Location = new System.Drawing.Point(428, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(362, 349);
            this.panel4.TabIndex = 3;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(178, 309);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 13;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(56, 309);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 12;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtproductname
            // 
            this.txtproductname.Location = new System.Drawing.Point(139, 80);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(181, 20);
            this.txtproductname.TabIndex = 11;
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(139, 251);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(181, 20);
            this.txtstock.TabIndex = 10;
            // 
            // txtunit
            // 
            this.txtunit.Location = new System.Drawing.Point(139, 122);
            this.txtunit.Name = "txtunit";
            this.txtunit.Size = new System.Drawing.Size(181, 20);
            this.txtunit.TabIndex = 9;
            // 
            // txtcostprice
            // 
            this.txtcostprice.Location = new System.Drawing.Point(139, 215);
            this.txtcostprice.Name = "txtcostprice";
            this.txtcostprice.Size = new System.Drawing.Size(181, 20);
            this.txtcostprice.TabIndex = 8;
            // 
            // txtsellingprice
            // 
            this.txtsellingprice.Location = new System.Drawing.Point(139, 161);
            this.txtsellingprice.Name = "txtsellingprice";
            this.txtsellingprice.Size = new System.Drawing.Size(181, 20);
            this.txtsellingprice.TabIndex = 7;
            // 
            // txtproductid
            // 
            this.txtproductid.Location = new System.Drawing.Point(139, 38);
            this.txtproductid.Name = "txtproductid";
            this.txtproductid.Size = new System.Drawing.Size(181, 20);
            this.txtproductid.TabIndex = 6;
            // 
            // lvlproductname
            // 
            this.lvlproductname.AutoSize = true;
            this.lvlproductname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlproductname.Location = new System.Drawing.Point(23, 87);
            this.lvlproductname.Name = "lvlproductname";
            this.lvlproductname.Size = new System.Drawing.Size(91, 13);
            this.lvlproductname.TabIndex = 5;
            this.lvlproductname.Text = "Product Name:";
            // 
            // lvlunit
            // 
            this.lvlunit.AutoSize = true;
            this.lvlunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlunit.Location = new System.Drawing.Point(23, 125);
            this.lvlunit.Name = "lvlunit";
            this.lvlunit.Size = new System.Drawing.Size(34, 13);
            this.lvlunit.TabIndex = 4;
            this.lvlunit.Text = "Unit:";
            // 
            // lvlsellingprice
            // 
            this.lvlsellingprice.AutoSize = true;
            this.lvlsellingprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlsellingprice.Location = new System.Drawing.Point(23, 168);
            this.lvlsellingprice.Name = "lvlsellingprice";
            this.lvlsellingprice.Size = new System.Drawing.Size(82, 13);
            this.lvlsellingprice.TabIndex = 3;
            this.lvlsellingprice.Text = "Selling Price:";
            // 
            // lvlcostprice
            // 
            this.lvlcostprice.AutoSize = true;
            this.lvlcostprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlcostprice.Location = new System.Drawing.Point(23, 215);
            this.lvlcostprice.Name = "lvlcostprice";
            this.lvlcostprice.Size = new System.Drawing.Size(69, 13);
            this.lvlcostprice.TabIndex = 2;
            this.lvlcostprice.Text = "Cost Price:";
            // 
            // lvlstockquantiy
            // 
            this.lvlstockquantiy.AutoSize = true;
            this.lvlstockquantiy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlstockquantiy.Location = new System.Drawing.Point(23, 258);
            this.lvlstockquantiy.Name = "lvlstockquantiy";
            this.lvlstockquantiy.Size = new System.Drawing.Size(95, 13);
            this.lvlstockquantiy.TabIndex = 1;
            this.lvlstockquantiy.Text = "Stock Quantity:";
            // 
            // lvlproductid
            // 
            this.lvlproductid.AutoSize = true;
            this.lvlproductid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlproductid.Location = new System.Drawing.Point(23, 45);
            this.lvlproductid.Name = "lvlproductid";
            this.lvlproductid.Size = new System.Drawing.Size(72, 13);
            this.lvlproductid.TabIndex = 0;
            this.lvlproductid.Text = "Product ID:";
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Product";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdproductlist)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtproductname;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.TextBox txtunit;
        private System.Windows.Forms.TextBox txtcostprice;
        private System.Windows.Forms.TextBox txtsellingprice;
        private System.Windows.Forms.TextBox txtproductid;
        private System.Windows.Forms.Label lvlproductname;
        private System.Windows.Forms.Label lvlunit;
        private System.Windows.Forms.Label lvlsellingprice;
        private System.Windows.Forms.Label lvlcostprice;
        private System.Windows.Forms.Label lvlstockquantiy;
        private System.Windows.Forms.Label lvlproductid;
        private System.Windows.Forms.Label lvlproducts;
        private System.Windows.Forms.DataGridView grdproductlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockQuantity;
    }
}