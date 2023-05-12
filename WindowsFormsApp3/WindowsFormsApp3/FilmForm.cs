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
    public partial class FilmForm : Form
    {
        public FilmForm()
        {
            InitializeComponent();
        }

        
        SinemaEntities2 db = new SinemaEntities2();
        private void Form2_Load_1(object sender, EventArgs e)
        {
            dataGridFilm.DataSource = (from x in db.Film
                                          select new
                                          {
                                              x.Film_Id,
                                              x.Film_Adı,
                                              x.Seans_Saati,
                                              x.Salon.Salon_Adı,


                                          }).ToList();

            Salon_cmb.DisplayMember = "Salon_Adı";
            Salon_cmb.ValueMember = "Salon_Id";

            Salon_cmb.DataSource = db.Salon.ToList();
        }

        private void Yenile_btn_Click(object sender, EventArgs e)
        {
            dataGridFilm.DataSource = (from x in db.Film
                                       select new
                                       {
                                           x.Film_Id,
                                           x.Film_Adı,
                                           x.Seans_Saati,
                                           x.Salon.Salon_Adı,


                                       }).ToList();
        }

        private void Güncelle_btn_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(label4.Text);
            var film = db.Film.Find(x);
            film.Film_Adı = FilmAdı_txt.Text;
            film.Seans_Saati = SeansSaati_txt.Text;
            film.Salon_Id = (int)Salon_cmb.SelectedValue;
            db.SaveChanges();
            MessageBox.Show("Film Güncellendi");
        }

        private void Sil_btn_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(label4.Text);
            var film = db.Film.Find(x);
            db.Film.Remove(film);
            db.SaveChanges();
            MessageBox.Show("Film Silindi");
        }

        private void Kaydet_btn_Click(object sender, EventArgs e)
        {
            Film film = new Film();
            film.Film_Adı = FilmAdı_txt.Text;
            film.Seans_Saati = SeansSaati_txt.Text;
            film.Salon_Id = (int)Salon_cmb.SelectedValue;
            db.Film.Add(film);
            db.SaveChanges();
            MessageBox.Show("Film Eklendi");
        }

        private void dataGridFilm_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridFilm.SelectedCells[0].RowIndex;
            Film film = new Film();

            label4.Text = dataGridFilm.Rows[selected].Cells[0].Value.ToString();
            FilmAdı_txt.Text = dataGridFilm.Rows[selected].Cells[1].Value.ToString();
            SeansSaati_txt.Text = dataGridFilm.Rows[selected].Cells[2].Value.ToString();
            Salon_cmb.Text = dataGridFilm.Rows[selected].Cells[3].Value.ToString();
        }

        private void Salon_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
