namespace WinForms
{
    partial class MainForm
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
            this.pictureBoxSekreter = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxDoktorGiriş = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSekreter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoktorGiriş)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSekreter
            // 
            this.pictureBoxSekreter.Image = global::WinForms.Properties.Resources._1995606;
            this.pictureBoxSekreter.Location = new System.Drawing.Point(166, 208);
            this.pictureBoxSekreter.Name = "pictureBoxSekreter";
            this.pictureBoxSekreter.Size = new System.Drawing.Size(158, 136);
            this.pictureBoxSekreter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSekreter.TabIndex = 0;
            this.pictureBoxSekreter.TabStop = false;
            this.pictureBoxSekreter.Click += new System.EventHandler(this.pictureBoxSekreter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sekreter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Doktor";
            // 
            // pictureBoxDoktorGiriş
            // 
            this.pictureBoxDoktorGiriş.Image = global::WinForms.Properties.Resources.d29869ee820d8b3f8c2518830bced789;
            this.pictureBoxDoktorGiriş.Location = new System.Drawing.Point(411, 208);
            this.pictureBoxDoktorGiriş.Name = "pictureBoxDoktorGiriş";
            this.pictureBoxDoktorGiriş.Size = new System.Drawing.Size(180, 136);
            this.pictureBoxDoktorGiriş.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDoktorGiriş.TabIndex = 2;
            this.pictureBoxDoktorGiriş.TabStop = false;
            this.pictureBoxDoktorGiriş.Click += new System.EventHandler(this.pictureBoxDoktorGiriş_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::WinForms.Properties.Resources.medicine_wallpaper_art_12647_03;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1001, 525);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxDoktorGiriş);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxSekreter);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSekreter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoktorGiriş)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBoxSekreter;
        private Label label1;
        private Label label2;
        private PictureBox pictureBoxDoktorGiriş;
    }
}