using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class NomeJogadores : Form
    {
        public NomeJogadores()
        {
            InitializeComponent();
        }

        private void btnVoltarTelaInicial_Click(object sender, EventArgs e)
        {
            this.Close();
            new TelaInicial().Show();
        }

        private void btnIniciarJogo_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                this.Hide();
                new Jogo(inputJogador1.Text, inputJogador2.Text).Show();
            }
        }

        private bool Validar()
        {
            if (String.IsNullOrEmpty(inputJogador1.Text))
            {
                MessageBox.Show("Por favor, preencha o campo de nome do Jogador 1.");
                inputJogador1.Focus();
                return false;
            }

            else if (String.IsNullOrEmpty(inputJogador2.Text))
            {
                MessageBox.Show("Por favor, preencha o campo de nome do Jogador 2.");
                inputJogador2.Focus();
                return false;
            }

            return true;
        }
    }
}
