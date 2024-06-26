﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace IngEconomica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            pnlSubMenuInteres.Visible = false;
            pnlSubMenuAnualidades.Visible = false;
            pnlSubMenuIndicadores.Visible = false;
        }

        private void hideSubMenu()
        {
            if(pnlSubMenuInteres.Visible == true)
                pnlSubMenuInteres.Visible = false;
            if (pnlSubMenuAnualidades.Visible == true)
                pnlSubMenuAnualidades.Visible=false;
            if (pnlSubMenuIndicadores.Visible == true)
                pnlSubMenuIndicadores.Visible=false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnInteres_Click(object sender, EventArgs e)
        {
            
            showSubMenu(pnlSubMenuInteres);
        }

        private void btnInteres2_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new interes());
            hideSubMenu();
        }

        private void btnInteresSimple_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new intSimple());
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new intCompuesto());
            hideSubMenu();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnInteresCompuesto_Paint(object sender, PaintEventArgs e)
        {
            //Ignorar de mientras
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAnualidades_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Presentacion2());
            showSubMenu(pnlSubMenuAnualidades);
        }

        private void btnAnualidadesVencidas_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnAnualidadesAnticipadas_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnAnualidadesDiferidas_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnPresentacion_Click(null, e);
        }

        private void AbrirFormHija(object formhija)
        {
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock= DockStyle.Fill;
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;    
            fh.Show();

        }

        private void btnPresentacion_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Presentacion());
        }
    }
}
