namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioSeguroDesemprego
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
            this.rbSolicitouBeneficioNao = new System.Windows.Forms.RadioButton();
            this.rbSolicitouBeneficoSim = new System.Windows.Forms.RadioButton();
            this.lblTrabalahndoAtualmente = new System.Windows.Forms.Label();
            this.lblAnosDeCarteira = new System.Windows.Forms.Label();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblresultado = new System.Windows.Forms.Label();
            this.txtVezesSolicitadas = new System.Windows.Forms.TextBox();
            this.lblVezesSolicitadas = new System.Windows.Forms.Label();
            this.txtMesesTrabalhados = new System.Windows.Forms.TextBox();
            this.lblLoading = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbSolicitouBeneficioNao
            // 
            this.rbSolicitouBeneficioNao.AutoSize = true;
            this.rbSolicitouBeneficioNao.BackColor = System.Drawing.Color.Silver;
            this.rbSolicitouBeneficioNao.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.rbSolicitouBeneficioNao.ForeColor = System.Drawing.Color.Black;
            this.rbSolicitouBeneficioNao.Location = new System.Drawing.Point(117, 154);
            this.rbSolicitouBeneficioNao.Margin = new System.Windows.Forms.Padding(4);
            this.rbSolicitouBeneficioNao.Name = "rbSolicitouBeneficioNao";
            this.rbSolicitouBeneficioNao.Size = new System.Drawing.Size(70, 29);
            this.rbSolicitouBeneficioNao.TabIndex = 21;
            this.rbSolicitouBeneficioNao.TabStop = true;
            this.rbSolicitouBeneficioNao.Text = "Não";
            this.rbSolicitouBeneficioNao.UseVisualStyleBackColor = false;
            this.rbSolicitouBeneficioNao.CheckedChanged += new System.EventHandler(this.rbSolicitouBeneficioNao_CheckedChanged);
            // 
            // rbSolicitouBeneficoSim
            // 
            this.rbSolicitouBeneficoSim.AutoSize = true;
            this.rbSolicitouBeneficoSim.BackColor = System.Drawing.Color.Silver;
            this.rbSolicitouBeneficoSim.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.rbSolicitouBeneficoSim.ForeColor = System.Drawing.Color.Black;
            this.rbSolicitouBeneficoSim.Location = new System.Drawing.Point(39, 154);
            this.rbSolicitouBeneficoSim.Margin = new System.Windows.Forms.Padding(4);
            this.rbSolicitouBeneficoSim.Name = "rbSolicitouBeneficoSim";
            this.rbSolicitouBeneficoSim.Size = new System.Drawing.Size(66, 29);
            this.rbSolicitouBeneficoSim.TabIndex = 20;
            this.rbSolicitouBeneficoSim.TabStop = true;
            this.rbSolicitouBeneficoSim.Text = "Sim";
            this.rbSolicitouBeneficoSim.UseVisualStyleBackColor = false;
            this.rbSolicitouBeneficoSim.CheckedChanged += new System.EventHandler(this.rbSolicitouBeneficioSim_CheckedChanged);
            // 
            // lblTrabalahndoAtualmente
            // 
            this.lblTrabalahndoAtualmente.AutoSize = true;
            this.lblTrabalahndoAtualmente.BackColor = System.Drawing.Color.Silver;
            this.lblTrabalahndoAtualmente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTrabalahndoAtualmente.ForeColor = System.Drawing.Color.Black;
            this.lblTrabalahndoAtualmente.Location = new System.Drawing.Point(25, 255);
            this.lblTrabalahndoAtualmente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrabalahndoAtualmente.Name = "lblTrabalahndoAtualmente";
            this.lblTrabalahndoAtualmente.Size = new System.Drawing.Size(522, 25);
            this.lblTrabalahndoAtualmente.TabIndex = 18;
            this.lblTrabalahndoAtualmente.Text = "tem quantos meses que você trabalha no emprego atual ?";
            // 
            // lblAnosDeCarteira
            // 
            this.lblAnosDeCarteira.AutoSize = true;
            this.lblAnosDeCarteira.BackColor = System.Drawing.Color.Silver;
            this.lblAnosDeCarteira.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAnosDeCarteira.ForeColor = System.Drawing.Color.Black;
            this.lblAnosDeCarteira.Location = new System.Drawing.Point(25, 125);
            this.lblAnosDeCarteira.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnosDeCarteira.Name = "lblAnosDeCarteira";
            this.lblAnosDeCarteira.Size = new System.Drawing.Size(332, 25);
            this.lblAnosDeCarteira.TabIndex = 17;
            this.lblAnosDeCarteira.Text = "Já solicitou o benefício alguma vez ?";
            // 
            // btnCalcula
            // 
            this.btnCalcula.BackColor = System.Drawing.Color.Silver;
            this.btnCalcula.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCalcula.ForeColor = System.Drawing.Color.Black;
            this.btnCalcula.Location = new System.Drawing.Point(199, 378);
            this.btnCalcula.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(136, 40);
            this.btnCalcula.TabIndex = 16;
            this.btnCalcula.Text = "CALCULAR";
            this.btnCalcula.UseVisualStyleBackColor = false;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblresultado);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(81, 426);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 51);
            this.panel1.TabIndex = 15;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(31, 11);
            this.lblresultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(65, 25);
            this.lblresultado.TabIndex = 4;
            this.lblresultado.Text = "label1";
            this.lblresultado.Visible = false;
            // 
            // txtVezesSolicitadas
            // 
            this.txtVezesSolicitadas.BackColor = System.Drawing.Color.Silver;
            this.txtVezesSolicitadas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtVezesSolicitadas.ForeColor = System.Drawing.Color.Black;
            this.txtVezesSolicitadas.Location = new System.Drawing.Point(26, 216);
            this.txtVezesSolicitadas.Margin = new System.Windows.Forms.Padding(4);
            this.txtVezesSolicitadas.Name = "txtVezesSolicitadas";
            this.txtVezesSolicitadas.Size = new System.Drawing.Size(239, 32);
            this.txtVezesSolicitadas.TabIndex = 22;
            this.txtVezesSolicitadas.Visible = false;
            this.txtVezesSolicitadas.WordWrap = false;
            // 
            // lblVezesSolicitadas
            // 
            this.lblVezesSolicitadas.AutoSize = true;
            this.lblVezesSolicitadas.BackColor = System.Drawing.Color.Silver;
            this.lblVezesSolicitadas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblVezesSolicitadas.ForeColor = System.Drawing.Color.Black;
            this.lblVezesSolicitadas.Location = new System.Drawing.Point(25, 187);
            this.lblVezesSolicitadas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVezesSolicitadas.Name = "lblVezesSolicitadas";
            this.lblVezesSolicitadas.Size = new System.Drawing.Size(508, 25);
            this.lblVezesSolicitadas.TabIndex = 23;
            this.lblVezesSolicitadas.Text = "Informe a quantidade de vezes que solicitou o benefício";
            this.lblVezesSolicitadas.Visible = false;
            // 
            // txtMesesTrabalhados
            // 
            this.txtMesesTrabalhados.BackColor = System.Drawing.Color.Silver;
            this.txtMesesTrabalhados.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtMesesTrabalhados.ForeColor = System.Drawing.Color.Black;
            this.txtMesesTrabalhados.Location = new System.Drawing.Point(26, 284);
            this.txtMesesTrabalhados.Margin = new System.Windows.Forms.Padding(4);
            this.txtMesesTrabalhados.Name = "txtMesesTrabalhados";
            this.txtMesesTrabalhados.Size = new System.Drawing.Size(239, 32);
            this.txtMesesTrabalhados.TabIndex = 24;
            this.txtMesesTrabalhados.WordWrap = false;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.Silver;
            this.lblLoading.Font = new System.Drawing.Font("Tempus Sans ITC", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblLoading.ForeColor = System.Drawing.Color.Black;
            this.lblLoading.Location = new System.Drawing.Point(217, 335);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(93, 18);
            this.lblLoading.TabIndex = 26;
            this.lblLoading.Text = "LOADING...";
            this.lblLoading.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Silver;
            this.progressBar1.ForeColor = System.Drawing.Color.Black;
            this.progressBar1.Location = new System.Drawing.Point(168, 356);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(198, 15);
            this.progressBar1.TabIndex = 25;
            this.progressBar1.Value = 100;
            this.progressBar1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 5;
            // 
            // frmBeneficioSeguroDesemprego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.imagens_rh;
            this.ClientSize = new System.Drawing.Size(623, 654);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtMesesTrabalhados);
            this.Controls.Add(this.lblVezesSolicitadas);
            this.Controls.Add(this.txtVezesSolicitadas);
            this.Controls.Add(this.rbSolicitouBeneficioNao);
            this.Controls.Add(this.rbSolicitouBeneficoSim);
            this.Controls.Add(this.lblTrabalahndoAtualmente);
            this.Controls.Add(this.lblAnosDeCarteira);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.panel1);
            this.Name = "frmBeneficioSeguroDesemprego";
            this.Text = "frmBeneficioSeguroDesemprego";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbSolicitouBeneficioNao;
        private System.Windows.Forms.RadioButton rbSolicitouBeneficoSim;
        private System.Windows.Forms.Label lblTrabalahndoAtualmente;
        private System.Windows.Forms.Label lblAnosDeCarteira;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.TextBox txtVezesSolicitadas;
        private System.Windows.Forms.Label lblVezesSolicitadas;
        private System.Windows.Forms.TextBox txtMesesTrabalhados;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
    }
}