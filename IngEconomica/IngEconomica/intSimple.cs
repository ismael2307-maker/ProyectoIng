using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngEconomica
{
    public partial class intSimple : Form
    {
        public intSimple()
        {
            InitializeComponent();
        }

        // Calcular valor futuro
        private void txtValorPresente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTasaInteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPeriodo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtValorPresente.Text = "";
            txtTasaInteres.Text = "";
            txtPeriodo.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double p, i, n,f;
            double i1, n1,i2;

            try
            {
              p = double.Parse(txtValorPresente.Text);
             i1 = double.Parse(txtTasaInteres.Text);
             n1 = double.Parse(txtPeriodo.Text);

                if (cmbInteres.SelectedItem != null && cmbPeriodo.SelectedItem != null)
                {
                    if (cmbInteres.SelectedItem.Equals("Anual") || cmbPeriodo.SelectedItem.Equals("Meses"))
                    {
                        i = i1 / 100;
                        n = n1 / 12;
                        f = p * (1 + (i * n));

                        int N =  dtgvResultados.Rows.Add();

                        dtgvResultados.Rows[N].Cells[0].Value = p;
                        dtgvResultados.Rows[N].Cells[1].Value = i;
                        dtgvResultados.Rows[N].Cells[2].Value = n;
                        dtgvResultados.Rows[N].Cells[3].Value = f;
                    }

                    if (cmbInteres.SelectedItem.Equals("Mensual") && cmbPeriodo.SelectedItem.Equals("Años"))
                    {
                        i2 = i1 / 100;
                        i = i2 / 12;
                        n = n1;
                        f = p * (1 + (i * n));

                        int N = dtgvResultados.Rows.Add();

                        dtgvResultados.Rows[N].Cells[0].Value = p;
                        dtgvResultados.Rows[N].Cells[1].Value = i;
                        dtgvResultados.Rows[N].Cells[2].Value = n;
                        dtgvResultados.Rows[N].Cells[3].Value = f;
                    }

                    if (cmbInteres.SelectedItem.Equals("Anual") && cmbPeriodo.SelectedItem.Equals("Años"))
                    {
                        i = i1 / 100;
                        n = n1;
                        f = p * (1 + (i * n));

                        int N = dtgvResultados.Rows.Add();

                        dtgvResultados.Rows[N].Cells[0].Value = p;
                        dtgvResultados.Rows[N].Cells[1].Value = i;
                        dtgvResultados.Rows[N].Cells[2].Value = n;
                        dtgvResultados.Rows[N].Cells[3].Value = f;
                    }

                    if (cmbInteres.SelectedItem.Equals("Mensual") && cmbPeriodo.SelectedItem.Equals("Meses")) 
                    {
                        i = i1 / 100;
                        n = n1;
                        f = p * (1 + (i * n));
                    }
                }
            }catch(FormatException x){

                MessageBox.Show("Rellene los campos necesarios " +x);
            }
        }

        //Calcular Valor Presente

        private void button2_Click(object sender, EventArgs e)
        {
            double p, i, n, f;
            double i1, n1;

            try
            {
                f = double.Parse(txtValorFuturo.Text);
                i1 = double.Parse(txtTasaInteresP.Text);
                n1 = double.Parse(txtPeriodoP.Text);

                if (cmbInteresP.SelectedItem != null && cmbPeriodoP.SelectedItem != null)
                {
                    if (cmbInteresP.SelectedItem.Equals("Anual") || cmbPeriodoP.SelectedItem.Equals("Años"))
                    {
                        i = i1 / 100;
                        n = n1;
                        p = f / (1 + (i * n));

                        int s = dtgvResultados.Rows.Add();

                        dtvgResultadosP.Rows[s].Cells[0].Value = f;
                        dtvgResultadosP.Rows[s].Cells[1].Value = i;
                        dtvgResultadosP.Rows[s].Cells[2].Value = n;
                        dtvgResultadosP.Rows[s].Cells[3].Value = p;
                    }
                }

            }catch(FormatException x)
            {
                MessageBox.Show("Rellene los campos necesarios" + x);
            }
        }

        private void txtLimpiarP_Click(object sender, EventArgs e)
        {
            txtValorFuturo.Text = "";
            txtTasaInteresP.Text = "";
            txtPeriodoP.Text = "";
        }

        private void txtValorFuturo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTasaInteresP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPeriodoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
