
namespace kargoTakip
{
    partial class KargoSorgulama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KargoSorgulama));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ktNoSorgu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ktgonder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.ktNoSorgu);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ktgonder);
            this.groupBox2.Location = new System.Drawing.Point(28, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(754, 78);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kargo Sorgula";
            // 
            // ktNoSorgu
            // 
            this.ktNoSorgu.Location = new System.Drawing.Point(154, 34);
            this.ktNoSorgu.Name = "ktNoSorgu";
            this.ktNoSorgu.Size = new System.Drawing.Size(386, 20);
            this.ktNoSorgu.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(48, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kargo Takip No:";
            // 
            // ktgonder
            // 
            this.ktgonder.Location = new System.Drawing.Point(564, 33);
            this.ktgonder.Name = "ktgonder";
            this.ktgonder.Size = new System.Drawing.Size(157, 24);
            this.ktgonder.TabIndex = 2;
            this.ktgonder.Text = "SORGULA";
            this.ktgonder.UseVisualStyleBackColor = true;
            this.ktgonder.Click += new System.EventHandler(this.ktgonder_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(754, 120);
            this.label2.TabIndex = 21;
            this.label2.Text = " ";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(756, 148);
            this.label3.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(27, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(755, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Kargo Varış Bilgileri:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(24, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(758, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "Gönderen ve Alıcı Bilgileri:";
            // 
            // KargoSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(817, 467);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Name = "KargoSorgulama";
            this.Text = "KargoSorgulama";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KargoSorgulama_FormClosing);
            this.Load += new System.EventHandler(this.KargoSorgulama_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ktNoSorgu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ktgonder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}