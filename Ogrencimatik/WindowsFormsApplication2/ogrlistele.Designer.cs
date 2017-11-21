namespace WindowsFormsApplication2
{
    partial class ogrlistele
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
            this.ogrlsls = new System.Windows.Forms.Button();
            this.btnogrlskyt = new System.Windows.Forms.Button();
            this.btnogrlssil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtogrlsara = new System.Windows.Forms.TextBox();
            this.txtogrlsnara = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(772, 254);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ogrlsls
            // 
            this.ogrlsls.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrlsls.Location = new System.Drawing.Point(101, 12);
            this.ogrlsls.Name = "ogrlsls";
            this.ogrlsls.Size = new System.Drawing.Size(108, 64);
            this.ogrlsls.TabIndex = 1;
            this.ogrlsls.Text = "Listele";
            this.ogrlsls.UseVisualStyleBackColor = true;
            this.ogrlsls.Click += new System.EventHandler(this.ogrlsls_Click);
            // 
            // btnogrlskyt
            // 
            this.btnogrlskyt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnogrlskyt.Location = new System.Drawing.Point(228, 12);
            this.btnogrlskyt.Name = "btnogrlskyt";
            this.btnogrlskyt.Size = new System.Drawing.Size(108, 64);
            this.btnogrlskyt.TabIndex = 2;
            this.btnogrlskyt.Text = "Kayit Penceresi";
            this.btnogrlskyt.UseVisualStyleBackColor = true;
            this.btnogrlskyt.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnogrlssil
            // 
            this.btnogrlssil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnogrlssil.ForeColor = System.Drawing.Color.DarkRed;
            this.btnogrlssil.Location = new System.Drawing.Point(676, 12);
            this.btnogrlssil.Name = "btnogrlssil";
            this.btnogrlssil.Size = new System.Drawing.Size(108, 64);
            this.btnogrlssil.TabIndex = 3;
            this.btnogrlssil.Text = "Ogrenciyi Sil";
            this.btnogrlssil.UseVisualStyleBackColor = true;
            this.btnogrlssil.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 64);
            this.button1.TabIndex = 4;
            this.button1.Text = "GERI DON";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // txtogrlsara
            // 
            this.txtogrlsara.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtogrlsara.Location = new System.Drawing.Point(72, 54);
            this.txtogrlsara.Multiline = true;
            this.txtogrlsara.Name = "txtogrlsara";
            this.txtogrlsara.Size = new System.Drawing.Size(321, 38);
            this.txtogrlsara.TabIndex = 6;
            this.txtogrlsara.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtogrlsnara
            // 
            this.txtogrlsnara.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtogrlsnara.Location = new System.Drawing.Point(20, 54);
            this.txtogrlsnara.Multiline = true;
            this.txtogrlsnara.Name = "txtogrlsnara";
            this.txtogrlsnara.Size = new System.Drawing.Size(46, 38);
            this.txtogrlsnara.TabIndex = 7;
            this.txtogrlsnara.TextChanged += new System.EventHandler(this.txtogrlsnara_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Numara";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(212, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Isim";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtogrlsara);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtogrlsnara);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 115);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ogrenci Arama";
            // 
            // ogrlistele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 535);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnogrlssil);
            this.Controls.Add(this.btnogrlskyt);
            this.Controls.Add(this.ogrlsls);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ogrlistele";
            this.Text = "ogrlistele";
            this.Load += new System.EventHandler(this.ogrlistele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ogrlsls;
        private System.Windows.Forms.Button btnogrlskyt;
        private System.Windows.Forms.Button btnogrlssil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtogrlsara;
        private System.Windows.Forms.TextBox txtogrlsnara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}