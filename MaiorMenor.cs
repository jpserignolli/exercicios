using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicios
{
    public partial class MaiorMenor : Form
    {
        public MaiorMenor()
        {
            InitializeComponent();

        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Verifica se todos os campos de texto estão preenchidos
            if (string.IsNullOrWhiteSpace(boxValor1.Text) ||
                string.IsNullOrWhiteSpace(boxValor2.Text) ||
                string.IsNullOrWhiteSpace(boxValor3.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos de valor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int numero, numero2, numero3;

            // Converte os valores dos campos de texto para inteiros
            try
            {
                numero = int.Parse(boxValor1.Text);
                numero2 = int.Parse(boxValor2.Text);
                numero3 = int.Parse(boxValor3.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira apenas números válidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calcula o maior valor
            if (numero > numero2 && numero > numero3)
            {
                boxMaior.Text = numero.ToString();
            }
            else if (numero2 > numero && numero2 > numero3)
            {
                boxMaior.Text = numero2.ToString();
            }
            else
            {
                boxMaior.Text = numero3.ToString();
            }

            // Calcula o menor valor
            if (numero < numero2 && numero < numero3)
            {
                boxMenor.Text = numero.ToString();
            }
            else if (numero2 < numero && numero2 < numero3)
            {
                boxMenor.Text = numero2.ToString();
            }
            else
            {
                boxMenor.Text = numero3.ToString();
            }
        }
    }
}
