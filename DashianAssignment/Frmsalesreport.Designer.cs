namespace DashianAssignment
{
    partial class Frmsalesreport
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
            this.txtinvoiceamount = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.dttodate = new System.Windows.Forms.DateTimePicker();
            this.dtfromdate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdlist = new System.Windows.Forms.DataGridView();
            this.SalesID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdlist)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtinvoiceamount);
            this.panel1.Controls.Add(this.btnsearch);
            this.panel1.Controls.Add(this.dttodate);
            this.panel1.Controls.Add(this.dtfromdate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 66);
            this.panel1.TabIndex = 0;
            // 
            // txtinvoiceamount
            // 
            this.txtinvoiceamount.Location = new System.Drawing.Point(594, 46);
            this.txtinvoiceamount.Name = "txtinvoiceamount";
            this.txtinvoiceamount.Size = new System.Drawing.Size(100, 20);
            this.txtinvoiceamount.TabIndex = 5;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(594, 12);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 4;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // dttodate
            // 
            this.dttodate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttodate.Location = new System.Drawing.Point(335, 16);
            this.dttodate.Name = "dttodate";
            this.dttodate.Size = new System.Drawing.Size(200, 20);
            this.dttodate.TabIndex = 3;
            // 
            // dtfromdate
            // 
            this.dtfromdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfromdate.Location = new System.Drawing.Point(75, 16);
            this.dtfromdate.Name = "dtfromdate";
            this.dtfromdate.Size = new System.Drawing.Size(200, 20);
            this.dtfromdate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // grdlist
            // 
            this.grdlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalesID,
            this.InvoiceNo,
            this.InvoiceAmount});
            this.grdlist.Location = new System.Drawing.Point(2, 92);
            this.grdlist.Name = "grdlist";
            this.grdlist.Size = new System.Drawing.Size(786, 330);
            this.grdlist.TabIndex = 1;
            // 
            // SalesID
            // 
            this.SalesID.DataPropertyName = "SalesID";
            this.SalesID.HeaderText = "SalesID";
            this.SalesID.Name = "SalesID";
            // 
            // InvoiceNo
            // 
            this.InvoiceNo.DataPropertyName = "InvoiceNo";
            this.InvoiceNo.HeaderText = "Invoice No";
            this.InvoiceNo.Name = "InvoiceNo";
            // 
            // InvoiceAmount
            // 
            this.InvoiceAmount.DataPropertyName = "InvoiceAmount";
            this.InvoiceAmount.HeaderText = "Amount";
            this.InvoiceAmount.Name = "InvoiceAmount";
            // 
            // Frmsalesreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdlist);
            this.Controls.Add(this.panel1);
            this.Name = "Frmsalesreport";
            this.Text = "Frmsalesreport";
            this.Load += new System.EventHandler(this.Frmsalesreport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdlist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DateTimePicker dttodate;
        private System.Windows.Forms.DateTimePicker dtfromdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdlist;
        private System.Windows.Forms.TextBox txtinvoiceamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceAmount;
    }
}