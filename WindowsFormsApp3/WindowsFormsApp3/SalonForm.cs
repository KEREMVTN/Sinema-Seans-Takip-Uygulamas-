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
    public partial class SalonForm : Form
    {
        public SalonForm()
        {
            InitializeComponent();
        }
        SinemaEntities2 db = new SinemaEntities2();
        private void SalonEkle_Load(object sender, EventArgs e)
        {
            dataGridSalon.DataSource = (from x in db.Salon
                                       select new
                                       {
                                           x.Salon_Id,
                                           x.Salon_Adı,
                                           x.Koltuk_Sayısı,


                                       }).ToList();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Yenile_btn_Click(object sender, EventArgs e)
        {
            dataGridSalon.DataSource = (from x in db.Salon
                                        select new
                                        {
                                            x.Salon_Id,
                                            x.Salon_Adı,
                                            x.Koltuk_Sayısı,


                                        }).ToList();
        }

        private void Kaydet_btn_Click(object sender, EventArgs e)
        {
            Salon salon = new Salon();
            salon.Salon_Adı = SalonAd_txt.Text;
            salon.Koltuk_Sayısı = int.Parse(KoltukSys_txt.Text.ToString());
            db.Salon.Add(salon);
            db.SaveChanges();
            MessageBox.Show("Salon Eklendi");
        }

        private void dataGridSalon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridSalon.SelectedCells[0].RowIndex;
            Salon salon = new Salon();

            label3.Text = dataGridSalon.Rows[selected].Cells[0].Value.ToString();
            SalonAd_txt.Text = dataGridSalon.Rows[selected].Cells[1].Value.ToString();
            KoltukSys_txt.Text = dataGridSalon.Rows[selected].Cells[2].Value.ToString();

            
            
        }

        private void Güncelle_btn_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(label3.Text);
            var salon = db.Salon.Find(x);
            salon.Salon_Adı = SalonAd_txt.Text;
            salon.Koltuk_Sayısı = int.Parse(KoltukSys_txt.Text.ToString());
            db.SaveChanges();
            MessageBox.Show("Salon Güncellendi");
        }

        private void Sil_btn_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(label3.Text);
            var salon = db.Salon.Find(x);
            db.Salon.Remove(salon);
            db.SaveChanges();
            MessageBox.Show("Salon Silindi");
        }
    }
}
