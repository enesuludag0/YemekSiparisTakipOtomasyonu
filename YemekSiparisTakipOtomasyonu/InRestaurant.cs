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

namespace YemekSiparisTakipOtomasyonu
{
    public partial class InRestaurant : Form
    {
        public class Food 
        {
            public string foodName;
            public string foodDescription;
            public double foodPrice;
            public string category;
        }
        public InRestaurant()
        {
            InitializeComponent();
            AddFoodsToList();
            AddCategoriesToList();
            ListFoods();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=dbYemek;User Id=postgres;Password=utku");
        List<Food> foodList = new List<Food>();
        List<String> categoryList = new List<String>();

        public void AddFoodsToList() 
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand komut = new NpgsqlCommand("SELECT foodname, unitprice, description, category FROM foods WHERE restaurantid=@restaurantid ORDER BY category", baglanti);
                komut.Parameters.AddWithValue("restaurantid", 1);
                NpgsqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    Food food = new Food();
                    food.foodName = dr["foodname"].ToString();
                    food.foodDescription = dr["description"].ToString();
                    food.foodPrice = Convert.ToDouble(dr["unitprice"]);
                    food.category = dr["category"].ToString();
                    foodList.Add(food);
                }
            }
            finally
            {
                baglanti.Close();
            }
        }
        public void AddCategoriesToList() 
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand komut = new NpgsqlCommand("SELECT category FROM foods WHERE restaurantid=@restaurantid ORDER BY category", baglanti);
                komut.Parameters.AddWithValue("restaurantid", 1);
                NpgsqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    categoryList.Add(dr["category"].ToString());
                    Debug.WriteLine(dr["category"].ToString());
                }
            }
            finally
            {
                baglanti.Close();
            }
        }
        public void ListFoods() 
        {
            for (int i = 0; i < foodList.Count; i++)
            {
                
                Panel pnl = new Panel();
                pnl.Location = new Point(1, 181 + (i * 105));
                PutLabel(i, 181 + (i * 105));
                pnl.BorderStyle = panelYemek.BorderStyle;
                pnl.BackColor = panelYemek.BackColor;
                pnl.Size = panelYemek.Size;
                pnl.Visible = true;

                foreach (Control c in panelYemek.Controls)
                {
                    Control c2;

                    if (c.GetType() == typeof(Krypton.Toolkit.KryptonButton))
                    {
                        Krypton.Toolkit.KryptonButton originalButton = (Krypton.Toolkit.KryptonButton)c;

                        Krypton.Toolkit.KryptonButton newButton = new Krypton.Toolkit.KryptonButton();
                        newButton.Text = "Sepete Ekle";  // Set the Text property here
                        newButton.StateCommon.Border.Rounding = originalButton.StateCommon.Border.Rounding;
                       // newButton.Click += new EventHandler(kryptonButton1_Click);
                        c2 = newButton;
                    }
                   else if (c.GetType() == typeof(Label))
                    {
                        c2 = new Label();
                        c2.Font = c.Font;

                        if (c.Name == "labelYemekAd")
                        {
                            ((Label)c2).Text = foodList[i].foodName;
                        }
                        else if (c.Name == "labelAciklama")
                        {
                            ((Label)c2).Text = foodList[i].foodDescription;
                        }
                        else if (c.Name == "labelFiyat")
                        {
                            ((Label)c2).Text = foodList[i].foodPrice.ToString() + "TL";
                        }      
                    }
                    else
                        c2 = new Control();

                    c2.Location = c.Location;
                    c2.Size = c.Size;
                    pnl.Controls.Add(c2);
                }
                this.Controls.Add(pnl);
            }
        }
        public void PutCategory() 
        {
            int k = 0;
            for(int i=0; i<categoryList.Count; i++) 
            {
                
                if(i == 0)
                {
                    Label label = new Label();
                    label.Text = categoryList[k];
                    label.Font = new Font("Arial", 12, FontStyle.Bold);
                    label.Location = new Point(556, 150);
                    this.Controls.Add(label);
                }
                else if (categoryList[i] == categoryList[k])
                {

                }
                else
                { 
                    k = i;
                    Label label = new Label();
                    label.Text = categoryList[k];
                    label.Font = new Font("Arial", 12, FontStyle.Bold);
                    label.Location = new Point(556, 170);
                    this.Controls.Add(label);
                }
            }
        }
        public Label PutLabel(int i, int location) 
        {
            if (i == 0) 
            {
                Label label = new Label();
                label.Text = categoryList[i];
                label.Font = new Font("Arial", 12, FontStyle.Bold);
                label.Location = new Point(1, location - 10);
                this.Controls.Add(label);
                return label;
            }
            else if (categoryList[i-1] != foodList[i].category) 
            {
                Label label = new Label();
                label.Text = categoryList[i];
                label.Font = new Font("Arial", 12, FontStyle.Bold);
                label.Location = new Point(1, location - 10);
                this.Controls.Add(label);
                return label;
            }
            return null;
        }
        public void ListFoodsByCategory()
        {
            // Assuming your categories are stored in categoryList
            foreach (string category in categoryList)
            {
                // Create a label for the category
                Label categoryLabel = new Label();
                categoryLabel.Text = category;
                categoryLabel.Font = new Font("Arial", 12, FontStyle.Bold);
                categoryLabel.Location = new Point(3, 284); // Adjust the location as needed
                this.Controls.Add(categoryLabel);

                // Find foods in the current category
                var foodsInCategory = foodList.Where(food => food.category == category).ToList();

                // Create a panel for the foods in the category
                Panel categoryPanel = new Panel();
                categoryPanel.Location = new Point(3, 284); // Adjust the location as needed
                categoryPanel.BorderStyle = panelRestoran.BorderStyle;
                categoryPanel.BackColor = panelRestoran.BackColor;
                categoryPanel.Size = panelRestoran.Size;
                categoryPanel.Visible = true;

                // Create controls for each food in the category
                for (int i = 0; i < foodsInCategory.Count; i++)
                {
                    foreach (Control c in panelRestoran.Controls)
                    {
                        Control c2 = CreateControl(c, i, foodsInCategory);
                        categoryPanel.Controls.Add(c2);
                    }
                }

                // Adjust the vertical position for the next category
                categoryPanel.Top += categoryPanel.Height;
            }
        }

        private Control CreateControl(Control originalControl, int index, List<Food> foodsInCategory)
        {
            Control newControl;

            if (originalControl.GetType() == typeof(Label))
            {
                newControl = new Label();
                newControl.Font = originalControl.Font;

                if (originalControl.Name == "labelYemekAd")
                {
                    ((Label)newControl).Text = foodsInCategory[index].foodName;
                }
                else if (originalControl.Name == "labelAciklama")
                {
                    ((Label)newControl).Text = "Tarih: " + foodsInCategory[index].foodDescription;
                }
                else if (originalControl.Name == "labelFiyat")
                {
                    ((Label)newControl).Text = foodsInCategory[index].foodPrice.ToString() + "TL";
                }
            }
            else
            {
                // Handle other control types if needed
                newControl = new Control();
            }

            newControl.Location = originalControl.Location;
            newControl.Size = originalControl.Size;

            return newControl;
        }

    }
}
