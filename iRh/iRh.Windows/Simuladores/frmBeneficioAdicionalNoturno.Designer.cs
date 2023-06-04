namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioAdicionalNoturno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioAdicionalNoturno));
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalacula = new System.Windows.Forms.Button();
            this.lblHorasNoturnas = new System.Windows.Forms.Label();
            this.txtAdicionalNoturno = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(87, 60);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(127, 38);
            this.lblSalario.TabIndex = 0;
            this.lblSalario.Text = "SALARIO";
            // 
            // txtSalario
            // 
            this.txtSalario.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSalario.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(48, 100);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(193, 43);
            this.txtSalario.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.lblResultado);
            this.panel1.Location = new System.Drawing.Point(59, 286);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 144);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(50, 60);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(64, 16);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "lblSalario";
            // 
            // btnCalacula
            // 
            this.btnCalacula.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnCalacula.Location = new System.Drawing.Point(69, 231);
            this.btnCalacula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalacula.Name = "btnCalacula";
            this.btnCalacula.Size = new System.Drawing.Size(132, 27);
            this.btnCalacula.TabIndex = 3;
            this.btnCalacula.Text = "CALCULA";
            this.btnCalacula.UseVisualStyleBackColor = false;
            this.btnCalacula.Click += new System.EventHandler(this.btnCalacula_Click);
            // 
            // lblHorasNoturnas
            // 
            this.lblHorasNoturnas.AutoSize = true;
            this.lblHorasNoturnas.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblHorasNoturnas.Location = new System.Drawing.Point(12, 145);
            this.lblHorasNoturnas.Name = "lblHorasNoturnas";
            this.lblHorasNoturnas.Size = new System.Drawing.Size(273, 16);
            this.lblHorasNoturnas.TabIndex = 4;
            this.lblHorasNoturnas.Text = "HORAS EM ADICIONAL NOTURNO FEITAS";
            // 
            // txtAdicionalNoturno
            // 
            this.txtAdicionalNoturno.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtAdicionalNoturno.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdicionalNoturno.Location = new System.Drawing.Point(48, 169);
            this.txtAdicionalNoturno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdicionalNoturno.Name = "txtAdicionalNoturno";
            this.txtAdicionalNoturno.Size = new System.Drawing.Size(193, 38);
            this.txtAdicionalNoturno.TabIndex = 5;
            // 
            // frmBeneficioAdicionalNoturno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.rh_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(868, 450);
            this.Controls.Add(this.txtAdicionalNoturno);
            this.Controls.Add(this.lblHorasNoturnas);
            this.Controls.Add(this.btnCalacula);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBeneficioAdicionalNoturno";
            this.Text = "Adicional Noturno";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCalacula;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblHorasNoturnas;
        private System.Windows.Forms.TextBox txtAdicionalNoturno;
    }
}