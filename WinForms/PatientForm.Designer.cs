namespace WinForms
{
    partial class PatientForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apointmentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meetsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnHastaSil = new System.Windows.Forms.Button();
            this.btnHastaGüncelle = new System.Windows.Forms.Button();
            this.btnHastaEkle = new System.Windows.Forms.Button();
            this.txtHastaSoyadi = new System.Windows.Forms.TextBox();
            this.txtHastaAdi = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtxthastaNumara = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHastaEmail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtHastaAra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.apointmentsDataGridViewTextBoxColumn,
            this.meetsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.patientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(317, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(672, 363);
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
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // apointmentsDataGridViewTextBoxColumn
            // 
            this.apointmentsDataGridViewTextBoxColumn.DataPropertyName = "Apointments";
            this.apointmentsDataGridViewTextBoxColumn.HeaderText = "Apointments";
            this.apointmentsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apointmentsDataGridViewTextBoxColumn.Name = "apointmentsDataGridViewTextBoxColumn";
            this.apointmentsDataGridViewTextBoxColumn.Width = 125;
            // 
            // meetsDataGridViewTextBoxColumn
            // 
            this.meetsDataGridViewTextBoxColumn.DataPropertyName = "Meets";
            this.meetsDataGridViewTextBoxColumn.HeaderText = "Meets";
            this.meetsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.meetsDataGridViewTextBoxColumn.Name = "meetsDataGridViewTextBoxColumn";
            this.meetsDataGridViewTextBoxColumn.Width = 125;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(EntityLayer.Concrete.Patient);
            // 
            // btnHastaSil
            // 
            this.btnHastaSil.BackColor = System.Drawing.Color.MediumBlue;
            this.btnHastaSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHastaSil.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnHastaSil.Location = new System.Drawing.Point(30, 413);
            this.btnHastaSil.Name = "btnHastaSil";
            this.btnHastaSil.Size = new System.Drawing.Size(261, 29);
            this.btnHastaSil.TabIndex = 6;
            this.btnHastaSil.Text = "Sil";
            this.btnHastaSil.UseVisualStyleBackColor = false;
            this.btnHastaSil.Click += new System.EventHandler(this.btnHastaSil_Click);
            // 
            // btnHastaGüncelle
            // 
            this.btnHastaGüncelle.BackColor = System.Drawing.Color.MediumBlue;
            this.btnHastaGüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHastaGüncelle.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnHastaGüncelle.Location = new System.Drawing.Point(30, 448);
            this.btnHastaGüncelle.Name = "btnHastaGüncelle";
            this.btnHastaGüncelle.Size = new System.Drawing.Size(261, 29);
            this.btnHastaGüncelle.TabIndex = 5;
            this.btnHastaGüncelle.Text = "Güncelle";
            this.btnHastaGüncelle.UseVisualStyleBackColor = false;
            this.btnHastaGüncelle.Click += new System.EventHandler(this.btnHastaGüncelle_Click);
            // 
            // btnHastaEkle
            // 
            this.btnHastaEkle.BackColor = System.Drawing.Color.MediumBlue;
            this.btnHastaEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHastaEkle.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnHastaEkle.Location = new System.Drawing.Point(30, 378);
            this.btnHastaEkle.Name = "btnHastaEkle";
            this.btnHastaEkle.Size = new System.Drawing.Size(261, 29);
            this.btnHastaEkle.TabIndex = 4;
            this.btnHastaEkle.Text = "Ekle";
            this.btnHastaEkle.UseVisualStyleBackColor = false;
            this.btnHastaEkle.Click += new System.EventHandler(this.btnHastaEkle_Click);
            // 
            // txtHastaSoyadi
            // 
            this.txtHastaSoyadi.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHastaSoyadi.Location = new System.Drawing.Point(84, 241);
            this.txtHastaSoyadi.Name = "txtHastaSoyadi";
            this.txtHastaSoyadi.Size = new System.Drawing.Size(167, 27);
            this.txtHastaSoyadi.TabIndex = 2;
            // 
            // txtHastaAdi
            // 
            this.txtHastaAdi.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHastaAdi.Location = new System.Drawing.Point(84, 194);
            this.txtHastaAdi.Name = "txtHastaAdi";
            this.txtHastaAdi.Size = new System.Drawing.Size(167, 27);
            this.txtHastaAdi.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.mtxthastaNumara);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtHastaEmail);
            this.panel1.Controls.Add(this.btnHastaSil);
            this.panel1.Controls.Add(this.btnHastaGüncelle);
            this.panel1.Controls.Add(this.btnHastaEkle);
            this.panel1.Controls.Add(this.txtHastaSoyadi);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtHastaAdi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 542);
            this.panel1.TabIndex = 8;
            // 
            // mtxthastaNumara
            // 
            this.mtxthastaNumara.Location = new System.Drawing.Point(84, 282);
            this.mtxthastaNumara.Mask = "(999) 000-0000";
            this.mtxthastaNumara.Name = "mtxthastaNumara";
            this.mtxthastaNumara.Size = new System.Drawing.Size(166, 27);
            this.mtxthastaNumara.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Adı";
            // 
            // txtHastaEmail
            // 
            this.txtHastaEmail.Location = new System.Drawing.Point(84, 326);
            this.txtHastaEmail.Name = "txtHastaEmail";
            this.txtHastaEmail.Size = new System.Drawing.Size(167, 27);
            this.txtHastaEmail.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox1.Image = global::WinForms.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(60, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtHastaAra
            // 
            this.txtHastaAra.Location = new System.Drawing.Point(404, 146);
            this.txtHastaAra.Name = "txtHastaAra";
            this.txtHastaAra.Size = new System.Drawing.Size(207, 27);
            this.txtHastaAra.TabIndex = 16;
            this.txtHastaAra.TextChanged += new System.EventHandler(this.txtHastaAra_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Hasta Ara";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(510, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 38);
            this.label6.TabIndex = 17;
            this.label6.Text = "Hasta Bölüm";
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::WinForms.Properties.Resources.indir__2_;
            this.ClientSize = new System.Drawing.Size(993, 542);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHastaAra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PatientForm";
            this.Text = "PatientForm";
            this.Click += new System.EventHandler(this.PatientForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dataGridView1;
        private Button btnHastaSil;
        private Button btnHastaGüncelle;
        private Button btnHastaEkle;
        private TextBox txtHastaSoyadi;
        private TextBox txtHastaAdi;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox txtHastaEmail;
        private DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apointmentsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn meetsDataGridViewTextBoxColumn;
        private BindingSource patientBindingSource;
        private MaskedTextBox mtxthastaNumara;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtHastaAra;
        private Label label5;
        private Label label6;
    }
}