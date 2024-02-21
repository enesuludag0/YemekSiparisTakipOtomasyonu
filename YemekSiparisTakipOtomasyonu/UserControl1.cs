using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YemekSiparisTakipOtomasyonu
{
    public partial class UserControl1 : UserControl
    {
        public class Reastaurant
        {
            public string reastaurantName;
        }
        public UserControl1()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=dbYemek;User Id=postgres;Password=utku");
        List<Reastaurant> reastaurantList = new List<Reastaurant>();
        List<Panel> panelList = new List<Panel>();
        private void txtRestoranAra_TextChanged(object sender, EventArgs e)
        {
            ClearPanels();
            try
            {
                baglanti.Open();

                // Check if the text box is empty
                if (string.IsNullOrEmpty(txtRestoranAra.Text))
                {
                    ClearPanels();
                }
                else
                {
                    NpgsqlCommand komut = new NpgsqlCommand("SELECT restaurantname FROM restaurants WHERE restaurantname LIKE @restaurantname", baglanti);
                    komut.Parameters.AddWithValue("@restaurantname", "%" + txtRestoranAra.Text + "%");
                    // Ensure the previous reader is closed before executing a new command
                    if (baglanti.State == ConnectionState.Open)
                    {
                        baglanti.Close();
                    }
                    baglanti.Open(); // Reopen the connection after closing it                
                    reastaurantList.Clear(); // Move this line outside of the while loop

                    using (NpgsqlDataReader dr = komut.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Reastaurant reastaurant = new Reastaurant();
                            reastaurant.reastaurantName = dr["restaurantname"].ToString();
                            reastaurantList.Add(reastaurant);
                        }
                    }

                    // Call Create() after retrieving all restaurants
                    Create();
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions here
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is closed in the finally block
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }
        public void Create()
        {
            for (int i = 0; i < reastaurantList.Count; i++)
            {
                Panel pnl = new Panel();
                pnl.Location = new Point(17, 50 + (i * 105));
                pnl.BorderStyle = panel1.BorderStyle;
                pnl.BackColor = panel1.BackColor;
                pnl.Size = panel1.Size;
                pnl.Visible = true;

                foreach (Control c in panel1.Controls)
                {
                    Control c2;

                    if (c.GetType() == typeof(Krypton.Toolkit.KryptonButton))
                    {
                        Krypton.Toolkit.KryptonButton originalButton = (Krypton.Toolkit.KryptonButton)c;

                        Krypton.Toolkit.KryptonButton newButton = new Krypton.Toolkit.KryptonButton();
                        newButton.Text = "İncele";  // Set the Text property here
                        newButton.StateCommon.Border.Rounding = originalButton.StateCommon.Border.Rounding;
                        // newButton.Click += new EventHandler(kryptonButton1_Click);
                        c2 = newButton;
                    }
                    else if (c.GetType() == typeof(Label))
                    {
                        c2 = new Label();
                        c2.Font = c.Font;

                        if (c.Name == "labelRestoran")
                        {
                            ((Label)c2).Text = reastaurantList[i].reastaurantName;
                        }
                        else if (c.Name == "labelKategori")
                        {
                            ((Label)c2).Text = "Kategori";
                        }
                        else if (c.Name == "labelAdres")
                        {
                            ((Label)c2).Text = "Adres";
                        }

                    }
                    else
                        c2 = new Control();

                    c2.Location = c.Location;
                    c2.Size = c.Size;
                    pnl.Controls.Add(c2);
                }
                panelList.Add(pnl);
                panelMain.Controls.Add(pnl);
            }
        }
        private void ClearPanels()
        {
            panelList.Clear();
            panelMain.Controls.Clear();
        }
    }
}
