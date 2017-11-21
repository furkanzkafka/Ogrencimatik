namespace WindowsFormsApplication2
{
    partial class email
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmailad = new System.Windows.Forms.TextBox();
            this.txtmailemail = new System.Windows.Forms.TextBox();
            this.txtmailkonu = new System.Windows.Forms.TextBox();
            this.rtxtmailmsj = new System.Windows.Forms.RichTextBox();
            this.btnmailgndr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(126, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veli Bilgilendirme E-Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(169, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(185, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(189, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Konu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(189, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mesaj";
            // 
            // txtmailad
            // 
            this.txtmailad.Location = new System.Drawing.Point(299, 100);
            this.txtmailad.Name = "txtmailad";
            this.txtmailad.Size = new System.Drawing.Size(200, 20);
            this.txtmailad.TabIndex = 5;
            // 
            // txtmailemail
            // 
            this.txtmailemail.Location = new System.Drawing.Point(299, 127);
            this.txtmailemail.Name = "txtmailemail";
            this.txtmailemail.Size = new System.Drawing.Size(200, 20);
            this.txtmailemail.TabIndex = 6;
            // 
            // txtmailkonu
            // 
            this.txtmailkonu.Location = new System.Drawing.Point(299, 153);
            this.txtmailkonu.Name = "txtmailkonu";
            this.txtmailkonu.Size = new System.Drawing.Size(200, 20);
            this.txtmailkonu.TabIndex = 7;
            // 
            // rtxtmailmsj
            // 
            this.rtxtmailmsj.Location = new System.Drawing.Point(299, 197);
            this.rtxtmailmsj.Name = "rtxtmailmsj";
            this.rtxtmailmsj.Size = new System.Drawing.Size(200, 118);
            this.rtxtmailmsj.TabIndex = 8;
            this.rtxtmailmsj.Text = "";
            // 
            // btnmailgndr
            // 
            this.btnmailgndr.Location = new System.Drawing.Point(275, 345);
            this.btnmailgndr.Name = "btnmailgndr";
            this.btnmailgndr.Size = new System.Drawing.Size(190, 40);
            this.btnmailgndr.TabIndex = 9;
            this.btnmailgndr.Text = "GONDER";
            this.btnmailgndr.UseVisualStyleBackColor = true;
            this.btnmailgndr.Click += new System.EventHandler(this.button1_Click);
            // 
            // email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 436);
            this.Controls.Add(this.btnmailgndr);
            this.Controls.Add(this.rtxtmailmsj);
            this.Controls.Add(this.txtmailkonu);
            this.Controls.Add(this.txtmailemail);
            this.Controls.Add(this.txtmailad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "email";
            this.Text = "email";
            this.Load += new System.EventHandler(this.email_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmailad;
        private System.Windows.Forms.TextBox txtmailemail;
        private System.Windows.Forms.TextBox txtmailkonu;
        private System.Windows.Forms.RichTextBox rtxtmailmsj;
        private System.Windows.Forms.Button btnmailgndr;
    }
}