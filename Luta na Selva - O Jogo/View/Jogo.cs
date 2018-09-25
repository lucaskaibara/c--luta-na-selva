using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class Jogo : Form
    {
        #region Atributos

        Stopwatch sw = new Stopwatch();
        private Animal animalSelecionado;
        private int jogadorVez = 1;
        private String tempoJogo;
        private String[] nomeJogadores = new String[2];

        #endregion

        #region Eventos

        private void tlpTabuleiro_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if ((e.Column == 3 && e.Row == 0) || (e.Column == 3 && e.Row == 8))
                e.Graphics.FillRectangle(Brushes.Green, e.CellBounds);

            else if ((e.Column == 2 && e.Row == 0) || (e.Column == 3 && e.Row == 1) || (e.Column == 4 && e.Row == 0) || (e.Column == 2 && e.Row == 8) || (e.Column == 3 && e.Row == 7) || (e.Column == 4 && e.Row == 8))
                e.Graphics.FillRectangle(Brushes.Brown, e.CellBounds);

            else if ((e.Column == 1 && e.Row == 3) || (e.Column == 2 && e.Row == 3) || (e.Column == 4 && e.Row == 3) || (e.Column == 5 && e.Row == 3) || (e.Column == 1 && e.Row == 4) || (e.Column == 2 && e.Row == 4) || (e.Column == 4 && e.Row == 4) || (e.Column == 5 && e.Row == 4) || (e.Column == 1 && e.Row == 5) || (e.Column == 2 && e.Row == 5) || (e.Column == 4 && e.Row == 5) || (e.Column == 5 && e.Row == 5))
                e.Graphics.FillRectangle(Brushes.Blue, e.CellBounds);            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.tempoJogo = sw.Elapsed.Hours.ToString("00") + ":" + sw.Elapsed.Minutes.ToString("00") + ":" + sw.Elapsed.Seconds.ToString("00");
            labelTempoJogo.Text = this.tempoJogo;
        }

        private void tlpTabuleiro_Click(object sender, EventArgs e)
        {
            if (this.animalSelecionado != null)
                PegarPosicaoRecolocarPeca();
        }

        #endregion

        #region Métodos

        public Jogo(String nomeJogador1, String nomeJogador2)
        {
            InitializeComponent();
            
            this.nomeJogadores[0] = nomeJogador1;
            this.nomeJogadores[1] = nomeJogador2;

            InicializarLabelsNomeJogadores();
            InicializarTimer();
            InicializarPecas();
        }

        private void InicializarLabelsNomeJogadores()
        {
            labelJogadorVez.Text = this.nomeJogadores[0];
            labelNomeJogador1.Text = this.nomeJogadores[0];
            labelNomeJogador2.Text = this.nomeJogadores[1];
            labelNomeJogador1.Location = new Point(((tlpTabuleiro.Width - labelNomeJogador1.Width) / 2) + 10, 90);
            labelNomeJogador2.Location = new Point(((tlpTabuleiro.Width - labelNomeJogador2.Width) / 2) + 10, 640);
        }

        private void InicializarTimer()
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            sw.Start();
        }

        private void InicializarPecas()
        {
            List<Animal> lstAnimal = new AnimalController().InicializarPecas();
            List<int[]> posInicialPecas = new List<int[]> {
                new int[] { 0, 2 }, new int[] { 5, 1 }, new int[] { 1, 1 }, new int[] { 4, 2 },
                new int[] { 2, 2 }, new int[] { 6, 0 }, new int[] { 0, 0 }, new int[] { 6, 2 },
                new int[] { 6, 6 }, new int[] { 1, 7 }, new int[] { 5, 7 }, new int[] { 2, 6 },
                new int[] { 4, 6 }, new int[] { 0, 8 }, new int[] { 6, 8 }, new int[] { 0, 6 }
            };

            foreach (Animal animal in lstAnimal)
                animal.pictureBox.Click += (sender, e) => SelecionarPeca(sender, e, animal);
            
            for (int x = 0; x < tlpTabuleiro.ColumnCount; x++)
            {
                for (int y = 0; y < tlpTabuleiro.RowCount; y++)
                {
                    for (int i = 0; i < 16; i++)
                    {
                        if (x == posInicialPecas[i][0] && y == posInicialPecas[i][1])
                            tlpTabuleiro.Controls.Add(lstAnimal[i].pictureBox, x, y);
                    }
                }
            }
        }

        private void SelecionarPeca(object sender, EventArgs e, Animal animal) {
            if (animal.jogador == this.jogadorVez)
            {
                this.animalSelecionado = animal;

                if (this.animalSelecionado.jogador == 1)
                    labelPecaSelecionada.Text = animal.nome + " (Peça Branca)";

                else
                    labelPecaSelecionada.Text = animal.nome + " (Peça Preta)";   
            }
            else
            {
                if (this.animalSelecionado != null)
                {
                    foreach (PictureBox p in tlpTabuleiro.Controls)
                    {
                        if (p.Name == animal.nome + animal.jogador)
                        {
                            int col = tlpTabuleiro.GetPositionFromControl(p).Column;
                            int row = tlpTabuleiro.GetPositionFromControl(p).Row;

                            List<int[]> lstPosicoesDisponiveis = ListarPosicoesDisponiveisMovimento();

                            foreach (int[] posDisponiveis in lstPosicoesDisponiveis)
                            {
                                if (posDisponiveis[0] == col && posDisponiveis[1] == row)
                                {
                                    if ((((col == 2 && row == 0) || (col == 3 && row == 1) || (col == 4 && row == 0)) && animal.jogador == 2) || (((col == 2 && row == 8) || (col == 3 && row == 7) || (col == 4 && row == 8)) && animal.jogador == 1))
                                    {
                                        RemoverPeca(animal);
                                        PegarPosicaoRecolocarPeca();
                                    }
                                    else
                                    {
                                        if ((animal.nome == "Rato" && this.animalSelecionado.nome == "Elefante") || (animal.nome == "Elefante" && this.animalSelecionado.nome == "Rato"))
                                        {
                                            int[] posAnimalSel = new int[] { tlpTabuleiro.GetPositionFromControl(this.animalSelecionado.pictureBox).Column, tlpTabuleiro.GetPositionFromControl(this.animalSelecionado.pictureBox).Row };
                                            int[] posAnimalAdvSel = new int[] { tlpTabuleiro.GetPositionFromControl(animal.pictureBox).Column, tlpTabuleiro.GetPositionFromControl(animal.pictureBox).Row };

                                            if (!(((posAnimalSel[0] == 1 && posAnimalSel[1] == 3) || (posAnimalSel[0] == 2 && posAnimalSel[1] == 3) || (posAnimalSel[0] == 4 && posAnimalSel[1] == 3) || (posAnimalSel[0] == 5 && posAnimalSel[1] == 3) || (posAnimalSel[0] == 1 && posAnimalSel[1] == 4) || (posAnimalSel[0] == 2 && posAnimalSel[1] == 4) || (posAnimalSel[0] == 4 && posAnimalSel[1] == 4) || (posAnimalSel[0] == 5 && posAnimalSel[1] == 4) || (posAnimalSel[0] == 1 && posAnimalSel[1] == 5) || (posAnimalSel[0] == 2 && posAnimalSel[1] == 5) || (posAnimalSel[0] == 4 && posAnimalSel[1] == 5) || (posAnimalSel[0] == 5 && posAnimalSel[1] == 5)) || ((posAnimalAdvSel[0] == 1 && posAnimalAdvSel[1] == 3) || (posAnimalAdvSel[0] == 2 && posAnimalAdvSel[1] == 3) || (posAnimalAdvSel[0] == 4 && posAnimalAdvSel[1] == 3) || (posAnimalAdvSel[0] == 5 && posAnimalAdvSel[1] == 3) || (posAnimalAdvSel[0] == 1 && posAnimalAdvSel[1] == 4) || (posAnimalAdvSel[0] == 2 && posAnimalAdvSel[1] == 4) || (posAnimalAdvSel[0] == 4 && posAnimalAdvSel[1] == 4) || (posAnimalAdvSel[0] == 5 && posAnimalAdvSel[1] == 4) || (posAnimalAdvSel[0] == 1 && posAnimalAdvSel[1] == 5) || (posAnimalAdvSel[0] == 2 && posAnimalAdvSel[1] == 5) || (posAnimalAdvSel[0] == 4 && posAnimalAdvSel[1] == 5) || (posAnimalAdvSel[0] == 5 && posAnimalAdvSel[1] == 5))))
                                            {
                                                RemoverPeca(animal);
                                                PegarPosicaoRecolocarPeca();
                                            }
                                        }

                                        else if (this.animalSelecionado.valor >= animal.valor)
                                        {
                                            RemoverPeca(animal);
                                            PegarPosicaoRecolocarPeca();
                                        }

                                        else
                                        {
                                            RemoverPeca(this.animalSelecionado);
                                            labelPecaSelecionada.Text = "Nenhum";
                                            this.animalSelecionado = null;
                                            TrocarJogadorVez();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void PegarPosicaoRecolocarPeca()
        {
            int[] posicaoSelecionada = PosicaoXY(tlpTabuleiro, tlpTabuleiro.PointToClient(Cursor.Position));
            RecolocarPeca(posicaoSelecionada);
        }

        private void RemoverPeca(Animal animal)
        {
            foreach (PictureBox p in tlpTabuleiro.Controls)
            {
                if (p == animal.pictureBox)
                    tlpTabuleiro.Controls.Remove(p);
            }
        }

        private int[] PosicaoXY(TableLayoutPanel tlp, Point point)
        {
            int coluna, linha, idx, w = tlp.Width, h = tlp.Height;
            int[] widths = tlpTabuleiro.GetColumnWidths();

            for (idx = widths.Length - 1; idx >= 0 && point.X < w; idx--)
                w -= widths[idx];

            coluna = idx + 1;

            int[] heights = tlp.GetRowHeights();
            for (idx = heights.Length - 1; idx >= 0 && point.Y < h; idx--)
                h -= heights[idx];

            linha = idx + 1;

            return new int[] { coluna, linha };
        }

        private void RecolocarPeca(int[] posicaoSelecionada)
        {
            List<int[]> lstPosicoesDisponiveis = ListarPosicoesDisponiveisMovimento();

            for (int x = 0; x < tlpTabuleiro.ColumnCount; x++)
            {
                for (int y = 0; y < tlpTabuleiro.RowCount; y++)
                {
                    if ((x == posicaoSelecionada[0] && y == posicaoSelecionada[1]))
                    {
                        if ((this.animalSelecionado.jogador == 2 && x == 3 && y == 8) || (this.animalSelecionado.jogador == 1 && x == 3 && y == 0))
                            return;
                    
                        else
                        {
                            foreach (int[] posDisponiveis in lstPosicoesDisponiveis)
                            {
                                if (posDisponiveis[0] == posicaoSelecionada[0] && posDisponiveis[1] == posicaoSelecionada[1])
                                {
                                    if ((x == 1 && y == 3) || (x == 2 && y == 3) || (x == 4 && y == 3) || (x == 5 && y == 3) || (x == 1 && y == 4) || (x == 2 && y == 4) || (x == 4 && y == 4) || (x == 5 && y == 4) || (x == 1 && y == 5) || (x == 2 && y == 5) || (x == 4 && y == 5) || (x == 5 && y == 5))
                                    {
                                        if (this.animalSelecionado.nome == "Rato")
                                        {
                                            AdicionarPeca(posicaoSelecionada[0], posicaoSelecionada[1]);
                                            return;
                                        }
                                    }

                                    else
                                    {
                                        AdicionarPeca(posicaoSelecionada[0], posicaoSelecionada[1]);
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private List<int[]> ListarPosicoesDisponiveisMovimento()
        {
            List<int> lstPosicoes = new List<int>();
            List<int[]> lstPosicoesRato = new List<int[]>();
            List<int[]> lstPosicoesDisponiveis = new List<int[]>();

            foreach (PictureBox p in tlpTabuleiro.Controls)
            {
                if (p.Name == this.animalSelecionado.nome + this.animalSelecionado.jogador)
                {
                    lstPosicoes.Add(tlpTabuleiro.GetPositionFromControl(p).Column);
                    lstPosicoes.Add(tlpTabuleiro.GetPositionFromControl(p).Row);

                    if (this.animalSelecionado.nome == "Tigre" || this.animalSelecionado.nome == "Leão")
                    {
                        foreach (PictureBox pb in tlpTabuleiro.Controls)
                        {
                            if (pb.Name == "Rato1" || pb.Name == "Rato2")
                                lstPosicoesRato.Add(new int[] { tlpTabuleiro.GetPositionFromControl(pb).Column, tlpTabuleiro.GetPositionFromControl(pb).Row });                            
                        }

                        if ((lstPosicoes[0] == 0 && lstPosicoes[1] == 3) || (lstPosicoes[0] == 0 && lstPosicoes[1] == 4) || (lstPosicoes[0] == 0 && lstPosicoes[1] == 5) || (lstPosicoes[0] == 3 && lstPosicoes[1] == 3) || (lstPosicoes[0] == 3 && lstPosicoes[1] == 4) || (lstPosicoes[0] == 3 && lstPosicoes[1] == 5) || (lstPosicoes[0] == 6 && lstPosicoes[1] == 3) || (lstPosicoes[0] == 6 && lstPosicoes[1] == 4) || (lstPosicoes[0] == 6 && lstPosicoes[1] == 5))
                        {
                            lstPosicoesDisponiveis.Add(new int[] { lstPosicoes[0], lstPosicoes[1] - 1 });
                            lstPosicoesDisponiveis.Add(new int[] { lstPosicoes[0], lstPosicoes[1] + 1 });

                            foreach (int[] posicoesRato in lstPosicoesRato)
                            {
                                if (lstPosicoesRato.Count == 0 || lstPosicoes[1] != posicoesRato[1])
                                {
                                    lstPosicoesDisponiveis.Add(new int[] { lstPosicoes[0] + 3, lstPosicoes[1] });
                                    lstPosicoesDisponiveis.Add(new int[] { lstPosicoes[0] - 3, lstPosicoes[1] });
                                }
                                else
                                {
                                    if (!(lstPosicoes[0] + 1 == posicoesRato[0] || lstPosicoes[0] + 2 == posicoesRato[0]))
                                        lstPosicoesDisponiveis.Add(new int[] { lstPosicoes[0] + 3, lstPosicoes[1] });

                                    else if (!(lstPosicoes[0] - 1 == posicoesRato[0] || lstPosicoes[0] - 2 == posicoesRato[0]))
                                        lstPosicoesDisponiveis.Add(new int[] { lstPosicoes[0] - 3, lstPosicoes[1] });                                  
                                }
                            }
                        }

                        else if ((lstPosicoes[0] == 1 && lstPosicoes[1] == 2) || (lstPosicoes[0] == 2 && lstPosicoes[1] == 2) || (lstPosicoes[0] == 4 && lstPosicoes[1] == 2) || (lstPosicoes[0] == 5 && lstPosicoes[1] == 2) || (lstPosicoes[0] == 1 && lstPosicoes[1] == 6) || (lstPosicoes[0] == 2 && lstPosicoes[1] == 6) || (lstPosicoes[0] == 4 && lstPosicoes[1] == 6) || (lstPosicoes[0] == 5 && lstPosicoes[1] == 6))
                        {
                            lstPosicoesDisponiveis.Add(new int[] { lstPosicoes[0] - 1, lstPosicoes[1] });
                            lstPosicoesDisponiveis.Add(new int[] { lstPosicoes[0] + 1, lstPosicoes[1] });

                            foreach (int[] posicoesRato in lstPosicoesRato)
                            {
                                if (lstPosicoesRato.Count == 0 || lstPosicoes[0] != posicoesRato[0])
                                {
                                    lstPosicoesDisponiveis.Add(new int[] { lstPosicoes[0], lstPosicoes[1] + 4 });
                                    lstPosicoesDisponiveis.Add(new int[] { lstPosicoes[0], lstPosicoes[1] - 4 });
                                }
                                else
                                {
                                    if (lstPosicoes[1] + 1 == posicoesRato[1] || lstPosicoes[1] + 2 == posicoesRato[1] || lstPosicoes[1] + 3 == posicoesRato[1])
                                        lstPosicoesDisponiveis.Add(new int[] { lstPosicoes[0], lstPosicoes[1] + 4 });

                                    else if (lstPosicoes[1] - 1 == posicoesRato[1] || lstPosicoes[1] - 2 == posicoesRato[1] || lstPosicoes[1] - 3 == posicoesRato[1])
                                        lstPosicoesDisponiveis.Add(new int[] { lstPosicoes[0], lstPosicoes[1] - 4 });
                                }
                            }
                        }

                        else
                        {
                            lstPosicoesDisponiveis.Add(new int[] { lstPosicoes[0], lstPosicoes[1] - 1 });
                            lstPosicoesDisponiveis.Add(new int[] { lstPosicoes[0], lstPosicoes[1] + 1 });
                            lstPosicoesDisponiveis.Add(new int[] { lstPosicoes[0] - 1, lstPosicoes[1] });
                            lstPosicoesDisponiveis.Add(new int[] { lstPosicoes[0] + 1, lstPosicoes[1] });
                        }
                    }

                    else
                    {
                        lstPosicoesDisponiveis.Add(new int[] { lstPosicoes[0], lstPosicoes[1] - 1 });
                        lstPosicoesDisponiveis.Add(new int[] { lstPosicoes[0], lstPosicoes[1] + 1 });
                        lstPosicoesDisponiveis.Add(new int[] { lstPosicoes[0] - 1, lstPosicoes[1] });
                        lstPosicoesDisponiveis.Add(new int[] { lstPosicoes[0] + 1, lstPosicoes[1] });
                    }
                }
            }

            return lstPosicoesDisponiveis;
        }

        private void AdicionarPeca(int x, int y)
        {
            tlpTabuleiro.Controls.Add(this.animalSelecionado.pictureBox, x, y);
            VerificarGanhouJogo(x, y);
            TrocarJogadorVez();
            this.animalSelecionado = null;
            labelPecaSelecionada.Text = "Nenhum";
            return;
        }
        
        private void TrocarJogadorVez()
        {
            int numPecasJog1 = 0, numPecasJog2 = 0;

            foreach (PictureBox pb in tlpTabuleiro.Controls)
            {
                String pictureBoxName = pb.Name;

                if (Int32.Parse(Regex.Match(pictureBoxName, @"\d+").Value) == 1)
                    numPecasJog1++;

                else if (Int32.Parse(Regex.Match(pictureBoxName, @"\d+").Value) == 2)
                    numPecasJog2++;
            }

            if (numPecasJog1 > 0 && numPecasJog2 > 0)
            {
                if (this.jogadorVez == 1)
                {
                    jogadorVez = 2;
                    labelJogadorVez.Text = nomeJogadores[1];
                }

                else if (jogadorVez == 2)
                {
                    jogadorVez = 1;
                    labelJogadorVez.Text = nomeJogadores[0];
                }
            }
        }

        private void VerificarGanhouJogo(int x, int y)
        {
            if ((this.jogadorVez == 1 && x == 3 && y == 8) || (this.jogadorVez == 2 && x == 3 && y == 0))
            {
                sw.Stop();
                MessageBox.Show("Parabéns " + (this.jogadorVez == 1 ? nomeJogadores[0] : nomeJogadores[1]) + ", você ganhou!\nTempo: " + this.tempoJogo);

                InserirTempoBanco();

                this.Hide();
                new Tempos().Show();
            }
        }

        private void InserirTempoBanco()
        {
            Tempo t = new Tempo();

            t.nomeJogador1 = this.nomeJogadores[0];
            t.nomeJogador2 = this.nomeJogadores[1];
            t.jogadorGanhador = this.jogadorVez;
            t.tempoJogo = TimeSpan.Parse(this.tempoJogo);
            
            new TempoController().Incluir(t);
        }

        #endregion
    }
}
