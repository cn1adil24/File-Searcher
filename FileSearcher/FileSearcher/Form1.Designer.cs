namespace FileSearcher
{
    partial class Form1
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.search = new System.Windows.Forms.Button();
            this.search_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_check = new System.Windows.Forms.CheckBox();
            this.doc_check = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.csv_check = new System.Windows.Forms.CheckBox();
            this.xml_check = new System.Windows.Forms.CheckBox();
            this.json_check = new System.Windows.Forms.CheckBox();
            this.advanced_check = new System.Windows.Forms.CheckBox();
            this.clear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 627);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(534, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 598);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "..";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = ".";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(9, 113);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(102, 20);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Select Folder";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(8, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 28);
            this.panel1.TabIndex = 9;
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(472, 220);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(89, 38);
            this.search.TabIndex = 5;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // search_box
            // 
            this.search_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_box.Location = new System.Drawing.Point(12, 72);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(549, 27);
            this.search_box.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter Keyword:";
            // 
            // txt_check
            // 
            this.txt_check.AutoSize = true;
            this.txt_check.Location = new System.Drawing.Point(11, 237);
            this.txt_check.Name = "txt_check";
            this.txt_check.Size = new System.Drawing.Size(49, 21);
            this.txt_check.TabIndex = 12;
            this.txt_check.Text = "Txt";
            this.txt_check.UseVisualStyleBackColor = true;
            // 
            // doc_check
            // 
            this.doc_check.AutoSize = true;
            this.doc_check.Location = new System.Drawing.Point(120, 237);
            this.doc_check.Name = "doc_check";
            this.doc_check.Size = new System.Drawing.Size(55, 21);
            this.doc_check.TabIndex = 13;
            this.doc_check.Text = "Doc";
            this.doc_check.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Select type(s):";
            // 
            // csv_check
            // 
            this.csv_check.AutoSize = true;
            this.csv_check.Location = new System.Drawing.Point(239, 237);
            this.csv_check.Name = "csv_check";
            this.csv_check.Size = new System.Drawing.Size(53, 21);
            this.csv_check.TabIndex = 15;
            this.csv_check.Text = "Csv";
            this.csv_check.UseVisualStyleBackColor = true;
            // 
            // xml_check
            // 
            this.xml_check.AutoSize = true;
            this.xml_check.Location = new System.Drawing.Point(11, 274);
            this.xml_check.Name = "xml_check";
            this.xml_check.Size = new System.Drawing.Size(58, 21);
            this.xml_check.TabIndex = 16;
            this.xml_check.Text = "XML";
            this.xml_check.UseVisualStyleBackColor = true;
            // 
            // json_check
            // 
            this.json_check.AutoSize = true;
            this.json_check.Location = new System.Drawing.Point(120, 274);
            this.json_check.Name = "json_check";
            this.json_check.Size = new System.Drawing.Size(67, 21);
            this.json_check.TabIndex = 17;
            this.json_check.Text = "JSON";
            this.json_check.UseVisualStyleBackColor = true;
            // 
            // advanced_check
            // 
            this.advanced_check.AutoSize = true;
            this.advanced_check.Enabled = false;
            this.advanced_check.Location = new System.Drawing.Point(12, 170);
            this.advanced_check.Name = "advanced_check";
            this.advanced_check.Size = new System.Drawing.Size(142, 21);
            this.advanced_check.TabIndex = 18;
            this.advanced_check.Text = "Advanced Search";
            this.advanced_check.UseVisualStyleBackColor = true;
            this.advanced_check.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(472, 170);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(89, 38);
            this.clear.TabIndex = 19;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(577, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(976, 653);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1560, 672);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.advanced_check);
            this.Controls.Add(this.json_check);
            this.Controls.Add(this.xml_check);
            this.Controls.Add(this.csv_check);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.doc_check);
            this.Controls.Add(this.txt_check);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.Text = "Search";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox txt_check;
        private System.Windows.Forms.CheckBox doc_check;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox csv_check;
        private System.Windows.Forms.CheckBox xml_check;
        private System.Windows.Forms.CheckBox json_check;
        private System.Windows.Forms.CheckBox advanced_check;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

