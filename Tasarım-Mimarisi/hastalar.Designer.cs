
namespace Tasarım_Mimarisi
{
    partial class hastalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hastalar));
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.cikis_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adminpcks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView3.Location = new System.Drawing.Point(49, 81);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(467, 192);
            this.dataGridView3.TabIndex = 0;
            // 
            // cikis_btn
            // 
            this.cikis_btn.BackColor = System.Drawing.Color.White;
            this.cikis_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikis_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikis_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis_btn.ForeColor = System.Drawing.Color.Transparent;
            this.cikis_btn.Image = ((System.Drawing.Image)(resources.GetObject("cikis_btn.Image")));
            this.cikis_btn.Location = new System.Drawing.Point(453, 294);
            this.cikis_btn.Name = "cikis_btn";
            this.cikis_btn.Size = new System.Drawing.Size(63, 54);
            this.cikis_btn.TabIndex = 4;
            this.cikis_btn.UseVisualStyleBackColor = false;
            this.cikis_btn.Click += new System.EventHandler(this.cikis_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 12F);
            this.label4.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Location = new System.Drawing.Point(466, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Geri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 14F);
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(44, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tüm Hastalar:";
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
            this.adminpcks.TabIndex = 20;
            this.adminpcks.UseVisualStyleBackColor = false;
            this.adminpcks.Click += new System.EventHandler(this.adminpcks_Click);
            // 
            // hastalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(566, 566);
            this.Controls.Add(this.adminpcks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cikis_btn);
            this.Controls.Add(this.dataGridView3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "hastalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastalar";
            this.Load += new System.EventHandler(this.hastalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button cikis_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adminpcks;
    }
}