
namespace Tasarım_Mimarisi
{
    partial class admin_paneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_paneli));
            this.cikis_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hasta_btn = new System.Windows.Forms.Button();
            this.diyetis_btn = new System.Windows.Forms.Button();
            this.tum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cikis_btn
            // 
            this.cikis_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis_btn.Location = new System.Drawing.Point(625, 42);
            this.cikis_btn.Name = "cikis_btn";
            this.cikis_btn.Size = new System.Drawing.Size(129, 31);
            this.cikis_btn.TabIndex = 0;
            this.cikis_btn.Text = "Çıkış Yap";
            this.cikis_btn.UseVisualStyleBackColor = true;
            this.cikis_btn.Click += new System.EventHandler(this.cikis_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(715, 278);
            this.dataGridView1.TabIndex = 1;
            // 
            // hasta_btn
            // 
            this.hasta_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hasta_btn.Location = new System.Drawing.Point(39, 381);
            this.hasta_btn.Name = "hasta_btn";
            this.hasta_btn.Size = new System.Drawing.Size(191, 31);
            this.hasta_btn.TabIndex = 2;
            this.hasta_btn.Text = "Hastalar";
            this.hasta_btn.UseVisualStyleBackColor = true;
            this.hasta_btn.Click += new System.EventHandler(this.hasta_btn_Click);
            // 
            // diyetis_btn
            // 
            this.diyetis_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.diyetis_btn.Location = new System.Drawing.Point(548, 381);
            this.diyetis_btn.Name = "diyetis_btn";
            this.diyetis_btn.Size = new System.Drawing.Size(206, 31);
            this.diyetis_btn.TabIndex = 3;
            this.diyetis_btn.Text = "Diyetisyenler";
            this.diyetis_btn.UseVisualStyleBackColor = true;
            this.diyetis_btn.Click += new System.EventHandler(this.diyetis_btn_Click);
            // 
            // tum
            // 
            this.tum.AutoSize = true;
            this.tum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tum.Location = new System.Drawing.Point(34, 43);
            this.tum.Name = "tum";
            this.tum.Size = new System.Drawing.Size(157, 25);
            this.tum.TabIndex = 4;
            this.tum.Text = "Tüm Kullanıcılar:";
            // 
            // admin_paneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tum);
            this.Controls.Add(this.diyetis_btn);
            this.Controls.Add(this.hasta_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cikis_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "admin_paneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cikis_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button hasta_btn;
        private System.Windows.Forms.Button diyetis_btn;
        private System.Windows.Forms.Label tum;
    }
}