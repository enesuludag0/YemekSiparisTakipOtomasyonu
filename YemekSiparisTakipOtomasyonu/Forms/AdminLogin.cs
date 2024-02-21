using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Npgsql;

namespace YemekSiparisTakipOtomasyonu.Forms
{
    public partial class AdminLogin : KryptonForm
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=dbYemek;User Id=postgres;Password=utku");

        private void bttnGirisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("SELECT * FROM admin WHERE email=@email " +
                "AND password_=@password_", baglanti);
            komut.Parameters.AddWithValue("@email", txtEposta.Text);
            komut.Parameters.AddWithValue("@password_", txtSifre.Text);
            NpgsqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                Form2 form = new Form2();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("E-mail adresi veya şifrenizi yanlış girdiniz.\n\tLütfen tekrar deneyiniz.", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();
        }


        private void lblUyeOl_Click(object sender, EventArgs e)
        {
            AdminSignUp form = new AdminSignUp();
            form.Show();
            this.Hide();
        }

        private void lblKullaniciGirisi_Click(object sender, EventArgs e)
        {
            UserLogin form = new UserLogin();
            form.Show();
            this.Hide();
        }

        private void checkBoxSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSifreGoster.Checked)
            {
                txtSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '●';
            }
        }
    }
}
