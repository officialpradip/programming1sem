namespace DashianAssignment
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvlCustomers = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnexport = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grdcustomerlist = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtcustomername = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtremarks = new System.Windows.Forms.TextBox();
            this.txttelephone = new System.Windows.Forms.TextBox();
            this.txtcustomerid = new System.Windows.Forms.TextBox();
            this.lvlcustomername = new System.Windows.Forms.Label();
            this.lvladdress = new System.Windows.Forms.Label();
            this.lvltelephone = new System.Windows.Forms.Label();
            this.lvlremarks = new System.Windows.Forms.Label();
            this.lvlcustomerid = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdcustomerlist)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvlCustomers);
            this.panel1.Location = new System.Drawing.Point(5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 65);
            this.panel1.TabIndex = 0;
            // 
            // lvlCustomers
            // 
            this.lvlCustomers.AutoSize = true;
            this.lvlCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlCustomers.Location = new System.Drawing.Point(60, 22);
            this.lvlCustomers.Name = "lvlCustomers";
            this.lvlCustomers.Size = new System.Drawing.Size(95, 20);
            this.lvlCustomers.TabIndex = 0;
            this.lvlCustomers.Text = "Customers";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnreset);
            this.panel2.Controls.Add(this.btnedit);
            this.panel2.Controls.Add(this.btnexport);
            this.panel2.Controls.Add(this.btnprint);
            this.panel2.Controls.Add(this.btnnew);
            this.panel2.Location = new System.Drawing.Point(253, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(538, 64);
            this.panel2.TabIndex = 1;
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(427, 21);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 23);
            this.btnreset.TabIndex = 16;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnedit
            // 
            this.btnedit.Image = ((System.Drawing.Image)(resources.GetObject("btnedit.Image")));
            this.btnedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnedit.Location = new System.Drawing.Point(135, 19);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 15;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnexport
            // 
            this.btnexport.Location = new System.Drawing.Point(323, 21);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(75, 23);
            this.btnexport.TabIndex = 14;
            this.btnexport.Text = "Export";
            this.btnexport.UseVisualStyleBackColor = true;
            // 
            // btnprint
            // 
            this.btnprint.Image = global::DashianAssignment.Properties.Resources._45;
            this.btnprint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprint.Location = new System.Drawing.Point(232, 21);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(75, 23);
            this.btnprint.TabIndex = 13;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = true;
            // 
            // btnnew
            // 
            this.btnnew.Image = ((System.Drawing.Image)(resources.GetObject("btnnew.Image")));
            this.btnnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnew.Location = new System.Drawing.Point(43, 19);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(75, 23);
            this.btnnew.TabIndex = 12;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grdcustomerlist);
            this.panel3.Location = new System.Drawing.Point(6, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(381, 333);
            this.panel3.TabIndex = 2;
            // 
            // grdcustomerlist
            // 
            this.grdcustomerlist.AllowUserToAddRows = false;
            this.grdcustomerlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdcustomerlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdcustomerlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.CustomerID,
            this.CustomerName,
            this.Address,
            this.Telephone,
            this.Remarks});
            this.grdcustomerlist.Location = new System.Drawing.Point(0, 3);
            this.grdcustomerlist.Name = "grdcustomerlist";
            this.grdcustomerlist.Size = new System.Drawing.Size(378, 324);
            this.grdcustomerlist.TabIndex = 0;
            this.grdcustomerlist.DoubleClick += new System.EventHandler(this.grdcustomerlist_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "S.NO.";
            this.Column1.Name = "Column1";
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "ID";
            this.CustomerID.Name = "CustomerID";
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Name";
            this.CustomerName.Name = "CustomerName";
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // Telephone
            // 
            this.Telephone.DataPropertyName = "Telephone";
            this.Telephone.HeaderText = "Telephone";
            this.Telephone.Name = "Telephone";
            // 
            // Remarks
            // 
            this.Remarks.DataPropertyName = "Remarks";
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer Details";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btndelete);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Controls.Add(this.txtcustomername);
            this.panel4.Controls.Add(this.txtaddress);
            this.panel4.Controls.Add(this.txtremarks);
            this.panel4.Controls.Add(this.txttelephone);
            this.panel4.Controls.Add(this.txtcustomerid);
            this.panel4.Controls.Add(this.lvlcustomername);
            this.panel4.Controls.Add(this.lvladdress);
            this.panel4.Controls.Add(this.lvltelephone);
            this.panel4.Controls.Add(this.lvlremarks);
            this.panel4.Controls.Add(this.lvlcustomerid);
            this.panel4.Location = new System.Drawing.Point(401, 117);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(389, 326);
            this.panel4.TabIndex = 4;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(184, 259);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 11;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(64, 259);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtcustomername
            // 
            this.txtcustomername.Location = new System.Drawing.Point(165, 71);
            this.txtcustomername.Name = "txtcustomername";
            this.txtcustomername.Size = new System.Drawing.Size(163, 20);
            this.txtcustomername.TabIndex = 9;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(165, 104);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(163, 20);
            this.txtaddress.TabIndex = 8;
            // 
            // txtremarks
            // 
            this.txtremarks.Location = new System.Drawing.Point(165, 175);
            this.txtremarks.Name = "txtremarks";
            this.txtremarks.Size = new System.Drawing.Size(163, 20);
            this.txtremarks.TabIndex = 7;
            // 
            // txttelephone
            // 
            this.txttelephone.Location = new System.Drawing.Point(165, 139);
            this.txttelephone.Name = "txttelephone";
            this.txttelephone.Size = new System.Drawing.Size(163, 20);
            this.txttelephone.TabIndex = 6;
            // 
            // txtcustomerid
            // 
            this.txtcustomerid.Location = new System.Drawing.Point(165, 38);
            this.txtcustomerid.Name = "txtcustomerid";
            this.txtcustomerid.Size = new System.Drawing.Size(163, 20);
            this.txtcustomerid.TabIndex = 5;
            // 
            // lvlcustomername
            // 
            this.lvlcustomername.AutoSize = true;
            this.lvlcustomername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlcustomername.Location = new System.Drawing.Point(29, 71);
            this.lvlcustomername.Name = "lvlcustomername";
            this.lvlcustomername.Size = new System.Drawing.Size(99, 13);
            this.lvlcustomername.TabIndex = 4;
            this.lvlcustomername.Text = "Customer Name:";
            // 
            // lvladdress
            // 
            this.lvladdress.AutoSize = true;
            this.lvladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvladdress.Location = new System.Drawing.Point(29, 104);
            this.lvladdress.Name = "lvladdress";
            this.lvladdress.Size = new System.Drawing.Size(56, 13);
            this.lvladdress.TabIndex = 3;
            this.lvladdress.Text = "Address:";
            // 
            // lvltelephone
            // 
            this.lvltelephone.AutoSize = true;
            this.lvltelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvltelephone.Location = new System.Drawing.Point(28, 142);
            this.lvltelephone.Name = "lvltelephone";
            this.lvltelephone.Size = new System.Drawing.Size(71, 13);
            this.lvltelephone.TabIndex = 2;
            this.lvltelephone.Text = "Telephone:";
            // 
            // lvlremarks
            // 
            this.lvlremarks.AutoSize = true;
            this.lvlremarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlremarks.Location = new System.Drawing.Point(29, 175);
            this.lvlremarks.Name = "lvlremarks";
            this.lvlremarks.Size = new System.Drawing.Size(60, 13);
            this.lvlremarks.TabIndex = 1;
            this.lvlremarks.Text = "Remarks:";
            // 
            // lvlcustomerid
            // 
            this.lvlcustomerid.AutoSize = true;
            this.lvlcustomerid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlcustomerid.Location = new System.Drawing.Point(28, 45);
            this.lvlcustomerid.Name = "lvlcustomerid";
            this.lvlcustomerid.Size = new System.Drawing.Size(80, 13);
            this.lvlcustomerid.TabIndex = 0;
            this.lvlcustomerid.Text = "Customer ID:";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdcustomerlist)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lvlCustomers;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView grdcustomerlist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lvlcustomerid;
        private System.Windows.Forms.Label lvlcustomername;
        private System.Windows.Forms.Label lvladdress;
        private System.Windows.Forms.Label lvltelephone;
        private System.Windows.Forms.Label lvlremarks;
        private System.Windows.Forms.TextBox txtcustomername;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtremarks;
        private System.Windows.Forms.TextBox txttelephone;
        private System.Windows.Forms.TextBox txtcustomerid;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
    }
}