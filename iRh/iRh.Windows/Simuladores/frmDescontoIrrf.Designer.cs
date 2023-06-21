namespace iRh.Windows.Simuladores
{
    partial class frmDescontoIrrf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDescontoIrrf));
            this.btnCalcular = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Silver;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCalcular.Location = new System.Drawing.Point(133, 153);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(124, 31);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblResultado);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(36, 248);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 45);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Valor do desconto: ";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblResultado.Location = new System.Drawing.Point(193, 10);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(52, 25);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "-----";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Silver;
            this.progressBar1.Location = new System.Drawing.Point(92, 227);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(198, 15);
            this.progressBar1.TabIndex = 15;
            this.progressBar1.Value = 100;
            this.progressBar1.Visible = false;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.BackColor = System.Drawing.Color.Silver;
            this.lblSalario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSalario.Location = new System.Drawing.Point(160, 85);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(75, 27);
            this.lblSalario.TabIndex = 4;
            this.lblSalario.Text = "Salário";
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.Silver;
            this.lblLoading.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.Black;
            this.lblLoading.Location = new System.Drawing.Point(130, 198);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(127, 26);
            this.lblLoading.TabIndex = 16;
            this.lblLoading.Text = "LOADING...";
            this.lblLoading.Visible = false;
            // 
            // txtSalario
            // 
            this.txtSalario.BackColor = System.Drawing.Color.Silver;
            this.txtSalario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtSalario.Location = new System.Drawing.Point(117, 115);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(162, 32);
            this.txtSalario.TabIndex = 5;
            // 
            // frmDescontoIrrf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.imagens_rh;
            this.ClientSize = new System.Drawing.Size(400, 429);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDescontoIrrf";
            this.Text = "Desconto do Imposto de Renda";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.TextBox txtSalario;
    }
}