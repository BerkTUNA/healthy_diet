
namespace Tasarım_Mimarisi
{
    partial class ekle_diyet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ekle_diyet));
            this.ekle_btn = new System.Windows.Forms.Button();
            this.diyetadi = new System.Windows.Forms.TextBox();
            this.ediyetcks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pzt = new System.Windows.Forms.TextBox();
            this.sli = new System.Windows.Forms.TextBox();
            this.crsb = new System.Windows.Forms.TextBox();
            this.prsb = new System.Windows.Forms.TextBox();
            this.cma = new System.Windows.Forms.TextBox();
            this.cmts = new System.Windows.Forms.TextBox();
            this.pzr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ekle_btn
            // 
            this.ekle_btn.BackColor = System.Drawing.Color.White;
            this.ekle_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ekle_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ekle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle_btn.ForeColor = System.Drawing.Color.White;
            this.ekle_btn.Image = ((System.Drawing.Image)(resources.GetObject("ekle_btn.Image")));
            this.ekle_btn.Location = new System.Drawing.Point(173, 472);
            this.ekle_btn.Name = "ekle_btn";
            this.ekle_btn.Size = new System.Drawing.Size(80, 119);
            this.ekle_btn.TabIndex = 5;
            this.ekle_btn.UseVisualStyleBackColor = false;
            this.ekle_btn.Click += new System.EventHandler(this.ekle_btn_Click);
            // 
            // diyetadi
            // 
            this.diyetadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.diyetadi.ForeColor = System.Drawing.Color.LightGray;
            this.diyetadi.Location = new System.Drawing.Point(157, 123);
            this.diyetadi.Name = "diyetadi";
            this.diyetadi.Size = new System.Drawing.Size(117, 26);
            this.diyetadi.TabIndex = 4;
            this.diyetadi.Text = "Diyet Adı";
            this.diyetadi.Enter += new System.EventHandler(this.diyet_Enter);
            this.diyetadi.Leave += new System.EventHandler(this.diyet_Leave);
            // 
            // ediyetcks
            // 
            this.ediyetcks.BackColor = System.Drawing.Color.Transparent;
            this.ediyetcks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ediyetcks.BackgroundImage")));
            this.ediyetcks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ediyetcks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ediyetcks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ediyetcks.ForeColor = System.Drawing.Color.Transparent;
            this.ediyetcks.Location = new System.Drawing.Point(590, 0);
            this.ediyetcks.Name = "ediyetcks";
            this.ediyetcks.Size = new System.Drawing.Size(60, 60);
            this.ediyetcks.TabIndex = 47;
            this.ediyetcks.UseVisualStyleBackColor = false;
            this.ediyetcks.Click += new System.EventHandler(this.anasycks_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 13F);
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(196, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 22);
            this.label1.TabIndex = 48;
            this.label1.Text = "Ekle";
            // 
            // pzt
            // 
            this.pzt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pzt.ForeColor = System.Drawing.Color.LightGray;
            this.pzt.Location = new System.Drawing.Point(157, 165);
            this.pzt.Name = "pzt";
            this.pzt.Size = new System.Drawing.Size(117, 26);
            this.pzt.TabIndex = 49;
            this.pzt.Text = "Pazartesi";
            this.pzt.Enter += new System.EventHandler(this.pzt_Enter);
            this.pzt.Leave += new System.EventHandler(this.pzt_Leave);
            // 
            // sli
            // 
            this.sli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sli.ForeColor = System.Drawing.Color.LightGray;
            this.sli.Location = new System.Drawing.Point(157, 207);
            this.sli.Name = "sli";
            this.sli.Size = new System.Drawing.Size(117, 26);
            this.sli.TabIndex = 50;
            this.sli.Text = "Salı";
            this.sli.Enter += new System.EventHandler(this.sli_Enter);
            this.sli.Leave += new System.EventHandler(this.sli_Leave);
            // 
            // crsb
            // 
            this.crsb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.crsb.ForeColor = System.Drawing.Color.LightGray;
            this.crsb.Location = new System.Drawing.Point(157, 249);
            this.crsb.Name = "crsb";
            this.crsb.Size = new System.Drawing.Size(117, 26);
            this.crsb.TabIndex = 51;
            this.crsb.Text = "Çarşamba";
            this.crsb.Enter += new System.EventHandler(this.crsb_Enter);
            this.crsb.Leave += new System.EventHandler(this.crsb_Leave);
            // 
            // prsb
            // 
            this.prsb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.prsb.ForeColor = System.Drawing.Color.LightGray;
            this.prsb.Location = new System.Drawing.Point(157, 291);
            this.prsb.Name = "prsb";
            this.prsb.Size = new System.Drawing.Size(117, 26);
            this.prsb.TabIndex = 52;
            this.prsb.Text = "Perşembe";
            this.prsb.Enter += new System.EventHandler(this.prsb_Enter);
            this.prsb.Leave += new System.EventHandler(this.prsb_Leave);
            // 
            // cma
            // 
            this.cma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cma.ForeColor = System.Drawing.Color.LightGray;
            this.cma.Location = new System.Drawing.Point(157, 333);
            this.cma.Name = "cma";
            this.cma.Size = new System.Drawing.Size(117, 26);
            this.cma.TabIndex = 53;
            this.cma.Text = "Cuma";
            this.cma.Enter += new System.EventHandler(this.cma_Enter);
            this.cma.Leave += new System.EventHandler(this.cma_Leave);
            // 
            // cmts
            // 
            this.cmts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmts.ForeColor = System.Drawing.Color.LightGray;
            this.cmts.Location = new System.Drawing.Point(157, 375);
            this.cmts.Name = "cmts";
            this.cmts.Size = new System.Drawing.Size(117, 26);
            this.cmts.TabIndex = 54;
            this.cmts.Text = "Cumartesi";
            this.cmts.Enter += new System.EventHandler(this.cmts_Enter);
            this.cmts.Leave += new System.EventHandler(this.cmts_Leave);
            // 
            // pzr
            // 
            this.pzr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pzr.ForeColor = System.Drawing.Color.LightGray;
            this.pzr.Location = new System.Drawing.Point(157, 417);
            this.pzr.Name = "pzr";
            this.pzr.Size = new System.Drawing.Size(117, 26);
            this.pzr.TabIndex = 55;
            this.pzr.Text = "Pazar";
            this.pzr.Enter += new System.EventHandler(this.pzr_Enter);
            this.pzr.Leave += new System.EventHandler(this.pzr_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 20F);
            this.label2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Location = new System.Drawing.Point(141, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 34);
            this.label2.TabIndex = 56;
            this.label2.Text = "Diyet Bilgileri";
            // 
            // ekle_diyet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(212)))), ((int)(((byte)(237)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(650, 650);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pzr);
            this.Controls.Add(this.cmts);
            this.Controls.Add(this.cma);
            this.Controls.Add(this.prsb);
            this.Controls.Add(this.crsb);
            this.Controls.Add(this.sli);
            this.Controls.Add(this.pzt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ediyetcks);
            this.Controls.Add(this.ekle_btn);
            this.Controls.Add(this.diyetadi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ekle_diyet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diyet Ekle";
            this.Load += new System.EventHandler(this.ekle_diyet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ekle_btn;
        private System.Windows.Forms.TextBox diyetadi;
        private System.Windows.Forms.Button ediyetcks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pzt;
        private System.Windows.Forms.TextBox sli;
        private System.Windows.Forms.TextBox crsb;
        private System.Windows.Forms.TextBox prsb;
        private System.Windows.Forms.TextBox cma;
        private System.Windows.Forms.TextBox cmts;
        private System.Windows.Forms.TextBox pzr;
        private System.Windows.Forms.Label label2;
    }
}