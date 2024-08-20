using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicios
{
    public partial class Resultados : Form
    {

        //Declaração Variáveis//
        private TextBox[] textBoxes;
        private Label[] labels;
        private string[] nomesTimes;

        public Resultados()
        {
            InitializeComponent();

            //Inicializar Vetores//
            textBoxes = new TextBox[]
            {
                txt1, txt2, txt03, txt4, txt5, txt6, txt7, txt8, txt9, txt10, txt11, txt12
                 
            };

            labels = new Label[] {
                lblResul1, lblResul2, lblResul3, lblResul4, lblResul5, lblResul6
            };

            nomesTimes = new string[]
            {
                "Corinthians","Palmeiras",
                "Chapecoense","Vasco da Gama",
                "Santos","Paysandu","Vitória",
                "Bahia","Internacional","Grêmio",
                "Avaí", "Joinville"
            };
            //Fim Inicialização//
           
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            int[] resultados = new int[12];
            try
            {
                for (int i = 0; i < 12; i++)
                {
                    resultados[i] = int.Parse(textBoxes[i].Text);
                }
            }

            //Mensagem pra informar ao usuário digitar todos os resultados//
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira números válidos para os resultados.");
                return;
            }

            //Determinar os Times Vencedores de cada Partida//
            for (int i = 0; i<6; i++)
            {
                int time1 = resultados[i * 2];
                int time2 = resultados[(i * 2) + 1];

                if (time1 > time2)
                {
                    labels[i].Text = $"{nomesTimes[i * 2]}";

                }
                else if (time1 < time2)
                {
                    labels[i].Text = $"{nomesTimes [i * 2 + 1]}";
                }
                else
                {
                    labels[i].Text = "Empate";
                }

            }








            
        }

        private void Resultados_Load(object sender, EventArgs e)
        {

        }
    }
}
