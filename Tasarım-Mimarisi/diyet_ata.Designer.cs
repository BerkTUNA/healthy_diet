
namespace Tasarım_Mimarisi
{
    partial class diyet_ata
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
            this.ekle_btn = new System.Windows.Forms.Button();
            this.combobox = new System.Windows.Forms.ComboBox();
            this.diyet = new System.Windows.Forms.Label();
            this.soyad_txt = new System.Windows.Forms.TextBox();
            this.tc_txt = new System.Windows.Forms.TextBox();
            this.ad_txt = new System.Windows.Forms.TextBox();
            this.soyad = new System.Windows.Forms.Label();
            this.tc = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.Label();
            this.geri_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ekle_btn
            // 
            this.ekle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle_btn.Location = new System.Drawing.Point(54, 303);
            this.ekle_btn.Name = "ekle_btn";
            this.ekle_btn.Size = new System.Drawing.Size(93, 31);
            this.ekle_btn.TabIndex = 41;
            this.ekle_btn.Text = "Ekle";
            this.ekle_btn.UseVisualStyleBackColor = true;
            // 
            // combobox
            // 
            this.combobox.FormattingEnabled = true;
            this.combobox.Location = new System.Drawing.Point(113, 246);
            this.combobox.Name = "combobox";
            this.combobox.Size = new System.Drawing.Size(169, 21);
            this.combobox.TabIndex = 40;
            // 
            // diyet
            // 
            this.diyet.AutoSize = true;
            this.diyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.diyet.Location = new System.Drawing.Point(37, 247);
            this.diyet.Name = "diyet";
            this.diyet.Size = new System.Drawing.Size(49, 20);
            this.diyet.TabIndex = 39;
            this.diyet.Text = "Diyet:";
            // 
            // soyad_txt
            // 
            this.soyad_txt.Location = new System.Drawing.Point(113, 120);
            this.soyad_txt.Name = "soyad_txt";
            this.soyad_txt.Size = new System.Drawing.Size(171, 20);
            this.soyad_txt.TabIndex = 38;
            // 
            // tc_txt
            // 
            this.tc_txt.Location = new System.Drawing.Point(111, 183);
            this.tc_txt.Name = "tc_txt";
            this.tc_txt.Size = new System.Drawing.Size(171, 20);
            this.tc_txt.TabIndex = 37;
            // 
            // ad_txt
            // 
            this.ad_txt.Location = new System.Drawing.Point(113, 57);
            this.ad_txt.Name = "ad_txt";
            this.ad_txt.Size = new System.Drawing.Size(171, 20);
            this.ad_txt.TabIndex = 36;
            // 
            // soyad
            // 
            this.soyad.AutoSize = true;
            this.soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyad.Location = new System.Drawing.Point(37, 119);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(58, 20);
            this.soyad.TabIndex = 35;
            this.soyad.Text = "Soyad:";
            // 
            // tc
            // 
            this.tc.AutoSize = true;
            this.tc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tc.Location = new System.Drawing.Point(53, 183);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(33, 20);
            this.tc.TabIndex = 34;
            this.tc.Text = "TC:";
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ad.Location = new System.Drawing.Point(62, 55);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(33, 20);
            this.ad.TabIndex = 33;
            this.ad.Text = "Ad:";
            // 
            // geri_btn
            // 
            this.geri_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geri_btn.Location = new System.Drawing.Point(208, 303);
            this.geri_btn.Name = "geri_btn";
            this.geri_btn.Size = new System.Drawing.Size(93, 31);
            this.geri_btn.TabIndex = 42;
            this.geri_btn.Text = "Geri";
            this.geri_btn.UseVisualStyleBackColor = true;
            this.geri_btn.Click += new System.EventHandler(this.geri_btn_Click);
            // 
            // diyet_ata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 379);
            this.Controls.Add(this.geri_btn);
            this.Controls.Add(this.ekle_btn);
            this.Controls.Add(this.combobox);
            this.Controls.Add(this.diyet);
            this.Controls.Add(this.soyad_txt);
            this.Controls.Add(this.tc_txt);
            this.Controls.Add(this.ad_txt);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.ad);
            this.Name = "diyet_ata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diyet Ata";
            this.Load += new System.EventHandler(this.diyet_ata_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ekle_btn;
        private System.Windows.Forms.ComboBox combobox;
        private System.Windows.Forms.Label diyet;
        private System.Windows.Forms.TextBox soyad_txt;
        private System.Windows.Forms.TextBox tc_txt;
        private System.Windows.Forms.TextBox ad_txt;
        private System.Windows.Forms.Label soyad;
        private System.Windows.Forms.Label tc;
        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.Button geri_btn;
    }
}