namespace WindowsFormsApplication2
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
            this.LblUyeGirisi = new System.Windows.Forms.Label();
            this.LblKullaniciAdi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnGiris = new System.Windows.Forms.Button();
            this.BtnIptl = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnsfrgstr = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblUyeGirisi
            // 
            this.LblUyeGirisi.AutoSize = true;
            this.LblUyeGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblUyeGirisi.ForeColor = System.Drawing.Color.Crimson;
            this.LblUyeGirisi.Location = new System.Drawing.Point(71, 19);
            this.LblUyeGirisi.Name = "LblUyeGirisi";
            this.LblUyeGirisi.Size = new System.Drawing.Size(366, 55);
            this.LblUyeGirisi.TabIndex = 0;
            this.LblUyeGirisi.Text = "Uye Giris Paneli";
            this.LblUyeGirisi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblUyeGirisi.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblKullaniciAdi
            // 
            this.LblKullaniciAdi.AutoSize = true;
            this.LblKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKullaniciAdi.Location = new System.Drawing.Point(96, 121);
            this.LblKullaniciAdi.Name = "LblKullaniciAdi";
            this.LblKullaniciAdi.Size = new System.Drawing.Size(161, 31);
            this.LblKullaniciAdi.TabIndex = 1;
            this.LblKullaniciAdi.Text = "Kullanici Adi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(150, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sifre";
            // 
            // BtnGiris
            // 
            this.BtnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGiris.Location = new System.Drawing.Point(155, 214);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(135, 42);
            this.BtnGiris.TabIndex = 8;
            this.BtnGiris.Text = "Giris";
            this.BtnGiris.UseVisualStyleBackColor = true;
            this.BtnGiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnIptl
            // 
            this.BtnIptl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnIptl.Location = new System.Drawing.Point(302, 214);
            this.BtnIptl.Name = "BtnIptl";
            this.BtnIptl.Size = new System.Drawing.Size(135, 42);
            this.BtnIptl.TabIndex = 9;
            this.BtnIptl.Text = "Iptal";
            this.BtnIptl.UseVisualStyleBackColor = true;
            this.BtnIptl.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.ForeColor = System.Drawing.Color.Crimson;
            this.button3.Location = new System.Drawing.Point(12, 304);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 54);
            this.button3.TabIndex = 10;
            this.button3.Text = "GUVENLI CIKIS";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnsfrgstr
            // 
            this.btnsfrgstr.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.btnsfrgstr.BackColor = System.Drawing.Color.Transparent;
            this.btnsfrgstr.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.locker;
            this.btnsfrgstr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsfrgstr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsfrgstr.FlatAppearance.BorderSize = 0;
            this.btnsfrgstr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsfrgstr.ForeColor = System.Drawing.Color.Transparent;
            this.btnsfrgstr.Location = new System.Drawing.Point(472, 152);
            this.btnsfrgstr.Name = "btnsfrgstr";
            this.btnsfrgstr.Size = new System.Drawing.Size(37, 54);
            this.btnsfrgstr.TabIndex = 12;
            this.btnsfrgstr.UseVisualStyleBackColor = false;
            this.btnsfrgstr.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.logo;
            this.pictureBox1.InitialImage = global::WindowsFormsApplication2.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(526, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // txtAd
            // 
            this.txtAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(263, 121);
            this.txtAd.MaxLength = 16;
            this.txtAd.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(192, 30);
            this.txtAd.TabIndex = 1;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // txtSifre
            // 
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(264, 161);
            this.txtSifre.MaxLength = 16;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(192, 28);
            this.txtSifre.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 382);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.btnsfrgstr);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnIptl);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblKullaniciAdi);
            this.Controls.Add(this.LblUyeGirisi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUyeGirisi;
        private System.Windows.Forms.Label LblKullaniciAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnGiris;
        private System.Windows.Forms.Button BtnIptl;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnsfrgstr;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSifre;
    }
}

