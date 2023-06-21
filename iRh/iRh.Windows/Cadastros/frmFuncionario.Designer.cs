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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionario));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbEstados = new System.Windows.Forms.ComboBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cmbDocumento = new System.Windows.Forms.ComboBox();
            this.lblDocumentoDeIdentificacao = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOME COMPLETO";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(52, 69);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(253, 22);
            this.txtNome.TabIndex = 1;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(331, 69);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(253, 22);
            this.txtCpf.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(604, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "DATA NASCIMENTO";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(608, 69);
            this.txtDataNascimento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDataNascimento.Mask = "00/00/0000";
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(200, 22);
            this.txtDataNascimento.TabIndex = 5;
            this.txtDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "CEP";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(179, 208);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 28);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(52, 262);
            this.txtLogradouro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(372, 22);
            this.txtLogradouro.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 242);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "LOGRADOURO";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(555, 262);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(253, 22);
            this.txtBairro.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 241);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "BAIRRO";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(52, 322);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(253, 22);
            this.txtCidade.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 302);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "CIDADE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(327, 302);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "UF/ESTADO";
            // 
            // cmbEstados
            // 
            this.cmbEstados.FormattingEnabled = true;
            this.cmbEstados.Location = new System.Drawing.Point(331, 322);
            this.cmbEstados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEstados.Name = "cmbEstados";
            this.cmbEstados.Size = new System.Drawing.Size(160, 24);
            this.cmbEstados.TabIndex = 16;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(433, 263);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(96, 22);
            this.txtNumero.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(429, 240);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "NÚMERO";
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(369, 386);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 25);
            this.button2.TabIndex = 19;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(52, 389);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(36, 22);
            this.textBox5.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 368);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "DDD";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(108, 389);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(253, 22);
            this.textBox6.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(104, 368);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "TELEFONE";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(427, 386);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(169, 29);
            this.linkLabel1.TabIndex = 24;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "chamar no zap";
            // 
            // cmbDocumento
            // 
            this.cmbDocumento.FormattingEnabled = true;
            this.cmbDocumento.Location = new System.Drawing.Point(52, 127);
            this.cmbDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDocumento.Name = "cmbDocumento";
            this.cmbDocumento.Size = new System.Drawing.Size(253, 24);
            this.cmbDocumento.TabIndex = 26;
            // 
            // lblDocumentoDeIdentificacao
            // 
            this.lblDocumentoDeIdentificacao.AutoSize = true;
            this.lblDocumentoDeIdentificacao.Location = new System.Drawing.Point(54, 107);
            this.lblDocumentoDeIdentificacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocumentoDeIdentificacao.Name = "lblDocumentoDeIdentificacao";
            this.lblDocumentoDeIdentificacao.Size = new System.Drawing.Size(231, 16);
            this.lblDocumentoDeIdentificacao.TabIndex = 25;
            this.lblDocumentoDeIdentificacao.Text = "DOCUMENTO DE INDENTIFICAÇÃO";
            // 
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(51, 206);
            this.txtCep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(117, 29);
            this.txtCep.TabIndex = 27;
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.imagens_rh;
            this.ClientSize = new System.Drawing.Size(871, 492);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.cmbDocumento);
            this.Controls.Add(this.lblDocumentoDeIdentificacao);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbEstados);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmFuncionario";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.frmFuncionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtDataNascimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbEstados;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox cmbDocumento;
        private System.Windows.Forms.Label lblDocumentoDeIdentificacao;
        private System.Windows.Forms.MaskedTextBox txtCep;
    }
}