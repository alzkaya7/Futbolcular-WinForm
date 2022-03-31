namespace Futbol
{
    partial class TakımBilgileri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnResimler = new System.Windows.Forms.Button();
            this.TakımIdtxt = new System.Windows.Forms.TextBox();
            this.TakımAdıTxt = new System.Windows.Forms.TextBox();
            this.TakımResimtxt = new System.Windows.Forms.TextBox();
            this.btnTakımSil = new System.Windows.Forms.Button();
            this.btnTakımGüncelle = new System.Windows.Forms.Button();
            this.BtnTakımEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnİsmeGöre = new System.Windows.Forms.Button();
            this.Stadyum = new System.Windows.Forms.Label();
            this.StadyumTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LigAdıcmbx = new System.Windows.Forms.ComboBox();
            this.btnVeriTemizle = new System.Windows.Forms.Button();
            this.btnGetir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResimler
            // 
            this.btnResimler.Location = new System.Drawing.Point(278, 200);
            this.btnResimler.Name = "btnResimler";
            this.btnResimler.Size = new System.Drawing.Size(75, 39);
            this.btnResimler.TabIndex = 1;
            this.btnResimler.Text = "Resim Yolu ";
            this.btnResimler.UseVisualStyleBackColor = true;
            this.btnResimler.Click += new System.EventHandler(this.btnResimler_Click);
            // 
            // TakımIdtxt
            // 
            this.TakımIdtxt.Location = new System.Drawing.Point(140, 25);
            this.TakımIdtxt.Name = "TakımIdtxt";
            this.TakımIdtxt.Size = new System.Drawing.Size(152, 20);
            this.TakımIdtxt.TabIndex = 2;
            // 
            // TakımAdıTxt
            // 
            this.TakımAdıTxt.Location = new System.Drawing.Point(140, 62);
            this.TakımAdıTxt.Name = "TakımAdıTxt";
            this.TakımAdıTxt.Size = new System.Drawing.Size(152, 20);
            this.TakımAdıTxt.TabIndex = 3;
            // 
            // TakımResimtxt
            // 
            this.TakımResimtxt.Location = new System.Drawing.Point(140, 128);
            this.TakımResimtxt.Name = "TakımResimtxt";
            this.TakımResimtxt.Size = new System.Drawing.Size(152, 20);
            this.TakımResimtxt.TabIndex = 4;
            // 
            // btnTakımSil
            // 
            this.btnTakımSil.Location = new System.Drawing.Point(194, 200);
            this.btnTakımSil.Name = "btnTakımSil";
            this.btnTakımSil.Size = new System.Drawing.Size(75, 39);
            this.btnTakımSil.TabIndex = 5;
            this.btnTakımSil.Text = "Takım Sil ";
            this.btnTakımSil.UseVisualStyleBackColor = true;
            this.btnTakımSil.Click += new System.EventHandler(this.btnTakımSil_Click);
            // 
            // btnTakımGüncelle
            // 
            this.btnTakımGüncelle.Location = new System.Drawing.Point(102, 200);
            this.btnTakımGüncelle.Name = "btnTakımGüncelle";
            this.btnTakımGüncelle.Size = new System.Drawing.Size(75, 39);
            this.btnTakımGüncelle.TabIndex = 6;
            this.btnTakımGüncelle.Text = "Takım Güncelle";
            this.btnTakımGüncelle.UseVisualStyleBackColor = true;
            this.btnTakımGüncelle.Click += new System.EventHandler(this.btnTakımGüncelle_Click);
            // 
            // BtnTakımEkle
            // 
            this.BtnTakımEkle.Location = new System.Drawing.Point(12, 200);
            this.BtnTakımEkle.Name = "BtnTakımEkle";
            this.BtnTakımEkle.Size = new System.Drawing.Size(75, 39);
            this.BtnTakımEkle.TabIndex = 7;
            this.BtnTakımEkle.Text = "Takım Ekle";
            this.BtnTakımEkle.UseVisualStyleBackColor = true;
            this.BtnTakımEkle.Click += new System.EventHandler(this.BtnTakımEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Takım ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Takım Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Takım Resim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Lig ID :";
            // 
            // btnİsmeGöre
            // 
            this.btnİsmeGöre.Location = new System.Drawing.Point(298, 55);
            this.btnİsmeGöre.Name = "btnİsmeGöre";
            this.btnİsmeGöre.Size = new System.Drawing.Size(85, 32);
            this.btnİsmeGöre.TabIndex = 13;
            this.btnİsmeGöre.Text = "İsme Göre Ara";
            this.btnİsmeGöre.UseVisualStyleBackColor = true;
            this.btnİsmeGöre.Click += new System.EventHandler(this.btnİsmeGöre_Click);
            // 
            // Stadyum
            // 
            this.Stadyum.AutoSize = true;
            this.Stadyum.Location = new System.Drawing.Point(16, 102);
            this.Stadyum.Name = "Stadyum";
            this.Stadyum.Size = new System.Drawing.Size(54, 13);
            this.Stadyum.TabIndex = 17;
            this.Stadyum.Text = "Stadyum :";
            // 
            // StadyumTxt
            // 
            this.StadyumTxt.Location = new System.Drawing.Point(140, 98);
            this.StadyumTxt.Name = "StadyumTxt";
            this.StadyumTxt.Size = new System.Drawing.Size(152, 20);
            this.StadyumTxt.TabIndex = 16;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 297);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(370, 220);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // LigAdıcmbx
            // 
            this.LigAdıcmbx.FormattingEnabled = true;
            this.LigAdıcmbx.Location = new System.Drawing.Point(140, 158);
            this.LigAdıcmbx.Name = "LigAdıcmbx";
            this.LigAdıcmbx.Size = new System.Drawing.Size(152, 21);
            this.LigAdıcmbx.TabIndex = 20;
            // 
            // btnVeriTemizle
            // 
            this.btnVeriTemizle.Location = new System.Drawing.Point(37, 246);
            this.btnVeriTemizle.Name = "btnVeriTemizle";
            this.btnVeriTemizle.Size = new System.Drawing.Size(96, 45);
            this.btnVeriTemizle.TabIndex = 21;
            this.btnVeriTemizle.Text = "Verileri Temizle";
            this.btnVeriTemizle.UseVisualStyleBackColor = true;
            this.btnVeriTemizle.Click += new System.EventHandler(this.btnVeriTemizle_Click);
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(202, 246);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(113, 44);
            this.btnGetir.TabIndex = 22;
            this.btnGetir.Text = "Takımları Listele";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(389, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 365);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TakımBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(813, 529);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.btnVeriTemizle);
            this.Controls.Add(this.LigAdıcmbx);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Stadyum);
            this.Controls.Add(this.StadyumTxt);
            this.Controls.Add(this.btnİsmeGöre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnTakımEkle);
            this.Controls.Add(this.btnTakımGüncelle);
            this.Controls.Add(this.btnTakımSil);
            this.Controls.Add(this.TakımResimtxt);
            this.Controls.Add(this.TakımAdıTxt);
            this.Controls.Add(this.TakımIdtxt);
            this.Controls.Add(this.btnResimler);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TakımBilgileri";
            this.Text = "Takım Bilgileri";
            this.Load += new System.EventHandler(this.TakımBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnResimler;
        private System.Windows.Forms.TextBox TakımIdtxt;
        private System.Windows.Forms.TextBox TakımAdıTxt;
        private System.Windows.Forms.TextBox TakımResimtxt;
        private System.Windows.Forms.Button btnTakımSil;
        private System.Windows.Forms.Button btnTakımGüncelle;
        private System.Windows.Forms.Button BtnTakımEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnİsmeGöre;
        private System.Windows.Forms.Label Stadyum;
        private System.Windows.Forms.TextBox StadyumTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox LigAdıcmbx;
        private System.Windows.Forms.Button btnVeriTemizle;
        private System.Windows.Forms.Button btnGetir;
    }
}