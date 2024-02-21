namespace YemekSiparisTakipOtomasyonu.Forms
{
    partial class UserSiparisler
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
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDurum = new System.Windows.Forms.Label();
            this.labelFiyat = new System.Windows.Forms.Label();
            this.labelTarih = new System.Windows.Forms.Label();
            this.labelRestoran = new System.Windows.Forms.Label();
            this.inceleButton = new Krypton.Toolkit.KryptonButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-1, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 59);
            this.label4.TabIndex = 21;
            this.label4.Text = "SIPARISLER";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.inceleButton);
            this.panel1.Controls.Add(this.labelDurum);
            this.panel1.Controls.Add(this.labelFiyat);
            this.panel1.Controls.Add(this.labelTarih);
            this.panel1.Controls.Add(this.labelRestoran);
            this.panel1.Location = new System.Drawing.Point(379, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 126);
            this.panel1.TabIndex = 22;
            this.panel1.Visible = false;
            // 
            // labelDurum
            // 
            this.labelDurum.AutoSize = true;
            this.labelDurum.BackColor = System.Drawing.Color.White;
            this.labelDurum.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDurum.Location = new System.Drawing.Point(7, 85);
            this.labelDurum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDurum.Name = "labelDurum";
            this.labelDurum.Size = new System.Drawing.Size(225, 25);
            this.labelDurum.TabIndex = 19;
            this.labelDurum.Text = "Sipariş Durumuuuuuuu";
            // 
            // labelFiyat
            // 
            this.labelFiyat.AutoSize = true;
            this.labelFiyat.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiyat.Location = new System.Drawing.Point(7, 60);
            this.labelFiyat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFiyat.Name = "labelFiyat";
            this.labelFiyat.Size = new System.Drawing.Size(160, 25);
            this.labelFiyat.TabIndex = 17;
            this.labelFiyat.Text = "Ürün Fiyatııııııııııı";
            // 
            // labelTarih
            // 
            this.labelTarih.AutoSize = true;
            this.labelTarih.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarih.Location = new System.Drawing.Point(4, 35);
            this.labelTarih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTarih.Name = "labelTarih";
            this.labelTarih.Size = new System.Drawing.Size(308, 25);
            this.labelTarih.TabIndex = 15;
            this.labelTarih.Text = "Tarihhhhhhhhhhhhhhhhhhhhhhhh";
            // 
            // labelRestoran
            // 
            this.labelRestoran.AutoSize = true;
            this.labelRestoran.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRestoran.Location = new System.Drawing.Point(4, 10);
            this.labelRestoran.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRestoran.Name = "labelRestoran";
            this.labelRestoran.Size = new System.Drawing.Size(130, 25);
            this.labelRestoran.TabIndex = 14;
            this.labelRestoran.Text = "Restoran İsmi";
            // 
            // inceleButton
            // 
            this.inceleButton.Location = new System.Drawing.Point(282, 60);
            this.inceleButton.Name = "inceleButton";
            this.inceleButton.Size = new System.Drawing.Size(111, 25);
            this.inceleButton.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.inceleButton.StateCommon.Border.Rounding = 10F;
            this.inceleButton.TabIndex = 23;
            this.inceleButton.Values.Text = "İncele";
            // 
            // UserSiparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Name = "UserSiparisler";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelFiyat;
        private System.Windows.Forms.Label labelTarih;
        private System.Windows.Forms.Label labelRestoran;
        protected System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDurum;
        private Krypton.Toolkit.KryptonButton inceleButton;
    }
}