
namespace kargoTakip
{
    partial class GelisBildirimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GelisBildirimi));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kargoİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelişBildirimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teslimatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilgileriGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ktNoSorgu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ktgonder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.normal = new System.Windows.Forms.RadioButton();
            this.dagitim = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kargoİşlemleriToolStripMenuItem,
            this.ayarlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kargoİşlemleriToolStripMenuItem
            // 
            this.kargoİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniKayıtToolStripMenuItem,
            this.gelişBildirimiToolStripMenuItem,
            this.teslimatToolStripMenuItem});
            this.kargoİşlemleriToolStripMenuItem.Name = "kargoİşlemleriToolStripMenuItem";
            this.kargoİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.kargoİşlemleriToolStripMenuItem.Text = "Kargo İşlemleri";
            // 
            // yeniKayıtToolStripMenuItem
            // 
            this.yeniKayıtToolStripMenuItem.Name = "yeniKayıtToolStripMenuItem";
            this.yeniKayıtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniKayıtToolStripMenuItem.Text = "Yeni Kayıt";
            this.yeniKayıtToolStripMenuItem.Click += new System.EventHandler(this.yeniKayıtToolStripMenuItem_Click);
            // 
            // gelişBildirimiToolStripMenuItem
            // 
            this.gelişBildirimiToolStripMenuItem.Name = "gelişBildirimiToolStripMenuItem";
            this.gelişBildirimiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gelişBildirimiToolStripMenuItem.Text = "Geliş Bildirimi";
            this.gelişBildirimiToolStripMenuItem.Click += new System.EventHandler(this.gelişBildirimiToolStripMenuItem_Click);
            // 
            // teslimatToolStripMenuItem
            // 
            this.teslimatToolStripMenuItem.Name = "teslimatToolStripMenuItem";
            this.teslimatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.teslimatToolStripMenuItem.Text = "Teslimat";
            this.teslimatToolStripMenuItem.Click += new System.EventHandler(this.teslimatToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bilgileriGüncelleToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // bilgileriGüncelleToolStripMenuItem
            // 
            this.bilgileriGüncelleToolStripMenuItem.Name = "bilgileriGüncelleToolStripMenuItem";
            this.bilgileriGüncelleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bilgileriGüncelleToolStripMenuItem.Text = "Bilgileri Güncelle";
            this.bilgileriGüncelleToolStripMenuItem.Click += new System.EventHandler(this.bilgileriGüncelleToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dagitim);
            this.groupBox2.Controls.Add(this.normal);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ktNoSorgu);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ktgonder);
            this.groupBox2.Location = new System.Drawing.Point(49, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(618, 133);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kargo Sorgula";
            // 
            // ktNoSorgu
            // 
            this.ktNoSorgu.Location = new System.Drawing.Point(129, 28);
            this.ktNoSorgu.Name = "ktNoSorgu";
            this.ktNoSorgu.Size = new System.Drawing.Size(257, 20);
            this.ktNoSorgu.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kargo Takip No:";
            // 
            // ktgonder
            // 
            this.ktgonder.Location = new System.Drawing.Point(405, 27);
            this.ktgonder.Name = "ktgonder";
            this.ktgonder.Size = new System.Drawing.Size(113, 63);
            this.ktgonder.TabIndex = 2;
            this.ktgonder.Text = "GETİR";
            this.ktgonder.UseVisualStyleBackColor = true;
            this.ktgonder.Click += new System.EventHandler(this.ktgonder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kargo Durumu:";
            // 
            // normal
            // 
            this.normal.AutoSize = true;
            this.normal.Checked = true;
            this.normal.Location = new System.Drawing.Point(129, 75);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(58, 17);
            this.normal.TabIndex = 8;
            this.normal.TabStop = true;
            this.normal.Text = "Normal";
            this.normal.UseVisualStyleBackColor = true;
            // 
            // dagitim
            // 
            this.dagitim.AutoSize = true;
            this.dagitim.Location = new System.Drawing.Point(202, 75);
            this.dagitim.Name = "dagitim";
            this.dagitim.Size = new System.Drawing.Size(60, 17);
            this.dagitim.TabIndex = 9;
            this.dagitim.Text = "Dağıtım";
            this.dagitim.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(45, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "* ARA KAYIT EKLEME SAYFASI";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(436, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(231, 25);
            this.label12.TabIndex = 26;
            this.label12.Text = " ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 268);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(744, 173);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // GelisBildirimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 440);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.menuStrip1);
            this.Name = "GelisBildirimi";
            this.Text = "Geliş Bildirimi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GelisBildirimi_FormClosing);
            this.Load += new System.EventHandler(this.GelisBildirimi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kargoİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelişBildirimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teslimatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilgileriGüncelleToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ktNoSorgu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ktgonder;
        private System.Windows.Forms.RadioButton normal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton dagitim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}