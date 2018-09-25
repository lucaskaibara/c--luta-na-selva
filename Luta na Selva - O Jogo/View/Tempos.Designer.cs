namespace View
{
    partial class Tempos
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
            this.labelMelhoresTemposTitulo = new System.Windows.Forms.Label();
            this.dgvTempos = new System.Windows.Forms.DataGridView();
            this.btnVoltarTelaInicial = new System.Windows.Forms.Button();
            this.clCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clJgadores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clVencedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTempoJogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTempos)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMelhoresTemposTitulo
            // 
            this.labelMelhoresTemposTitulo.AutoSize = true;
            this.labelMelhoresTemposTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMelhoresTemposTitulo.Location = new System.Drawing.Point(240, 10);
            this.labelMelhoresTemposTitulo.Name = "labelMelhoresTemposTitulo";
            this.labelMelhoresTemposTitulo.Size = new System.Drawing.Size(135, 20);
            this.labelMelhoresTemposTitulo.TabIndex = 1;
            this.labelMelhoresTemposTitulo.Text = "Melhores Tempos";
            // 
            // dgvTempos
            // 
            this.dgvTempos.AllowUserToAddRows = false;
            this.dgvTempos.AllowUserToDeleteRows = false;
            this.dgvTempos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTempos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTempos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCodigo,
            this.clJgadores,
            this.clVencedor,
            this.clTempoJogo});
            this.dgvTempos.Location = new System.Drawing.Point(12, 60);
            this.dgvTempos.Name = "dgvTempos";
            this.dgvTempos.ReadOnly = true;
            this.dgvTempos.RowHeadersVisible = false;
            this.dgvTempos.Size = new System.Drawing.Size(604, 250);
            this.dgvTempos.TabIndex = 2;
            // 
            // btnVoltarTelaInicial
            // 
            this.btnVoltarTelaInicial.Location = new System.Drawing.Point(205, 360);
            this.btnVoltarTelaInicial.Name = "btnVoltarTelaInicial";
            this.btnVoltarTelaInicial.Size = new System.Drawing.Size(200, 35);
            this.btnVoltarTelaInicial.TabIndex = 3;
            this.btnVoltarTelaInicial.Text = "Voltar à Tela Inicial";
            this.btnVoltarTelaInicial.UseVisualStyleBackColor = true;
            this.btnVoltarTelaInicial.Click += new System.EventHandler(this.btnVoltarTelaInicial_Click);
            // 
            // clCodigo
            // 
            this.clCodigo.DataPropertyName = "codTempo";
            this.clCodigo.HeaderText = "Código";
            this.clCodigo.Name = "clCodigo";
            this.clCodigo.ReadOnly = true;
            this.clCodigo.Width = 150;
            // 
            // clJgadores
            // 
            this.clJgadores.DataPropertyName = "jogadores";
            this.clJgadores.HeaderText = "Jogadores";
            this.clJgadores.Name = "clJgadores";
            this.clJgadores.ReadOnly = true;
            this.clJgadores.Width = 150;
            // 
            // clVencedor
            // 
            this.clVencedor.DataPropertyName = "vencedor";
            this.clVencedor.HeaderText = "Vencedor";
            this.clVencedor.Name = "clVencedor";
            this.clVencedor.ReadOnly = true;
            this.clVencedor.Width = 150;
            // 
            // clTempoJogo
            // 
            this.clTempoJogo.DataPropertyName = "tempoJogo";
            this.clTempoJogo.HeaderText = "Tempo de Jogo";
            this.clTempoJogo.Name = "clTempoJogo";
            this.clTempoJogo.ReadOnly = true;
            this.clTempoJogo.Width = 150;
            // 
            // Tempos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 421);
            this.Controls.Add(this.btnVoltarTelaInicial);
            this.Controls.Add(this.dgvTempos);
            this.Controls.Add(this.labelMelhoresTemposTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tempos";
            this.Text = "Luta na Selva - Melhores Tempos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTempos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMelhoresTemposTitulo;
        private System.Windows.Forms.DataGridView dgvTempos;
        private System.Windows.Forms.Button btnVoltarTelaInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clJgadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn clVencedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTempoJogo;
    }
}