namespace View
{
    partial class Regras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Regras));
            this.labelRegrasTitulo = new System.Windows.Forms.Label();
            this.labelRegras = new System.Windows.Forms.Label();
            this.btnVoltarTelaInicial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelRegrasTitulo
            // 
            this.labelRegrasTitulo.AutoSize = true;
            this.labelRegrasTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegrasTitulo.Location = new System.Drawing.Point(183, 10);
            this.labelRegrasTitulo.Name = "labelRegrasTitulo";
            this.labelRegrasTitulo.Size = new System.Drawing.Size(61, 20);
            this.labelRegrasTitulo.TabIndex = 1;
            this.labelRegrasTitulo.Text = "Regras";
            // 
            // labelRegras
            // 
            this.labelRegras.AutoSize = true;
            this.labelRegras.Location = new System.Drawing.Point(12, 60);
            this.labelRegras.Name = "labelRegras";
            this.labelRegras.Size = new System.Drawing.Size(428, 351);
            this.labelRegras.TabIndex = 2;
            this.labelRegras.Text = resources.GetString("labelRegras.Text");
            this.labelRegras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVoltarTelaInicial
            // 
            this.btnVoltarTelaInicial.Location = new System.Drawing.Point(120, 445);
            this.btnVoltarTelaInicial.Name = "btnVoltarTelaInicial";
            this.btnVoltarTelaInicial.Size = new System.Drawing.Size(200, 35);
            this.btnVoltarTelaInicial.TabIndex = 3;
            this.btnVoltarTelaInicial.Text = "Voltar à Tela Inicial";
            this.btnVoltarTelaInicial.UseVisualStyleBackColor = true;
            this.btnVoltarTelaInicial.Click += new System.EventHandler(this.btnVoltarTelaInicial_Click);
            // 
            // Regras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 511);
            this.Controls.Add(this.btnVoltarTelaInicial);
            this.Controls.Add(this.labelRegras);
            this.Controls.Add(this.labelRegrasTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Regras";
            this.Text = "Luta na Selva - Regras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRegrasTitulo;
        private System.Windows.Forms.Label labelRegras;
        private System.Windows.Forms.Button btnVoltarTelaInicial;
    }
}