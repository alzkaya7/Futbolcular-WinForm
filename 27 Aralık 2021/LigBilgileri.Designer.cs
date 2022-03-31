namespace Futbol
{
    partial class LigBilgileri
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnLigAdınaGöre = new System.Windows.Forms.Button();
            this.LigIdtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LigResmitxt = new System.Windows.Forms.TextBox();
            this.ÜlkeResmitxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLigResmi = new System.Windows.Forms.Button();
            this.btnÜlkeResmi = new System.Windows.Forms.Button();
            this.ligAdııtxt = new System.Windows.Forms.TextBox();
            this.LigÜlkesitxt = new System.Windows.Forms.TextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnLigTakımları = new System.Windows.Forms.Button();
            this.btnLigGetir = new System.Windows.Forms.Button();
            this.btnOyuncular = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(4, 211);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(89, 52);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(108, 211);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 52);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(198, 211);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(97, 52);
            this.btnGüncelle.TabIndex = 2;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnLigAdınaGöre
            // 
            this.btnLigAdınaGöre.Location = new System.Drawing.Point(230, 50);
            this.btnLigAdınaGöre.Name = "btnLigAdınaGöre";
            this.btnLigAdınaGöre.Size = new System.Drawing.Size(123, 27);
            this.btnLigAdınaGöre.TabIndex = 3;
            this.btnLigAdınaGöre.Text = "Lig Adına Göre Ara";
            this.btnLigAdınaGöre.UseVisualStyleBackColor = true;
            this.btnLigAdınaGöre.Click += new System.EventHandler(this.btnLigAdınaGöre_Click);
            // 
            // LigIdtxt
            // 
            this.LigIdtxt.Location = new System.Drawing.Point(103, 9);
            this.LigIdtxt.Name = "LigIdtxt";
            this.LigIdtxt.Size = new System.Drawing.Size(121, 20);
            this.LigIdtxt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lig ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lig Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lig Ülkesi :";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 376);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(373, 223);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // LigResmitxt
            // 
            this.LigResmitxt.Location = new System.Drawing.Point(103, 124);
            this.LigResmitxt.Name = "LigResmitxt";
            this.LigResmitxt.Size = new System.Drawing.Size(121, 20);
            this.LigResmitxt.TabIndex = 13;
            // 
            // ÜlkeResmitxt
            // 
            this.ÜlkeResmitxt.Location = new System.Drawing.Point(103, 165);
            this.ÜlkeResmitxt.Name = "ÜlkeResmitxt";
            this.ÜlkeResmitxt.Size = new System.Drawing.Size(121, 20);
            this.ÜlkeResmitxt.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Lig Resmi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ülke Resmi :";
            // 
            // btnLigResmi
            // 
            this.btnLigResmi.Location = new System.Drawing.Point(230, 122);
            this.btnLigResmi.Name = "btnLigResmi";
            this.btnLigResmi.Size = new System.Drawing.Size(123, 23);
            this.btnLigResmi.TabIndex = 17;
            this.btnLigResmi.Text = "Lig Resmi Seç ";
            this.btnLigResmi.UseVisualStyleBackColor = true;
            this.btnLigResmi.Click += new System.EventHandler(this.btnLigResmi_Click);
            // 
            // btnÜlkeResmi
            // 
            this.btnÜlkeResmi.Location = new System.Drawing.Point(230, 165);
            this.btnÜlkeResmi.Name = "btnÜlkeResmi";
            this.btnÜlkeResmi.Size = new System.Drawing.Size(123, 23);
            this.btnÜlkeResmi.TabIndex = 18;
            this.btnÜlkeResmi.Text = "Ülke Resmi Seç ";
            this.btnÜlkeResmi.UseVisualStyleBackColor = true;
            this.btnÜlkeResmi.Click += new System.EventHandler(this.btnÜlkeResmi_Click);
            // 
            // ligAdııtxt
            // 
            this.ligAdııtxt.Location = new System.Drawing.Point(103, 54);
            this.ligAdııtxt.Name = "ligAdııtxt";
            this.ligAdııtxt.Size = new System.Drawing.Size(121, 20);
            this.ligAdııtxt.TabIndex = 19;
            // 
            // LigÜlkesitxt
            // 
            this.LigÜlkesitxt.Location = new System.Drawing.Point(103, 93);
            this.LigÜlkesitxt.Name = "LigÜlkesitxt";
            this.LigÜlkesitxt.Size = new System.Drawing.Size(121, 20);
            this.LigÜlkesitxt.TabIndex = 20;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(302, 211);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 52);
            this.btnTemizle.TabIndex = 21;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnLigTakımları
            // 
            this.btnLigTakımları.Location = new System.Drawing.Point(434, 22);
            this.btnLigTakımları.Name = "btnLigTakımları";
            this.btnLigTakımları.Size = new System.Drawing.Size(123, 52);
            this.btnLigTakımları.TabIndex = 22;
            this.btnLigTakımları.Text = "Liglerde Hangi Takımlar Var ?";
            this.btnLigTakımları.UseVisualStyleBackColor = true;
            this.btnLigTakımları.Click += new System.EventHandler(this.btnLigTakımları_Click);
            // 
            // btnLigGetir
            // 
            this.btnLigGetir.Location = new System.Drawing.Point(434, 150);
            this.btnLigGetir.Name = "btnLigGetir";
            this.btnLigGetir.Size = new System.Drawing.Size(123, 38);
            this.btnLigGetir.TabIndex = 23;
            this.btnLigGetir.Text = "Ligleri Getir";
            this.btnLigGetir.UseVisualStyleBackColor = true;
            this.btnLigGetir.Click += new System.EventHandler(this.btnLigGetir_Click);
            // 
            // btnOyuncular
            // 
            this.btnOyuncular.Location = new System.Drawing.Point(434, 80);
            this.btnOyuncular.Name = "btnOyuncular";
            this.btnOyuncular.Size = new System.Drawing.Size(123, 53);
            this.btnOyuncular.TabIndex = 25;
            this.btnOyuncular.Text = "Liglerde Hangi Futbolcular Var ?";
            this.btnOyuncular.UseVisualStyleBackColor = true;
            this.btnOyuncular.Click += new System.EventHandler(this.btnOyuncular_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(383, 343);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(630, 256);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(563, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(479, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // LigBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1054, 611);
            this.Controls.Add(this.btnOyuncular);
            this.Controls.Add(this.btnLigGetir);
            this.Controls.Add(this.btnLigTakımları);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.LigÜlkesitxt);
            this.Controls.Add(this.ligAdııtxt);
            this.Controls.Add(this.btnÜlkeResmi);
            this.Controls.Add(this.btnLigResmi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ÜlkeResmitxt);
            this.Controls.Add(this.LigResmitxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LigIdtxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLigAdınaGöre);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "LigBilgileri";
            this.Text = "LigBilgileri";
            this.Load += new System.EventHandler(this.LigBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnLigAdınaGöre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox LigIdtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox LigResmitxt;
        private System.Windows.Forms.TextBox ÜlkeResmitxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLigResmi;
        private System.Windows.Forms.Button btnÜlkeResmi;
        private System.Windows.Forms.TextBox LigÜlkesitxt;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnLigTakımları;
        private System.Windows.Forms.Button btnLigGetir;
        private System.Windows.Forms.Button btnOyuncular;
        public System.Windows.Forms.TextBox ligAdııtxt;
    }
}