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

namespace YemekSiparisTakipOtomasyonu.Forms
{
    public partial class Form11 : KryptonForm
    {
        private Form currentChildForm;
        public int email { get; set; }
        bool sidebarExpand;
        public Form11()
        {
            InitializeComponent();
        }
        void showOrders() 
        {
            //panel555.Visible = true;
        }
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width==sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width==sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void hesabimButton_Click(object sender, EventArgs e)
        {
            UserHesabim userHesabim = new UserHesabim();
            userHesabim.userId = email;
            OpenChildForm(new UserHesabim());
        }
        private void OpenChildForm(Form childForm) 
        {
            //currentChildForm.Close();

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;    
            panel5.Controls.Add(childForm);
            panel5.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonSiparisler_Click(object sender, EventArgs e)
        {
            UserSiparisler userSiparisler = new UserSiparisler();
            userSiparisler.userId = email;
            OpenChildForm(new UserSiparisler());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RestoranlarForm restoranlarForm = new RestoranlarForm();
            OpenChildForm(restoranlarForm);
            //UserControl1 userControl1 = new UserControl1();
            //userControl1.Dock = DockStyle.Fill;
            //panel5.Controls.Clear();
            //panel5.Controls.Add(userControl1);
            //userControl1.BringToFront();
        }
    }
}
