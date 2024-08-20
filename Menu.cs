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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Resultados resultados = new Resultados();
            resultados.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MaiorMenor mm = new MaiorMenor();
            mm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Peso pe = new Peso();
            pe.Show();
        }
    }
}
