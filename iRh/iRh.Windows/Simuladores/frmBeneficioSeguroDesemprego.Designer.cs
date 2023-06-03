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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbSolicitouBeneficioNao
            // 
            this.rbSolicitouBeneficioNao.AutoSize = true;
            this.rbSolicitouBeneficioNao.Location = new System.Drawing.Point(131, 108);
            this.rbSolicitouBeneficioNao.Margin = new System.Windows.Forms.Padding(4);
            this.rbSolicitouBeneficioNao.Name = "rbSolicitouBeneficioNao";
            this.rbSolicitouBeneficioNao.Size = new System.Drawing.Size(54, 20);
            this.rbSolicitouBeneficioNao.TabIndex = 21;
            this.rbSolicitouBeneficioNao.TabStop = true;
            this.rbSolicitouBeneficioNao.Text = "Não";
            this.rbSolicitouBeneficioNao.UseVisualStyleBackColor = true;
            this.rbSolicitouBeneficioNao.CheckedChanged += new System.EventHandler(this.rbSolicitouBeneficioNao_CheckedChanged);
            // 
            // rbSolicitouBeneficoSim
            // 
            this.rbSolicitouBeneficoSim.AutoSize = true;
            this.rbSolicitouBeneficoSim.Location = new System.Drawing.Point(53, 108);
            this.rbSolicitouBeneficoSim.Margin = new System.Windows.Forms.Padding(4);
            this.rbSolicitouBeneficoSim.Name = "rbSolicitouBeneficoSim";
            this.rbSolicitouBeneficoSim.Size = new System.Drawing.Size(51, 20);
            this.rbSolicitouBeneficoSim.TabIndex = 20;
            this.rbSolicitouBeneficoSim.TabStop = true;
            this.rbSolicitouBeneficoSim.Text = "Sim";
            this.rbSolicitouBeneficoSim.UseVisualStyleBackColor = true;
            this.rbSolicitouBeneficoSim.CheckedChanged += new System.EventHandler(this.rbSolicitouBeneficioSim_CheckedChanged);
            // 
            // lblTrabalahndoAtualmente
            // 
            this.lblTrabalahndoAtualmente.AutoSize = true;
            this.lblTrabalahndoAtualmente.Location = new System.Drawing.Point(48, 189);
            this.lblTrabalahndoAtualmente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrabalahndoAtualmente.Name = "lblTrabalahndoAtualmente";
            this.lblTrabalahndoAtualmente.Size = new System.Drawing.Size(346, 16);
            this.lblTrabalahndoAtualmente.TabIndex = 18;
            this.lblTrabalahndoAtualmente.Text = "Tem quanto tempo que você trabalha no emprego atual?";
            // 
            // lblAnosDeCarteira
            // 
            this.lblAnosDeCarteira.AutoSize = true;
            this.lblAnosDeCarteira.Location = new System.Drawing.Point(49, 88);
            this.lblAnosDeCarteira.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnosDeCarteira.Name = "lblAnosDeCarteira";
            this.lblAnosDeCarteira.Size = new System.Drawing.Size(225, 16);
            this.lblAnosDeCarteira.TabIndex = 17;
            this.lblAnosDeCarteira.Text = "Já solicitou o benefício alguma vez ?";
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(176, 403);
            this.btnCalcula.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(199, 47);
            this.btnCalcula.TabIndex = 16;
            this.btnCalcula.Text = "CALCULAR";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblresultado);
            this.panel1.Location = new System.Drawing.Point(76, 458);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 183);
            this.panel1.TabIndex = 15;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(152, 81);
            this.lblresultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(44, 16);
            this.lblresultado.TabIndex = 4;
            this.lblresultado.Text = "label1";
            // 
            // txtVezesSolicitadas
            // 
            this.txtVezesSolicitadas.Location = new System.Drawing.Point(53, 152);
            this.txtVezesSolicitadas.Margin = new System.Windows.Forms.Padding(4);
            this.txtVezesSolicitadas.Name = "txtVezesSolicitadas";
            this.txtVezesSolicitadas.Size = new System.Drawing.Size(239, 22);
            this.txtVezesSolicitadas.TabIndex = 22;
            this.txtVezesSolicitadas.Visible = false;
            this.txtVezesSolicitadas.WordWrap = false;
            // 
            // lblVezesSolicitadas
            // 
            this.lblVezesSolicitadas.AutoSize = true;
            this.lblVezesSolicitadas.Location = new System.Drawing.Point(48, 132);
            this.lblVezesSolicitadas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVezesSolicitadas.Name = "lblVezesSolicitadas";
            this.lblVezesSolicitadas.Size = new System.Drawing.Size(338, 16);
            this.lblVezesSolicitadas.TabIndex = 23;
            this.lblVezesSolicitadas.Text = "Informe a quantidade de vezes que solicitou o benefício";
            this.lblVezesSolicitadas.Visible = false;
            // 
            // txtMesesTrabalhados
            // 
            this.txtMesesTrabalhados.Location = new System.Drawing.Point(52, 219);
            this.txtMesesTrabalhados.Margin = new System.Windows.Forms.Padding(4);
            this.txtMesesTrabalhados.Name = "txtMesesTrabalhados";
            this.txtMesesTrabalhados.Size = new System.Drawing.Size(239, 22);
            this.txtMesesTrabalhados.TabIndex = 24;
            this.txtMesesTrabalhados.WordWrap = false;
            // 
            // frmBeneficioSeguroDesemprego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 654);
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
    }
}