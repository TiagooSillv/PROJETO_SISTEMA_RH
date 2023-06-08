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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDiasVendidos = new System.Windows.Forms.ComboBox();
            this.rbVendaDeFeriasNao = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(63, 149);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(128, 29);
            this.txtSalario.TabIndex = 0;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(90, 105);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(82, 23);
            this.lblSalario.TabIndex = 1;
            this.lblSalario.Text = "SALÁRIO";
            // 
            // btnCalcula
            // 
            this.btnCalcula.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcula.Location = new System.Drawing.Point(70, 270);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(121, 35);
            this.btnCalcula.TabIndex = 2;
            this.btnCalcula.Text = "CALCULAR";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // rbVendaDeFerias
            // 
            this.rbVendaDeFerias.AutoSize = true;
            this.rbVendaDeFerias.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVendaDeFerias.Location = new System.Drawing.Point(231, 137);
            this.rbVendaDeFerias.Name = "rbVendaDeFerias";
            this.rbVendaDeFerias.Size = new System.Drawing.Size(62, 27);
            this.rbVendaDeFerias.TabIndex = 4;
            this.rbVendaDeFerias.TabStop = true;
            this.rbVendaDeFerias.Text = "Sim";
            this.rbVendaDeFerias.UseVisualStyleBackColor = true;
            this.rbVendaDeFerias.CheckedChanged += new System.EventHandler(this.rbVendaDeFerias_CheckedChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(150, 11);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(38, 23);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "----";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblResultado);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 320);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 43);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Valor a receber: ";
            // 
            // cmbDiasVendidos
            // 
            this.cmbDiasVendidos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmbDiasVendidos.Location = new System.Drawing.Point(225, 170);
            this.cmbDiasVendidos.Name = "cmbDiasVendidos";
            this.cmbDiasVendidos.Size = new System.Drawing.Size(152, 29);
            this.cmbDiasVendidos.TabIndex = 3;
            this.cmbDiasVendidos.Visible = false;
            // 
            // rbVendaDeFeriasNao
            // 
            this.rbVendaDeFeriasNao.AutoSize = true;
            this.rbVendaDeFeriasNao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVendaDeFeriasNao.Location = new System.Drawing.Point(314, 137);
            this.rbVendaDeFeriasNao.Name = "rbVendaDeFeriasNao";
            this.rbVendaDeFeriasNao.Size = new System.Drawing.Size(63, 27);
            this.rbVendaDeFeriasNao.TabIndex = 7;
            this.rbVendaDeFeriasNao.TabStop = true;
            this.rbVendaDeFeriasNao.Text = "Não";
            this.rbVendaDeFeriasNao.UseVisualStyleBackColor = true;
            this.rbVendaDeFeriasNao.CheckedChanged += new System.EventHandler(this.rbVendaDeFeriasNao_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Deseja Vender alguns dias de ferias ?";
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.Transparent;
            this.lblLoading.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.Black;
            this.lblLoading.Location = new System.Drawing.Point(75, 220);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(127, 26);
            this.lblLoading.TabIndex = 10;
            this.lblLoading.Text = "LOADING...";
            this.lblLoading.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.progressBar1.Location = new System.Drawing.Point(38, 249);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(198, 15);
            this.progressBar1.TabIndex = 9;
            this.progressBar1.Value = 100;
            this.progressBar1.Visible = false;
            // 
            // frmBeneficioFerias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.qual_o_perfil_ideal_dos_profissionais_de_rh1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(539, 436);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbVendaDeFeriasNao);
            this.Controls.Add(this.cmbDiasVendidos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbVendaDeFerias);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.txtSalario);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}