namespace SampleWinApp
{
    partial class Home
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblHover = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtText = new SampleWinApp.TextBoxNemo();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 148);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 102);
            this.textBox1.TabIndex = 1;
            // 
            // lblHover
            // 
            this.lblHover.AutoSize = true;
            this.lblHover.Location = new System.Drawing.Point(237, 237);
            this.lblHover.Name = "lblHover";
            this.lblHover.Size = new System.Drawing.Size(16, 13);
            this.lblHover.TabIndex = 2;
            this.lblHover.Text = "...";
            this.lblHover.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(43, 104);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // txtText
            // 
            this.txtText.AcceptsReturn = true;
            this.txtText.AcceptsTab = true;
            this.txtText.AllowDrop = true;
            this.txtText.Location = new System.Drawing.Point(55, 25);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(170, 73);
            this.txtText.TabIndex = 0;
            this.txtText.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtText_DragEnter);
            this.txtText.MouseLeave += new System.EventHandler(this.txtText_MouseLeave);
            this.txtText.MouseHover += new System.EventHandler(this.txtText_MouseHover);
            this.txtText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtText_MouseMove);
            // 
            // Home
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblHover);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtText);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBoxNemo txtText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblHover;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}