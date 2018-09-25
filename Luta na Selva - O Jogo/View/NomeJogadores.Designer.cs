namespace View
{
    partial class NomeJogadores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelJogador1 = new System.Windows.Forms.Label();
            this.labelJogador2 = new System.Windows.Forms.Label();
            this.inputJogador1 = new System.Windows.Forms.TextBox();
            this.inputJogador2 = new System.Windows.Forms.TextBox();
            this.btnVoltarTelaInicial = new System.Windows.Forms.Button();
            this.btnIniciarJogo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelJogador1
            // 
            this.labelJogador1.AutoSize = true;
            this.labelJogador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJogador1.Location = new System.Drawing.Point(90, 10);
            this.labelJogador1.Name = "labelJogador1";
            this.labelJogador1.Size = new System.Drawing.Size(84, 20);
            this.labelJogador1.TabIndex = 3;
            this.labelJogador1.Text = "Jogador 1:";
            // 
            // labelJogador2
            // 
            this.labelJogador2.AutoSize = true;
            this.labelJogador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJogador2.Location = new System.Drawing.Point(90, 90);
            this.labelJogador2.Name = "labelJogador2";
            this.labelJogador2.Size = new System.Drawing.Size(84, 20);
            this.labelJogador2.TabIndex = 4;
            this.labelJogador2.Text = "Jogador 2:";
            // 
            // inputJogador1
            // 
            this.inputJogador1.Location = new System.Drawing.Point(10, 40);
            this.inputJogador1.Name = "inputJogador1";
            this.inputJogador1.Size = new System.Drawing.Size(250, 20);
            this.inputJogador1.TabIndex = 5;
            // 
            // inputJogador2
            // 
            this.inputJogador2.Location = new System.Drawing.Point(10, 120);
            this.inputJogador2.Name = "inputJogador2";
            this.inputJogador2.Size = new System.Drawing.Size(250, 20);
            this.inputJogador2.TabIndex = 6;
            // 
            // btnVoltarTelaInicial
            // 
            this.btnVoltarTelaInicial.Location = new System.Drawing.Point(10, 160);
            this.btnVoltarTelaInicial.Name = "btnVoltarTelaInicial";
            this.btnVoltarTelaInicial.Size = new System.Drawing.Size(121, 35);
            this.btnVoltarTelaInicial.TabIndex = 7;
            this.btnVoltarTelaInicial.Text = "Voltar à Tela Inicial";
            this.btnVoltarTelaInicial.UseVisualStyleBackColor = true;
            this.btnVoltarTelaInicial.Click += new System.EventHandler(this.btnVoltarTelaInicial_Click);
            // 
            // btnIniciarJogo
            // 
            this.btnIniciarJogo.Location = new System.Drawing.Point(139, 160);
            this.btnIniciarJogo.Name = "btnIniciarJogo";
            this.btnIniciarJogo.Size = new System.Drawing.Size(121, 35);
            this.btnIniciarJogo.TabIndex = 8;
            this.btnIniciarJogo.Text = "Iniciar Jogo";
            this.btnIniciarJogo.UseVisualStyleBackColor = true;
            this.btnIniciarJogo.Click += new System.EventHandler(this.btnIniciarJogo_Click);
            // 
            // NomeJogadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 211);
            this.Controls.Add(this.btnIniciarJogo);
            this.Controls.Add(this.btnVoltarTelaInicial);
            this.Controls.Add(this.inputJogador2);
            this.Controls.Add(this.inputJogador1);
            this.Controls.Add(this.labelJogador2);
            this.Controls.Add(this.labelJogador1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NomeJogadores";
            this.Text = "Luta na Selva - Nome dos Jogadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJogador1;
        private System.Windows.Forms.Label labelJogador2;
        private System.Windows.Forms.TextBox inputJogador1;
        private System.Windows.Forms.TextBox inputJogador2;
        private System.Windows.Forms.Button btnVoltarTelaInicial;
        private System.Windows.Forms.Button btnIniciarJogo;
    }
}