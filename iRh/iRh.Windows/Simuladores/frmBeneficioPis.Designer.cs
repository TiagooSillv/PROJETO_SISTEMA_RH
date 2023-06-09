﻿using System;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioPis));
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
            this.lblLoading = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSalario
            // 
            this.txtSalario.BackColor = System.Drawing.Color.Silver;
            this.txtSalario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtSalario.Location = new System.Drawing.Point(148, 98);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(239, 32);
            this.txtSalario.TabIndex = 0;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.BackColor = System.Drawing.Color.Silver;
            this.lblSalario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSalario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSalario.Location = new System.Drawing.Point(223, 68);
            this.lblSalario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(93, 27);
            this.lblSalario.TabIndex = 1;
            this.lblSalario.Text = "SALÁRIO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblResultado1);
            this.panel1.Controls.Add(this.lblresultado);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(113, 377);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 42);
            this.panel1.TabIndex = 2;
            // 
            // lblResultado1
            // 
            this.lblResultado1.AutoSize = true;
            this.lblResultado1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblResultado1.Location = new System.Drawing.Point(24, 9);
            this.lblResultado1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado1.Name = "lblResultado1";
            this.lblResultado1.Size = new System.Drawing.Size(161, 25);
            this.lblResultado1.TabIndex = 14;
            this.lblResultado1.Text = "Valor a receber : ";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblresultado.Location = new System.Drawing.Point(220, 9);
            this.lblresultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(52, 25);
            this.lblresultado.TabIndex = 4;
            this.lblresultado.Text = "-----";
            // 
            // btnCalcula
            // 
            this.btnCalcula.BackColor = System.Drawing.Color.Silver;
            this.btnCalcula.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCalcula.Location = new System.Drawing.Point(179, 336);
            this.btnCalcula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(148, 32);
            this.btnCalcula.TabIndex = 3;
            this.btnCalcula.Text = "CALCULAR";
            this.btnCalcula.UseVisualStyleBackColor = false;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // lblAnosDeCarteira
            // 
            this.lblAnosDeCarteira.AutoSize = true;
            this.lblAnosDeCarteira.BackColor = System.Drawing.Color.Silver;
            this.lblAnosDeCarteira.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnosDeCarteira.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAnosDeCarteira.Location = new System.Drawing.Point(63, 146);
            this.lblAnosDeCarteira.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnosDeCarteira.Name = "lblAnosDeCarteira";
            this.lblAnosDeCarteira.Size = new System.Drawing.Size(378, 27);
            this.lblAnosDeCarteira.TabIndex = 4;
            this.lblAnosDeCarteira.Text = "Tem mais de 5 anos de carteira assinada ?";
            // 
            // lblTrabalahndoAtualmente
            // 
            this.lblTrabalahndoAtualmente.AutoSize = true;
            this.lblTrabalahndoAtualmente.BackColor = System.Drawing.Color.Silver;
            this.lblTrabalahndoAtualmente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTrabalahndoAtualmente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTrabalahndoAtualmente.Location = new System.Drawing.Point(63, 222);
            this.lblTrabalahndoAtualmente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrabalahndoAtualmente.Name = "lblTrabalahndoAtualmente";
            this.lblTrabalahndoAtualmente.Size = new System.Drawing.Size(536, 27);
            this.lblTrabalahndoAtualmente.TabIndex = 9;
            this.lblTrabalahndoAtualmente.Text = "Quantos meses trabalhou de carteira assinada no ano atual";
            // 
            // cmbMesesTrabalhados
            // 
            this.cmbMesesTrabalhados.BackColor = System.Drawing.Color.Silver;
            this.cmbMesesTrabalhados.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
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
            this.cmbMesesTrabalhados.Location = new System.Drawing.Point(63, 252);
            this.cmbMesesTrabalhados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMesesTrabalhados.Name = "cmbMesesTrabalhados";
            this.cmbMesesTrabalhados.Size = new System.Drawing.Size(160, 33);
            this.cmbMesesTrabalhados.TabIndex = 10;
            // 
            // rbSolicitouBeneficioNao
            // 
            this.rbSolicitouBeneficioNao.AutoSize = true;
            this.rbSolicitouBeneficioNao.BackColor = System.Drawing.Color.Silver;
            this.rbSolicitouBeneficioNao.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.rbSolicitouBeneficioNao.Location = new System.Drawing.Point(148, 177);
            this.rbSolicitouBeneficioNao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbSolicitouBeneficioNao.Name = "rbSolicitouBeneficioNao";
            this.rbSolicitouBeneficioNao.Size = new System.Drawing.Size(70, 29);
            this.rbSolicitouBeneficioNao.TabIndex = 12;
            this.rbSolicitouBeneficioNao.TabStop = true;
            this.rbSolicitouBeneficioNao.Text = "Não";
            this.rbSolicitouBeneficioNao.UseVisualStyleBackColor = false;
            // 
            // rbSolicitouBeneficioSim
            // 
            this.rbSolicitouBeneficioSim.AutoSize = true;
            this.rbSolicitouBeneficioSim.BackColor = System.Drawing.Color.Silver;
            this.rbSolicitouBeneficioSim.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.rbSolicitouBeneficioSim.Location = new System.Drawing.Point(67, 177);
            this.rbSolicitouBeneficioSim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbSolicitouBeneficioSim.Name = "rbSolicitouBeneficioSim";
            this.rbSolicitouBeneficioSim.Size = new System.Drawing.Size(66, 29);
            this.rbSolicitouBeneficioSim.TabIndex = 13;
            this.rbSolicitouBeneficioSim.TabStop = true;
            this.rbSolicitouBeneficioSim.Text = "Sim";
            this.rbSolicitouBeneficioSim.UseVisualStyleBackColor = false;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.Silver;
            this.lblLoading.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.Black;
            this.lblLoading.Location = new System.Drawing.Point(199, 290);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(108, 22);
            this.lblLoading.TabIndex = 16;
            this.lblLoading.Text = "LOADING...";
            this.lblLoading.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Silver;
            this.progressBar1.Location = new System.Drawing.Point(156, 315);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(197, 15);
            this.progressBar1.TabIndex = 15;
            this.progressBar1.Value = 100;
            this.progressBar1.Visible = false;
            // 
            // frmBeneficioPis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.imagens_rh;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(633, 533);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.rbSolicitouBeneficioSim);
            this.Controls.Add(this.rbSolicitouBeneficioNao);
            this.Controls.Add(this.cmbMesesTrabalhados);
            this.Controls.Add(this.lblTrabalahndoAtualmente);
            this.Controls.Add(this.lblAnosDeCarteira);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.txtSalario);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBeneficioPis";
            this.Text = "Beneficio PIS";
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
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}