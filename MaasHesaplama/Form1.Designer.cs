
namespace MaasHesaplama
{
    partial class Form1
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
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_maas = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdb_gece = new System.Windows.Forms.RadioButton();
            this.rdb_sabah = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_mesaisaati = new System.Windows.Forms.TextBox();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Maaş";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(131, 81);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(100, 20);
            this.txt_ad.TabIndex = 3;
            // 
            // txt_maas
            // 
            this.txt_maas.Location = new System.Drawing.Point(131, 174);
            this.txt_maas.Name = "txt_maas";
            this.txt_maas.Size = new System.Drawing.Size(100, 20);
            this.txt_maas.TabIndex = 4;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(131, 131);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(100, 20);
            this.txt_soyad.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mesai";
            // 
            // rdb_gece
            // 
            this.rdb_gece.AutoSize = true;
            this.rdb_gece.Location = new System.Drawing.Point(131, 235);
            this.rdb_gece.Name = "rdb_gece";
            this.rdb_gece.Size = new System.Drawing.Size(51, 17);
            this.rdb_gece.TabIndex = 7;
            this.rdb_gece.TabStop = true;
            this.rdb_gece.Text = "Gece";
            this.rdb_gece.UseVisualStyleBackColor = true;
            // 
            // rdb_sabah
            // 
            this.rdb_sabah.AutoSize = true;
            this.rdb_sabah.Location = new System.Drawing.Point(233, 235);
            this.rdb_sabah.Name = "rdb_sabah";
            this.rdb_sabah.Size = new System.Drawing.Size(56, 17);
            this.rdb_sabah.TabIndex = 8;
            this.rdb_sabah.TabStop = true;
            this.rdb_sabah.Text = "Sabah";
            this.rdb_sabah.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mesai Saati";
            // 
            // txt_mesaisaati
            // 
            this.txt_mesaisaati.Location = new System.Drawing.Point(131, 285);
            this.txt_mesaisaati.Name = "txt_mesaisaati";
            this.txt_mesaisaati.Size = new System.Drawing.Size(100, 20);
            this.txt_mesaisaati.TabIndex = 10;
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(131, 342);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(69, 27);
            this.btn_hesapla.TabIndex = 11;
            this.btn_hesapla.Text = "Hesapla";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.txt_mesaisaati);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rdb_sabah);
            this.Controls.Add(this.rdb_gece);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_maas);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_maas;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdb_gece;
        private System.Windows.Forms.RadioButton rdb_sabah;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_mesaisaati;
        private System.Windows.Forms.Button btn_hesapla;
    }
}

