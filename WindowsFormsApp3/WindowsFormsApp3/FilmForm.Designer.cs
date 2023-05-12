namespace WindowsFormsApp3
{
    partial class FilmForm
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
            this.dataGridFilm = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SeansSaati_txt = new System.Windows.Forms.TextBox();
            this.FilmAdı_txt = new System.Windows.Forms.TextBox();
            this.Salon_cmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Güncelle_btn = new System.Windows.Forms.Button();
            this.Yenile_btn = new System.Windows.Forms.Button();
            this.Sil_btn = new System.Windows.Forms.Button();
            this.Kaydet_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridFilm
            // 
            this.dataGridFilm.AllowUserToResizeColumns = false;
            this.dataGridFilm.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFilm.Location = new System.Drawing.Point(12, 192);
            this.dataGridFilm.Name = "dataGridFilm";
            this.dataGridFilm.Size = new System.Drawing.Size(549, 380);
            this.dataGridFilm.TabIndex = 9;
            this.dataGridFilm.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFilm_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seans Saati";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Film Adı";
            // 
            // SeansSaati_txt
            // 
            this.SeansSaati_txt.BackColor = System.Drawing.Color.Bisque;
            this.SeansSaati_txt.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SeansSaati_txt.Location = new System.Drawing.Point(156, 57);
            this.SeansSaati_txt.Name = "SeansSaati_txt";
            this.SeansSaati_txt.Size = new System.Drawing.Size(267, 39);
            this.SeansSaati_txt.TabIndex = 6;
            // 
            // FilmAdı_txt
            // 
            this.FilmAdı_txt.BackColor = System.Drawing.Color.Bisque;
            this.FilmAdı_txt.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FilmAdı_txt.Location = new System.Drawing.Point(156, 12);
            this.FilmAdı_txt.Name = "FilmAdı_txt";
            this.FilmAdı_txt.Size = new System.Drawing.Size(267, 39);
            this.FilmAdı_txt.TabIndex = 5;
            // 
            // Salon_cmb
            // 
            this.Salon_cmb.BackColor = System.Drawing.Color.Bisque;
            this.Salon_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Salon_cmb.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Salon_cmb.FormattingEnabled = true;
            this.Salon_cmb.Location = new System.Drawing.Point(156, 102);
            this.Salon_cmb.Name = "Salon_cmb";
            this.Salon_cmb.Size = new System.Drawing.Size(267, 39);
            this.Salon_cmb.TabIndex = 10;
            this.Salon_cmb.SelectedIndexChanged += new System.EventHandler(this.Salon_cmb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Salon";
            // 
            // Güncelle_btn
            // 
            this.Güncelle_btn.BackColor = System.Drawing.Color.Bisque;
            this.Güncelle_btn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Güncelle_btn.Location = new System.Drawing.Point(151, 147);
            this.Güncelle_btn.Name = "Güncelle_btn";
            this.Güncelle_btn.Size = new System.Drawing.Size(133, 39);
            this.Güncelle_btn.TabIndex = 39;
            this.Güncelle_btn.Text = "Güncelle";
            this.Güncelle_btn.UseVisualStyleBackColor = false;
            this.Güncelle_btn.Click += new System.EventHandler(this.Güncelle_btn_Click);
            // 
            // Yenile_btn
            // 
            this.Yenile_btn.BackColor = System.Drawing.Color.Bisque;
            this.Yenile_btn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yenile_btn.Location = new System.Drawing.Point(428, 147);
            this.Yenile_btn.Name = "Yenile_btn";
            this.Yenile_btn.Size = new System.Drawing.Size(133, 39);
            this.Yenile_btn.TabIndex = 38;
            this.Yenile_btn.Text = "Yenile";
            this.Yenile_btn.UseVisualStyleBackColor = false;
            this.Yenile_btn.Click += new System.EventHandler(this.Yenile_btn_Click);
            // 
            // Sil_btn
            // 
            this.Sil_btn.BackColor = System.Drawing.Color.Bisque;
            this.Sil_btn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sil_btn.Location = new System.Drawing.Point(290, 147);
            this.Sil_btn.Name = "Sil_btn";
            this.Sil_btn.Size = new System.Drawing.Size(133, 39);
            this.Sil_btn.TabIndex = 37;
            this.Sil_btn.Text = "Sil";
            this.Sil_btn.UseVisualStyleBackColor = false;
            this.Sil_btn.Click += new System.EventHandler(this.Sil_btn_Click);
            // 
            // Kaydet_btn
            // 
            this.Kaydet_btn.BackColor = System.Drawing.Color.Bisque;
            this.Kaydet_btn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kaydet_btn.Location = new System.Drawing.Point(12, 147);
            this.Kaydet_btn.Name = "Kaydet_btn";
            this.Kaydet_btn.Size = new System.Drawing.Size(133, 39);
            this.Kaydet_btn.TabIndex = 36;
            this.Kaydet_btn.Text = "Kaydet";
            this.Kaydet_btn.UseVisualStyleBackColor = false;
            this.Kaydet_btn.Click += new System.EventHandler(this.Kaydet_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Tan;
            this.label4.Location = new System.Drawing.Point(486, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "label4";
            // 
            // FilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(575, 591);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Güncelle_btn);
            this.Controls.Add(this.Yenile_btn);
            this.Controls.Add(this.Sil_btn);
            this.Controls.Add(this.Kaydet_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Salon_cmb);
            this.Controls.Add(this.dataGridFilm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SeansSaati_txt);
            this.Controls.Add(this.FilmAdı_txt);
            this.Name = "FilmForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFilm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridFilm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SeansSaati_txt;
        private System.Windows.Forms.TextBox FilmAdı_txt;
        private System.Windows.Forms.ComboBox Salon_cmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Güncelle_btn;
        private System.Windows.Forms.Button Yenile_btn;
        private System.Windows.Forms.Button Sil_btn;
        private System.Windows.Forms.Button Kaydet_btn;
        private System.Windows.Forms.Label label4;
    }
}