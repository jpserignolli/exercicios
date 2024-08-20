using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicios
{
    public partial class Peso : Form
    {
        public Peso()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso, soma;

            double mercurio = 0.37, venus = 0.88, marte = 0.38, jupiter = 2.64, saturno = 1.15, urano = 1.17;

            peso = double.Parse(boxPeso.Text);

            if (radioMercurio.Checked)
            {
                soma = peso * mercurio;
                MessageBox.Show("O seu peso em Mercúrio é " + soma + "kg");

            }
            else if (radioVenus.Checked)
            {
                soma = peso * venus;
                MessageBox.Show("O seu peso em Vênus é " + soma + "kg");

            }
            else if (radioMarte.Checked)
            {
                soma = peso * marte;
                MessageBox.Show("O seu peso em Marte é " + soma + "kg");

            }
            else if (radioJupiter.Checked)
            {
                soma = peso * jupiter;
                MessageBox.Show("O seu peso em Júpiter é " + soma + "kg");

            }
            else if (radioSaturno.Checked)
            {
                soma = peso * saturno;
                MessageBox.Show("O seu peso em Saturno é " + soma + "kg");

            }
            else if (radioUrano.Checked)
            {
                soma = peso * urano;
                MessageBox.Show("O seu peso em Urano é " + soma + "kg");

            }
        }
    }
}
