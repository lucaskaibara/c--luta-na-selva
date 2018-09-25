namespace View
{
    partial class Jogo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTempo = new System.Windows.Forms.Label();
            this.labelTempoJogo = new System.Windows.Forms.Label();
            this.tlpTabuleiro = new System.Windows.Forms.TableLayoutPanel();
            this.labelNomeJogador1Titulo = new System.Windows.Forms.Label();
            this.labelNomeJogador2Titulo = new System.Windows.Forms.Label();
            this.labelNomeJogador1 = new System.Windows.Forms.Label();
            this.labelNomeJogador2 = new System.Windows.Forms.Label();
            this.labelJogadorVezTitulo = new System.Windows.Forms.Label();
            this.labelJogadorVez = new System.Windows.Forms.Label();
            this.labelPecaSelecionadaTitulo = new System.Windows.Forms.Label();
            this.labelPecaSelecionada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTempo
            // 
            this.labelTempo.AutoSize = true;
            this.labelTempo.Location = new System.Drawing.Point(12, 9);
            this.labelTempo.Name = "labelTempo";
            this.labelTempo.Size = new System.Drawing.Size(43, 13);
            this.labelTempo.TabIndex = 0;
            this.labelTempo.Text = "Tempo:";
            // 
            // labelTempoJogo
            // 
            this.labelTempoJogo.AutoSize = true;
            this.labelTempoJogo.Location = new System.Drawing.Point(116, 9);
            this.labelTempoJogo.Name = "labelTempoJogo";
            this.labelTempoJogo.Size = new System.Drawing.Size(49, 13);
            this.labelTempoJogo.TabIndex = 1;
            this.labelTempoJogo.Text = "00:00:00";
            // 
            // tlpTabuleiro
            // 
            this.tlpTabuleiro.BackColor = System.Drawing.Color.LightGray;
            this.tlpTabuleiro.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpTabuleiro.ColumnCount = 7;
            this.tlpTabuleiro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.5162F));
            this.tlpTabuleiro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.51621F));
            this.tlpTabuleiro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.51621F));
            this.tlpTabuleiro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.51621F));
            this.tlpTabuleiro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.51621F));
            this.tlpTabuleiro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.51621F));
            this.tlpTabuleiro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.90274F));
            this.tlpTabuleiro.Location = new System.Drawing.Point(12, 110);
            this.tlpTabuleiro.Name = "tlpTabuleiro";
            this.tlpTabuleiro.RowCount = 9;
            this.tlpTabuleiro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11F));
            this.tlpTabuleiro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11F));
            this.tlpTabuleiro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11F));
            this.tlpTabuleiro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11F));
            this.tlpTabuleiro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.12F));
            this.tlpTabuleiro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11F));
            this.tlpTabuleiro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11F));
            this.tlpTabuleiro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11F));
            this.tlpTabuleiro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11F));
            this.tlpTabuleiro.Size = new System.Drawing.Size(420, 500);
            this.tlpTabuleiro.TabIndex = 2;
            this.tlpTabuleiro.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tlpTabuleiro_CellPaint);
            this.tlpTabuleiro.Click += new System.EventHandler(this.tlpTabuleiro_Click);
            // 
            // labelNomeJogador1Titulo
            // 
            this.labelNomeJogador1Titulo.AutoSize = true;
            this.labelNomeJogador1Titulo.Location = new System.Drawing.Point(192, 70);
            this.labelNomeJogador1Titulo.Name = "labelNomeJogador1Titulo";
            this.labelNomeJogador1Titulo.Size = new System.Drawing.Size(57, 13);
            this.labelNomeJogador1Titulo.TabIndex = 3;
            this.labelNomeJogador1Titulo.Text = "Jogador 1:";
            // 
            // labelNomeJogador2Titulo
            // 
            this.labelNomeJogador2Titulo.AutoSize = true;
            this.labelNomeJogador2Titulo.Location = new System.Drawing.Point(192, 620);
            this.labelNomeJogador2Titulo.Name = "labelNomeJogador2Titulo";
            this.labelNomeJogador2Titulo.Size = new System.Drawing.Size(57, 13);
            this.labelNomeJogador2Titulo.TabIndex = 4;
            this.labelNomeJogador2Titulo.Text = "Jogador 2:";
            // 
            // labelNomeJogador1
            // 
            this.labelNomeJogador1.AutoSize = true;
            this.labelNomeJogador1.Location = new System.Drawing.Point(171, 90);
            this.labelNomeJogador1.Name = "labelNomeJogador1";
            this.labelNomeJogador1.Size = new System.Drawing.Size(100, 13);
            this.labelNomeJogador1.TabIndex = 5;
            this.labelNomeJogador1.Text = "Nome do Jogador 1";
            this.labelNomeJogador1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNomeJogador2
            // 
            this.labelNomeJogador2.AutoSize = true;
            this.labelNomeJogador2.Location = new System.Drawing.Point(171, 640);
            this.labelNomeJogador2.Name = "labelNomeJogador2";
            this.labelNomeJogador2.Size = new System.Drawing.Size(100, 13);
            this.labelNomeJogador2.TabIndex = 6;
            this.labelNomeJogador2.Text = "Nome do Jogador 2";
            this.labelNomeJogador2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelJogadorVezTitulo
            // 
            this.labelJogadorVezTitulo.AutoSize = true;
            this.labelJogadorVezTitulo.Location = new System.Drawing.Point(15, 26);
            this.labelJogadorVezTitulo.Name = "labelJogadorVezTitulo";
            this.labelJogadorVezTitulo.Size = new System.Drawing.Size(28, 13);
            this.labelJogadorVezTitulo.TabIndex = 7;
            this.labelJogadorVezTitulo.Text = "Vez:";
            // 
            // labelJogadorVez
            // 
            this.labelJogadorVez.AutoSize = true;
            this.labelJogadorVez.Location = new System.Drawing.Point(116, 26);
            this.labelJogadorVez.Name = "labelJogadorVez";
            this.labelJogadorVez.Size = new System.Drawing.Size(54, 13);
            this.labelJogadorVez.TabIndex = 8;
            this.labelJogadorVez.Text = "Jogador 1";
            // 
            // labelPecaSelecionadaTitulo
            // 
            this.labelPecaSelecionadaTitulo.AutoSize = true;
            this.labelPecaSelecionadaTitulo.Location = new System.Drawing.Point(15, 43);
            this.labelPecaSelecionadaTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPecaSelecionadaTitulo.Name = "labelPecaSelecionadaTitulo";
            this.labelPecaSelecionadaTitulo.Size = new System.Drawing.Size(97, 13);
            this.labelPecaSelecionadaTitulo.TabIndex = 9;
            this.labelPecaSelecionadaTitulo.Text = "Peça Selecionada:";
            // 
            // labelPecaSelecionada
            // 
            this.labelPecaSelecionada.AutoSize = true;
            this.labelPecaSelecionada.Location = new System.Drawing.Point(116, 43);
            this.labelPecaSelecionada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPecaSelecionada.Name = "labelPecaSelecionada";
            this.labelPecaSelecionada.Size = new System.Drawing.Size(47, 13);
            this.labelPecaSelecionada.TabIndex = 10;
            this.labelPecaSelecionada.Text = "Nenhum";
            // 
            // Jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 661);
            this.Controls.Add(this.labelPecaSelecionada);
            this.Controls.Add(this.labelPecaSelecionadaTitulo);
            this.Controls.Add(this.labelJogadorVez);
            this.Controls.Add(this.labelJogadorVezTitulo);
            this.Controls.Add(this.labelNomeJogador2);
            this.Controls.Add(this.labelNomeJogador1);
            this.Controls.Add(this.labelNomeJogador2Titulo);
            this.Controls.Add(this.labelNomeJogador1Titulo);
            this.Controls.Add(this.tlpTabuleiro);
            this.Controls.Add(this.labelTempoJogo);
            this.Controls.Add(this.labelTempo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Jogo";
            this.Text = "Luta na Selva - Jogo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTempo;
        private System.Windows.Forms.Label labelTempoJogo;
        private System.Windows.Forms.TableLayoutPanel tlpTabuleiro;
        private System.Windows.Forms.Label labelNomeJogador1Titulo;
        private System.Windows.Forms.Label labelNomeJogador2Titulo;
        private System.Windows.Forms.Label labelNomeJogador1;
        private System.Windows.Forms.Label labelNomeJogador2;
        private System.Windows.Forms.Label labelJogadorVezTitulo;
        private System.Windows.Forms.Label labelJogadorVez;
        private System.Windows.Forms.Label labelPecaSelecionadaTitulo;
        private System.Windows.Forms.Label labelPecaSelecionada;
    }
}

