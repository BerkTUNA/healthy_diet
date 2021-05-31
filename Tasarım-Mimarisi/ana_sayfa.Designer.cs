
namespace Tasarım_Mimarisi
{
    partial class ana_sayfa
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.yeni_btn = new System.Windows.Forms.Button();
            this.rapor_btn = new System.Windows.Forms.Button();
            this.diyet_btn = new System.Windows.Forms.Button();
            this.hastalık_btn = new System.Windows.Forms.Button();
            this.diyet_planı = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.filtre = new System.Windows.Forms.Label();
            this.cikis_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(732, 291);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tüm Hastalar:";
            // 
            // yeni_btn
            // 
            this.yeni_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeni_btn.Location = new System.Drawing.Point(34, 389);
            this.yeni_btn.Name = "yeni_btn";
            this.yeni_btn.Size = new System.Drawing.Size(98, 49);
            this.yeni_btn.TabIndex = 2;
            this.yeni_btn.Text = "Yeni Hasta Ekle";
            this.yeni_btn.UseVisualStyleBackColor = true;
            this.yeni_btn.Click += new System.EventHandler(this.yeni_btn_Click);
            // 
            // rapor_btn
            // 
            this.rapor_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rapor_btn.Location = new System.Drawing.Point(192, 389);
            this.rapor_btn.Name = "rapor_btn";
            this.rapor_btn.Size = new System.Drawing.Size(98, 49);
            this.rapor_btn.TabIndex = 3;
            this.rapor_btn.Text = "Rapor Al";
            this.rapor_btn.UseVisualStyleBackColor = true;
            this.rapor_btn.Click += new System.EventHandler(this.rapor_btn_Click);
            // 
            // diyet_btn
            // 
            this.diyet_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.diyet_btn.Location = new System.Drawing.Point(350, 389);
            this.diyet_btn.Name = "diyet_btn";
            this.diyet_btn.Size = new System.Drawing.Size(98, 49);
            this.diyet_btn.TabIndex = 4;
            this.diyet_btn.Text = "Diyet Ata";
            this.diyet_btn.UseVisualStyleBackColor = true;
            this.diyet_btn.Click += new System.EventHandler(this.diyet_btn_Click);
            // 
            // hastalık_btn
            // 
            this.hastalık_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastalık_btn.Location = new System.Drawing.Point(508, 389);
            this.hastalık_btn.Name = "hastalık_btn";
            this.hastalık_btn.Size = new System.Drawing.Size(98, 49);
            this.hastalık_btn.TabIndex = 5;
            this.hastalık_btn.Text = "Yeni Hastalık Ekle";
            this.hastalık_btn.UseVisualStyleBackColor = true;
            this.hastalık_btn.Click += new System.EventHandler(this.hastalık_btn_Click);
            // 
            // diyet_planı
            // 
            this.diyet_planı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.diyet_planı.Location = new System.Drawing.Point(666, 389);
            this.diyet_planı.Name = "diyet_planı";
            this.diyet_planı.Size = new System.Drawing.Size(98, 49);
            this.diyet_planı.TabIndex = 6;
            this.diyet_planı.Text = "Yeni Diyet Planı";
            this.diyet_planı.UseVisualStyleBackColor = true;
            this.diyet_planı.Click += new System.EventHandler(this.diyet_planı_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(617, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // filtre
            // 
            this.filtre.AutoSize = true;
            this.filtre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filtre.Location = new System.Drawing.Point(551, 90);
            this.filtre.Name = "filtre";
            this.filtre.Size = new System.Drawing.Size(60, 20);
            this.filtre.TabIndex = 8;
            this.filtre.Text = "Filtrele:";
            // 
            // cikis_btn
            // 
            this.cikis_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis_btn.Location = new System.Drawing.Point(666, 40);
            this.cikis_btn.Name = "cikis_btn";
            this.cikis_btn.Size = new System.Drawing.Size(98, 26);
            this.cikis_btn.TabIndex = 9;
            this.cikis_btn.Text = "Çıkış Yap";
            this.cikis_btn.UseVisualStyleBackColor = true;
            this.cikis_btn.Click += new System.EventHandler(this.cikis_btn_Click);
            // 
            // ana_sayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.cikis_btn);
            this.Controls.Add(this.filtre);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.diyet_planı);
            this.Controls.Add(this.hastalık_btn);
            this.Controls.Add(this.diyet_btn);
            this.Controls.Add(this.rapor_btn);
            this.Controls.Add(this.yeni_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ana_sayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yeni_btn;
        private System.Windows.Forms.Button rapor_btn;
        private System.Windows.Forms.Button diyet_btn;
        private System.Windows.Forms.Button hastalık_btn;
        private System.Windows.Forms.Button diyet_planı;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label filtre;
        private System.Windows.Forms.Button cikis_btn;
    }
}