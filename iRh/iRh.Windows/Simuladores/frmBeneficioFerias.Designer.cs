namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioFerias
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
            this.btnCalcula = new System.Windows.Forms.Button();
            this.rbVendaDeFerias = new System.Windows.Forms.RadioButton();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbDiasVendidos = new System.Windows.Forms.ComboBox();
            this.rbVendaDeFeriasNao = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(45, 121);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(128, 35);
            this.txtSalario.TabIndex = 0;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblSalario.Location = new System.Drawing.Point(60, 88);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(100, 30);
            this.lblSalario.TabIndex = 1;
            this.lblSalario.Text = "SALÁRIO";
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(65, 160);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(75, 23);
            this.btnCalcula.TabIndex = 2;
            this.btnCalcula.Text = "CALCULAR";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // rbVendaDeFerias
            // 
            this.rbVendaDeFerias.AutoSize = true;
            this.rbVendaDeFerias.Location = new System.Drawing.Point(222, 121);
            this.rbVendaDeFerias.Name = "rbVendaDeFerias";
            this.rbVendaDeFerias.Size = new System.Drawing.Size(43, 17);
            this.rbVendaDeFerias.TabIndex = 4;
            this.rbVendaDeFerias.TabStop = true;
            this.rbVendaDeFerias.Text = "Sim";
            this.rbVendaDeFerias.UseVisualStyleBackColor = true;
            this.rbVendaDeFerias.CheckedChanged += new System.EventHandler(this.rbVendaDeFerias_CheckedChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblResultado.Location = new System.Drawing.Point(237, 26);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(100, 30);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "SALÁRIO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblResultado);
            this.panel1.Location = new System.Drawing.Point(6, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 93);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // cmbDiasVendidos
            // 
            this.cmbDiasVendidos.FormattingEnabled = true;
            this.cmbDiasVendidos.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbDiasVendidos.Location = new System.Drawing.Point(222, 144);
            this.cmbDiasVendidos.Name = "cmbDiasVendidos";
            this.cmbDiasVendidos.Size = new System.Drawing.Size(121, 21);
            this.cmbDiasVendidos.TabIndex = 3;
            this.cmbDiasVendidos.Visible = false;
            // 
            // rbVendaDeFeriasNao
            // 
            this.rbVendaDeFeriasNao.AutoSize = true;
            this.rbVendaDeFeriasNao.Location = new System.Drawing.Point(271, 121);
            this.rbVendaDeFeriasNao.Name = "rbVendaDeFeriasNao";
            this.rbVendaDeFeriasNao.Size = new System.Drawing.Size(46, 17);
            this.rbVendaDeFeriasNao.TabIndex = 7;
            this.rbVendaDeFeriasNao.TabStop = true;
            this.rbVendaDeFeriasNao.Text = "Não";
            this.rbVendaDeFeriasNao.UseVisualStyleBackColor = true;
            this.rbVendaDeFeriasNao.CheckedChanged += new System.EventHandler(this.rbVendaDeFeriasNao_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label1.Location = new System.Drawing.Point(219, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Deseja Vender alguns dias de ferias ?";
            // 
            // frmBeneficioFerias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 324);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbVendaDeFeriasNao);
            this.Controls.Add(this.cmbDiasVendidos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbVendaDeFerias);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.txtSalario);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBeneficioFerias";
            this.Text = "frmBeneficioFerias";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.RadioButton rbVendaDeFerias;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbDiasVendidos;
        private System.Windows.Forms.RadioButton rbVendaDeFeriasNao;
        private System.Windows.Forms.Label label1;
    }
}