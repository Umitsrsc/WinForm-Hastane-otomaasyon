namespace WinForms
{
    partial class MeetDetayForm
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
            this.dataGridViewdetay = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Describe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meetDtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meetDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnpdf = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDoktorSoyadı = new System.Windows.Forms.TextBox();
            this.txtDoktorAdı = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHastaSoyadı = new System.Windows.Forms.TextBox();
            this.txtHastaAdı = new System.Windows.Forms.TextBox();
            this.txtDoktorGorus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdetay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetDtoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDtoBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewdetay
            // 
            this.dataGridViewdetay.AutoGenerateColumns = false;
            this.dataGridViewdetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewdetay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.doctorIdDataGridViewTextBoxColumn,
            this.DoctorName,
            this.DoctorLastName,
            this.patientIdDataGridViewTextBoxColumn,
            this.PatientName,
            this.PatientLastName,
            this.Describe});
            this.dataGridViewdetay.DataSource = this.meetDtoBindingSource1;
            this.dataGridViewdetay.Location = new System.Drawing.Point(287, 139);
            this.dataGridViewdetay.Name = "dataGridViewdetay";
            this.dataGridViewdetay.RowHeadersWidth = 51;
            this.dataGridViewdetay.RowTemplate.Height = 29;
            this.dataGridViewdetay.Size = new System.Drawing.Size(817, 394);
            this.dataGridViewdetay.TabIndex = 0;
            this.dataGridViewdetay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewdetay_CellClick);
            this.dataGridViewdetay.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewdetay_RowHeaderMouseDoubleClick);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.Width = 125;
            // 
            // doctorIdDataGridViewTextBoxColumn
            // 
            this.doctorIdDataGridViewTextBoxColumn.DataPropertyName = "DoctorId";
            this.doctorIdDataGridViewTextBoxColumn.HeaderText = "DoctorId";
            this.doctorIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorIdDataGridViewTextBoxColumn.Name = "doctorIdDataGridViewTextBoxColumn";
            this.doctorIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // DoctorName
            // 
            this.DoctorName.DataPropertyName = "DoctorName";
            this.DoctorName.HeaderText = "DoctorName";
            this.DoctorName.MinimumWidth = 6;
            this.DoctorName.Name = "DoctorName";
            this.DoctorName.Width = 125;
            // 
            // DoctorLastName
            // 
            this.DoctorLastName.DataPropertyName = "DoctorLastName";
            this.DoctorLastName.HeaderText = "DoctorLastName";
            this.DoctorLastName.MinimumWidth = 6;
            this.DoctorLastName.Name = "DoctorLastName";
            this.DoctorLastName.Width = 125;
            // 
            // patientIdDataGridViewTextBoxColumn
            // 
            this.patientIdDataGridViewTextBoxColumn.DataPropertyName = "PatientId";
            this.patientIdDataGridViewTextBoxColumn.HeaderText = "PatientId";
            this.patientIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientIdDataGridViewTextBoxColumn.Name = "patientIdDataGridViewTextBoxColumn";
            this.patientIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // PatientName
            // 
            this.PatientName.DataPropertyName = "PatientName";
            this.PatientName.HeaderText = "PatientName";
            this.PatientName.MinimumWidth = 6;
            this.PatientName.Name = "PatientName";
            this.PatientName.Width = 125;
            // 
            // PatientLastName
            // 
            this.PatientLastName.DataPropertyName = "PatientLastName";
            this.PatientLastName.HeaderText = "PatientLastName";
            this.PatientLastName.MinimumWidth = 6;
            this.PatientLastName.Name = "PatientLastName";
            this.PatientLastName.Width = 125;
            // 
            // Describe
            // 
            this.Describe.DataPropertyName = "Describe";
            this.Describe.HeaderText = "Describe";
            this.Describe.MinimumWidth = 6;
            this.Describe.Name = "Describe";
            this.Describe.Width = 125;
            // 
            // meetDtoBindingSource1
            // 
            this.meetDtoBindingSource1.DataSource = typeof(EntityLayer.Concrete.MeetDto);
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(EntityLayer.Concrete.Patient);
            // 
            // meetDtoBindingSource
            // 
            this.meetDtoBindingSource.DataSource = typeof(EntityLayer.Concrete.MeetDto);
            // 
            // categoryDtoBindingSource
            // 
            this.categoryDtoBindingSource.DataSource = typeof(EntityLayer.Concrete.CategoryDto);
            // 
            // btnpdf
            // 
            this.btnpdf.Location = new System.Drawing.Point(37, 493);
            this.btnpdf.Name = "btnpdf";
            this.btnpdf.Size = new System.Drawing.Size(206, 40);
            this.btnpdf.TabIndex = 1;
            this.btnpdf.Text = "Pdf Oluştur";
            this.btnpdf.UseVisualStyleBackColor = true;
            this.btnpdf.Click += new System.EventHandler(this.btnpdf_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtDoktorSoyadı);
            this.panel2.Controls.Add(this.txtDoktorAdı);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 172);
            this.panel2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Soyadı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Doktor Bilgileri";
            // 
            // txtDoktorSoyadı
            // 
            this.txtDoktorSoyadı.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDoktorSoyadı.Location = new System.Drawing.Point(64, 112);
            this.txtDoktorSoyadı.Name = "txtDoktorSoyadı";
            this.txtDoktorSoyadı.Size = new System.Drawing.Size(167, 27);
            this.txtDoktorSoyadı.TabIndex = 9;
            // 
            // txtDoktorAdı
            // 
            this.txtDoktorAdı.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDoktorAdı.Location = new System.Drawing.Point(64, 64);
            this.txtDoktorAdı.Name = "txtDoktorAdı";
            this.txtDoktorAdı.Size = new System.Drawing.Size(167, 27);
            this.txtDoktorAdı.TabIndex = 8;
            this.txtDoktorAdı.TextChanged += new System.EventHandler(this.txtDoktorAdı_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtHastaSoyadı);
            this.panel1.Controls.Add(this.txtHastaAdı);
            this.panel1.Location = new System.Drawing.Point(12, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 173);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Soyadı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Adı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Hasta Bilgileri";
            // 
            // txtHastaSoyadı
            // 
            this.txtHastaSoyadı.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHastaSoyadı.Location = new System.Drawing.Point(64, 117);
            this.txtHastaSoyadı.Name = "txtHastaSoyadı";
            this.txtHastaSoyadı.Size = new System.Drawing.Size(167, 27);
            this.txtHastaSoyadı.TabIndex = 9;
            // 
            // txtHastaAdı
            // 
            this.txtHastaAdı.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHastaAdı.Location = new System.Drawing.Point(64, 70);
            this.txtHastaAdı.Name = "txtHastaAdı";
            this.txtHastaAdı.Size = new System.Drawing.Size(167, 27);
            this.txtHastaAdı.TabIndex = 8;
            // 
            // txtDoktorGorus
            // 
            this.txtDoktorGorus.Location = new System.Drawing.Point(18, 409);
            this.txtDoktorGorus.Multiline = true;
            this.txtDoktorGorus.Name = "txtDoktorGorus";
            this.txtDoktorGorus.Size = new System.Drawing.Size(263, 68);
            this.txtDoktorGorus.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(535, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 38);
            this.label3.TabIndex = 16;
            this.label3.Text = "Görüşme Bölüm";
            // 
            // MeetDetayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::WinForms.Properties.Resources.images1;
            this.ClientSize = new System.Drawing.Size(1107, 570);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDoktorGorus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnpdf);
            this.Controls.Add(this.dataGridViewdetay);
            this.Name = "MeetDetayForm";
            this.Text = "MeetDetayForm";
            this.Load += new System.EventHandler(this.MeetDetayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdetay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetDtoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDtoBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

         public DataGridView dataGridViewdetay;
        private BindingSource patientBindingSource;
        private BindingSource meetDtoBindingSource;
        private BindingSource categoryDtoBindingSource;
        private Button btnpdf;
        private BindingSource meetDtoBindingSource1;
        private Panel panel2;
        private Label label2;
        private TextBox txtDoktorSoyadı;
        private TextBox txtDoktorAdı;
        private Label label5;
        private Label label4;
        private Panel panel1;
        private Label label1;
        private Label label6;
        private Label label8;
        private TextBox txtHastaSoyadı;
        private TextBox txtHastaAdı;
        private TextBox txtDoktorGorus;
        private DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn doctorIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn DoctorName;
        private DataGridViewTextBoxColumn DoctorLastName;
        private DataGridViewTextBoxColumn patientIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn PatientName;
        private DataGridViewTextBoxColumn PatientLastName;
        private DataGridViewTextBoxColumn Describe;
        private Label label3;
    }
}