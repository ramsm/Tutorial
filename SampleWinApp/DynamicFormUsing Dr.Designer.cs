namespace SampleWinApp
{
    partial class DynamicFormUsing_Dr
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
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            this.cmbOrderItems = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbOrder
            // 
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.Location = new System.Drawing.Point(82, 32);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(121, 21);
            this.cmbOrder.TabIndex = 0;
            this.cmbOrder.SelectedValueChanged += new System.EventHandler(this.cmbOrder_SelectedValueChanged);
            // 
            // cmbOrderItems
            // 
            this.cmbOrderItems.FormattingEnabled = true;
            this.cmbOrderItems.Location = new System.Drawing.Point(82, 81);
            this.cmbOrderItems.Name = "cmbOrderItems";
            this.cmbOrderItems.Size = new System.Drawing.Size(121, 21);
            this.cmbOrderItems.TabIndex = 1;
            // 
            // DynamicFormUsing_Dr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cmbOrderItems);
            this.Controls.Add(this.cmbOrder);
            this.Name = "DynamicFormUsing_Dr";
            this.Text = "DynamicFormUsing_Dr";
            this.Load += new System.EventHandler(this.DynamicFormUsing_Dr_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOrder;
        private System.Windows.Forms.ComboBox cmbOrderItems;
    }
}