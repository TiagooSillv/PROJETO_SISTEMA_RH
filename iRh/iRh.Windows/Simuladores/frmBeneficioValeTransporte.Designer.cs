namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioValeTransporte
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
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.lblValorDaPassagem = new System.Windows.Forms.Label();
            this.txtValorDaPassagem = new System.Windows.Forms.TextBox();
            this.txtQuantidadeDePassagem = new System.Windows.Forms.TextBox();
            this.lblQuantidadeDePassagem = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(317, 59);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(127, 38);
            this.lblSalario.TabIndex = 0;
            this.lblSalario.Text = "SALÁRIO";
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(286, 111);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(195, 43);
            this.txtSalario.TabIndex = 1;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lblResultado);
            this.panel1.Location = new System.Drawing.Point(7, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 126);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(346, 38);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(91, 38);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "label2";
            // 
            // btnCalcula
            // 
            this.btnCalcula.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcula.Location = new System.Drawing.Point(324, 250);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(144, 42);
            this.btnCalcula.TabIndex = 3;
            this.btnCalcula.Text = "CALCULAR";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // lblValorDaPassagem
            // 
            this.lblValorDaPassagem.AutoSize = true;
            this.lblValorDaPassagem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDaPassagem.Location = new System.Drawing.Point(157, 166);
            this.lblValorDaPassagem.Name = "lblValorDaPassagem";
            this.lblValorDaPassagem.Size = new System.Drawing.Size(179, 23);
            this.lblValorDaPassagem.TabIndex = 4;
            this.lblValorDaPassagem.Text = "VALOR DA PASSAGEM";
            this.lblValorDaPassagem.Visible = false;
            // 
            // txtValorDaPassagem
            // 
            this.txtValorDaPassagem.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDaPassagem.Location = new System.Drawing.Point(161, 192);
            this.txtValorDaPassagem.Name = "txtValorDaPassagem";
            this.txtValorDaPassagem.Size = new System.Drawing.Size(160, 43);
            this.txtValorDaPassagem.TabIndex = 5;
            this.txtValorDaPassagem.Visible = false;
            this.txtValorDaPassagem.TextChanged += new System.EventHandler(this.txtValorDaPassagem_TextChanged);
            // 
            // txtQuantidadeDePassagem
            // 
            this.txtQuantidadeDePassagem.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeDePassagem.Location = new System.Drawing.Point(493, 192);
            this.txtQuantidadeDePassagem.Name = "txtQuantidadeDePassagem";
            this.txtQuantidadeDePassagem.Size = new System.Drawing.Size(160, 43);
            this.txtQuantidadeDePassagem.TabIndex = 6;
            this.txtQuantidadeDePassagem.Visible = false;
            // 
            // lblQuantidadeDePassagem
            // 
            this.lblQuantidadeDePassagem.AutoSize = true;
            this.lblQuantidadeDePassagem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeDePassagem.Location = new System.Drawing.Point(415, 166);
            this.lblQuantidadeDePassagem.Name = "lblQuantidadeDePassagem";
            this.lblQuantidadeDePassagem.Size = new System.Drawing.Size(304, 23);
            this.lblQuantidadeDePassagem.TabIndex = 7;
            this.lblQuantidadeDePassagem.Text = "QUANTAS PASSAGENS GASTA NO DIA";
            this.lblQuantidadeDePassagem.Visible = false;
            // 
            // frmBeneficioValeTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblQuantidadeDePassagem);
            this.Controls.Add(this.txtQuantidadeDePassagem);
            this.Controls.Add(this.txtValorDaPassagem);
            this.Controls.Add(this.lblValorDaPassagem);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Name = "frmBeneficioValeTransporte";
            this.Text = "Calculo do Vale Transporte";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.Label lblValorDaPassagem;
        private System.Windows.Forms.TextBox txtValorDaPassagem;
        private System.Windows.Forms.TextBox txtQuantidadeDePassagem;
        private System.Windows.Forms.Label lblQuantidadeDePassagem;
    }
}