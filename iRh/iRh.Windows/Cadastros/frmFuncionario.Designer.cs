namespace iRh.Windows.Cadastros
{
    partial class frmFuncionario
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
            this.cmdGernero = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbRemFilhosSim = new System.Windows.Forms.RadioButton();
            this.rbRemFilhosNao = new System.Windows.Forms.RadioButton();
            this.txtFilhoNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.panelExibeDadosFilhos = new System.Windows.Forms.Panel();
            this.txtFilhoDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.panelExibeDadosFilhos.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdGernero
            // 
            this.cmdGernero.FormattingEnabled = true;
            this.cmdGernero.Items.AddRange(new object[] {
            "Feminino",
            "Masculino",
            "Prefiro nao indentificar"});
            this.cmdGernero.Location = new System.Drawing.Point(29, 58);
            this.cmdGernero.Name = "cmdGernero";
            this.cmdGernero.Size = new System.Drawing.Size(178, 21);
            this.cmdGernero.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Você tem Filhos ?";
            // 
            // rbRemFilhosSim
            // 
            this.rbRemFilhosSim.AutoSize = true;
            this.rbRemFilhosSim.Location = new System.Drawing.Point(29, 109);
            this.rbRemFilhosSim.Name = "rbRemFilhosSim";
            this.rbRemFilhosSim.Size = new System.Drawing.Size(42, 17);
            this.rbRemFilhosSim.TabIndex = 2;
            this.rbRemFilhosSim.TabStop = true;
            this.rbRemFilhosSim.Text = "Sim";
            this.rbRemFilhosSim.UseVisualStyleBackColor = true;
            this.rbRemFilhosSim.CheckedChanged += new System.EventHandler(this.rbRemFilhosSim_CheckedChanged);
            // 
            // rbRemFilhosNao
            // 
            this.rbRemFilhosNao.AutoSize = true;
            this.rbRemFilhosNao.Location = new System.Drawing.Point(81, 109);
            this.rbRemFilhosNao.Name = "rbRemFilhosNao";
            this.rbRemFilhosNao.Size = new System.Drawing.Size(45, 17);
            this.rbRemFilhosNao.TabIndex = 3;
            this.rbRemFilhosNao.TabStop = true;
            this.rbRemFilhosNao.Text = "Não";
            this.rbRemFilhosNao.UseVisualStyleBackColor = true;
            this.rbRemFilhosNao.CheckedChanged += new System.EventHandler(this.rbRemFilhosNao_CheckedChanged);
            // 
            // txtFilhoNome
            // 
            this.txtFilhoNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFilhoNome.Location = new System.Drawing.Point(9, 27);
            this.txtFilhoNome.Name = "txtFilhoNome";
            this.txtFilhoNome.Size = new System.Drawing.Size(88, 20);
            this.txtFilhoNome.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Você tem Filhos ?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data de Nascimento";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(245, 30);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(44, 13);
            this.lblIdade.TabIndex = 8;
            this.lblIdade.Text = "lblIdade";
            // 
            // panelExibeDadosFilhos
            // 
            this.panelExibeDadosFilhos.Controls.Add(this.txtFilhoDataNascimento);
            this.panelExibeDadosFilhos.Controls.Add(this.lblIdade);
            this.panelExibeDadosFilhos.Controls.Add(this.label3);
            this.panelExibeDadosFilhos.Controls.Add(this.label2);
            this.panelExibeDadosFilhos.Controls.Add(this.txtFilhoNome);
            this.panelExibeDadosFilhos.Location = new System.Drawing.Point(29, 132);
            this.panelExibeDadosFilhos.Name = "panelExibeDadosFilhos";
            this.panelExibeDadosFilhos.Size = new System.Drawing.Size(299, 57);
            this.panelExibeDadosFilhos.TabIndex = 9;
            // 
            // txtFilhoDataNascimento
            // 
            this.txtFilhoDataNascimento.Location = new System.Drawing.Point(130, 27);
            this.txtFilhoDataNascimento.Mask = "00/00/0000";
            this.txtFilhoDataNascimento.Name = "txtFilhoDataNascimento";
            this.txtFilhoDataNascimento.Size = new System.Drawing.Size(109, 20);
            this.txtFilhoDataNascimento.TabIndex = 10;
            this.txtFilhoDataNascimento.ValidatingType = typeof(System.DateTime);
            this.txtFilhoDataNascimento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilhoDataNascimento_KeyDown);
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelExibeDadosFilhos);
            this.Controls.Add(this.rbRemFilhosNao);
            this.Controls.Add(this.rbRemFilhosSim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdGernero);
            this.Name = "frmFuncionario";
            this.Text = "frmFuncionario";
            this.Load += new System.EventHandler(this.frmFuncionario_Load);
            this.panelExibeDadosFilhos.ResumeLayout(false);
            this.panelExibeDadosFilhos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmdGernero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbRemFilhosSim;
        private System.Windows.Forms.RadioButton rbRemFilhosNao;
        private System.Windows.Forms.TextBox txtFilhoNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Panel panelExibeDadosFilhos;
        private System.Windows.Forms.MaskedTextBox txtFilhoDataNascimento;
    }
}