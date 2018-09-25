using Controller;
using Model;
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
    public partial class Tempos : Form
    {
        public Tempos()
        {
            InitializeComponent();
            CarregarTempos();
        }

        private void CarregarTempos()
        {
            List<Tempo> lstTempos = new TempoController().ListarTempos();

            dgvTempos.Rows.Clear();

            for (int i = 0; i < lstTempos.Count; i++)
            {
                String jogadores = lstTempos[i].nomeJogador1 + " vs " + lstTempos[i].nomeJogador2;
                String vencedor;

                if (lstTempos[i].jogadorGanhador == 1)
                    vencedor = lstTempos[i].nomeJogador1;

                else
                    vencedor = lstTempos[i].nomeJogador1;

                dgvTempos.Rows.Add(
                    lstTempos[i].codTempo,
                    jogadores,
                    vencedor,
                    lstTempos[i].tempoJogo
                );
            }
        }

        private void btnVoltarTelaInicial_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TelaInicial().Show();
        }
    }
}
