using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YemekSiparisTakipOtomasyonu.Forms
{
    public partial class UserHesabim : Form
    {
        public int userId { get; set; }
        public UserHesabim()
        {
            InitializeComponent();
            Goster();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=dbYemek;User Id=postgres;Password=utku");

        public void Goster()
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("SELECT * FROM users WHERE id=@id", baglanti);
            komut.Parameters.AddWithValue("@id", 1);
            NpgsqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                txtAd.Text = dr["namesurname"].ToString();
                txtEPosta.Text = dr["email"].ToString();
                txtSifre.Text = dr["password_"].ToString();
                txtTelefon.Text = dr["telno"].ToString();
            }
            baglanti.Close();
        }

        private void bttnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("UPDATE users SET namesurname=@namesurname, email=@email, password_=@password_, telno=@telno WHERE id=@id", baglanti);
            komut.Parameters.AddWithValue("@id", 1);

            komut.Parameters.AddWithValue("@namesurname", txtAd.Text);
            komut.Parameters.AddWithValue("@password_", txtSifre.Text) ;
            komut.Parameters.AddWithValue("@email",txtEPosta.Text);
            komut.Parameters.AddWithValue("@telno", txtTelefon.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Güncellendi");
            // This parameter is used in the WHERE clause to identify the user to update
            //komut.Parameters.AddWithValue("@oldEmail", "ali.veli@email.com");
        }
    }
}
