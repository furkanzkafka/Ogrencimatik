namespace WindowsFormsApplication2
{
    partial class deneme
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtdnmnara = new System.Windows.Forms.TextBox();
            this.txtdnmara = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtdnmogrno = new System.Windows.Forms.TextBox();
            this.txtdnmicrk = new System.Windows.Forms.TextBox();
            this.txtdnmsrsys = new System.Windows.Forms.TextBox();
            this.txtdnmdgr = new System.Windows.Forms.TextBox();
            this.txtdnmynls = new System.Windows.Forms.TextBox();
            this.txtdnmbs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btndnmekle = new System.Windows.Forms.Button();
            this.btndnmiptal = new System.Windows.Forms.Button();
            this.btndnmsil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(778, 233);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            // 
            // txtdnmnara
            // 
            this.txtdnmnara.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtdnmnara.Location = new System.Drawing.Point(10, 67);
            this.txtdnmnara.Multiline = true;
            this.txtdnmnara.Name = "txtdnmnara";
            this.txtdnmnara.Size = new System.Drawing.Size(39, 44);
            this.txtdnmnara.TabIndex = 1;
            this.txtdnmnara.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtdnmara
            // 
            this.txtdnmara.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtdnmara.Location = new System.Drawing.Point(55, 67);
            this.txtdnmara.Multiline = true;
            this.txtdnmara.Name = "txtdnmara";
            this.txtdnmara.Size = new System.Drawing.Size(261, 44);
            this.txtdnmara.TabIndex = 2;
            this.txtdnmara.TextChanged += new System.EventHandler(this.txdnmara_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(22, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "GERI DON";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtdnmara);
            this.groupBox1.Controls.Add(this.txtdnmnara);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 141);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deneme Bilgisi Listeleme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(153, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Isim";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btndnmiptal);
            this.groupBox2.Controls.Add(this.btndnmekle);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtdnmbs);
            this.groupBox2.Controls.Add(this.txtdnmynls);
            this.groupBox2.Controls.Add(this.txtdnmdgr);
            this.groupBox2.Controls.Add(this.txtdnmsrsys);
            this.groupBox2.Controls.Add(this.txtdnmicrk);
            this.groupBox2.Controls.Add(this.txtdnmogrno);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(381, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 220);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deneme Bilgisi Ekle";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtdnmogrno
            // 
            this.txtdnmogrno.Location = new System.Drawing.Point(100, 37);
            this.txtdnmogrno.Multiline = true;
            this.txtdnmogrno.Name = "txtdnmogrno";
            this.txtdnmogrno.Size = new System.Drawing.Size(100, 27);
            this.txtdnmogrno.TabIndex = 0;
            // 
            // txtdnmicrk
            // 
            this.txtdnmicrk.Location = new System.Drawing.Point(100, 81);
            this.txtdnmicrk.Multiline = true;
            this.txtdnmicrk.Name = "txtdnmicrk";
            this.txtdnmicrk.Size = new System.Drawing.Size(100, 27);
            this.txtdnmicrk.TabIndex = 1;
            // 
            // txtdnmsrsys
            // 
            this.txtdnmsrsys.Location = new System.Drawing.Point(100, 124);
            this.txtdnmsrsys.Multiline = true;
            this.txtdnmsrsys.Name = "txtdnmsrsys";
            this.txtdnmsrsys.Size = new System.Drawing.Size(100, 27);
            this.txtdnmsrsys.TabIndex = 2;
            // 
            // txtdnmdgr
            // 
            this.txtdnmdgr.Location = new System.Drawing.Point(305, 37);
            this.txtdnmdgr.Multiline = true;
            this.txtdnmdgr.Name = "txtdnmdgr";
            this.txtdnmdgr.Size = new System.Drawing.Size(100, 27);
            this.txtdnmdgr.TabIndex = 3;
            // 
            // txtdnmynls
            // 
            this.txtdnmynls.Location = new System.Drawing.Point(305, 81);
            this.txtdnmynls.Multiline = true;
            this.txtdnmynls.Name = "txtdnmynls";
            this.txtdnmynls.Size = new System.Drawing.Size(100, 26);
            this.txtdnmynls.TabIndex = 4;
            // 
            // txtdnmbs
            // 
            this.txtdnmbs.Location = new System.Drawing.Point(305, 124);
            this.txtdnmbs.Multiline = true;
            this.txtdnmbs.Name = "txtdnmbs";
            this.txtdnmbs.Size = new System.Drawing.Size(100, 26);
            this.txtdnmbs.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(5, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 40);
            this.label3.TabIndex = 6;
            this.label3.Text = "  Ogrenci\r\n Numarasi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(24, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Icerik";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(0, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Soru Sayisi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(234, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Dogru";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(234, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Yanlis";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(234, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Bos";
            // 
            // btndnmekle
            // 
            this.btndnmekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndnmekle.Location = new System.Drawing.Point(83, 171);
            this.btndnmekle.Name = "btndnmekle";
            this.btndnmekle.Size = new System.Drawing.Size(117, 36);
            this.btndnmekle.TabIndex = 12;
            this.btndnmekle.Text = "Ekle";
            this.btndnmekle.UseVisualStyleBackColor = true;
            this.btndnmekle.Click += new System.EventHandler(this.btndnmekle_Click);
            // 
            // btndnmiptal
            // 
            this.btndnmiptal.Location = new System.Drawing.Point(221, 171);
            this.btndnmiptal.Name = "btndnmiptal";
            this.btndnmiptal.Size = new System.Drawing.Size(117, 36);
            this.btndnmiptal.TabIndex = 13;
            this.btndnmiptal.Text = "Iptal";
            this.btndnmiptal.UseVisualStyleBackColor = true;
            this.btndnmiptal.Click += new System.EventHandler(this.btndnmiptal_Click);
            // 
            // btndnmsil
            // 
            this.btndnmsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndnmsil.ForeColor = System.Drawing.Color.Firebrick;
            this.btndnmsil.Location = new System.Drawing.Point(193, 428);
            this.btndnmsil.Name = "btndnmsil";
            this.btndnmsil.Size = new System.Drawing.Size(109, 58);
            this.btndnmsil.TabIndex = 6;
            this.btndnmsil.Text = "Deneme Sil";
            this.btndnmsil.UseVisualStyleBackColor = true;
            this.btndnmsil.Click += new System.EventHandler(this.button2_Click);
            // 
            // deneme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 528);
            this.Controls.Add(this.btndnmsil);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "deneme";
            this.Text = "deneme";
            this.Load += new System.EventHandler(this.deneme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtdnmnara;
        private System.Windows.Forms.TextBox txtdnmara;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btndnmiptal;
        private System.Windows.Forms.Button btndnmekle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdnmbs;
        private System.Windows.Forms.TextBox txtdnmynls;
        private System.Windows.Forms.TextBox txtdnmdgr;
        private System.Windows.Forms.TextBox txtdnmsrsys;
        private System.Windows.Forms.TextBox txtdnmicrk;
        private System.Windows.Forms.TextBox txtdnmogrno;
        private System.Windows.Forms.Button btndnmsil;
    }
}