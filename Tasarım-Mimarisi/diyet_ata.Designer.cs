
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(diyet_ata));
            this.ekle_btn = new System.Windows.Forms.Button();
            this.comboboxdiyet = new System.Windows.Forms.ComboBox();
            this.soyad_txt = new System.Windows.Forms.TextBox();
            this.tc_txt = new System.Windows.Forms.TextBox();
            this.ad_txt = new System.Windows.Forms.TextBox();
            this.geri_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.diyetatacks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ekle_btn
            // 
            this.ekle_btn.BackColor = System.Drawing.Color.White;
            this.ekle_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ekle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle_btn.ForeColor = System.Drawing.Color.Transparent;
            this.ekle_btn.Image = ((System.Drawing.Image)(resources.GetObject("ekle_btn.Image")));
            this.ekle_btn.Location = new System.Drawing.Point(140, 236);
            this.ekle_btn.Name = "ekle_btn";
            this.ekle_btn.Size = new System.Drawing.Size(63, 59);
            this.ekle_btn.TabIndex = 41;
            this.ekle_btn.UseVisualStyleBackColor = false;
            this.ekle_btn.Click += new System.EventHandler(this.ekle_btn_Click);
            // 
            // comboboxdiyet
            // 
            this.comboboxdiyet.ForeColor = System.Drawing.Color.LightGray;
            this.comboboxdiyet.FormattingEnabled = true;
            this.comboboxdiyet.Location = new System.Drawing.Point(140, 170);
            this.comboboxdiyet.Name = "comboboxdiyet";
            this.comboboxdiyet.Size = new System.Drawing.Size(171, 21);
            this.comboboxdiyet.TabIndex = 40;
            this.comboboxdiyet.Text = "Diyet Seçiniz";
            this.comboboxdiyet.Click += new System.EventHandler(this.combobox_Click);
            this.comboboxdiyet.Enter += new System.EventHandler(this.combobox_Enter);
            this.comboboxdiyet.Leave += new System.EventHandler(this.combobox_Leave);
            // 
            // soyad_txt
            // 
            this.soyad_txt.Location = new System.Drawing.Point(140, 104);
            this.soyad_txt.Name = "soyad_txt";
            this.soyad_txt.ReadOnly = true;
            this.soyad_txt.Size = new System.Drawing.Size(171, 20);
            this.soyad_txt.TabIndex = 38;
            // 
            // tc_txt
            // 
            this.tc_txt.Location = new System.Drawing.Point(140, 135);
            this.tc_txt.Name = "tc_txt";
            this.tc_txt.ReadOnly = true;
            this.tc_txt.Size = new System.Drawing.Size(171, 20);
            this.tc_txt.TabIndex = 37;
            // 
            // ad_txt
            // 
            this.ad_txt.Location = new System.Drawing.Point(140, 73);
            this.ad_txt.Name = "ad_txt";
            this.ad_txt.ReadOnly = true;
            this.ad_txt.Size = new System.Drawing.Size(171, 20);
            this.ad_txt.TabIndex = 36;
            // 
            // geri_btn
            // 
            this.geri_btn.BackColor = System.Drawing.Color.White;
            this.geri_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.geri_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.geri_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geri_btn.Font = new System.Drawing.Font("Impact", 12F);
            this.geri_btn.ForeColor = System.Drawing.Color.Transparent;
            this.geri_btn.Image = ((System.Drawing.Image)(resources.GetObject("geri_btn.Image")));
            this.geri_btn.Location = new System.Drawing.Point(248, 241);
            this.geri_btn.Name = "geri_btn";
            this.geri_btn.Size = new System.Drawing.Size(63, 54);
            this.geri_btn.TabIndex = 43;
            this.geri_btn.UseVisualStyleBackColor = false;
            this.geri_btn.Click += new System.EventHandler(this.cikis_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Impact", 12F);
            this.label7.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label7.Location = new System.Drawing.Point(262, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Geri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 12F);
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(143, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Diyeti Ekle";
            // 
            // diyetatacks
            // 
            this.diyetatacks.BackColor = System.Drawing.Color.Transparent;
            this.diyetatacks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("diyetatacks.BackgroundImage")));
            this.diyetatacks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.diyetatacks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.diyetatacks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diyetatacks.ForeColor = System.Drawing.Color.Transparent;
            this.diyetatacks.Location = new System.Drawing.Point(322, 0);
            this.diyetatacks.Name = "diyetatacks";
            this.diyetatacks.Size = new System.Drawing.Size(40, 40);
            this.diyetatacks.TabIndex = 46;
            this.diyetatacks.UseVisualStyleBackColor = false;
            this.diyetatacks.Click += new System.EventHandler(this.anasycks_Click);
            // 
            // diyet_ata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(360, 379);
            this.Controls.Add(this.diyetatacks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.geri_btn);
            this.Controls.Add(this.ekle_btn);
            this.Controls.Add(this.comboboxdiyet);
            this.Controls.Add(this.soyad_txt);
            this.Controls.Add(this.tc_txt);
            this.Controls.Add(this.ad_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "diyet_ata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diyet Ata";
            this.Load += new System.EventHandler(this.diyet_ata_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ekle_btn;
        private System.Windows.Forms.ComboBox comboboxdiyet;
        private System.Windows.Forms.TextBox soyad_txt;
        private System.Windows.Forms.TextBox tc_txt;
        private System.Windows.Forms.TextBox ad_txt;
        private System.Windows.Forms.Button geri_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button diyetatacks;
    }
}