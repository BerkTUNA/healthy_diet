﻿
namespace Tasarım_Mimarisi
{
    partial class diyetisyenler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(diyetisyenler));
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.ekle_diyetis = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cikis_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adminpcks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView4.Location = new System.Drawing.Point(49, 81);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.Size = new System.Drawing.Size(467, 168);
            this.dataGridView4.TabIndex = 0;
            // 
            // ekle_diyetis
            // 
            this.ekle_diyetis.BackColor = System.Drawing.Color.Transparent;
            this.ekle_diyetis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ekle_diyetis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekle_diyetis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle_diyetis.ForeColor = System.Drawing.Color.Transparent;
            this.ekle_diyetis.Image = ((System.Drawing.Image)(resources.GetObject("ekle_diyetis.Image")));
            this.ekle_diyetis.Location = new System.Drawing.Point(72, 270);
            this.ekle_diyetis.Name = "ekle_diyetis";
            this.ekle_diyetis.Size = new System.Drawing.Size(97, 132);
            this.ekle_diyetis.TabIndex = 6;
            this.ekle_diyetis.UseVisualStyleBackColor = false;
            this.ekle_diyetis.Click += new System.EventHandler(this.ekle_diyetis_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 12F);
            this.label4.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Location = new System.Drawing.Point(473, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Geri";
            // 
            // cikis_btn
            // 
            this.cikis_btn.BackColor = System.Drawing.Color.White;
            this.cikis_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikis_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikis_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis_btn.ForeColor = System.Drawing.Color.Transparent;
            this.cikis_btn.Image = ((System.Drawing.Image)(resources.GetObject("cikis_btn.Image")));
            this.cikis_btn.Location = new System.Drawing.Point(462, 270);
            this.cikis_btn.Name = "cikis_btn";
            this.cikis_btn.Size = new System.Drawing.Size(57, 53);
            this.cikis_btn.TabIndex = 20;
            this.cikis_btn.UseVisualStyleBackColor = false;
            this.cikis_btn.Click += new System.EventHandler(this.cikis_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 14F);
            this.label2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Location = new System.Drawing.Point(44, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tüm Diyetisyenler:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 12F);
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(52, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Yeni Diyetisyen Ekle";
            // 
            // adminpcks
            // 
            this.adminpcks.BackColor = System.Drawing.Color.Transparent;
            this.adminpcks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adminpcks.BackgroundImage")));
            this.adminpcks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminpcks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminpcks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminpcks.ForeColor = System.Drawing.Color.Transparent;
            this.adminpcks.Location = new System.Drawing.Point(526, 0);
            this.adminpcks.Name = "adminpcks";
            this.adminpcks.Size = new System.Drawing.Size(40, 40);
            this.adminpcks.TabIndex = 23;
            this.adminpcks.UseVisualStyleBackColor = false;
            this.adminpcks.Click += new System.EventHandler(this.adminpcks_Click);
            // 
            // diyetisyenler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(566, 566);
            this.Controls.Add(this.adminpcks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cikis_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ekle_diyetis);
            this.Controls.Add(this.dataGridView4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "diyetisyenler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diyetisyenler";
            this.Load += new System.EventHandler(this.diyetisyenler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button ekle_diyetis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cikis_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adminpcks;
    }
}