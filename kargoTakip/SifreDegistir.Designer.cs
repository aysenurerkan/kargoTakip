
namespace kargoTakip
{
    partial class SifreDegistir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifreDegistir));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.yeni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.eski = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ktgonder = new System.Windows.Forms.Button();
            this.yeni2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.yeni2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.yeni);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.eski);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ktgonder);
            this.groupBox2.Location = new System.Drawing.Point(41, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 254);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Şifre Değiştirme Paneli";
            // 
            // yeni
            // 
            this.yeni.Location = new System.Drawing.Point(98, 101);
            this.yeni.Name = "yeni";
            this.yeni.Size = new System.Drawing.Size(128, 20);
            this.yeni.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Yeni Şifre";
            // 
            // eski
            // 
            this.eski.Location = new System.Drawing.Point(98, 65);
            this.eski.Name = "eski";
            this.eski.Size = new System.Drawing.Size(128, 20);
            this.eski.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Eski Şifre";
            // 
            // ktgonder
            // 
            this.ktgonder.Location = new System.Drawing.Point(98, 183);
            this.ktgonder.Name = "ktgonder";
            this.ktgonder.Size = new System.Drawing.Size(128, 24);
            this.ktgonder.TabIndex = 2;
            this.ktgonder.Text = "DEĞİŞTİR";
            this.ktgonder.UseVisualStyleBackColor = true;
            this.ktgonder.Click += new System.EventHandler(this.ktgonder_Click);
            // 
            // yeni2
            // 
            this.yeni2.Location = new System.Drawing.Point(98, 140);
            this.yeni2.Name = "yeni2";
            this.yeni2.Size = new System.Drawing.Size(128, 20);
            this.yeni2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Yeni Şifre Tekrar";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(38, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(279, 31);
            this.label12.TabIndex = 29;
            this.label12.Text = " ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(337, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 247);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // SifreDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 362);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox2);
            this.Name = "SifreDegistir";
            this.Text = "Bilgileri Değiştir";
            this.Load += new System.EventHandler(this.SifreDegistir_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox yeni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox eski;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ktgonder;
        private System.Windows.Forms.TextBox yeni2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}