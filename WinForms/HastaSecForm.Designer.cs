namespace WinForms
{
    partial class HastaSecForm
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
            this.btnSeç = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.txtHastaAra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(64, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(844, 310);
            this.dataGridView1.TabIndex = 0;
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
            // btnSeç
            // 
            this.btnSeç.BackColor = System.Drawing.Color.MediumBlue;
            this.btnSeç.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeç.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSeç.Location = new System.Drawing.Point(280, 459);
            this.btnSeç.Name = "btnSeç";
            this.btnSeç.Size = new System.Drawing.Size(131, 29);
            this.btnSeç.TabIndex = 1;
            this.btnSeç.Text = "Seç";
            this.btnSeç.UseVisualStyleBackColor = false;
            this.btnSeç.Click += new System.EventHandler(this.btnSeç_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.BackColor = System.Drawing.Color.MediumBlue;
            this.btnİptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnİptal.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnİptal.Location = new System.Drawing.Point(446, 459);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(131, 29);
            this.btnİptal.TabIndex = 2;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = false;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // txtHastaAra
            // 
            this.txtHastaAra.Location = new System.Drawing.Point(193, 89);
            this.txtHastaAra.Name = "txtHastaAra";
            this.txtHastaAra.Size = new System.Drawing.Size(207, 27);
            this.txtHastaAra.TabIndex = 18;
            this.txtHastaAra.Text = "Hasta Ara";
            this.txtHastaAra.TextChanged += new System.EventHandler(this.txtHastaAra_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Hasta Ara";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(342, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 38);
            this.label1.TabIndex = 19;
            this.label1.Text = "Hasta Seçme Bölüm";
            // 
            // HastaSecForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::WinForms.Properties.Resources.indir__2_;
            this.ClientSize = new System.Drawing.Size(990, 526);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHastaAra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnSeç);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HastaSecForm";
            this.Text = "HastaSecForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnSeç;
        private Button btnİptal;
        private DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apointmentsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn meetsDataGridViewTextBoxColumn;
        private BindingSource patientBindingSource;
        private TextBox txtHastaAra;
        private Label label5;
        private Label label1;
    }
}