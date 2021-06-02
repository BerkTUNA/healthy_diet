
namespace Tasarım_Mimarisi
{
    partial class rapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rapor));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.anasycks = new System.Windows.Forms.Button();
            this.cikis_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(209, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(207, 304);
            this.dataGridView1.TabIndex = 7;
            // 
            // anasycks
            // 
            this.anasycks.BackColor = System.Drawing.Color.Transparent;
            this.anasycks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("anasycks.BackgroundImage")));
            this.anasycks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.anasycks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anasycks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anasycks.ForeColor = System.Drawing.Color.Transparent;
            this.anasycks.Location = new System.Drawing.Point(720, -1);
            this.anasycks.Name = "anasycks";
            this.anasycks.Size = new System.Drawing.Size(55, 58);
            this.anasycks.TabIndex = 11;
            this.anasycks.UseVisualStyleBackColor = false;
            this.anasycks.Click += new System.EventHandler(this.anasycks_Click);
            // 
            // cikis_btn
            // 
            this.cikis_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cikis_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cikis_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikis_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikis_btn.Font = new System.Drawing.Font("Impact", 12F);
            this.cikis_btn.ForeColor = System.Drawing.Color.Transparent;
            this.cikis_btn.Image = ((System.Drawing.Image)(resources.GetObject("cikis_btn.Image")));
            this.cikis_btn.Location = new System.Drawing.Point(-3, -1);
            this.cikis_btn.Name = "cikis_btn";
            this.cikis_btn.Size = new System.Drawing.Size(63, 54);
            this.cikis_btn.TabIndex = 18;
            this.cikis_btn.UseVisualStyleBackColor = false;
            this.cikis_btn.Click += new System.EventHandler(this.cikis_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Impact", 12F);
            this.label7.ForeColor = System.Drawing.Color.CadetBlue;
            this.label7.Location = new System.Drawing.Point(354, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Rapor Al";
            // 
            // rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(181)))), ((int)(((byte)(155)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(772, 517);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cikis_btn);
            this.Controls.Add(this.anasycks);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapor Al";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button anasycks;
        private System.Windows.Forms.Button cikis_btn;
        private System.Windows.Forms.Label label7;
    }
}