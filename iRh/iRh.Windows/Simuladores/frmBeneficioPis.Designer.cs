using System;

namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioPis
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
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblresultado = new System.Windows.Forms.Label();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.lblAnosDeCarteira = new System.Windows.Forms.Label();
            this.lblTrabalahndoAtualmente = new System.Windows.Forms.Label();
            this.cmbMesesTrabalhados = new System.Windows.Forms.ComboBox();
            this.rbSolicitouBeneficioSim = new System.Windows.Forms.RadioButton();
            this.rbSolicitouBeneficioNao = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(200, 44);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(180, 20);
            this.txtSalario.TabIndex = 0;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(253, 28);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(53, 13);
            this.lblSalario.TabIndex = 1;
            this.lblSalario.Text = "SALÁRIO";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblresultado);
            this.panel1.Location = new System.Drawing.Point(139, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 149);
            this.panel1.TabIndex = 2;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(114, 66);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(35, 13);
            this.lblresultado.TabIndex = 4;
            this.lblresultado.Text = "label1";
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(200, 224);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(149, 38);
            this.btnCalcula.TabIndex = 3;
            this.btnCalcula.Text = "CALCULAR";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // lblAnosDeCarteira
            // 
            this.lblAnosDeCarteira.AutoSize = true;
            this.lblAnosDeCarteira.Location = new System.Drawing.Point(136, 78);
            this.lblAnosDeCarteira.Name = "lblAnosDeCarteira";
            this.lblAnosDeCarteira.Size = new System.Drawing.Size(209, 13);
            this.lblAnosDeCarteira.TabIndex = 4;
            this.lblAnosDeCarteira.Text = "Tem mais de 5 anos de carteira assinada ?";
            // 
            // lblTrabalahndoAtualmente
            // 
            this.lblTrabalahndoAtualmente.AutoSize = true;
            this.lblTrabalahndoAtualmente.Location = new System.Drawing.Point(136, 145);
            this.lblTrabalahndoAtualmente.Name = "lblTrabalahndoAtualmente";
            this.lblTrabalahndoAtualmente.Size = new System.Drawing.Size(287, 13);
            this.lblTrabalahndoAtualmente.TabIndex = 9;
            this.lblTrabalahndoAtualmente.Text = "Quantos meses trabalhou de carteira assinada no ano atual";
            // 
            // cmbMesesTrabalhados
            // 
            this.cmbMesesTrabalhados.FormattingEnabled = true;
            this.cmbMesesTrabalhados.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbMesesTrabalhados.Location = new System.Drawing.Point(139, 171);
            this.cmbMesesTrabalhados.Name = "cmbMesesTrabalhados";
            this.cmbMesesTrabalhados.Size = new System.Drawing.Size(121, 21);
            this.cmbMesesTrabalhados.TabIndex = 10;
            // 
            // rbTempoDeCarteiraSim
            // 
            this.rbSolicitouBeneficioSim.AutoSize = true;
            this.rbSolicitouBeneficioSim.Location = new System.Drawing.Point(142, 109);
            this.rbSolicitouBeneficioSim.Name = "rbSolicitouBeneficioSim";
            this.rbSolicitouBeneficioSim.Size = new System.Drawing.Size(42, 17);
            this.rbSolicitouBeneficioSim.TabIndex = 11;
            this.rbSolicitouBeneficioSim.TabStop = true;
            this.rbSolicitouBeneficioSim.Text = "Sim";
            this.rbSolicitouBeneficioSim.UseVisualStyleBackColor = true;
            // 
            // rbTempoDeCarteiraNao
            // 
            this.rbSolicitouBeneficioNao.AutoSize = true;
            this.rbSolicitouBeneficioNao.Location = new System.Drawing.Point(200, 109);
            this.rbSolicitouBeneficioNao.Name = "rbTempoDeCarteiraNao";
            this.rbSolicitouBeneficioNao.Size = new System.Drawing.Size(45, 17);
            this.rbSolicitouBeneficioNao.TabIndex = 12;
            this.rbSolicitouBeneficioNao.TabStop = true;
            this.rbSolicitouBeneficioNao.Text = "Não";
            this.rbSolicitouBeneficioNao.UseVisualStyleBackColor = true;
            this.rbSolicitouBeneficioNao.CheckedChanged += new System.EventHandler(this.rbSolicitouBeneficioNao_CheckedChanged);
            // 
            // frmBeneficioPis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.rbSolicitouBeneficioNao);
            this.Controls.Add(this.rbSolicitouBeneficioNao);
            this.Controls.Add(this.cmbMesesTrabalhados);
            this.Controls.Add(this.lblTrabalahndoAtualmente);
            this.Controls.Add(this.lblAnosDeCarteira);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.txtSalario);
            this.Name = "frmBeneficioPis";
            this.Text = "frmBeneficioPis";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void rbSolicitouBeneficioNao_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label lblAnosDeCarteira;
        private System.Windows.Forms.Label lblTrabalahndoAtualmente;
        private System.Windows.Forms.ComboBox cmbMesesTrabalhados;
        private System.Windows.Forms.RadioButton rbSolicitouBeneficioSim;
        private System.Windows.Forms.RadioButton rbSolicitouBeneficioNao;
    }
}