namespace View
{
    partial class TelaInicial
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
            this.btnIniciarJogo = new System.Windows.Forms.Button();
            this.btnComoJogar = new System.Windows.Forms.Button();
            this.btnRegras = new System.Windows.Forms.Button();
            this.btnSobreNos = new System.Windows.Forms.Button();
            this.btnMelhoresTempos = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciarJogo
            // 
            this.btnIniciarJogo.Location = new System.Drawing.Point(41, 206);
            this.btnIniciarJogo.Name = "btnIniciarJogo";
            this.btnIniciarJogo.Size = new System.Drawing.Size(200, 35);
            this.btnIniciarJogo.TabIndex = 1;
            this.btnIniciarJogo.Text = "Iniciar Jogo";
            this.btnIniciarJogo.UseVisualStyleBackColor = true;
            this.btnIniciarJogo.Click += new System.EventHandler(this.btnIniciarJogo_Click);
            // 
            // btnComoJogar
            // 
            this.btnComoJogar.Location = new System.Drawing.Point(41, 247);
            this.btnComoJogar.Name = "btnComoJogar";
            this.btnComoJogar.Size = new System.Drawing.Size(200, 35);
            this.btnComoJogar.TabIndex = 2;
            this.btnComoJogar.Text = "Como Jogar";
            this.btnComoJogar.UseVisualStyleBackColor = true;
            this.btnComoJogar.Click += new System.EventHandler(this.btnComoJogar_Click);
            // 
            // btnRegras
            // 
            this.btnRegras.Location = new System.Drawing.Point(41, 288);
            this.btnRegras.Name = "btnRegras";
            this.btnRegras.Size = new System.Drawing.Size(200, 35);
            this.btnRegras.TabIndex = 3;
            this.btnRegras.Text = "Regras do Jogo";
            this.btnRegras.UseVisualStyleBackColor = true;
            this.btnRegras.Click += new System.EventHandler(this.btnRegras_Click);
            // 
            // btnSobreNos
            // 
            this.btnSobreNos.Location = new System.Drawing.Point(41, 370);
            this.btnSobreNos.Name = "btnSobreNos";
            this.btnSobreNos.Size = new System.Drawing.Size(200, 35);
            this.btnSobreNos.TabIndex = 4;
            this.btnSobreNos.Text = "Sobre Nós";
            this.btnSobreNos.UseVisualStyleBackColor = true;
            this.btnSobreNos.Click += new System.EventHandler(this.btnSobreNos_Click);
            // 
            // btnMelhoresTempos
            // 
            this.btnMelhoresTempos.Location = new System.Drawing.Point(41, 329);
            this.btnMelhoresTempos.Name = "btnMelhoresTempos";
            this.btnMelhoresTempos.Size = new System.Drawing.Size(200, 35);
            this.btnMelhoresTempos.TabIndex = 5;
            this.btnMelhoresTempos.Text = "Melhores Tempos";
            this.btnMelhoresTempos.UseVisualStyleBackColor = true;
            this.btnMelhoresTempos.Click += new System.EventHandler(this.btnMelhoresTempos_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::View.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(41, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(200, 200);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 441);
            this.Controls.Add(this.btnMelhoresTempos);
            this.Controls.Add(this.btnSobreNos);
            this.Controls.Add(this.btnRegras);
            this.Controls.Add(this.btnComoJogar);
            this.Controls.Add(this.btnIniciarJogo);
            this.Controls.Add(this.pbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaInicial";
            this.Text = "Luta na Selva - Tela Inicial";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnIniciarJogo;
        private System.Windows.Forms.Button btnComoJogar;
        private System.Windows.Forms.Button btnRegras;
        private System.Windows.Forms.Button btnSobreNos;
        private System.Windows.Forms.Button btnMelhoresTempos;
    }
}