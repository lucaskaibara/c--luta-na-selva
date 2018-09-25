namespace View
{
    partial class SobreNos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SobreNos));
            this.labelSobreNosTitulo = new System.Windows.Forms.Label();
            this.labelSobreNos = new System.Windows.Forms.Label();
            this.btnVoltarTelaInicial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSobreNosTitulo
            // 
            this.labelSobreNosTitulo.AutoSize = true;
            this.labelSobreNosTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSobreNosTitulo.Location = new System.Drawing.Point(90, 10);
            this.labelSobreNosTitulo.Name = "labelSobreNosTitulo";
            this.labelSobreNosTitulo.Size = new System.Drawing.Size(84, 20);
            this.labelSobreNosTitulo.TabIndex = 2;
            this.labelSobreNosTitulo.Text = "Sobre Nós";
            // 
            // labelSobreNos
            // 
            this.labelSobreNos.AutoSize = true;
            this.labelSobreNos.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelSobreNos.Location = new System.Drawing.Point(12, 60);
            this.labelSobreNos.Name = "labelSobreNos";
            this.labelSobreNos.Size = new System.Drawing.Size(244, 130);
            this.labelSobreNos.TabIndex = 3;
            this.labelSobreNos.Text = resources.GetString("labelSobreNos.Text");
            this.labelSobreNos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVoltarTelaInicial
            // 
            this.btnVoltarTelaInicial.Location = new System.Drawing.Point(35, 235);
            this.btnVoltarTelaInicial.Name = "btnVoltarTelaInicial";
            this.btnVoltarTelaInicial.Size = new System.Drawing.Size(200, 35);
            this.btnVoltarTelaInicial.TabIndex = 4;
            this.btnVoltarTelaInicial.Text = "Voltar à Tela Inicial";
            this.btnVoltarTelaInicial.UseVisualStyleBackColor = true;
            this.btnVoltarTelaInicial.Click += new System.EventHandler(this.btnVoltarTelaInicial_Click);
            // 
            // SobreNos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 301);
            this.Controls.Add(this.btnVoltarTelaInicial);
            this.Controls.Add(this.labelSobreNos);
            this.Controls.Add(this.labelSobreNosTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SobreNos";
            this.Text = "Luta na Selva - Sobre Nós";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSobreNosTitulo;
        private System.Windows.Forms.Label labelSobreNos;
        private System.Windows.Forms.Button btnVoltarTelaInicial;
    }
}