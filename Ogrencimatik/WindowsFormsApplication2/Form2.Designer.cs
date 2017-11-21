namespace WindowsFormsApplication2
{
    partial class Form2
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
            this.lblislm = new System.Windows.Forms.Label();
            this.btnogrekle = new System.Windows.Forms.Button();
            this.btnogrlst = new System.Windows.Forms.Button();
            this.btndeneme = new System.Windows.Forms.Button();
            this.btndvmszlk = new System.Windows.Forms.Button();
            this.btnposta = new System.Windows.Forms.Button();
            this.btnucret = new System.Windows.Forms.Button();
            this.btncks2 = new System.Windows.Forms.Button();
            this.btnyedek = new System.Windows.Forms.Button();
            this.btnkonu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblislm
            // 
            this.lblislm.AutoSize = true;
            this.lblislm.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblislm.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblislm.Location = new System.Drawing.Point(233, 9);
            this.lblislm.Name = "lblislm";
            this.lblislm.Size = new System.Drawing.Size(427, 63);
            this.lblislm.TabIndex = 0;
            this.lblislm.Text = "Islem Penceresi";
            // 
            // btnogrekle
            // 
            this.btnogrekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnogrekle.Location = new System.Drawing.Point(32, 110);
            this.btnogrekle.Name = "btnogrekle";
            this.btnogrekle.Size = new System.Drawing.Size(108, 67);
            this.btnogrekle.TabIndex = 1;
            this.btnogrekle.Text = "Ogrenci Kayit";
            this.btnogrekle.UseVisualStyleBackColor = true;
            this.btnogrekle.Click += new System.EventHandler(this.btnogrekle_Click);
            // 
            // btnogrlst
            // 
            this.btnogrlst.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnogrlst.Location = new System.Drawing.Point(32, 194);
            this.btnogrlst.Name = "btnogrlst";
            this.btnogrlst.Size = new System.Drawing.Size(108, 67);
            this.btnogrlst.TabIndex = 2;
            this.btnogrlst.Text = "Ogrenci Listele";
            this.btnogrlst.UseVisualStyleBackColor = true;
            this.btnogrlst.Click += new System.EventHandler(this.btnogrlst_Click);
            // 
            // btndeneme
            // 
            this.btndeneme.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndeneme.Location = new System.Drawing.Point(230, 194);
            this.btndeneme.Name = "btndeneme";
            this.btndeneme.Size = new System.Drawing.Size(115, 67);
            this.btndeneme.TabIndex = 4;
            this.btndeneme.Text = "Deneme Bilgileri";
            this.btndeneme.UseVisualStyleBackColor = true;
            this.btndeneme.Click += new System.EventHandler(this.btndeneme_Click);
            // 
            // btndvmszlk
            // 
            this.btndvmszlk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndvmszlk.Location = new System.Drawing.Point(428, 112);
            this.btndvmszlk.Name = "btndvmszlk";
            this.btndvmszlk.Size = new System.Drawing.Size(115, 65);
            this.btndvmszlk.TabIndex = 6;
            this.btndvmszlk.Text = "Devamsizlik";
            this.btndvmszlk.UseVisualStyleBackColor = true;
            this.btndvmszlk.Click += new System.EventHandler(this.btndvmszlk_Click);
            // 
            // btnposta
            // 
            this.btnposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnposta.Location = new System.Drawing.Point(603, 110);
            this.btnposta.Name = "btnposta";
            this.btnposta.Size = new System.Drawing.Size(103, 67);
            this.btnposta.TabIndex = 7;
            this.btnposta.Text = "Eposta - Sms";
            this.btnposta.UseVisualStyleBackColor = true;
            this.btnposta.Click += new System.EventHandler(this.btnposta_Click);
            // 
            // btnucret
            // 
            this.btnucret.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnucret.Location = new System.Drawing.Point(428, 194);
            this.btnucret.Name = "btnucret";
            this.btnucret.Size = new System.Drawing.Size(115, 67);
            this.btnucret.TabIndex = 8;
            this.btnucret.Text = "Ucret Durumu";
            this.btnucret.UseVisualStyleBackColor = true;
            // 
            // btncks2
            // 
            this.btncks2.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btncks2.FlatAppearance.BorderSize = 2;
            this.btncks2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncks2.ForeColor = System.Drawing.Color.Firebrick;
            this.btncks2.Location = new System.Drawing.Point(23, 20);
            this.btncks2.Name = "btncks2";
            this.btncks2.Size = new System.Drawing.Size(90, 50);
            this.btncks2.TabIndex = 9;
            this.btncks2.Text = "GUVENLI CIKIS";
            this.btncks2.UseVisualStyleBackColor = true;
            this.btncks2.Click += new System.EventHandler(this.btncks2_Click);
            // 
            // btnyedek
            // 
            this.btnyedek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyedek.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnyedek.Location = new System.Drawing.Point(603, 194);
            this.btnyedek.Name = "btnyedek";
            this.btnyedek.Size = new System.Drawing.Size(103, 67);
            this.btnyedek.TabIndex = 10;
            this.btnyedek.Text = "VERI YEDEKLEME";
            this.btnyedek.UseVisualStyleBackColor = true;
            this.btnyedek.Click += new System.EventHandler(this.btnyedek_Click);
            // 
            // btnkonu
            // 
            this.btnkonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkonu.Location = new System.Drawing.Point(230, 112);
            this.btnkonu.Name = "btnkonu";
            this.btnkonu.Size = new System.Drawing.Size(115, 65);
            this.btnkonu.TabIndex = 11;
            this.btnkonu.Text = "Konu Ilerlemesi";
            this.btnkonu.UseVisualStyleBackColor = true;
            this.btnkonu.Click += new System.EventHandler(this.btnkonu_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 325);
            this.Controls.Add(this.btnkonu);
            this.Controls.Add(this.btnyedek);
            this.Controls.Add(this.btncks2);
            this.Controls.Add(this.btnucret);
            this.Controls.Add(this.btnposta);
            this.Controls.Add(this.btndvmszlk);
            this.Controls.Add(this.btndeneme);
            this.Controls.Add(this.btnogrlst);
            this.Controls.Add(this.btnogrekle);
            this.Controls.Add(this.lblislm);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblislm;
        private System.Windows.Forms.Button btnogrekle;
        private System.Windows.Forms.Button btnogrlst;
        private System.Windows.Forms.Button btndeneme;
        private System.Windows.Forms.Button btndvmszlk;
        private System.Windows.Forms.Button btnposta;
        private System.Windows.Forms.Button btnucret;
        private System.Windows.Forms.Button btncks2;
        private System.Windows.Forms.Button btnyedek;
        private System.Windows.Forms.Button btnkonu;
    }
}