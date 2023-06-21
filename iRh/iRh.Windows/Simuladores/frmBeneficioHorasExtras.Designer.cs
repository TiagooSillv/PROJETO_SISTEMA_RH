namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioHorasExtras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioHorasExtras));
            this.txtHorasExtra = new System.Windows.Forms.TextBox();
            this.lblHorasExtras = new System.Windows.Forms.Label();
            this.btnCalacula = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHorasExtra
            // 
            this.txtHorasExtra.BackColor = System.Drawing.Color.Silver;
            this.txtHorasExtra.ForeColor = System.Drawing.Color.Black;
            this.txtHorasExtra.Location = new System.Drawing.Point(186, 184);
            this.txtHorasExtra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHorasExtra.Name = "txtHorasExtra";
            this.txtHorasExtra.Size = new System.Drawing.Size(193, 22);
            this.txtHorasExtra.TabIndex = 11;
            // 
            // lblHorasExtras
            // 
            this.lblHorasExtras.AutoSize = true;
            this.lblHorasExtras.BackColor = System.Drawing.Color.Silver;
            this.lblHorasExtras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHorasExtras.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblHorasExtras.ForeColor = System.Drawing.Color.Black;
            this.lblHorasExtras.Location = new System.Drawing.Point(213, 155);
            this.lblHorasExtras.Name = "lblHorasExtras";
            this.lblHorasExtras.Size = new System.Drawing.Size(144, 27);
            this.lblHorasExtras.TabIndex = 10;
            this.lblHorasExtras.Text = "HORAS FEITAS";
            // 
            // btnCalacula
            // 
            this.btnCalacula.BackColor = System.Drawing.Color.Silver;
            this.btnCalacula.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCalacula.ForeColor = System.Drawing.Color.Black;
            this.btnCalacula.Location = new System.Drawing.Point(211, 220);
            this.btnCalacula.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalacula.Name = "btnCalacula";
            this.btnCalacula.Size = new System.Drawing.Size(144, 35);
            this.btnCalacula.TabIndex = 9;
            this.btnCalacula.Text = "CALCULA";
            this.btnCalacula.UseVisualStyleBackColor = false;
            this.btnCalacula.Click += new System.EventHandler(this.btnCalacula_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblResultado);
            this.panel1.Location = new System.Drawing.Point(143, 308);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 49);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Valor a receber: ";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblResultado.Location = new System.Drawing.Point(166, 11);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(52, 25);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "-----";
            // 
            // txtSalario
            // 
            this.txtSalario.BackColor = System.Drawing.Color.Silver;
            this.txtSalario.ForeColor = System.Drawing.Color.Black;
            this.txtSalario.Location = new System.Drawing.Point(186, 120);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(193, 22);
            this.txtSalario.TabIndex = 7;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.BackColor = System.Drawing.Color.Silver;
            this.lblSalario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSalario.ForeColor = System.Drawing.Color.Black;
            this.lblSalario.Location = new System.Drawing.Point(240, 91);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(93, 27);
            this.lblSalario.TabIndex = 6;
            this.lblSalario.Text = "SALARIO";
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.Silver;
            this.lblLoading.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.Black;
            this.lblLoading.Location = new System.Drawing.Point(219, 259);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(127, 26);
            this.lblLoading.TabIndex = 14;
            this.lblLoading.Text = "LOADING...";
            this.lblLoading.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Silver;
            this.progressBar1.Location = new System.Drawing.Point(181, 288);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(198, 15);
            this.progressBar1.TabIndex = 13;
            this.progressBar1.Value = 100;
            this.progressBar1.Visible = false;
            // 
            // frmBeneficioHorasExtras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.imagens_rh;
            this.ClientSize = new System.Drawing.Size(549, 519);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtHorasExtra);
            this.Controls.Add(this.lblHorasExtras);
            this.Controls.Add(this.btnCalacula);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBeneficioHorasExtras";
            this.Text = "Horas Extras";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHorasExtra;
        private System.Windows.Forms.Label lblHorasExtras;
        private System.Windows.Forms.Button btnCalacula;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
    }
}