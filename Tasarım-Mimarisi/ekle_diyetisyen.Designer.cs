
namespace Tasarım_Mimarisi
{
    partial class ekle_diyetisyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ekle_diyetisyen));
            this.ekle_btn = new System.Windows.Forms.Button();
            this.ad_txt = new System.Windows.Forms.TextBox();
            this.sifre2_txt = new System.Windows.Forms.TextBox();
            this.eposta_txt = new System.Windows.Forms.TextBox();
            this.kullanici_txt = new System.Windows.Forms.TextBox();
            this.tc_txt = new System.Windows.Forms.TextBox();
            this.soyad_txt = new System.Windows.Forms.TextBox();
            this.sifre_txt = new System.Windows.Forms.TextBox();
            this.Cinsiyet = new System.Windows.Forms.ComboBox();
            this.adminpcks = new System.Windows.Forms.Button();
            this.cikis_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ekle_btn
            // 
            this.ekle_btn.BackColor = System.Drawing.Color.White;
            this.ekle_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ekle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle_btn.ForeColor = System.Drawing.Color.Transparent;
            this.ekle_btn.Image = ((System.Drawing.Image)(resources.GetObject("ekle_btn.Image")));
            this.ekle_btn.Location = new System.Drawing.Point(38, 362);
            this.ekle_btn.Name = "ekle_btn";
            this.ekle_btn.Size = new System.Drawing.Size(104, 130);
            this.ekle_btn.TabIndex = 6;
            this.ekle_btn.UseVisualStyleBackColor = false;
            this.ekle_btn.Click += new System.EventHandler(this.ekle_btn_Click);
            // 
            // ad_txt
            // 
            this.ad_txt.ForeColor = System.Drawing.Color.LightGray;
            this.ad_txt.Location = new System.Drawing.Point(26, 130);
            this.ad_txt.Name = "ad_txt";
            this.ad_txt.Size = new System.Drawing.Size(135, 20);
            this.ad_txt.TabIndex = 14;
            this.ad_txt.Text = "Ad";
            this.ad_txt.Enter += new System.EventHandler(this.ad_txt_Enter);
            this.ad_txt.Leave += new System.EventHandler(this.ad_txt_Leave);
            // 
            // sifre2_txt
            // 
            this.sifre2_txt.ForeColor = System.Drawing.Color.LightGray;
            this.sifre2_txt.Location = new System.Drawing.Point(341, 299);
            this.sifre2_txt.Name = "sifre2_txt";
            this.sifre2_txt.Size = new System.Drawing.Size(135, 20);
            this.sifre2_txt.TabIndex = 15;
            this.sifre2_txt.Text = "Parola Tekrar";
            this.sifre2_txt.Enter += new System.EventHandler(this.sifre2_txt_Enter);
            this.sifre2_txt.Leave += new System.EventHandler(this.sifre2_txt_Leave);
            // 
            // eposta_txt
            // 
            this.eposta_txt.ForeColor = System.Drawing.Color.LightGray;
            this.eposta_txt.Location = new System.Drawing.Point(341, 173);
            this.eposta_txt.Name = "eposta_txt";
            this.eposta_txt.Size = new System.Drawing.Size(135, 20);
            this.eposta_txt.TabIndex = 16;
            this.eposta_txt.Text = "ePosta";
            this.eposta_txt.Enter += new System.EventHandler(this.eposta_txt_Enter);
            this.eposta_txt.Leave += new System.EventHandler(this.eposta_txt_Leave);
            // 
            // kullanici_txt
            // 
            this.kullanici_txt.ForeColor = System.Drawing.Color.LightGray;
            this.kullanici_txt.Location = new System.Drawing.Point(341, 130);
            this.kullanici_txt.Name = "kullanici_txt";
            this.kullanici_txt.Size = new System.Drawing.Size(135, 20);
            this.kullanici_txt.TabIndex = 17;
            this.kullanici_txt.Text = "Kullanıcı Adı";
            this.kullanici_txt.Enter += new System.EventHandler(this.kullanici_txt_Enter);
            this.kullanici_txt.Leave += new System.EventHandler(this.kullanici_txt_Leave);
            // 
            // tc_txt
            // 
            this.tc_txt.ForeColor = System.Drawing.Color.LightGray;
            this.tc_txt.Location = new System.Drawing.Point(26, 299);
            this.tc_txt.MaxLength = 11;
            this.tc_txt.Name = "tc_txt";
            this.tc_txt.Size = new System.Drawing.Size(135, 20);
            this.tc_txt.TabIndex = 18;
            this.tc_txt.Text = "TC";
            this.tc_txt.Enter += new System.EventHandler(this.tc_txt_Enter);
            this.tc_txt.Leave += new System.EventHandler(this.tc_txt_Leave);
            // 
            // soyad_txt
            // 
            this.soyad_txt.ForeColor = System.Drawing.Color.LightGray;
            this.soyad_txt.Location = new System.Drawing.Point(26, 173);
            this.soyad_txt.Name = "soyad_txt";
            this.soyad_txt.Size = new System.Drawing.Size(135, 20);
            this.soyad_txt.TabIndex = 19;
            this.soyad_txt.Text = "Soyad";
            this.soyad_txt.Enter += new System.EventHandler(this.soyad_txt_Enter);
            this.soyad_txt.Leave += new System.EventHandler(this.soyad_txt_Leave);
            // 
            // sifre_txt
            // 
            this.sifre_txt.ForeColor = System.Drawing.Color.LightGray;
            this.sifre_txt.Location = new System.Drawing.Point(341, 258);
            this.sifre_txt.Name = "sifre_txt";
            this.sifre_txt.Size = new System.Drawing.Size(135, 20);
            this.sifre_txt.TabIndex = 20;
            this.sifre_txt.Text = "Parola";
            this.sifre_txt.Enter += new System.EventHandler(this.sifre_txt_Enter);
            this.sifre_txt.Leave += new System.EventHandler(this.sifre_txt_Leave);
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.ForeColor = System.Drawing.Color.LightGray;
            this.Cinsiyet.FormattingEnabled = true;
            this.Cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.Cinsiyet.Location = new System.Drawing.Point(26, 258);
            this.Cinsiyet.Name = "Cinsiyet";
            this.Cinsiyet.Size = new System.Drawing.Size(135, 21);
            this.Cinsiyet.TabIndex = 41;
            this.Cinsiyet.Text = "Cinsiyetinizi Seçiniz";
            this.Cinsiyet.Enter += new System.EventHandler(this.Cinsiyet_Enter);
            this.Cinsiyet.Leave += new System.EventHandler(this.Cinsiyet_Leave);
            // 
            // adminpcks
            // 
            this.adminpcks.BackColor = System.Drawing.Color.Transparent;
            this.adminpcks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adminpcks.BackgroundImage")));
            this.adminpcks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminpcks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminpcks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminpcks.ForeColor = System.Drawing.Color.Transparent;
            this.adminpcks.Location = new System.Drawing.Point(460, 0);
            this.adminpcks.Name = "adminpcks";
            this.adminpcks.Size = new System.Drawing.Size(40, 40);
            this.adminpcks.TabIndex = 42;
            this.adminpcks.UseVisualStyleBackColor = false;
            this.adminpcks.Click += new System.EventHandler(this.adminpcks_Click);
            // 
            // cikis_btn
            // 
            this.cikis_btn.BackColor = System.Drawing.Color.White;
            this.cikis_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikis_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikis_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis_btn.ForeColor = System.Drawing.Color.Transparent;
            this.cikis_btn.Image = ((System.Drawing.Image)(resources.GetObject("cikis_btn.Image")));
            this.cikis_btn.Location = new System.Drawing.Point(383, 382);
            this.cikis_btn.Name = "cikis_btn";
            this.cikis_btn.Size = new System.Drawing.Size(53, 57);
            this.cikis_btn.TabIndex = 43;
            this.cikis_btn.UseVisualStyleBackColor = false;
            this.cikis_btn.Click += new System.EventHandler(this.cikis_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 12F);
            this.label4.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Location = new System.Drawing.Point(393, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Geri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 12F);
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(74, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Ekle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 30F);
            this.label2.ForeColor = System.Drawing.Color.OldLace;
            this.label2.Location = new System.Drawing.Point(84, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 48);
            this.label2.TabIndex = 46;
            this.label2.Text = "Diyetisyen Bilgileri";
            // 
            // ekle_diyetisyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cikis_btn);
            this.Controls.Add(this.adminpcks);
            this.Controls.Add(this.Cinsiyet);
            this.Controls.Add(this.sifre_txt);
            this.Controls.Add(this.soyad_txt);
            this.Controls.Add(this.tc_txt);
            this.Controls.Add(this.kullanici_txt);
            this.Controls.Add(this.eposta_txt);
            this.Controls.Add(this.sifre2_txt);
            this.Controls.Add(this.ad_txt);
            this.Controls.Add(this.ekle_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ekle_diyetisyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ekle_diyetisyen";
            this.Load += new System.EventHandler(this.ekle_diyetisyen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ekle_btn;
        private System.Windows.Forms.TextBox ad_txt;
        private System.Windows.Forms.TextBox sifre2_txt;
        private System.Windows.Forms.TextBox eposta_txt;
        private System.Windows.Forms.TextBox kullanici_txt;
        private System.Windows.Forms.TextBox tc_txt;
        private System.Windows.Forms.TextBox soyad_txt;
        private System.Windows.Forms.TextBox sifre_txt;
        private System.Windows.Forms.ComboBox Cinsiyet;
        private System.Windows.Forms.Button adminpcks;
        private System.Windows.Forms.Button cikis_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}