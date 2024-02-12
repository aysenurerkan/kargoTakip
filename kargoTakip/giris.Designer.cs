
namespace kargoTakip
{
    partial class giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tcno = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.girisYap = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(176, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 146);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(91, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "KARGO TAKİP PROGRAMI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "TC NO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ŞİFRE:";
            // 
            // tcno
            // 
            this.tcno.Location = new System.Drawing.Point(174, 248);
            this.tcno.Name = "tcno";
            this.tcno.Size = new System.Drawing.Size(205, 20);
            this.tcno.TabIndex = 4;
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(173, 284);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(205, 20);
            this.sifre.TabIndex = 5;
            this.sifre.TextChanged += new System.EventHandler(this.sifre_TextChanged);
            // 
            // girisYap
            // 
            this.girisYap.BackColor = System.Drawing.Color.DarkGray;
            this.girisYap.Location = new System.Drawing.Point(173, 320);
            this.girisYap.Name = "girisYap";
            this.girisYap.Size = new System.Drawing.Size(206, 29);
            this.girisYap.TabIndex = 6;
            this.girisYap.Text = "GİRİŞ YAP";
            this.girisYap.UseVisualStyleBackColor = false;
            this.girisYap.Click += new System.EventHandler(this.girisYap_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "KARGOM NEREDE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // giris
            // 
            this.AcceptButton = this.girisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 422);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.girisYap);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.tcno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "giris";
            this.Text = "GİRİŞ FORMU";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.giris_FormClosing);
            this.Load += new System.EventHandler(this.giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tcno;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Button girisYap;
        private System.Windows.Forms.Button button1;
    }
}

