namespace WinForms
{
    partial class DoctorLogin
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.apointmentDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnGörüşmeyiKaydet = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btnGorusmeDetay = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apointmentDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.MediumBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(76, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "doktorGiriş";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 27);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(76, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 27);
            this.textBox2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(301, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(744, 410);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // apointmentDtoBindingSource
            // 
            this.apointmentDtoBindingSource.DataSource = typeof(EntityLayer.Concrete.ApointmentDto);
            // 
            // categoryDtoBindingSource
            // 
            this.categoryDtoBindingSource.DataSource = typeof(EntityLayer.Concrete.CategoryDto);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(76, 348);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(217, 101);
            this.textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(76, 271);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(169, 27);
            this.textBox3.TabIndex = 0;
            // 
            // btnGörüşmeyiKaydet
            // 
            this.btnGörüşmeyiKaydet.BackColor = System.Drawing.Color.MediumBlue;
            this.btnGörüşmeyiKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGörüşmeyiKaydet.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGörüşmeyiKaydet.Location = new System.Drawing.Point(76, 455);
            this.btnGörüşmeyiKaydet.Name = "btnGörüşmeyiKaydet";
            this.btnGörüşmeyiKaydet.Size = new System.Drawing.Size(217, 33);
            this.btnGörüşmeyiKaydet.TabIndex = 6;
            this.btnGörüşmeyiKaydet.Text = "Görüşmeyi Kaydet";
            this.btnGörüşmeyiKaydet.UseVisualStyleBackColor = false;
            this.btnGörüşmeyiKaydet.Click += new System.EventHandler(this.btnGörüşmeyiKaydet_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(76, 304);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(169, 27);
            this.textBox5.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(76, 238);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(169, 27);
            this.textBox6.TabIndex = 0;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(76, 62);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(169, 27);
            this.textBox7.TabIndex = 1;
            // 
            // btnGorusmeDetay
            // 
            this.btnGorusmeDetay.BackColor = System.Drawing.Color.MediumBlue;
            this.btnGorusmeDetay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGorusmeDetay.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGorusmeDetay.Location = new System.Drawing.Point(76, 505);
            this.btnGorusmeDetay.Name = "btnGorusmeDetay";
            this.btnGorusmeDetay.Size = new System.Drawing.Size(217, 33);
            this.btnGorusmeDetay.TabIndex = 8;
            this.btnGorusmeDetay.Text = "Görüşme Detay";
            this.btnGorusmeDetay.UseVisualStyleBackColor = false;
            this.btnGorusmeDetay.Click += new System.EventHandler(this.btnGorusmeDetay_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Şifre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Soyadı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Adı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Görüş";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(481, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(367, 38);
            this.label8.TabIndex = 23;
            this.label8.Text = "Doktor Giriş Randevu Bölüm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(91, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 28);
            this.label9.TabIndex = 24;
            this.label9.Text = "Doktor Giriş ";
            // 
            // DoctorLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::WinForms.Properties.Resources.indir1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 542);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGorusmeDetay);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.btnGörüşmeyiKaydet);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "DoctorLogin";
            this.Text = "main";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apointmentDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private TextBox textBox4;
        private TextBox textBox3;
        private Button btnGörüşmeyiKaydet;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button btnGorusmeDetay;
        private BindingSource categoryDtoBindingSource;
        private BindingSource apointmentDtoBindingSource;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}