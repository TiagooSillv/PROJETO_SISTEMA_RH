namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioPericulosidade
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
            this.txtPericulosidade = new System.Windows.Forms.TextBox();
            this.lblHorasExtras = new System.Windows.Forms.Label();
            this.btnCalacula = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPericulosidade
            // 
            this.txtPericulosidade.Location = new System.Drawing.Point(409, 201);
            this.txtPericulosidade.Margin = new System.Windows.Forms.Padding(2);
            this.txtPericulosidade.Name = "txtPericulosidade";
            this.txtPericulosidade.Size = new System.Drawing.Size(146, 20);
            this.txtPericulosidade.TabIndex = 17;
            // 
            // lblHorasExtras
            // 
            this.lblHorasExtras.AutoSize = true;
            this.lblHorasExtras.Location = new System.Drawing.Point(436, 173);
            this.lblHorasExtras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHorasExtras.Name = "lblHorasExtras";
            this.lblHorasExtras.Size = new System.Drawing.Size(85, 13);
            this.lblHorasExtras.TabIndex = 16;
            this.lblHorasExtras.Text = "HORAS FEITAS";
            // 
            // btnCalacula
            // 
            this.btnCalacula.Location = new System.Drawing.Point(290, 235);
            this.btnCalacula.Name = "btnCalacula";
            this.btnCalacula.Size = new System.Drawing.Size(99, 22);
            this.btnCalacula.TabIndex = 15;
            this.btnCalacula.Text = "CALCULA";
            this.btnCalacula.UseVisualStyleBackColor = true;
            this.btnCalacula.Click += new System.EventHandler(this.btnCalacula_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblResultado);
            this.panel1.Location = new System.Drawing.Point(47, 293);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 146);
            this.panel1.TabIndex = 14;
            this.panel1.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(267, 66);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(49, 13);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "lblSalario";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(120, 201);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(146, 20);
            this.txtSalario.TabIndex = 13;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(171, 173);
            this.lblSalario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(53, 13);
            this.lblSalario.TabIndex = 12;
            this.lblSalario.Text = "SALARIO";
            // 
            // frmBeneficioPericulosidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPericulosidade);
            this.Controls.Add(this.lblHorasExtras);
            this.Controls.Add(this.btnCalacula);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Name = "frmBeneficioPericulosidade";
            this.Text = "frmBeneficioPericulosidade";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPericulosidade;
        private System.Windows.Forms.Label lblHorasExtras;
        private System.Windows.Forms.Button btnCalacula;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
    }
}