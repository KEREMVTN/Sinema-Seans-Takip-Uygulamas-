using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class MüsteriForm : Form
    {
        public MüsteriForm()
        {
            InitializeComponent();
        }

        SinemaEntities2 db = new SinemaEntities2();   
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridMüsteri.DataSource = (from x in db.Müşteri
                                           select new
                                           {
                                               x.Müsteri_Id,
                                               x.Müsteri_Ad,
                                               x.Bilet_Aralıgı,
                                               x.Bilet_Sayısı,
                                               x.Film.Film_Adı,
                                               x.Salon.Salon_Adı,


                                           }).ToList();

            Film_cmb.DisplayMember = "Film_Adı";
            Film_cmb.ValueMember = "Film_Id";

            Film_cmb.DataSource = db.Film.ToList();

            Salon_cmb.DisplayMember = "Salon_Adı";
            Salon_cmb.ValueMember = "Salon_Id";

            Salon_cmb.DataSource = db.Salon.ToList();

        }

        private void Film_btn_Click(object sender, EventArgs e)
        {
            FilmForm form = new FilmForm();
            form.Show();
        }

        private void Salon_btn_Click(object sender, EventArgs e)
        {
            SalonForm form = new SalonForm();
            form.Show();
        }

        private void Yenile_btn_Click(object sender, EventArgs e)
        {
            dataGridMüsteri.DataSource = (from x in db.Müşteri
                                          select new
                                          {
                                              x.Müsteri_Id,
                                              x.Müsteri_Ad,
                                              x.Bilet_Aralıgı,
                                              x.Bilet_Sayısı,
                                              x.Film.Film_Adı,
                                              x.Salon.Salon_Adı,


                                          }).ToList();
        }

        private void dataGridMüsteri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridMüsteri.SelectedCells[0].RowIndex;
            Müşteri müsteri = new Müşteri();

            label6.Text = dataGridMüsteri.Rows[selected].Cells[0].Value.ToString();
            AdSoyad_txt.Text = dataGridMüsteri.Rows[selected].Cells[1].Value.ToString();
            BiletAralıgı_txt.Text = dataGridMüsteri.Rows[selected].Cells[2].Value.ToString();
            BiletSys_txt.Text = dataGridMüsteri.Rows[selected].Cells[3].Value.ToString();
            Film_cmb.Text = dataGridMüsteri.Rows[selected].Cells[4].Value.ToString();
            Salon_cmb.Text = dataGridMüsteri.Rows[selected].Cells[5].Value.ToString();
        }

        private void Ekle_btn_Click(object sender, EventArgs e)
        {
            Müşteri müsteri = new Müşteri();
            müsteri.Müsteri_Ad = AdSoyad_txt.Text;
            müsteri.Bilet_Sayısı = int.Parse(BiletSys_txt.Text);
            müsteri.Bilet_Aralıgı = BiletAralıgı_txt.Text;
            müsteri.Film_Id = (int)Film_cmb.SelectedValue;
            müsteri.Salon_Id = (int)Salon_cmb.SelectedValue;
            db.Müşteri.Add(müsteri);
            db.SaveChanges();
            MessageBox.Show("Müşteri Eklendi");
        }

        private void Güncelle_btn_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(label6.Text);
            var müsteri = db.Müşteri.Find(x);
            müsteri.Müsteri_Ad = AdSoyad_txt.Text;
            müsteri.Bilet_Sayısı = int.Parse(BiletSys_txt.Text);
            müsteri.Bilet_Aralıgı = BiletAralıgı_txt.Text;
            müsteri.Film_Id = (int)Film_cmb.SelectedValue;
            müsteri.Salon_Id = (int)Salon_cmb.SelectedValue;
            db.SaveChanges();
            MessageBox.Show("Müşteri Güncellendi");
        }

        private void Sil_btn_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(label6.Text);
            var müsteri = db.Müşteri.Find(x);
            db.Müşteri.Remove(müsteri);
            db.SaveChanges();
            MessageBox.Show("Müşteri Silindi");
        }
    }
}
