namespace EAVinogradov.CSWindowsForms.SecondLaboratory.SixthExample
{
    partial class BiblWorm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.authorBox = new System.Windows.Forms.TextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.publishBox = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.AvailBox = new System.Windows.Forms.CheckBox();
            this.returnBox = new System.Windows.Forms.CheckBox();
            this.sortBox = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.publishedBox = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabBooks = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.tabBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBooks);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(654, 411);
            this.tabControl1.TabIndex = 0;
            // 
            // authorBox
            // 
            this.authorBox.Location = new System.Drawing.Point(106, 17);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(120, 20);
            this.authorBox.TabIndex = 0;
            this.authorBox.Tag = "";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(106, 44);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(120, 20);
            this.titleBox.TabIndex = 1;
            // 
            // publishBox
            // 
            this.publishBox.Location = new System.Drawing.Point(106, 70);
            this.publishBox.Name = "publishBox";
            this.publishBox.Size = new System.Drawing.Size(120, 20);
            this.publishBox.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(106, 132);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(106, 159);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 4;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(106, 186);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 5;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(106, 212);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown4.TabIndex = 6;
            // 
            // AvailBox
            // 
            this.AvailBox.AutoSize = true;
            this.AvailBox.Location = new System.Drawing.Point(24, 249);
            this.AvailBox.Name = "AvailBox";
            this.AvailBox.Size = new System.Drawing.Size(69, 17);
            this.AvailBox.TabIndex = 7;
            this.AvailBox.Text = "Наличие";
            this.AvailBox.UseVisualStyleBackColor = true;
            this.AvailBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // returnBox
            // 
            this.returnBox.AutoSize = true;
            this.returnBox.Location = new System.Drawing.Point(106, 249);
            this.returnBox.Name = "returnBox";
            this.returnBox.Size = new System.Drawing.Size(125, 17);
            this.returnBox.TabIndex = 8;
            this.returnBox.Text = "Возвращает в срок";
            this.returnBox.UseVisualStyleBackColor = true;
            // 
            // sortBox
            // 
            this.sortBox.AutoSize = true;
            this.sortBox.Location = new System.Drawing.Point(272, 360);
            this.sortBox.Name = "sortBox";
            this.sortBox.Size = new System.Drawing.Size(181, 17);
            this.sortBox.TabIndex = 9;
            this.sortBox.Text = "Сортировать по инвентарному";
            this.sortBox.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(249, 17);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(379, 323);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(68, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 31);
            this.button2.TabIndex = 12;
            this.button2.Text = "Просмотреть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 14;
            // 
            // publishedBox
            // 
            this.publishedBox.AutoSize = true;
            this.publishedBox.Location = new System.Drawing.Point(21, 73);
            this.publishedBox.Name = "publishedBox";
            this.publishedBox.Size = new System.Drawing.Size(0, 13);
            this.publishedBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 19;
            // 
            // tabBooks
            // 
            this.tabBooks.Controls.Add(this.label7);
            this.tabBooks.Controls.Add(this.label6);
            this.tabBooks.Controls.Add(this.label5);
            this.tabBooks.Controls.Add(this.label4);
            this.tabBooks.Controls.Add(this.publishedBox);
            this.tabBooks.Controls.Add(this.label2);
            this.tabBooks.Controls.Add(this.label1);
            this.tabBooks.Controls.Add(this.button2);
            this.tabBooks.Controls.Add(this.button1);
            this.tabBooks.Controls.Add(this.richTextBox1);
            this.tabBooks.Controls.Add(this.sortBox);
            this.tabBooks.Controls.Add(this.returnBox);
            this.tabBooks.Controls.Add(this.AvailBox);
            this.tabBooks.Controls.Add(this.numericUpDown4);
            this.tabBooks.Controls.Add(this.numericUpDown3);
            this.tabBooks.Controls.Add(this.numericUpDown2);
            this.tabBooks.Controls.Add(this.numericUpDown1);
            this.tabBooks.Controls.Add(this.publishBox);
            this.tabBooks.Controls.Add(this.titleBox);
            this.tabBooks.Controls.Add(this.authorBox);
            this.tabBooks.Location = new System.Drawing.Point(4, 22);
            this.tabBooks.Name = "tabBooks";
            this.tabBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabBooks.Size = new System.Drawing.Size(646, 385);
            this.tabBooks.TabIndex = 0;
            this.tabBooks.Text = "Книги";
            this.tabBooks.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(646, 385);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Журналы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BiblWorm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 411);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "BiblWorm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека";
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.tabBooks.ResumeLayout(false);
            this.tabBooks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBooks;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label publishedBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox sortBox;
        private System.Windows.Forms.CheckBox returnBox;
        private System.Windows.Forms.CheckBox AvailBox;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox publishBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox authorBox;
        private System.Windows.Forms.TabPage tabPage1;
    }
}
