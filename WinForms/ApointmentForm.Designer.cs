namespace WinForms
{
    partial class ApointmentForm
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
            this.btnSekreterler = new System.Windows.Forms.Button();
            this.btnDoktorlar = new System.Windows.Forms.Button();
            this.btnHastalar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHastaId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHastaMail = new System.Windows.Forms.TextBox();
            this.txtHastaNumara = new System.Windows.Forms.TextBox();
            this.txtHastaSoyadi = new System.Windows.Forms.TextBox();
            this.txtHastaAdi = new System.Windows.Forms.TextBox();
            this.btnSec = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apointmentDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRandevuAl = new System.Windows.Forms.Button();
            this.btnRandevuSil = new System.Windows.Forms.Button();
            this.btnRandevuGuncelle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textSaat = new System.Windows.Forms.TextBox();
            this.dateTimeGün = new System.Windows.Forms.DateTimePicker();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apointmentDtoBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSekreterler
            // 
            this.btnSekreterler.BackColor = System.Drawing.Color.MediumBlue;
            this.btnSekreterler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSekreterler.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSekreterler.Location = new System.Drawing.Point(26, 62);
            this.btnSekreterler.Name = "btnSekreterler";
            this.btnSekreterler.Size = new System.Drawing.Size(101, 37);
            this.btnSekreterler.TabIndex = 0;
            this.btnSekreterler.Text = "Sekreterler";
            this.btnSekreterler.UseVisualStyleBackColor = false;
            this.btnSekreterler.Click += new System.EventHandler(this.btnSekreterler_Click);
            // 
            // btnDoktorlar
            // 
            this.btnDoktorlar.BackColor = System.Drawing.Color.MediumBlue;
            this.btnDoktorlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoktorlar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDoktorlar.Location = new System.Drawing.Point(136, 62);
            this.btnDoktorlar.Name = "btnDoktorlar";
            this.btnDoktorlar.Size = new System.Drawing.Size(101, 37);
            this.btnDoktorlar.TabIndex = 1;
            this.btnDoktorlar.Text = "Doktorlar";
            this.btnDoktorlar.UseVisualStyleBackColor = false;
            this.btnDoktorlar.Click += new System.EventHandler(this.btnDoktorlar_Click);
            // 
            // btnHastalar
            // 
            this.btnHastalar.BackColor = System.Drawing.Color.MediumBlue;
            this.btnHastalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHastalar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHastalar.Location = new System.Drawing.Point(243, 62);
            this.btnHastalar.Name = "btnHastalar";
            this.btnHastalar.Size = new System.Drawing.Size(101, 37);
            this.btnHastalar.TabIndex = 2;
            this.btnHastalar.Text = "Hastalar";
            this.btnHastalar.UseVisualStyleBackColor = false;
            this.btnHastalar.Click += new System.EventHandler(this.btnHastalar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtHastaId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtHastaMail);
            this.panel1.Controls.Add(this.txtHastaNumara);
            this.panel1.Controls.Add(this.txtHastaSoyadi);
            this.panel1.Controls.Add(this.txtHastaAdi);
            this.panel1.Location = new System.Drawing.Point(26, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 299);
            this.panel1.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Numara";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Soyadı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Id";
            // 
            // txtHastaId
            // 
            this.txtHastaId.Location = new System.Drawing.Point(87, 70);
            this.txtHastaId.Name = "txtHastaId";
            this.txtHastaId.Size = new System.Drawing.Size(167, 27);
            this.txtHastaId.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Hasta Bilgileri";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtHastaMail
            // 
            this.txtHastaMail.Location = new System.Drawing.Point(87, 243);
            this.txtHastaMail.Name = "txtHastaMail";
            this.txtHastaMail.Size = new System.Drawing.Size(167, 27);
            this.txtHastaMail.TabIndex = 11;
            // 
            // txtHastaNumara
            // 
            this.txtHastaNumara.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHastaNumara.Location = new System.Drawing.Point(87, 201);
            this.txtHastaNumara.Name = "txtHastaNumara";
            this.txtHastaNumara.Size = new System.Drawing.Size(167, 27);
            this.txtHastaNumara.TabIndex = 10;
            // 
            // txtHastaSoyadi
            // 
            this.txtHastaSoyadi.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHastaSoyadi.Location = new System.Drawing.Point(87, 158);
            this.txtHastaSoyadi.Name = "txtHastaSoyadi";
            this.txtHastaSoyadi.Size = new System.Drawing.Size(167, 27);
            this.txtHastaSoyadi.TabIndex = 9;
            this.txtHastaSoyadi.TextChanged += new System.EventHandler(this.txtHastaSoyadi_TextChanged);
            // 
            // txtHastaAdi
            // 
            this.txtHastaAdi.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHastaAdi.Location = new System.Drawing.Point(87, 115);
            this.txtHastaAdi.Name = "txtHastaAdi";
            this.txtHastaAdi.Size = new System.Drawing.Size(167, 27);
            this.txtHastaAdi.TabIndex = 8;
            // 
            // btnSec
            // 
            this.btnSec.BackColor = System.Drawing.Color.MediumBlue;
            this.btnSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSec.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnSec.Location = new System.Drawing.Point(70, 441);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(176, 37);
            this.btnSec.TabIndex = 6;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = false;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.doctorNameDataGridViewTextBoxColumn,
            this.patientNameDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.hourDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.apointmentDtoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(381, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(648, 201);
            this.dataGridView1.TabIndex = 0;
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
            // doctorNameDataGridViewTextBoxColumn
            // 
            this.doctorNameDataGridViewTextBoxColumn.DataPropertyName = "DoctorName";
            this.doctorNameDataGridViewTextBoxColumn.HeaderText = "DoctorName";
            this.doctorNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorNameDataGridViewTextBoxColumn.Name = "doctorNameDataGridViewTextBoxColumn";
            this.doctorNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // patientNameDataGridViewTextBoxColumn
            // 
            this.patientNameDataGridViewTextBoxColumn.DataPropertyName = "PatientName";
            this.patientNameDataGridViewTextBoxColumn.HeaderText = "PatientName";
            this.patientNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientNameDataGridViewTextBoxColumn.Name = "patientNameDataGridViewTextBoxColumn";
            this.patientNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.Width = 125;
            // 
            // hourDataGridViewTextBoxColumn
            // 
            this.hourDataGridViewTextBoxColumn.DataPropertyName = "Hour";
            this.hourDataGridViewTextBoxColumn.HeaderText = "Hour";
            this.hourDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hourDataGridViewTextBoxColumn.Name = "hourDataGridViewTextBoxColumn";
            this.hourDataGridViewTextBoxColumn.Width = 125;
            // 
            // apointmentDtoBindingSource
            // 
            this.apointmentDtoBindingSource.DataSource = typeof(EntityLayer.Concrete.ApointmentDto);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRandevuAl);
            this.panel3.Controls.Add(this.btnRandevuSil);
            this.panel3.Controls.Add(this.btnRandevuGuncelle);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button16);
            this.panel3.Controls.Add(this.button15);
            this.panel3.Controls.Add(this.button14);
            this.panel3.Controls.Add(this.button21);
            this.panel3.Controls.Add(this.button20);
            this.panel3.Controls.Add(this.button19);
            this.panel3.Controls.Add(this.button17);
            this.panel3.Controls.Add(this.button13);
            this.panel3.Controls.Add(this.button12);
            this.panel3.Controls.Add(this.button11);
            this.panel3.Controls.Add(this.button10);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.textSaat);
            this.panel3.Controls.Add(this.dateTimeGün);
            this.panel3.Controls.Add(this.cmbDoctor);
            this.panel3.Controls.Add(this.cmbCategory);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(381, 281);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(648, 291);
            this.panel3.TabIndex = 8;
            // 
            // btnRandevuAl
            // 
            this.btnRandevuAl.BackColor = System.Drawing.Color.MediumBlue;
            this.btnRandevuAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandevuAl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRandevuAl.Location = new System.Drawing.Point(42, 241);
            this.btnRandevuAl.Name = "btnRandevuAl";
            this.btnRandevuAl.Size = new System.Drawing.Size(176, 29);
            this.btnRandevuAl.TabIndex = 12;
            this.btnRandevuAl.Text = "Randevu Al";
            this.btnRandevuAl.UseVisualStyleBackColor = false;
            this.btnRandevuAl.Click += new System.EventHandler(this.btnRandevuAl_Click);
            // 
            // btnRandevuSil
            // 
            this.btnRandevuSil.BackColor = System.Drawing.Color.MediumBlue;
            this.btnRandevuSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandevuSil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRandevuSil.Location = new System.Drawing.Point(437, 241);
            this.btnRandevuSil.Name = "btnRandevuSil";
            this.btnRandevuSil.Size = new System.Drawing.Size(176, 29);
            this.btnRandevuSil.TabIndex = 11;
            this.btnRandevuSil.Text = "Randevu Sil";
            this.btnRandevuSil.UseVisualStyleBackColor = false;
            this.btnRandevuSil.Click += new System.EventHandler(this.btnRandevuSil_Click);
            // 
            // btnRandevuGuncelle
            // 
            this.btnRandevuGuncelle.BackColor = System.Drawing.Color.MediumBlue;
            this.btnRandevuGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandevuGuncelle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRandevuGuncelle.Location = new System.Drawing.Point(235, 241);
            this.btnRandevuGuncelle.Name = "btnRandevuGuncelle";
            this.btnRandevuGuncelle.Size = new System.Drawing.Size(176, 29);
            this.btnRandevuGuncelle.TabIndex = 10;
            this.btnRandevuGuncelle.Text = "Randevu Güncelle";
            this.btnRandevuGuncelle.UseVisualStyleBackColor = false;
            this.btnRandevuGuncelle.Click += new System.EventHandler(this.btnRandevuGuncelle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Randevu saatini üzerine tıklayıp seçebilirsiniz.";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(316, 39);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 35);
            this.button9.TabIndex = 4;
            this.button9.Text = "10:20";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.BaglaTexte);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(235, 162);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 35);
            this.button8.TabIndex = 4;
            this.button8.Text = "14:40";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.BaglaTexte);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(235, 121);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 35);
            this.button7.TabIndex = 4;
            this.button7.Text = "13:20";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.BaglaTexte);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(235, 80);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 35);
            this.button6.TabIndex = 4;
            this.button6.Text = "11:20";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.BaglaTexte);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(398, 162);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 35);
            this.button16.TabIndex = 4;
            this.button16.Text = "15.20";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.BaglaTexte);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(398, 121);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 35);
            this.button15.TabIndex = 4;
            this.button15.Text = "14:00";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.BaglaTexte);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(397, 80);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 35);
            this.button14.TabIndex = 4;
            this.button14.Text = "12:00";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.BaglaTexte);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(478, 162);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 35);
            this.button21.TabIndex = 4;
            this.button21.Text = "15:40";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.BaglaTexte);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(478, 121);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 35);
            this.button20.TabIndex = 4;
            this.button20.Text = "14:20";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.BaglaTexte);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(478, 80);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 35);
            this.button19.TabIndex = 4;
            this.button19.Text = "13:00";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.BaglaTexte);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(478, 39);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 35);
            this.button17.TabIndex = 4;
            this.button17.Text = "11:00";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.BaglaTexte);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(397, 39);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 35);
            this.button13.TabIndex = 4;
            this.button13.Text = "10:40";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.BaglaTexte);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(316, 162);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 35);
            this.button12.TabIndex = 4;
            this.button12.Text = "15:00";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.BaglaTexte);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(317, 121);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 35);
            this.button11.TabIndex = 4;
            this.button11.Text = "13:40";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.BaglaTexte);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(316, 80);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 35);
            this.button10.TabIndex = 4;
            this.button10.Text = "11:40";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.BaglaTexte);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(235, 39);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 35);
            this.button5.TabIndex = 4;
            this.button5.Text = "10:00";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.BaglaTexte);
            // 
            // textSaat
            // 
            this.textSaat.Location = new System.Drawing.Point(57, 191);
            this.textSaat.Name = "textSaat";
            this.textSaat.Size = new System.Drawing.Size(146, 27);
            this.textSaat.TabIndex = 3;
            // 
            // dateTimeGün
            // 
            this.dateTimeGün.Location = new System.Drawing.Point(57, 143);
            this.dateTimeGün.Name = "dateTimeGün";
            this.dateTimeGün.Size = new System.Drawing.Size(146, 27);
            this.dateTimeGün.TabIndex = 2;
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.DisplayMember = "Name";
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(57, 92);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(146, 28);
            this.cmbDoctor.TabIndex = 1;
            this.cmbDoctor.ValueMember = "Id";
            this.cmbDoctor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbDoctor_MouseClick);
            // 
            // cmbCategory
            // 
            this.cmbCategory.DisplayMember = "Name";
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(57, 39);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(146, 28);
            this.cmbCategory.TabIndex = 1;
            this.cmbCategory.ValueMember = "Id";
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            this.cmbCategory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbCategory_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Randevu Alma İşlemi";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(EntityLayer.Concrete.Category);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(617, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Randevu Listesi";
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataSource = typeof(EntityLayer.Concrete.Doctor);
            // 
            // ApointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1054, 581);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnHastalar);
            this.Controls.Add(this.btnDoktorlar);
            this.Controls.Add(this.btnSekreterler);
            this.MaximumSize = new System.Drawing.Size(1072, 641);
            this.Name = "ApointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ApointmentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apointmentDtoBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSekreterler;
        private Button btnDoktorlar;
        private Button btnHastalar;
        private Panel panel1;
        private Label label1;
        private TextBox txtHastaMail;
        private TextBox txtHastaNumara;
        private TextBox txtHastaSoyadi;
        private TextBox txtHastaAdi;
        private Button btnSec;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Button btnRandevuAl;
        private Button btnRandevuSil;
        private Button btnRandevuGuncelle;
        private Label label4;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button16;
        private Button button15;
        private Button button14;
        private Button button21;
        private Button button20;
        private Button button19;
        private Button button17;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button5;
        private TextBox textSaat;
        private DateTimePicker dateTimeGün;
        private ComboBox cmbDoctor;
        private ComboBox cmbCategory;
        private Label label2;
        private Label label3;
        private BindingSource doctorBindingSource;
        private BindingSource categoryBindingSource;
        private TextBox txtHastaId;
        private DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn doctorNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn patientNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hourDataGridViewTextBoxColumn;
        private BindingSource apointmentDtoBindingSource;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
    }
}