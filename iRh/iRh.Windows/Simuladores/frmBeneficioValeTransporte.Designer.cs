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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioValeTransporte));
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.lblValorDaPassagem = new System.Windows.Forms.Label();
            this.txtValorDaPassagem = new System.Windows.Forms.TextBox();
            this.txtQuantidadeDePassagem = new System.Windows.Forms.TextBox();
            this.lblQuantidadeDePassagem = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.BackColor = System.Drawing.Color.Silver;
            this.lblSalario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblSalario.Location = new System.Drawing.Point(311, 94);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(93, 27);
            this.lblSalario.TabIndex = 0;
            this.lblSalario.Text = "SALÁRIO";
            // 
            // txtSalario
            // 
            this.txtSalario.BackColor = System.Drawing.Color.Silver;
            this.txtSalario.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(258, 124);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(195, 43);
            this.txtSalario.TabIndex = 1;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblResultado);
            this.panel1.Location = new System.Drawing.Point(167, 378);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 46);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Valor do desconto: ";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblResultado.Location = new System.Drawing.Point(191, 11);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(44, 25);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "----";
            // 
            // btnCalcula
            // 
            this.btnCalcula.BackColor = System.Drawing.Color.Silver;
            this.btnCalcula.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCalcula.Location = new System.Drawing.Point(267, 316);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(144, 42);
            this.btnCalcula.TabIndex = 3;
            this.btnCalcula.Text = "CALCULAR";
            this.btnCalcula.UseVisualStyleBackColor = false;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // lblValorDaPassagem
            // 
            this.lblValorDaPassagem.AutoSize = true;
            this.lblValorDaPassagem.BackColor = System.Drawing.Color.Silver;
            this.lblValorDaPassagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValorDaPassagem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblValorDaPassagem.Location = new System.Drawing.Point(48, 186);
            this.lblValorDaPassagem.Name = "lblValorDaPassagem";
            this.lblValorDaPassagem.Size = new System.Drawing.Size(213, 27);
            this.lblValorDaPassagem.TabIndex = 4;
            this.lblValorDaPassagem.Text = "VALOR DA PASSAGEM";
            this.lblValorDaPassagem.Visible = false;
            // 
            // txtValorDaPassagem
            // 
            this.txtValorDaPassagem.BackColor = System.Drawing.Color.Silver;
            this.txtValorDaPassagem.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDaPassagem.Location = new System.Drawing.Point(78, 214);
            this.txtValorDaPassagem.Name = "txtValorDaPassagem";
            this.txtValorDaPassagem.Size = new System.Drawing.Size(160, 43);
            this.txtValorDaPassagem.TabIndex = 5;
            this.txtValorDaPassagem.Visible = false;
            this.txtValorDaPassagem.TextChanged += new System.EventHandler(this.txtValorDaPassagem_TextChanged);
            // 
            // txtQuantidadeDePassagem
            // 
            this.txtQuantidadeDePassagem.BackColor = System.Drawing.Color.Silver;
            this.txtQuantidadeDePassagem.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeDePassagem.Location = new System.Drawing.Point(469, 214);
            this.txtQuantidadeDePassagem.Name = "txtQuantidadeDePassagem";
            this.txtQuantidadeDePassagem.Size = new System.Drawing.Size(160, 43);
            this.txtQuantidadeDePassagem.TabIndex = 6;
            this.txtQuantidadeDePassagem.Visible = false;
            // 
            // lblQuantidadeDePassagem
            // 
            this.lblQuantidadeDePassagem.AutoSize = true;
            this.lblQuantidadeDePassagem.BackColor = System.Drawing.Color.Silver;
            this.lblQuantidadeDePassagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuantidadeDePassagem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblQuantidadeDePassagem.Location = new System.Drawing.Point(397, 186);
            this.lblQuantidadeDePassagem.Name = "lblQuantidadeDePassagem";
            this.lblQuantidadeDePassagem.Size = new System.Drawing.Size(356, 27);
            this.lblQuantidadeDePassagem.TabIndex = 7;
            this.lblQuantidadeDePassagem.Text = "QUANTAS PASSAGENS GASTA NO DIA";
            this.lblQuantidadeDePassagem.Visible = false;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.Silver;
            this.lblLoading.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.Black;
            this.lblLoading.Location = new System.Drawing.Point(284, 259);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(127, 26);
            this.lblLoading.TabIndex = 16;
            this.lblLoading.Text = "LOADING...";
            this.lblLoading.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Silver;
            this.progressBar1.Location = new System.Drawing.Point(246, 288);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(198, 15);
            this.progressBar1.TabIndex = 15;
            this.progressBar1.Value = 100;
            this.progressBar1.Visible = false;
            // 
            // frmBeneficioValeTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.imagens_rh;
            this.ClientSize = new System.Drawing.Size(761, 506);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblQuantidadeDePassagem);
            this.Controls.Add(this.txtQuantidadeDePassagem);
            this.Controls.Add(this.txtValorDaPassagem);
            this.Controls.Add(this.lblValorDaPassagem);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBeneficioValeTransporte";
            this.Text = "Calculo Vale Transporte";
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
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
    }
}