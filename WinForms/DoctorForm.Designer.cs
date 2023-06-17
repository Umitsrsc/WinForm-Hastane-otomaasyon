namespace WinForms
{
    partial class DoctorForm
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
            this.maskedTel = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDoktorParola = new System.Windows.Forms.TextBox();
            this.btnDoktorSil = new System.Windows.Forms.Button();
            this.btnDoktorGüncelle = new System.Windows.Forms.Button();
            this.btnDoktorEkle = new System.Windows.Forms.Button();
            this.txtDoktorSoyadi = new System.Windows.Forms.TextBox();
            this.txtDoktorAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDtoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryDtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtDoktorAra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.categoryDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDtoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDtoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorManagerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.maskedTel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbCategory);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtDoktorParola);
            this.panel1.Controls.Add(this.btnDoktorSil);
            this.panel1.Controls.Add(this.btnDoktorGüncelle);
            this.panel1.Controls.Add(this.btnDoktorEkle);
            this.panel1.Controls.Add(this.txtDoktorSoyadi);
            this.panel1.Controls.Add(this.txtDoktorAdi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 560);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // maskedTel
            // 
            this.maskedTel.Location = new System.Drawing.Point(97, 285);
            this.maskedTel.Mask = "(999) 000-0000";
            this.maskedTel.Name = "maskedTel";
            this.maskedTel.Size = new System.Drawing.Size(162, 27);
            this.maskedTel.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Branş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Numara";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Soyadı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Adı";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DisplayMember = "Name";
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(96, 353);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(163, 28);
            this.cmbCategory.TabIndex = 8;
            this.cmbCategory.ValueMember = "Id";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox1.Image = global::WinForms.Properties.Resources.indir__1_;
            this.pictureBox1.Location = new System.Drawing.Point(76, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txtDoktorParola
            // 
            this.txtDoktorParola.Location = new System.Drawing.Point(96, 320);
            this.txtDoktorParola.Name = "txtDoktorParola";
            this.txtDoktorParola.Size = new System.Drawing.Size(163, 27);
            this.txtDoktorParola.TabIndex = 3;
            // 
            // btnDoktorSil
            // 
            this.btnDoktorSil.BackColor = System.Drawing.Color.MediumBlue;
            this.btnDoktorSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoktorSil.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDoktorSil.Location = new System.Drawing.Point(43, 461);
            this.btnDoktorSil.Name = "btnDoktorSil";
            this.btnDoktorSil.Size = new System.Drawing.Size(238, 29);
            this.btnDoktorSil.TabIndex = 6;
            this.btnDoktorSil.Text = "Sil";
            this.btnDoktorSil.UseVisualStyleBackColor = false;
            this.btnDoktorSil.Click += new System.EventHandler(this.btnDoktorSil_Click);
            // 
            // btnDoktorGüncelle
            // 
            this.btnDoktorGüncelle.BackColor = System.Drawing.Color.MediumBlue;
            this.btnDoktorGüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoktorGüncelle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDoktorGüncelle.Location = new System.Drawing.Point(43, 496);
            this.btnDoktorGüncelle.Name = "btnDoktorGüncelle";
            this.btnDoktorGüncelle.Size = new System.Drawing.Size(238, 29);
            this.btnDoktorGüncelle.TabIndex = 5;
            this.btnDoktorGüncelle.Text = "Güncelle";
            this.btnDoktorGüncelle.UseVisualStyleBackColor = false;
            this.btnDoktorGüncelle.Click += new System.EventHandler(this.btnDoktorGüncelle_Click);
            // 
            // btnDoktorEkle
            // 
            this.btnDoktorEkle.BackColor = System.Drawing.Color.MediumBlue;
            this.btnDoktorEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoktorEkle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDoktorEkle.Location = new System.Drawing.Point(43, 419);
            this.btnDoktorEkle.Name = "btnDoktorEkle";
            this.btnDoktorEkle.Size = new System.Drawing.Size(238, 29);
            this.btnDoktorEkle.TabIndex = 4;
            this.btnDoktorEkle.Text = "Ekle";
            this.btnDoktorEkle.UseVisualStyleBackColor = false;
            this.btnDoktorEkle.Click += new System.EventHandler(this.btnDoktorEkle_Click);
            // 
            // txtDoktorSoyadi
            // 
            this.txtDoktorSoyadi.Location = new System.Drawing.Point(96, 246);
            this.txtDoktorSoyadi.Name = "txtDoktorSoyadi";
            this.txtDoktorSoyadi.Size = new System.Drawing.Size(163, 27);
            this.txtDoktorSoyadi.TabIndex = 2;
            // 
            // txtDoktorAdi
            // 
            this.txtDoktorAdi.Location = new System.Drawing.Point(96, 208);
            this.txtDoktorAdi.Name = "txtDoktorAdi";
            this.txtDoktorAdi.Size = new System.Drawing.Size(163, 27);
            this.txtDoktorAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doktorlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.LastName,
            this.phoneDataGridViewTextBoxColumn,
            this.CategoryName,
            this.sifreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.categoryDtoBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(306, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(714, 380);
            this.dataGridView1.TabIndex = 7;
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
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "LastName";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "CategoryName";
            this.CategoryName.MinimumWidth = 6;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Width = 125;
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "Sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "Sifre";
            this.sifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            this.sifreDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryDtoBindingSource2
            // 
            this.categoryDtoBindingSource2.DataSource = typeof(EntityLayer.Concrete.CategoryDto);
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataSource = typeof(EntityLayer.Concrete.Doctor);
            // 
            // categoryDtoBindingSource1
            // 
            this.categoryDtoBindingSource1.DataSource = typeof(EntityLayer.Concrete.CategoryDto);
            // 
            // txtDoktorAra
            // 
            this.txtDoktorAra.Location = new System.Drawing.Point(399, 146);
            this.txtDoktorAra.Name = "txtDoktorAra";
            this.txtDoktorAra.Size = new System.Drawing.Size(207, 27);
            this.txtDoktorAra.TabIndex = 16;
            this.txtDoktorAra.TextChanged += new System.EventHandler(this.txtDoktorAra_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Doktor Ara";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(510, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 38);
            this.label8.TabIndex = 24;
            this.label8.Text = "Doktor Bölüm";
            // 
            // categoryDtoBindingSource
            // 
            this.categoryDtoBindingSource.DataSource = typeof(EntityLayer.Concrete.CategoryDto);
            // 
            // doctorManagerBindingSource
            // 
            this.doctorManagerBindingSource.DataSource = typeof(BussinessLayer.Concrete.DoctorManager);
            // 
            // doctorBindingSource1
            // 
            this.doctorBindingSource1.DataSource = typeof(EntityLayer.Concrete.Doctor);
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::WinForms.Properties.Resources.indir;
            this.ClientSize = new System.Drawing.Size(1015, 560);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDoktorAra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "DoctorForm";
            this.Text = "DoctorForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDtoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDtoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorManagerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Button btnDoktorSil;
        private Button btnDoktorGüncelle;
        private Button btnDoktorEkle;
        private TextBox txtDoktorSoyadi;
        private TextBox txtDoktorAdi;
        private Label label1;
        private PictureBox pictureBox1;
        private ComboBox cmbCategory;
        private TextBox txtDoktorParola;
        private BindingSource doctorBindingSource;
        private TextBox txtDoktorAra;
        private Label label4;
        private Label label7;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label8;
        private BindingSource categoryDtoBindingSource;
        private BindingSource categoryDtoBindingSource1;
        private BindingSource doctorBindingSource1;
        private BindingSource doctorManagerBindingSource;
        private DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private BindingSource categoryDtoBindingSource2;
        private MaskedTextBox maskedTel;
    }
}