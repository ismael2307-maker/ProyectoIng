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
    public partial class interes : Form
    {
        public interes()
        {
            InitializeComponent();
        }

        private void txtValorPresente_TextChanged(object sender, EventArgs e)
        {
            //Ignorar
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Ignorar
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Ignorar
        }

        private void txtValorPresente_KeyPress(object sender, KeyPressEventArgs e)
        {
             if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
             {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
             }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double P,i=0,I=0,n=0;
            double i1, i2;
            double n1;

            try
            {
                 P = double.Parse(txtValorPresente.Text);
                i1 = double.Parse(textBox1.Text);
                n1 = double.Parse(textBox2.Text);

                if (cmbInteres.SelectedItem != null && cmbPeriodo.SelectedItem != null)
                {

                    if (cmbInteres.SelectedItem.Equals("Anual") || cmbPeriodo.SelectedItem.Equals("Meses"))
                    {
                        i = i1 / 100;
                        n = n1 / 12;
                        I = P * i * n;

                        int N = dtgvResultados.Rows.Add();

                        dtgvResultados.Rows[N].Cells[0].Value = P;
                        dtgvResultados.Rows[N].Cells[1].Value = i;
                        dtgvResultados.Rows[N].Cells[2].Value = n;
                        dtgvResultados.Rows[N].Cells[3].Value = I;

                    }
                    if (cmbInteres.SelectedItem.Equals("Mensual") && cmbPeriodo.SelectedItem.Equals("Años"))
                    {
                        i = i1 / 12;
                        n = n1;
                        I = P * i * n;
                        int N = dtgvResultados.Rows.Add();
                        dtgvResultados.Rows[N].Cells[0].Value = P;
                        dtgvResultados.Rows[N].Cells[1].Value = i;
                        dtgvResultados.Rows[N].Cells[2].Value = n;
                        dtgvResultados.Rows[N].Cells[3].Value = I;

                    }
                    if (cmbInteres.SelectedItem.Equals("Anual") && cmbPeriodo.SelectedItem.Equals("Años"))
                    {
                        i = i1 / 100;
                        n = n1;
                        I = P * i * n;
                        int N = dtgvResultados.Rows.Add();
                        dtgvResultados.Rows[N].Cells[0].Value = P;
                        dtgvResultados.Rows[N].Cells[1].Value = i;
                        dtgvResultados.Rows[N].Cells[2].Value = n;
                        dtgvResultados.Rows[N].Cells[3].Value = I;

                    }
                    if (cmbInteres.SelectedItem.Equals("Mensual") && cmbPeriodo.SelectedItem.Equals("Meses"))
                    {
                        i = i1 / 12;
                        n = n1;

                        int N = dtgvResultados.Rows.Add();
                        dtgvResultados.Rows[N].Cells[0].Value = P;
                        dtgvResultados.Rows[N].Cells[1].Value = i;
                        dtgvResultados.Rows[N].Cells[2].Value = n;
                        dtgvResultados.Rows[N].Cells[3].Value = I;
                    }

                }
            }
            catch (FormatException x)
            {
                MessageBox.Show("Rellene los campos necesarios");
            }
        }
    }
}
