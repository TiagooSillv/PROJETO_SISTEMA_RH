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
            this.lblResultado1 = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.lblAnosDeCarteira = new System.Windows.Forms.Label();
            this.lblTrabalahndoAtualmente = new System.Windows.Forms.Label();
            this.cmbMesesTrabalhados = new System.Windows.Forms.ComboBox();
            this.rbSolicitouBeneficioNao = new System.Windows.Forms.RadioButton();
            this.rbSolicitouBeneficioSim = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSalario
            // 
            this.txtSalario.BackColor = System.Drawing.SystemColors.Control;
            this.txtSalario.Location = new System.Drawing.Point(85, 42);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(180, 20);
            this.txtSalario.TabIndex = 0;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.BackColor = System.Drawing.SystemColors.Control;
            this.lblSalario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSalario.Location = new System.Drawing.Point(146, 24);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(55, 15);
            this.lblSalario.TabIndex = 1;
            this.lblSalario.Text = "SALÁRIO";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblResultado1);
            this.panel1.Controls.Add(this.lblresultado);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(59, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 35);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // lblResultado1
            // 
            this.lblResultado1.AutoSize = true;
            this.lblResultado1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado1.Location = new System.Drawing.Point(18, 7);
            this.lblResultado1.Name = "lblResultado1";
            this.lblResultado1.Size = new System.Drawing.Size(112, 17);
            this.lblResultado1.TabIndex = 14;
            this.lblResultado1.Text = "Valor a receber : ";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(144, 7);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(45, 17);
            this.lblresultado.TabIndex = 4;
            this.lblresultado.Text = "label1";
            // 
            // btnCalcula
            // 
            this.btnCalcula.BackColor = System.Drawing.SystemColors.Control;
            this.btnCalcula.Location = new System.Drawing.Point(105, 223);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(111, 26);
            this.btnCalcula.TabIndex = 3;
            this.btnCalcula.Text = "CALCULAR";
            this.btnCalcula.UseVisualStyleBackColor = false;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // lblAnosDeCarteira
            // 
            this.lblAnosDeCarteira.AutoSize = true;
            this.lblAnosDeCarteira.BackColor = System.Drawing.SystemColors.Control;
            this.lblAnosDeCarteira.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnosDeCarteira.Location = new System.Drawing.Point(41, 83);
            this.lblAnosDeCarteira.Name = "lblAnosDeCarteira";
            this.lblAnosDeCarteira.Size = new System.Drawing.Size(211, 15);
            this.lblAnosDeCarteira.TabIndex = 4;
            this.lblAnosDeCarteira.Text = "Tem mais de 5 anos de carteira assinada ?";
            // 
            // lblTrabalahndoAtualmente
            // 
            this.lblTrabalahndoAtualmente.AutoSize = true;
            this.lblTrabalahndoAtualmente.BackColor = System.Drawing.SystemColors.Control;
            this.lblTrabalahndoAtualmente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTrabalahndoAtualmente.Location = new System.Drawing.Point(41, 144);
            this.lblTrabalahndoAtualmente.Name = "lblTrabalahndoAtualmente";
            this.lblTrabalahndoAtualmente.Size = new System.Drawing.Size(289, 15);
            this.lblTrabalahndoAtualmente.TabIndex = 9;
            this.lblTrabalahndoAtualmente.Text = "Quantos meses trabalhou de carteira assinada no ano atual";
            // 
            // cmbMesesTrabalhados
            // 
            this.cmbMesesTrabalhados.BackColor = System.Drawing.SystemColors.Control;
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
            this.cmbMesesTrabalhados.Location = new System.Drawing.Point(44, 170);
            this.cmbMesesTrabalhados.Name = "cmbMesesTrabalhados";
            this.cmbMesesTrabalhados.Size = new System.Drawing.Size(121, 21);
            this.cmbMesesTrabalhados.TabIndex = 10;
            // 
            // rbSolicitouBeneficioNao
            // 
            this.rbSolicitouBeneficioNao.AutoSize = true;
            this.rbSolicitouBeneficioNao.BackColor = System.Drawing.SystemColors.Control;
            this.rbSolicitouBeneficioNao.Location = new System.Drawing.Point(105, 108);
            this.rbSolicitouBeneficioNao.Name = "rbSolicitouBeneficioNao";
            this.rbSolicitouBeneficioNao.Size = new System.Drawing.Size(45, 17);
            this.rbSolicitouBeneficioNao.TabIndex = 12;
            this.rbSolicitouBeneficioNao.TabStop = true;
            this.rbSolicitouBeneficioNao.Text = "Não";
            this.rbSolicitouBeneficioNao.UseVisualStyleBackColor = false;
            // 
            // rbSolicitouBeneficioSim
            // 
            this.rbSolicitouBeneficioSim.AutoSize = true;
            this.rbSolicitouBeneficioSim.BackColor = System.Drawing.SystemColors.Control;
            this.rbSolicitouBeneficioSim.Location = new System.Drawing.Point(44, 108);
            this.rbSolicitouBeneficioSim.Name = "rbSolicitouBeneficioSim";
            this.rbSolicitouBeneficioSim.Size = new System.Drawing.Size(42, 17);
            this.rbSolicitouBeneficioSim.TabIndex = 13;
            this.rbSolicitouBeneficioSim.TabStop = true;
            this.rbSolicitouBeneficioSim.Text = "Sim";
            this.rbSolicitouBeneficioSim.UseVisualStyleBackColor = false;
            // 
            // frmBeneficioPis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.qual_o_perfil_ideal_dos_profissionais_de_rh;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(353, 341);
            this.Controls.Add(this.rbSolicitouBeneficioSim);
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
        private System.Windows.Forms.Label lblTrabalahndoAtualmente;
        private System.Windows.Forms.ComboBox cmbMesesTrabalhados;
        private System.Windows.Forms.RadioButton rbSolicitouBeneficioNao;
        private System.Windows.Forms.RadioButton rbSolicitouBeneficioSim;
        private System.Windows.Forms.Label lblResultado1;
        private System.Windows.Forms.Label lblAnosDeCarteira;
    }
}