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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioAdicionalNoturno));
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalacula = new System.Windows.Forms.Button();
            this.lblHorasNoturnas = new System.Windows.Forms.Label();
            this.txtAdicionalNoturno = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblLoading = new System.Windows.Forms.Label();
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
            this.lblSalario.Location = new System.Drawing.Point(180, 92);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(93, 30);
            this.lblSalario.TabIndex = 0;
            this.lblSalario.Text = "SALARIO";
            // 
            // txtSalario
            // 
            this.txtSalario.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSalario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSalario.Location = new System.Drawing.Point(131, 124);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(193, 30);
            this.txtSalario.TabIndex = 1;
            this.txtSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblResultado);
            this.panel1.Location = new System.Drawing.Point(90, 369);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 50);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Valor a receber: ";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblResultado.Location = new System.Drawing.Point(158, 12);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(45, 23);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "-----";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalacula
            // 
            this.btnCalacula.AutoSize = true;
            this.btnCalacula.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCalacula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCalacula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalacula.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCalacula.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalacula.ForeColor = System.Drawing.Color.Black;
            this.btnCalacula.Location = new System.Drawing.Point(157, 230);
            this.btnCalacula.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalacula.Name = "btnCalacula";
            this.btnCalacula.Size = new System.Drawing.Size(132, 38);
            this.btnCalacula.TabIndex = 3;
            this.btnCalacula.Text = "CALCULAR";
            this.btnCalacula.UseVisualStyleBackColor = false;
            this.btnCalacula.Click += new System.EventHandler(this.btnCalacula_Click);
            // 
            // lblHorasNoturnas
            // 
            this.lblHorasNoturnas.AutoSize = true;
            this.lblHorasNoturnas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblHorasNoturnas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasNoturnas.Location = new System.Drawing.Point(75, 170);
            this.lblHorasNoturnas.Name = "lblHorasNoturnas";
            this.lblHorasNoturnas.Size = new System.Drawing.Size(330, 23);
            this.lblHorasNoturnas.TabIndex = 4;
            this.lblHorasNoturnas.Text = "HORAS EM ADICIONAL NOTURNO FEITAS";
            // 
            // txtAdicionalNoturno
            // 
            this.txtAdicionalNoturno.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAdicionalNoturno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdicionalNoturno.Location = new System.Drawing.Point(131, 195);
            this.txtAdicionalNoturno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdicionalNoturno.Name = "txtAdicionalNoturno";
            this.txtAdicionalNoturno.Size = new System.Drawing.Size(193, 29);
            this.txtAdicionalNoturno.TabIndex = 5;
            this.txtAdicionalNoturno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAdicionalNoturno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdicionalNoturno_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Interval = 100000;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.progressBar1.Location = new System.Drawing.Point(107, 341);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(244, 23);
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Value = 100;
            this.progressBar1.Visible = false;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.Transparent;
            this.lblLoading.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.Black;
            this.lblLoading.Location = new System.Drawing.Point(170, 310);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(127, 26);
            this.lblLoading.TabIndex = 7;
            this.lblLoading.Text = "LOADING...";
            this.lblLoading.Visible = false;
            // 
            // frmBeneficioAdicionalNoturno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.qual_o_perfil_ideal_dos_profissionais_de_rh1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(447, 475);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtAdicionalNoturno);
            this.Controls.Add(this.lblHorasNoturnas);
            this.Controls.Add(this.btnCalacula);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBeneficioAdicionalNoturno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULO ADICIONAL NOTURNO";
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblLoading;
    }
}