namespace DashianAssignment
{
    partial class Sales
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.lvlsales = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnsearch = new System.Windows.Forms.Button();
            this.cmbcustomerid = new System.Windows.Forms.ComboBox();
            this.dtpicker = new System.Windows.Forms.DateTimePicker();
            this.txtinvoiceno = new System.Windows.Forms.TextBox();
            this.txtremarks = new System.Windows.Forms.TextBox();
            this.txtinvoiceamount = new System.Windows.Forms.TextBox();
            this.txtsalesid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtsalesrate = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbproductid = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.grdsaleslist = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdsaleslist)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lvlsales);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 78);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnreset);
            this.panel2.Controls.Add(this.btnedit);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Controls.Add(this.btnnew);
            this.panel2.Location = new System.Drawing.Point(136, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(648, 66);
            this.panel2.TabIndex = 1;
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(541, 22);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(104, 34);
            this.btnreset.TabIndex = 3;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(431, 22);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(104, 34);
            this.btnedit.TabIndex = 2;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(321, 22);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(104, 34);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(211, 22);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(104, 34);
            this.btnnew.TabIndex = 0;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // lvlsales
            // 
            this.lvlsales.AutoSize = true;
            this.lvlsales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlsales.Location = new System.Drawing.Point(31, 36);
            this.lvlsales.Name = "lvlsales";
            this.lvlsales.Size = new System.Drawing.Size(54, 20);
            this.lvlsales.TabIndex = 0;
            this.lvlsales.Text = "Sales";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnsearch);
            this.panel3.Controls.Add(this.cmbcustomerid);
            this.panel3.Controls.Add(this.dtpicker);
            this.panel3.Controls.Add(this.txtinvoiceno);
            this.panel3.Controls.Add(this.txtremarks);
            this.panel3.Controls.Add(this.txtinvoiceamount);
            this.panel3.Controls.Add(this.txtsalesid);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(781, 116);
            this.panel3.TabIndex = 1;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(316, 25);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 21;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // cmbcustomerid
            // 
            this.cmbcustomerid.FormattingEnabled = true;
            this.cmbcustomerid.Location = new System.Drawing.Point(206, 88);
            this.cmbcustomerid.Name = "cmbcustomerid";
            this.cmbcustomerid.Size = new System.Drawing.Size(121, 21);
            this.cmbcustomerid.TabIndex = 20;
            this.cmbcustomerid.SelectedIndexChanged += new System.EventHandler(this.cmbcustomerid_SelectedIndexChanged);
            // 
            // dtpicker
            // 
            this.dtpicker.Location = new System.Drawing.Point(491, 18);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.Size = new System.Drawing.Size(105, 20);
            this.dtpicker.TabIndex = 11;
            // 
            // txtinvoiceno
            // 
            this.txtinvoiceno.Location = new System.Drawing.Point(206, 60);
            this.txtinvoiceno.Name = "txtinvoiceno";
            this.txtinvoiceno.Size = new System.Drawing.Size(100, 20);
            this.txtinvoiceno.TabIndex = 10;
            // 
            // txtremarks
            // 
            this.txtremarks.Location = new System.Drawing.Point(491, 88);
            this.txtremarks.Name = "txtremarks";
            this.txtremarks.Size = new System.Drawing.Size(100, 20);
            this.txtremarks.TabIndex = 8;
            // 
            // txtinvoiceamount
            // 
            this.txtinvoiceamount.Location = new System.Drawing.Point(491, 50);
            this.txtinvoiceamount.Name = "txtinvoiceamount";
            this.txtinvoiceamount.Size = new System.Drawing.Size(100, 20);
            this.txtinvoiceamount.TabIndex = 7;
            // 
            // txtsalesid
            // 
            this.txtsalesid.Location = new System.Drawing.Point(206, 27);
            this.txtsalesid.Name = "txtsalesid";
            this.txtsalesid.Size = new System.Drawing.Size(100, 20);
            this.txtsalesid.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(397, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Invoice Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Remarks:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sales Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Invoice No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales ID:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(435, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // txtsalesrate
            // 
            this.txtsalesrate.Location = new System.Drawing.Point(309, 34);
            this.txtsalesrate.Name = "txtsalesrate";
            this.txtsalesrate.Size = new System.Drawing.Size(100, 20);
            this.txtsalesrate.TabIndex = 13;
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(185, 34);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(100, 20);
            this.txtquantity.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sales";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(469, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(329, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Rate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(216, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Quantity";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(586, 20);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(72, 34);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(673, 20);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(72, 34);
            this.btndelete.TabIndex = 19;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cmbproductid);
            this.panel4.Controls.Add(this.btndelete);
            this.panel4.Controls.Add(this.btnadd);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.txtsalesrate);
            this.panel4.Controls.Add(this.txtquantity);
            this.panel4.Location = new System.Drawing.Point(5, 207);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(776, 81);
            this.panel4.TabIndex = 20;
            // 
            // cmbproductid
            // 
            this.cmbproductid.FormattingEnabled = true;
            this.cmbproductid.Location = new System.Drawing.Point(43, 34);
            this.cmbproductid.Name = "cmbproductid";
            this.cmbproductid.Size = new System.Drawing.Size(121, 21);
            this.cmbproductid.TabIndex = 12;
            this.cmbproductid.SelectedIndexChanged += new System.EventHandler(this.cmbproductid_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.grdsaleslist);
            this.panel5.Location = new System.Drawing.Point(3, 296);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(659, 149);
            this.panel5.TabIndex = 21;
            // 
            // grdsaleslist
            // 
            this.grdsaleslist.AllowUserToAddRows = false;
            this.grdsaleslist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdsaleslist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdsaleslist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ProductID,
            this.ProductName,
            this.Quantity,
            this.SalesRate,
            this.Total});
            this.grdsaleslist.Location = new System.Drawing.Point(9, 3);
            this.grdsaleslist.Name = "grdsaleslist";
            this.grdsaleslist.Size = new System.Drawing.Size(647, 143);
            this.grdsaleslist.TabIndex = 0;
            this.grdsaleslist.DoubleClick += new System.EventHandler(this.grdsaleslist_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "S.No";
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
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // SalesRate
            // 
            this.SalesRate.DataPropertyName = "SalesRate";
            this.SalesRate.HeaderText = "Rate";
            this.SalesRate.Name = "SalesRate";
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdsaleslist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lvlsales;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpicker;
        private System.Windows.Forms.TextBox txtinvoiceno;
        private System.Windows.Forms.TextBox txtremarks;
        private System.Windows.Forms.TextBox txtinvoiceamount;
        private System.Windows.Forms.TextBox txtsalesid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtsalesrate;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView grdsaleslist;
        private System.Windows.Forms.ComboBox cmbcustomerid;
        private System.Windows.Forms.ComboBox cmbproductid;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}