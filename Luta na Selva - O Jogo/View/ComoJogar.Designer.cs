namespace View
{
    partial class ComoJogar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComoJogar));
            this.labelComoJogarTitulo = new System.Windows.Forms.Label();
            this.labelComoJogar = new System.Windows.Forms.Label();
            this.btnVoltarTelaInicial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelComoJogarTitulo
            // 
            this.labelComoJogarTitulo.AutoSize = true;
            this.labelComoJogarTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComoJogarTitulo.Location = new System.Drawing.Point(169, 10);
            this.labelComoJogarTitulo.Name = "labelComoJogarTitulo";
            this.labelComoJogarTitulo.Size = new System.Drawing.Size(95, 20);
            this.labelComoJogarTitulo.TabIndex = 0;
            this.labelComoJogarTitulo.Text = "Como Jogar";
            // 
            // labelComoJogar
            // 
            this.labelComoJogar.AutoSize = true;
            this.labelComoJogar.Location = new System.Drawing.Point(12, 60);
            this.labelComoJogar.Name = "labelComoJogar";
            this.labelComoJogar.Size = new System.Drawing.Size(414, 156);
            this.labelComoJogar.TabIndex = 1;
            this.labelComoJogar.Text = resources.GetString("labelComoJogar.Text");
            this.labelComoJogar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVoltarTelaInicial
            // 
            this.btnVoltarTelaInicial.Location = new System.Drawing.Point(120, 250);
            this.btnVoltarTelaInicial.Name = "btnVoltarTelaInicial";
            this.btnVoltarTelaInicial.Size = new System.Drawing.Size(200, 35);
            this.btnVoltarTelaInicial.TabIndex = 2;
            this.btnVoltarTelaInicial.Text = "Voltar à Tela Inicial";
            this.btnVoltarTelaInicial.UseVisualStyleBackColor = true;
            this.btnVoltarTelaInicial.Click += new System.EventHandler(this.btnVoltarTelaInicial_Click);
            // 
            // ComoJogar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 311);
            this.Controls.Add(this.btnVoltarTelaInicial);
            this.Controls.Add(this.labelComoJogar);
            this.Controls.Add(this.labelComoJogarTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComoJogar";
            this.Text = "Luta na Selva - Como Jogar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelComoJogarTitulo;
        private System.Windows.Forms.Label labelComoJogar;
        private System.Windows.Forms.Button btnVoltarTelaInicial;
    }
}