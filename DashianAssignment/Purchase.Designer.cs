namespace DashianAssignment
{
    partial class Purchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchase));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.grdpurchaselist = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lvltotal = new System.Windows.Forms.Label();
            this.cmbproductid = new System.Windows.Forms.ComboBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txtpurchaerate = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtinvoiceamount = new System.Windows.Forms.TextBox();
            this.txtremarks = new System.Windows.Forms.TextBox();
            this.lvlamountofinvoice = new System.Windows.Forms.Label();
            this.lvlremarks = new System.Windows.Forms.Label();
            this.dtpicker = new System.Windows.Forms.DateTimePicker();
            this.cmbsupplierid = new System.Windows.Forms.ComboBox();
            this.txtinvoiceno = new System.Windows.Forms.TextBox();
            this.txtpurchaseid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdpurchaselist)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 66);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnedit);
            this.panel3.Controls.Add(this.btnreset);
            this.panel3.Controls.Add(this.btnsave);
            this.panel3.Controls.Add(this.btnnew);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(241, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(625, 66);
            this.panel3.TabIndex = 1;
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.SystemColors.Control;
            this.btnedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnedit.Location = new System.Drawing.Point(374, 17);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 33);
            this.btnedit.TabIndex = 1;
            this.btnedit.Text = "Edit";
            this.btnedit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click_1);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.SystemColors.Control;
            this.btnreset.Image = ((System.Drawing.Image)(resources.GetObject("btnreset.Image")));
            this.btnreset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreset.Location = new System.Drawing.Point(545, 17);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 33);
            this.btnreset.TabIndex = 0;
            this.btnreset.Text = "Reset";
            this.btnreset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnreset.UseVisualStyleBackColor = false;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.Control;
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(464, 17);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 33);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "Save";
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click_1);
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.SystemColors.Control;
            this.btnnew.Image = ((System.Drawing.Image)(resources.GetObject("btnnew.Image")));
            this.btnnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnew.Location = new System.Drawing.Point(277, 17);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(75, 33);
            this.btnnew.TabIndex = 0;
            this.btnnew.Text = "New";
            this.btnnew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 66);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purchase";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.grdpurchaselist);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(866, 394);
            this.panel4.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(679, 372);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Total:";
            // 
            // grdpurchaselist
            // 
            this.grdpurchaselist.AllowUserToAddRows = false;
            this.grdpurchaselist.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdpurchaselist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdpurchaselist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ProductID,
            this.ProductName,
            this.Quantity,
            this.PurchaseRate,
            this.Total});
            this.grdpurchaselist.Location = new System.Drawing.Point(3, 242);
            this.grdpurchaselist.Name = "grdpurchaselist";
            this.grdpurchaselist.Size = new System.Drawing.Size(653, 149);
            this.grdpurchaselist.TabIndex = 2;
            this.grdpurchaselist.Click += new System.EventHandler(this.grdpurchaselist_DoubleClick);
            this.grdpurchaselist.DoubleClick += new System.EventHandler(this.grdpurchaselist_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "S.N.";
            this.Column1.Name = "Column1";
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
            this.ProductName.HeaderText = "Product";
            this.ProductName.Name = "ProductName";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Qty.";
            this.Quantity.Name = "Quantity";
            // 
            // PurchaseRate
            // 
            this.PurchaseRate.DataPropertyName = "PurchaseRate";
            this.PurchaseRate.HeaderText = "Rate";
            this.PurchaseRate.Name = "PurchaseRate";
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.lvltotal);
            this.panel6.Controls.Add(this.cmbproductid);
            this.panel6.Controls.Add(this.txttotal);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.txtquantity);
            this.panel6.Controls.Add(this.txtpurchaerate);
            this.panel6.Controls.Add(this.btndelete);
            this.panel6.Controls.Add(this.btnadd);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(0, 155);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(866, 77);
            this.panel6.TabIndex = 1;
            // 
            // lvltotal
            // 
            this.lvltotal.AutoSize = true;
            this.lvltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvltotal.Location = new System.Drawing.Point(498, 21);
            this.lvltotal.Name = "lvltotal";
            this.lvltotal.Size = new System.Drawing.Size(31, 13);
            this.lvltotal.TabIndex = 7;
            this.lvltotal.Text = "Total";
            // 
            // cmbproductid
            // 
            this.cmbproductid.BackColor = System.Drawing.SystemColors.Control;
            this.cmbproductid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbproductid.FormattingEnabled = true;
            this.cmbproductid.Location = new System.Drawing.Point(54, 37);
            this.cmbproductid.Name = "cmbproductid";
            this.cmbproductid.Size = new System.Drawing.Size(141, 24);
            this.cmbproductid.TabIndex = 9;
            this.cmbproductid.SelectedIndexChanged += new System.EventHandler(this.cmbproductid_SelectedIndexChanged);
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.SystemColors.Control;
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(469, 48);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(117, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Product";
            // 
            // txtquantity
            // 
            this.txtquantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.Location = new System.Drawing.Point(220, 48);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(100, 20);
            this.txtquantity.TabIndex = 3;
            // 
            // txtpurchaerate
            // 
            this.txtpurchaerate.BackColor = System.Drawing.SystemColors.Control;
            this.txtpurchaerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpurchaerate.Location = new System.Drawing.Point(343, 49);
            this.txtpurchaerate.Name = "txtpurchaerate";
            this.txtpurchaerate.Size = new System.Drawing.Size(100, 20);
            this.txtpurchaerate.TabIndex = 2;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.Control;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndelete.Location = new System.Drawing.Point(705, 35);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 33);
            this.btndelete.TabIndex = 0;
            this.btndelete.Text = "Delete";
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click_1);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.Control;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.Location = new System.Drawing.Point(624, 36);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 33);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Add";
            this.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(369, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Rate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(238, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Quantity";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.btnsearch);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.txtinvoiceamount);
            this.panel5.Controls.Add(this.txtremarks);
            this.panel5.Controls.Add(this.lvlamountofinvoice);
            this.panel5.Controls.Add(this.lvlremarks);
            this.panel5.Controls.Add(this.dtpicker);
            this.panel5.Controls.Add(this.cmbsupplierid);
            this.panel5.Controls.Add(this.txtinvoiceno);
            this.panel5.Controls.Add(this.txtpurchaseid);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(866, 155);
            this.panel5.TabIndex = 0;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(343, 14);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 12;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(465, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 9;
            // 
            // txtinvoiceamount
            // 
            this.txtinvoiceamount.BackColor = System.Drawing.SystemColors.Control;
            this.txtinvoiceamount.Location = new System.Drawing.Point(572, 13);
            this.txtinvoiceamount.Name = "txtinvoiceamount";
            this.txtinvoiceamount.Size = new System.Drawing.Size(141, 20);
            this.txtinvoiceamount.TabIndex = 8;
            // 
            // txtremarks
            // 
            this.txtremarks.BackColor = System.Drawing.SystemColors.Control;
            this.txtremarks.Location = new System.Drawing.Point(572, 55);
            this.txtremarks.Name = "txtremarks";
            this.txtremarks.Size = new System.Drawing.Size(141, 20);
            this.txtremarks.TabIndex = 7;
            // 
            // lvlamountofinvoice
            // 
            this.lvlamountofinvoice.AutoSize = true;
            this.lvlamountofinvoice.Location = new System.Drawing.Point(466, 19);
            this.lvlamountofinvoice.Name = "lvlamountofinvoice";
            this.lvlamountofinvoice.Size = new System.Drawing.Size(81, 13);
            this.lvlamountofinvoice.TabIndex = 6;
            this.lvlamountofinvoice.Text = "Invoice Amount";
            // 
            // lvlremarks
            // 
            this.lvlremarks.AutoSize = true;
            this.lvlremarks.Location = new System.Drawing.Point(466, 55);
            this.lvlremarks.Name = "lvlremarks";
            this.lvlremarks.Size = new System.Drawing.Size(49, 13);
            this.lvlremarks.TabIndex = 5;
            this.lvlremarks.Text = "Remarks";
            // 
            // dtpicker
            // 
            this.dtpicker.Location = new System.Drawing.Point(179, 48);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.Size = new System.Drawing.Size(141, 20);
            this.dtpicker.TabIndex = 4;
            // 
            // cmbsupplierid
            // 
            this.cmbsupplierid.BackColor = System.Drawing.SystemColors.Control;
            this.cmbsupplierid.FormattingEnabled = true;
            this.cmbsupplierid.Location = new System.Drawing.Point(179, 109);
            this.cmbsupplierid.Name = "cmbsupplierid";
            this.cmbsupplierid.Size = new System.Drawing.Size(141, 21);
            this.cmbsupplierid.TabIndex = 3;
            // 
            // txtinvoiceno
            // 
            this.txtinvoiceno.BackColor = System.Drawing.SystemColors.Control;
            this.txtinvoiceno.Location = new System.Drawing.Point(179, 80);
            this.txtinvoiceno.Name = "txtinvoiceno";
            this.txtinvoiceno.Size = new System.Drawing.Size(141, 20);
            this.txtinvoiceno.TabIndex = 1;
            // 
            // txtpurchaseid
            // 
            this.txtpurchaseid.BackColor = System.Drawing.SystemColors.Control;
            this.txtpurchaseid.Location = new System.Drawing.Point(179, 16);
            this.txtpurchaseid.Name = "txtpurchaseid";
            this.txtpurchaseid.Size = new System.Drawing.Size(141, 20);
            this.txtpurchaseid.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "label1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Supplier Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Invoice Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Purchase ID";
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(866, 460);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Purchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.Purchase_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdpurchaselist)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.TextBox txtinvoiceno;
        private System.Windows.Forms.TextBox txtpurchaseid;
        private System.Windows.Forms.DataGridView grdpurchaselist;
        private System.Windows.Forms.TextBox txtpurchaerate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ComboBox cmbsupplierid;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.DateTimePicker dtpicker;
        private System.Windows.Forms.TextBox txtinvoiceamount;
        private System.Windows.Forms.TextBox txtremarks;
        private System.Windows.Forms.Label lvlamountofinvoice;
        private System.Windows.Forms.Label lvlremarks;
        private System.Windows.Forms.Label lvltotal;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.ComboBox cmbproductid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label label6;
    }
}