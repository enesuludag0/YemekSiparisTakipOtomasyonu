﻿namespace YemekSiparisTakipOtomasyonu
{
    partial class RestoranlarForm
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
            this.txtRestoranAra = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelRestoran = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelKategori = new System.Windows.Forms.Label();
            this.labelAdres = new System.Windows.Forms.Label();
            this.inceleButton = new Krypton.Toolkit.KryptonButton();
            this.panel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRestoranAra
            // 
            this.txtRestoranAra.Location = new System.Drawing.Point(222, 13);
            this.txtRestoranAra.Margin = new System.Windows.Forms.Padding(4);
            this.txtRestoranAra.Name = "txtRestoranAra";
            this.txtRestoranAra.Size = new System.Drawing.Size(300, 39);
            this.txtRestoranAra.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtRestoranAra.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.txtRestoranAra.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.txtRestoranAra.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtRestoranAra.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtRestoranAra.StateCommon.Border.Rounding = 20;
            this.txtRestoranAra.StateCommon.Border.Width = 1;
            this.txtRestoranAra.StateCommon.Content.Color1 = System.Drawing.SystemColors.ControlText;
            this.txtRestoranAra.StateCommon.Content.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestoranAra.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtRestoranAra.TabIndex = 11;
            this.txtRestoranAra.TextChanged += new System.EventHandler(this.txtRestoranAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Restoran Ara:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.inceleButton);
            this.panel1.Controls.Add(this.labelAdres);
            this.panel1.Controls.Add(this.labelKategori);
            this.panel1.Controls.Add(this.labelRestoran);
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 100);
            this.panel1.TabIndex = 9;
            // 
            // labelRestoran
            // 
            this.labelRestoran.AutoSize = true;
            this.labelRestoran.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRestoran.Location = new System.Drawing.Point(4, 9);
            this.labelRestoran.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRestoran.Name = "labelRestoran";
            this.labelRestoran.Size = new System.Drawing.Size(118, 23);
            this.labelRestoran.TabIndex = 25;
            this.labelRestoran.Text = "Restoran Ara:";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Location = new System.Drawing.Point(12, 59);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(769, 395);
            this.panelMain.TabIndex = 25;
            // 
            // labelKategori
            // 
            this.labelKategori.AutoSize = true;
            this.labelKategori.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKategori.Location = new System.Drawing.Point(4, 32);
            this.labelKategori.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKategori.Name = "labelKategori";
            this.labelKategori.Size = new System.Drawing.Size(79, 23);
            this.labelKategori.TabIndex = 26;
            this.labelKategori.Text = "Kategori";
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdres.Location = new System.Drawing.Point(4, 55);
            this.labelAdres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(56, 23);
            this.labelAdres.TabIndex = 27;
            this.labelAdres.Text = "Adres";
            // 
            // inceleButton
            // 
            this.inceleButton.Location = new System.Drawing.Point(184, 32);
            this.inceleButton.Name = "inceleButton";
            this.inceleButton.Size = new System.Drawing.Size(111, 25);
            this.inceleButton.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.inceleButton.StateCommon.Border.Rounding = 10F;
            this.inceleButton.TabIndex = 28;
            this.inceleButton.Values.Text = "İncele";
            // 
            // RestoranlarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(811, 495);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRestoranAra);
            this.Name = "RestoranlarForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtRestoranAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelRestoran;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.Label labelKategori;
        private Krypton.Toolkit.KryptonButton inceleButton;
    }
}