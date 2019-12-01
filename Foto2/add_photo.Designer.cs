namespace Foto2
{
    partial class add_photo
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.category_tree = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.album_list = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sciezka = new System.Windows.Forms.TextBox();
            this.nazwa_pliku = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1999 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.opis_zdjecia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nazwa_zdjecia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.category_tree);
            this.groupBox2.Location = new System.Drawing.Point(11, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(173, 164);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wybierz kategorię dla zdjęcia";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // category_tree
            // 
            this.category_tree.Location = new System.Drawing.Point(11, 24);
            this.category_tree.Margin = new System.Windows.Forms.Padding(2);
            this.category_tree.Name = "category_tree";
            this.category_tree.Size = new System.Drawing.Size(152, 121);
            this.category_tree.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.album_list);
            this.groupBox1.Location = new System.Drawing.Point(11, 210);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(168, 164);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybierz album dla zdjęcia";
            // 
            // album_list
            // 
            this.album_list.FormattingEnabled = true;
            this.album_list.Location = new System.Drawing.Point(11, 24);
            this.album_list.Margin = new System.Windows.Forms.Padding(2);
            this.album_list.Name = "album_list";
            this.album_list.Size = new System.Drawing.Size(148, 121);
            this.album_list.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Location = new System.Drawing.Point(201, 22);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(349, 147);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lista tagów";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Location = new System.Drawing.Point(192, 17);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(142, 85);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dodaj";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 22);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "Wpisz nowy tag";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 48);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 25);
            this.button2.TabIndex = 16;
            this.button2.Text = "Dodaj";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 106);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "Usuń";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(14, 24);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 108);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Location = new System.Drawing.Point(609, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 293);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Nazwa pliku:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // sciezka
            // 
            this.sciezka.Enabled = false;
            this.sciezka.Location = new System.Drawing.Point(315, 314);
            this.sciezka.Margin = new System.Windows.Forms.Padding(2);
            this.sciezka.Name = "sciezka";
            this.sciezka.Size = new System.Drawing.Size(270, 20);
            this.sciezka.TabIndex = 48;
            this.sciezka.TextChanged += new System.EventHandler(this.sciezka_TextChanged);
            // 
            // nazwa_pliku
            // 
            this.nazwa_pliku.Enabled = false;
            this.nazwa_pliku.Location = new System.Drawing.Point(315, 290);
            this.nazwa_pliku.Margin = new System.Windows.Forms.Padding(2);
            this.nazwa_pliku.Name = "nazwa_pliku";
            this.nazwa_pliku.Size = new System.Drawing.Size(270, 20);
            this.nazwa_pliku.TabIndex = 47;
            this.nazwa_pliku.TextChanged += new System.EventHandler(this.nazwa_pliku_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(315, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(270, 23);
            this.button3.TabIndex = 46;
            this.button3.Text = "Wybierz zdjęcie";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1999
            // 
            this.button1999.Location = new System.Drawing.Point(237, 338);
            this.button1999.Margin = new System.Windows.Forms.Padding(2);
            this.button1999.Name = "button1999";
            this.button1999.Size = new System.Drawing.Size(171, 36);
            this.button1999.TabIndex = 45;
            this.button1999.Text = "Dodaj";
            this.button1999.UseVisualStyleBackColor = true;
            this.button1999.Click += new System.EventHandler(this.button1999_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 317);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Ścieżka:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(417, 338);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(170, 36);
            this.button6.TabIndex = 43;
            this.button6.Text = "Powrót";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // opis_zdjecia
            // 
            this.opis_zdjecia.Location = new System.Drawing.Point(315, 237);
            this.opis_zdjecia.Margin = new System.Windows.Forms.Padding(2);
            this.opis_zdjecia.Name = "opis_zdjecia";
            this.opis_zdjecia.Size = new System.Drawing.Size(270, 20);
            this.opis_zdjecia.TabIndex = 42;
            this.opis_zdjecia.TextChanged += new System.EventHandler(this.opis_zdjecia_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 239);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Opis słowny:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // nazwa_zdjecia
            // 
            this.nazwa_zdjecia.Location = new System.Drawing.Point(315, 214);
            this.nazwa_zdjecia.Margin = new System.Windows.Forms.Padding(2);
            this.nazwa_zdjecia.Name = "nazwa_zdjecia";
            this.nazwa_zdjecia.Size = new System.Drawing.Size(270, 20);
            this.nazwa_zdjecia.TabIndex = 40;
            this.nazwa_zdjecia.TextChanged += new System.EventHandler(this.nazwa_zdjecia_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 217);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Nazwa zdjęcia:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // add_photo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 388);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sciezka);
            this.Controls.Add(this.nazwa_pliku);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1999);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.opis_zdjecia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nazwa_zdjecia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "add_photo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.add_photo_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TreeView category_tree;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox album_list;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sciezka;
        private System.Windows.Forms.TextBox nazwa_pliku;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1999;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox opis_zdjecia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nazwa_zdjecia;
        private System.Windows.Forms.Label label1;
    }
}