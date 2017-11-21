namespace WindowsFormsApplication2
{
    partial class konuilerleme
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
            this.txtkonunara = new System.Windows.Forms.TextBox();
            this.txtkonuara = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtknogrno = new System.Windows.Forms.TextBox();
            this.txtknders = new System.Windows.Forms.TextBox();
            this.txtknkn = new System.Windows.Forms.TextBox();
            this.txtknsrsy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btmkonuekle = new System.Windows.Forms.Button();
            this.btnkonuiptal = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(799, 227);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtkonunara
            // 
            this.txtkonunara.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkonunara.Location = new System.Drawing.Point(21, 57);
            this.txtkonunara.Multiline = true;
            this.txtkonunara.Name = "txtkonunara";
            this.txtkonunara.Size = new System.Drawing.Size(81, 52);
            this.txtkonunara.TabIndex = 1;
            this.txtkonunara.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtkonuara
            // 
            this.txtkonuara.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkonuara.Location = new System.Drawing.Point(105, 57);
            this.txtkonuara.Multiline = true;
            this.txtkonuara.Name = "txtkonuara";
            this.txtkonuara.Size = new System.Drawing.Size(293, 52);
            this.txtkonuara.TabIndex = 2;
            this.txtkonuara.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtkonuara);
            this.groupBox1.Controls.Add(this.txtkonunara);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 133);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Konu Bilgisi Listeleme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(230, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Isim";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnkonuiptal);
            this.groupBox2.Controls.Add(this.btmkonuekle);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtknsrsy);
            this.groupBox2.Controls.Add(this.txtknkn);
            this.groupBox2.Controls.Add(this.txtknders);
            this.groupBox2.Controls.Add(this.txtknogrno);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(452, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 249);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Konu Bilgisi Ekleme";
            // 
            // txtknogrno
            // 
            this.txtknogrno.Location = new System.Drawing.Point(170, 31);
            this.txtknogrno.Name = "txtknogrno";
            this.txtknogrno.Size = new System.Drawing.Size(171, 32);
            this.txtknogrno.TabIndex = 0;
            // 
            // txtknders
            // 
            this.txtknders.Location = new System.Drawing.Point(170, 69);
            this.txtknders.Name = "txtknders";
            this.txtknders.Size = new System.Drawing.Size(171, 32);
            this.txtknders.TabIndex = 1;
            // 
            // txtknkn
            // 
            this.txtknkn.Location = new System.Drawing.Point(170, 107);
            this.txtknkn.Name = "txtknkn";
            this.txtknkn.Size = new System.Drawing.Size(171, 32);
            this.txtknkn.TabIndex = 2;
            // 
            // txtknsrsy
            // 
            this.txtknsrsy.Location = new System.Drawing.Point(170, 145);
            this.txtknsrsy.Name = "txtknsrsy";
            this.txtknsrsy.Size = new System.Drawing.Size(171, 32);
            this.txtknsrsy.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ogrenci No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ders";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Konu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 26);
            this.label6.TabIndex = 7;
            this.label6.Text = "Soru Sayisi";
            // 
            // btmkonuekle
            // 
            this.btmkonuekle.Location = new System.Drawing.Point(89, 199);
            this.btmkonuekle.Name = "btmkonuekle";
            this.btmkonuekle.Size = new System.Drawing.Size(110, 44);
            this.btmkonuekle.TabIndex = 8;
            this.btmkonuekle.Text = "Ekle";
            this.btmkonuekle.UseVisualStyleBackColor = true;
            this.btmkonuekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnkonuiptal
            // 
            this.btnkonuiptal.Location = new System.Drawing.Point(205, 199);
            this.btnkonuiptal.Name = "btnkonuiptal";
            this.btnkonuiptal.Size = new System.Drawing.Size(110, 44);
            this.btnkonuiptal.TabIndex = 9;
            this.btnkonuiptal.Text = "Iptal";
            this.btnkonuiptal.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.DarkRed;
            this.button3.Location = new System.Drawing.Point(42, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 71);
            this.button3.TabIndex = 5;
            this.button3.Text = "GERI DON";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // konuilerleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 498);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "konuilerleme";
            this.Text = "konuilerleme";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtkonunara;
        private System.Windows.Forms.TextBox txtkonuara;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnkonuiptal;
        private System.Windows.Forms.Button btmkonuekle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtknsrsy;
        private System.Windows.Forms.TextBox txtknkn;
        private System.Windows.Forms.TextBox txtknders;
        private System.Windows.Forms.TextBox txtknogrno;
        private System.Windows.Forms.Button button3;
    }
}