namespace SampleWinApp
{
    partial class GroupControls
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("1-1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("1", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("2");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Root", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.DataSetSample = new System.Data.DataSet();
            this.Order = new System.Data.DataTable();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetSample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Order)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(114, 167);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 1;
            // 
            // DataSetSample
            // 
            this.DataSetSample.DataSetName = "NewDataSet";
            this.DataSetSample.Tables.AddRange(new System.Data.DataTable[] {
            this.Order});
            // 
            // Order
            // 
            this.Order.TableName = "Order";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(451, 156);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "1-1";
            treeNode1.Text = "1-1";
            treeNode2.Name = "1";
            treeNode2.Text = "1";
            treeNode3.Name = "2";
            treeNode3.Text = "2";
            treeNode4.Name = "Root";
            treeNode4.Text = "Root";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // GroupControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 443);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "GroupControls";
            this.Text = "GroupControls";
            this.Load += new System.EventHandler(this.GroupControls_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetSample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Order)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Data.DataSet DataSetSample;
        private System.Data.DataTable Order;
        private System.Windows.Forms.TreeView treeView1;
    }
}