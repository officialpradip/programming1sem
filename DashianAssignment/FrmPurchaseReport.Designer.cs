namespace DashianAssignment
{
    partial class FrmPurchaseReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtfromdate = new System.Windows.Forms.DateTimePicker();
            this.dttodate = new System.Windows.Forms.DateTimePicker();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtinvoiceamount = new System.Windows.Forms.TextBox();
            this.grdlist = new System.Windows.Forms.DataGridView();
            this.PurchaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdlist)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            // 
            // dtfromdate
            // 
            this.dtfromdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfromdate.Location = new System.Drawing.Point(76, 13);
            this.dtfromdate.Name = "dtfromdate";
            this.dtfromdate.Size = new System.Drawing.Size(200, 20);
            this.dtfromdate.TabIndex = 3;
            // 
            // dttodate
            // 
            this.dttodate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttodate.Location = new System.Drawing.Point(376, 13);
            this.dttodate.Name = "dttodate";
            this.dttodate.Size = new System.Drawing.Size(200, 20);
            this.dttodate.TabIndex = 4;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(632, 9);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 5;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtinvoiceamount
            // 
            this.txtinvoiceamount.Location = new System.Drawing.Point(637, 60);
            this.txtinvoiceamount.Name = "txtinvoiceamount";
            this.txtinvoiceamount.Size = new System.Drawing.Size(100, 20);
            this.txtinvoiceamount.TabIndex = 7;
            // 
            // grdlist
            // 
            this.grdlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PurchaseID,
            this.InvoiceNo,
            this.InvoiceAmount});
            this.grdlist.Location = new System.Drawing.Point(8, 119);
            this.grdlist.Name = "grdlist";
            this.grdlist.Size = new System.Drawing.Size(780, 303);
            this.grdlist.TabIndex = 6;
            // 
            // PurchaseID
            // 
            this.PurchaseID.DataPropertyName = "PurchaseID";
            this.PurchaseID.HeaderText = "PurchaseID";
            this.PurchaseID.Name = "PurchaseID";
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
            this.InvoiceAmount.HeaderText = "InvoiceAmount";
            this.InvoiceAmount.Name = "InvoiceAmount";
            // 
            // FrmPurchaseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtinvoiceamount);
            this.Controls.Add(this.grdlist);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.dttodate);
            this.Controls.Add(this.dtfromdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPurchaseReport";
            this.Text = "FrmPurchaseReport";
            this.Load += new System.EventHandler(this.FrmPurchaseReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtfromdate;
        private System.Windows.Forms.DateTimePicker dttodate;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtinvoiceamount;
        private System.Windows.Forms.DataGridView grdlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceAmount;
    }
}