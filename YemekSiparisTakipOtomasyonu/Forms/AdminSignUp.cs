using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Npgsql;

namespace YemekSiparisTakipOtomasyonu.Forms
{
    public partial class AdminSignUp : KryptonForm
    {
        public AdminSignUp()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=dbYemek;User Id=postgres;Password=utku");
        NpgsqlCommand komut;
        NpgsqlDataReader dr;
        DateTime simdi = DateTime.Now;
        string email;
        int adminId;

        private void bttnUyeOl_Click(object sender, EventArgs e)
        {
            Bul();
        }

        private void Kaydet()
        {
            // Diğer kodlar...

            // 1. Admin bilgilerini ekleyin
            baglanti.Open();
            komut = new NpgsqlCommand("INSERT INTO admins (namesurname, email, password_) " +
                "VALUES (@namesurname, @email, @password_) RETURNING id", baglanti);
            komut.Parameters.AddWithValue("@namesurname", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@email", txtEposta.Text);
            komut.Parameters.AddWithValue("@password_", txtSifre.Text);

            // Yeni adminin ID'sini alın
            int adminId = (int)komut.ExecuteScalar();
            baglanti.Close();

            // 2. Kategori ID'sini alın
            baglanti.Open();
            komut = new NpgsqlCommand("SELECT id FROM categories WHERE maincategory = @categoryname", baglanti);
            komut.Parameters.AddWithValue("@categoryname", cmbKategori.Text);  // txtKategori, kullanıcının girdiği kategori ismi
            int categoryId = (int)komut.ExecuteScalar();
            baglanti.Close();

            // 3. Restoran bilgilerini ekleyin
            baglanti.Open();
            komut = new NpgsqlCommand("INSERT INTO restaurants (categoryid, restaurantname, adminid) " +
                "VALUES (@categoryid, @restaurantname, @adminid)", baglanti);
            komut.Parameters.AddWithValue("@adminid", adminId);
            komut.Parameters.AddWithValue("@categoryid", categoryId);  // Yukarıda aldığımız kategori ID'sini kullanın
            komut.Parameters.AddWithValue("@restaurantname", txtRestoranAdi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Üyeliğiniz başarıyla gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Bul()
        {
            email = txtEposta.Text;
            baglanti.Open();
            komut = new NpgsqlCommand("SELECT * FROM users WHERE email='" + email + "'", baglanti);
            dr = komut.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Girmiş olduğunuz e-mail adresi ile üyeliğiniz bulunmaktadır.", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
            }
            else
            {
                baglanti.Close();
                Kaydet();
            }
        }

        private void AdminSignUp_Load(object sender, EventArgs e)
        {
            komut = new NpgsqlCommand("SELECT * FROM categories", baglanti);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataView dv = dt.DefaultView;
            dv.Sort = "maincategory";

            cmbKategori.ValueMember = "id";
            cmbKategori.DisplayMember = "maincategory";
            cmbKategori.DataSource = dt;
        }

        private void lblGirisYap_Click(object sender, EventArgs e)
        {
            AdminLogin form = new AdminLogin();
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
