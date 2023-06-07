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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSalario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.ForeColor = System.Drawing.Color.Black;
            this.lblSalario.Location = new System.Drawing.Point(132, 67);
            this.lblSalario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(75, 23);
            this.lblSalario.TabIndex = 0;
            this.lblSalario.Text = "SALARIO";
            // 
            // txtSalario
            // 
            this.txtSalario.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSalario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSalario.Location = new System.Drawing.Point(92, 92);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(146, 25);
            this.txtSalario.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblResultado);
            this.panel1.Location = new System.Drawing.Point(62, 230);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 41);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblResultado.Location = new System.Drawing.Point(121, 10);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(66, 17);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "lblSalario";
            // 
            // btnCalacula
            // 
            this.btnCalacula.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCalacula.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalacula.Location = new System.Drawing.Point(108, 194);
            this.btnCalacula.Name = "btnCalacula";
            this.btnCalacula.Size = new System.Drawing.Size(99, 31);
            this.btnCalacula.TabIndex = 3;
            this.btnCalacula.Text = "CALCULA";
            this.btnCalacula.UseVisualStyleBackColor = false;
            this.btnCalacula.Click += new System.EventHandler(this.btnCalacula_Click);
            // 
            // lblHorasNoturnas
            // 
            this.lblHorasNoturnas.AutoSize = true;
            this.lblHorasNoturnas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblHorasNoturnas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasNoturnas.Location = new System.Drawing.Point(46, 136);
            this.lblHorasNoturnas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHorasNoturnas.Name = "lblHorasNoturnas";
            this.lblHorasNoturnas.Size = new System.Drawing.Size(250, 17);
            this.lblHorasNoturnas.TabIndex = 4;
            this.lblHorasNoturnas.Text = "HORAS EM ADICIONAL NOTURNO FEITAS";
            // 
            // txtAdicionalNoturno
            // 
            this.txtAdicionalNoturno.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAdicionalNoturno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdicionalNoturno.Location = new System.Drawing.Point(92, 155);
            this.txtAdicionalNoturno.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdicionalNoturno.Name = "txtAdicionalNoturno";
            this.txtAdicionalNoturno.Size = new System.Drawing.Size(146, 25);
            this.txtAdicionalNoturno.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Valor a receber: ";
            // 
            // frmBeneficioAdicionalNoturno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.qual_o_perfil_ideal_dos_profissionais_de_rh1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(335, 386);
            this.Controls.Add(this.txtAdicionalNoturno);
            this.Controls.Add(this.lblHorasNoturnas);
            this.Controls.Add(this.btnCalacula);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBeneficioAdicionalNoturno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label1;
    }
}