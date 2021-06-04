
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
            this.diyet = new System.Windows.Forms.TextBox();
            this.ediyetcks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.ekle_btn.Location = new System.Drawing.Point(80, 144);
            this.ekle_btn.Name = "ekle_btn";
            this.ekle_btn.Size = new System.Drawing.Size(80, 119);
            this.ekle_btn.TabIndex = 5;
            this.ekle_btn.UseVisualStyleBackColor = false;
            this.ekle_btn.Click += new System.EventHandler(this.ekle_btn_Click);
            // 
            // diyet
            // 
            this.diyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.diyet.Location = new System.Drawing.Point(64, 73);
            this.diyet.Name = "diyet";
            this.diyet.Size = new System.Drawing.Size(117, 26);
            this.diyet.TabIndex = 4;
            this.diyet.Enter += new System.EventHandler(this.diyet_Enter);
            this.diyet.Leave += new System.EventHandler(this.diyet_Leave);
            // 
            // ediyetcks
            // 
            this.ediyetcks.BackColor = System.Drawing.Color.Transparent;
            this.ediyetcks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ediyetcks.BackgroundImage")));
            this.ediyetcks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ediyetcks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ediyetcks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ediyetcks.ForeColor = System.Drawing.Color.Transparent;
            this.ediyetcks.Location = new System.Drawing.Point(313, -1);
            this.ediyetcks.Name = "ediyetcks";
            this.ediyetcks.Size = new System.Drawing.Size(31, 30);
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
            this.label1.Location = new System.Drawing.Point(100, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 22);
            this.label1.TabIndex = 48;
            this.label1.Text = "Ekle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 13F);
            this.label2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Location = new System.Drawing.Point(82, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 49;
            this.label2.Text = "Diyet Adı";
            // 
            // ekle_diyet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(212)))), ((int)(((byte)(237)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(345, 290);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ediyetcks);
            this.Controls.Add(this.ekle_btn);
            this.Controls.Add(this.diyet);
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
        private System.Windows.Forms.TextBox diyet;
        private System.Windows.Forms.Button ediyetcks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}