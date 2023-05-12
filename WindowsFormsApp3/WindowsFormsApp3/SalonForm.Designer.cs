namespace WindowsFormsApp3
{
    partial class SalonForm
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
            this.dataGridSalon = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SalonAd_txt = new System.Windows.Forms.TextBox();
            this.KoltukSys_txt = new System.Windows.Forms.TextBox();
            this.Kaydet_btn = new System.Windows.Forms.Button();
            this.Sil_btn = new System.Windows.Forms.Button();
            this.Yenile_btn = new System.Windows.Forms.Button();
            this.Güncelle_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSalon)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridSalon
            // 
            this.dataGridSalon.AllowUserToResizeColumns = false;
            this.dataGridSalon.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridSalon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSalon.Location = new System.Drawing.Point(12, 141);
            this.dataGridSalon.Name = "dataGridSalon";
            this.dataGridSalon.Size = new System.Drawing.Size(550, 423);
            this.dataGridSalon.TabIndex = 14;
            this.dataGridSalon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSalon_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "Koltuk Kapasitesi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Salon Adı";
            // 
            // SalonAd_txt
            // 
            this.SalonAd_txt.BackColor = System.Drawing.Color.Bisque;
            this.SalonAd_txt.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SalonAd_txt.Location = new System.Drawing.Point(220, 6);
            this.SalonAd_txt.Name = "SalonAd_txt";
            this.SalonAd_txt.Size = new System.Drawing.Size(342, 39);
            this.SalonAd_txt.TabIndex = 11;
            // 
            // KoltukSys_txt
            // 
            this.KoltukSys_txt.BackColor = System.Drawing.Color.Bisque;
            this.KoltukSys_txt.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KoltukSys_txt.Location = new System.Drawing.Point(220, 51);
            this.KoltukSys_txt.Name = "KoltukSys_txt";
            this.KoltukSys_txt.Size = new System.Drawing.Size(342, 39);
            this.KoltukSys_txt.TabIndex = 17;
            // 
            // Kaydet_btn
            // 
            this.Kaydet_btn.BackColor = System.Drawing.Color.Bisque;
            this.Kaydet_btn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kaydet_btn.Location = new System.Drawing.Point(12, 96);
            this.Kaydet_btn.Name = "Kaydet_btn";
            this.Kaydet_btn.Size = new System.Drawing.Size(133, 39);
            this.Kaydet_btn.TabIndex = 32;
            this.Kaydet_btn.Text = "Kaydet";
            this.Kaydet_btn.UseVisualStyleBackColor = false;
            this.Kaydet_btn.Click += new System.EventHandler(this.Kaydet_btn_Click);
            // 
            // Sil_btn
            // 
            this.Sil_btn.BackColor = System.Drawing.Color.Bisque;
            this.Sil_btn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sil_btn.Location = new System.Drawing.Point(290, 96);
            this.Sil_btn.Name = "Sil_btn";
            this.Sil_btn.Size = new System.Drawing.Size(133, 39);
            this.Sil_btn.TabIndex = 33;
            this.Sil_btn.Text = "Sil";
            this.Sil_btn.UseVisualStyleBackColor = false;
            this.Sil_btn.Click += new System.EventHandler(this.Sil_btn_Click);
            // 
            // Yenile_btn
            // 
            this.Yenile_btn.BackColor = System.Drawing.Color.Bisque;
            this.Yenile_btn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yenile_btn.Location = new System.Drawing.Point(429, 96);
            this.Yenile_btn.Name = "Yenile_btn";
            this.Yenile_btn.Size = new System.Drawing.Size(133, 39);
            this.Yenile_btn.TabIndex = 34;
            this.Yenile_btn.Text = "Yenile";
            this.Yenile_btn.UseVisualStyleBackColor = false;
            this.Yenile_btn.Click += new System.EventHandler(this.Yenile_btn_Click);
            // 
            // Güncelle_btn
            // 
            this.Güncelle_btn.BackColor = System.Drawing.Color.Bisque;
            this.Güncelle_btn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Güncelle_btn.Location = new System.Drawing.Point(151, 96);
            this.Güncelle_btn.Name = "Güncelle_btn";
            this.Güncelle_btn.Size = new System.Drawing.Size(133, 39);
            this.Güncelle_btn.TabIndex = 35;
            this.Güncelle_btn.Text = "Güncelle";
            this.Güncelle_btn.UseVisualStyleBackColor = false;
            this.Güncelle_btn.Click += new System.EventHandler(this.Güncelle_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(693, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "label3";
            // 
            // SalonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(579, 576);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Güncelle_btn);
            this.Controls.Add(this.Yenile_btn);
            this.Controls.Add(this.Sil_btn);
            this.Controls.Add(this.Kaydet_btn);
            this.Controls.Add(this.KoltukSys_txt);
            this.Controls.Add(this.dataGridSalon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SalonAd_txt);
            this.Name = "SalonForm";
            this.Text = "SalonEkle";
            this.Load += new System.EventHandler(this.SalonEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSalon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSalon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SalonAd_txt;
        private System.Windows.Forms.TextBox KoltukSys_txt;
        private System.Windows.Forms.Button Kaydet_btn;
        private System.Windows.Forms.Button Sil_btn;
        private System.Windows.Forms.Button Yenile_btn;
        private System.Windows.Forms.Button Güncelle_btn;
        private System.Windows.Forms.Label label3;
    }
}