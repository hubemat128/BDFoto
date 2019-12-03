namespace Foto2
{
    partial class category
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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("");
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.category_tree = new System.Windows.Forms.TreeView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_delCategory = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_addCategory = new System.Windows.Forms.Button();
            this.txtNewCat = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtChCat = new System.Windows.Forms.TextBox();
            this.button_chCategory = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(148, 242);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 36);
            this.button4.TabIndex = 10;
            this.button4.Text = "Powrót";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.category_tree);
            this.groupBox4.Location = new System.Drawing.Point(11, 11);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(133, 267);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lista kategorii";
            // 
            // category_tree
            // 
            this.category_tree.AllowDrop = true;
            this.category_tree.Location = new System.Drawing.Point(4, 24);
            this.category_tree.Margin = new System.Windows.Forms.Padding(2);
            this.category_tree.Name = "category_tree";
            treeNode2.Name = "Node0";
            treeNode2.Text = "";
            this.category_tree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.category_tree.Size = new System.Drawing.Size(124, 238);
            this.category_tree.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_delCategory);
            this.groupBox3.Location = new System.Drawing.Point(148, 98);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(191, 50);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Usunięcie kategorii";
            // 
            // button_delCategory
            // 
            this.button_delCategory.Location = new System.Drawing.Point(12, 19);
            this.button_delCategory.Margin = new System.Windows.Forms.Padding(2);
            this.button_delCategory.Name = "button_delCategory";
            this.button_delCategory.Size = new System.Drawing.Size(170, 23);
            this.button_delCategory.TabIndex = 3;
            this.button_delCategory.Text = "Usuń kategorię";
            this.button_delCategory.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_addCategory);
            this.groupBox2.Controls.Add(this.txtNewCat);
            this.groupBox2.Location = new System.Drawing.Point(148, 154);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(191, 84);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodawanie kategorii";
            // 
            // button_addCategory
            // 
            this.button_addCategory.Location = new System.Drawing.Point(12, 52);
            this.button_addCategory.Margin = new System.Windows.Forms.Padding(2);
            this.button_addCategory.Name = "button_addCategory";
            this.button_addCategory.Size = new System.Drawing.Size(168, 22);
            this.button_addCategory.TabIndex = 1;
            this.button_addCategory.Text = "Dodaj kategorię";
            this.button_addCategory.UseVisualStyleBackColor = true;
            // 
            // txtNewCat
            // 
            this.txtNewCat.Location = new System.Drawing.Point(12, 25);
            this.txtNewCat.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewCat.Name = "txtNewCat";
            this.txtNewCat.Size = new System.Drawing.Size(169, 20);
            this.txtNewCat.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtChCat);
            this.groupBox1.Controls.Add(this.button_chCategory);
            this.groupBox1.Location = new System.Drawing.Point(148, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(191, 84);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zmiana nazwy kategorii";
            // 
            // txtChCat
            // 
            this.txtChCat.Location = new System.Drawing.Point(12, 24);
            this.txtChCat.Margin = new System.Windows.Forms.Padding(2);
            this.txtChCat.Name = "txtChCat";
            this.txtChCat.Size = new System.Drawing.Size(171, 20);
            this.txtChCat.TabIndex = 3;
            // 
            // button_chCategory
            // 
            this.button_chCategory.Location = new System.Drawing.Point(12, 51);
            this.button_chCategory.Margin = new System.Windows.Forms.Padding(2);
            this.button_chCategory.Name = "button_chCategory";
            this.button_chCategory.Size = new System.Drawing.Size(170, 23);
            this.button_chCategory.TabIndex = 2;
            this.button_chCategory.Text = "Zmień nazwę";
            this.button_chCategory.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 296);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TreeView category_tree;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_delCategory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_addCategory;
        private System.Windows.Forms.TextBox txtNewCat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtChCat;
        private System.Windows.Forms.Button button_chCategory;
    }
}