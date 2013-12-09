namespace SampleWinApp
{
    partial class GridViewExample
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
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.OrderName,
            this.UserName});
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(0, 0);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.Size = new System.Drawing.Size(797, 503);
            this.dgvOrders.TabIndex = 0;
            // 
            // OrderId
            // 
            this.OrderId.DataPropertyName = "OrderID";
            this.OrderId.HeaderText = "Order Id";
            this.OrderId.Name = "OrderId";
            this.OrderId.ReadOnly = true;
            // 
            // OrderName
            // 
            this.OrderName.DataPropertyName = "OrderName";
            this.OrderName.HeaderText = "Order Name";
            this.OrderName.Name = "OrderName";
            this.OrderName.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "User Name";
            this.UserName.Name = "UserName";
            // 
            // GridViewExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 503);
            this.Controls.Add(this.dgvOrders);
            this.Name = "GridViewExample";
            this.Text = "GridViewExample";
            this.Load += new System.EventHandler(this.GridViewExample_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
    }
}