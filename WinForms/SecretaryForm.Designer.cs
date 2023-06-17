namespace WinForms
{
    partial class SecretaryForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedSekreterNumara = new System.Windows.Forms.MaskedTextBox();
            this.btnSekreterSil = new System.Windows.Forms.Button();
            this.btnSekreterGüncelle = new System.Windows.Forms.Button();
            this.btnSekreterEkle = new System.Windows.Forms.Button();
            this.txtSekreterSoyadi = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSekreterAdi = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secretaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtSekreterAra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secretaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.maskedSekreterNumara);
            this.panel1.Controls.Add(this.btnSekreterSil);
            this.panel1.Controls.Add(this.btnSekreterGüncelle);
            this.panel1.Controls.Add(this.btnSekreterEkle);
            this.panel1.Controls.Add(this.txtSekreterSoyadi);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtSekreterAdi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 502);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Numara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Adı";
            // 
            // maskedSekreterNumara
            // 
            this.maskedSekreterNumara.Location = new System.Drawing.Point(101, 272);
            this.maskedSekreterNumara.Mask = "(999) 000-0000";
            this.maskedSekreterNumara.Name = "maskedSekreterNumara";
            this.maskedSekreterNumara.Size = new System.Drawing.Size(167, 27);
            this.maskedSekreterNumara.TabIndex = 7;
            // 
            // btnSekreterSil
            // 
            this.btnSekreterSil.BackColor = System.Drawing.Color.MediumBlue;
            this.btnSekreterSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSekreterSil.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnSekreterSil.Location = new System.Drawing.Point(43, 374);
            this.btnSekreterSil.Name = "btnSekreterSil";
            this.btnSekreterSil.Size = new System.Drawing.Size(238, 29);
            this.btnSekreterSil.TabIndex = 6;
            this.btnSekreterSil.Text = "Sil";
            this.btnSekreterSil.UseVisualStyleBackColor = false;
            this.btnSekreterSil.Click += new System.EventHandler(this.btnSekreterSil_Click);
            // 
            // btnSekreterGüncelle
            // 
            this.btnSekreterGüncelle.BackColor = System.Drawing.Color.MediumBlue;
            this.btnSekreterGüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSekreterGüncelle.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnSekreterGüncelle.Location = new System.Drawing.Point(43, 409);
            this.btnSekreterGüncelle.Name = "btnSekreterGüncelle";
            this.btnSekreterGüncelle.Size = new System.Drawing.Size(240, 29);
            this.btnSekreterGüncelle.TabIndex = 5;
            this.btnSekreterGüncelle.Text = "Güncelle";
            this.btnSekreterGüncelle.UseVisualStyleBackColor = false;
            this.btnSekreterGüncelle.Click += new System.EventHandler(this.btnSekreterGüncelle_Click);
            // 
            // btnSekreterEkle
            // 
            this.btnSekreterEkle.BackColor = System.Drawing.Color.MediumBlue;
            this.btnSekreterEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSekreterEkle.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnSekreterEkle.Location = new System.Drawing.Point(43, 339);
            this.btnSekreterEkle.Name = "btnSekreterEkle";
            this.btnSekreterEkle.Size = new System.Drawing.Size(238, 29);
            this.btnSekreterEkle.TabIndex = 4;
            this.btnSekreterEkle.Text = "Ekle";
            this.btnSekreterEkle.UseVisualStyleBackColor = false;
            this.btnSekreterEkle.Click += new System.EventHandler(this.btnSekreterEkle_Click);
            // 
            // txtSekreterSoyadi
            // 
            this.txtSekreterSoyadi.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSekreterSoyadi.Location = new System.Drawing.Point(101, 227);
            this.txtSekreterSoyadi.Name = "txtSekreterSoyadi";
            this.txtSekreterSoyadi.Size = new System.Drawing.Size(167, 27);
            this.txtSekreterSoyadi.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = global::WinForms.Properties.Resources._19956061;
            this.pictureBox1.Location = new System.Drawing.Point(64, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtSekreterAdi
            // 
            this.txtSekreterAdi.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSekreterAdi.Location = new System.Drawing.Point(101, 185);
            this.txtSekreterAdi.Name = "txtSekreterAdi";
            this.txtSekreterAdi.Size = new System.Drawing.Size(167, 27);
            this.txtSekreterAdi.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.secretaryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(317, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(705, 340);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // secretaryBindingSource
            // 
            this.secretaryBindingSource.DataSource = typeof(EntityLayer.Concrete.Secretary);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(324, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sekreter Ara";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtSekreterAra
            // 
            this.txtSekreterAra.Location = new System.Drawing.Point(425, 130);
            this.txtSekreterAra.Name = "txtSekreterAra";
            this.txtSekreterAra.Size = new System.Drawing.Size(207, 27);
            this.txtSekreterAra.TabIndex = 14;
            this.txtSekreterAra.TextChanged += new System.EventHandler(this.txtSekreterAra_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(542, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 38);
            this.label5.TabIndex = 15;
            this.label5.Text = "Sekreter Bölüm";
            // 
            // SecretaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1026, 502);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSekreterAra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "SecretaryForm";
            this.Text = "SecretaryForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secretaryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button btnSekreterSil;
        private Button btnSekreterGüncelle;
        private Button btnSekreterEkle;
        private TextBox txtSekreterSoyadi;
        private PictureBox pictureBox1;
        private TextBox txtSekreterAdi;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private BindingSource secretaryBindingSource;
        private MaskedTextBox maskedSekreterNumara;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox txtSekreterAra;
        private Label label5;
    }
}