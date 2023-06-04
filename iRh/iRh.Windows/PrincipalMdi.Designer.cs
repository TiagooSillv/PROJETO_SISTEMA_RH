namespace iRh.Windows
{
    partial class PrincipalMdi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalMdi));
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.simuladoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDescontoInss = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDescontoIrrf = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuBeneficioAdicionalNoturno = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioFgts = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioFerias = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioHoraExtra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioPericulosidade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioPis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioSeguroDesemprego = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioValeTransporte = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionáriosToolStripMenuItem,
            this.simuladoresToolStripMenuItem});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.MenuPrincipal.Size = new System.Drawing.Size(1067, 28);
            this.MenuPrincipal.TabIndex = 1;
            this.MenuPrincipal.Text = "menuStrip1";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroFuncionario});
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.funcionáriosToolStripMenuItem.Text = "Cadastros";
            // 
            // menuCadastroFuncionario
            // 
            this.menuCadastroFuncionario.Name = "menuCadastroFuncionario";
            this.menuCadastroFuncionario.Size = new System.Drawing.Size(169, 26);
            this.menuCadastroFuncionario.Text = "Funcionário";
            this.menuCadastroFuncionario.Click += new System.EventHandler(this.menuCadastroFuncionario_Click);
            // 
            // simuladoresToolStripMenuItem
            // 
            this.simuladoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDescontoInss,
            this.menuDescontoIrrf,
            this.toolStripSeparator1,
            this.menuBeneficioAdicionalNoturno,
            this.menuBeneficioFgts,
            this.menuBeneficioFerias,
            this.menuBeneficioHoraExtra,
            this.menuBeneficioPericulosidade,
            this.menuBeneficioPis,
            this.menuBeneficioSeguroDesemprego,
            this.menuBeneficioValeTransporte});
            this.simuladoresToolStripMenuItem.Name = "simuladoresToolStripMenuItem";
            this.simuladoresToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.simuladoresToolStripMenuItem.Text = "Simuladores";
            // 
            // menuDescontoInss
            // 
            this.menuDescontoInss.Name = "menuDescontoInss";
            this.menuDescontoInss.Size = new System.Drawing.Size(295, 26);
            this.menuDescontoInss.Text = "Desconto de INSS";
            this.menuDescontoInss.Click += new System.EventHandler(this.menuDescontoInss_Click);
            // 
            // menuDescontoIrrf
            // 
            this.menuDescontoIrrf.Name = "menuDescontoIrrf";
            this.menuDescontoIrrf.Size = new System.Drawing.Size(295, 26);
            this.menuDescontoIrrf.Text = "Desconto IRRF";
            this.menuDescontoIrrf.Click += new System.EventHandler(this.menuDescontoIrrf_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(292, 6);
            // 
            // menuBeneficioAdicionalNoturno
            // 
            this.menuBeneficioAdicionalNoturno.Name = "menuBeneficioAdicionalNoturno";
            this.menuBeneficioAdicionalNoturno.Size = new System.Drawing.Size(295, 26);
            this.menuBeneficioAdicionalNoturno.Text = "Benéficio Adicional Noturno";
            this.menuBeneficioAdicionalNoturno.Click += new System.EventHandler(this.menuBeneficioAdicionalNoturno_Click);
            // 
            // menuBeneficioFgts
            // 
            this.menuBeneficioFgts.Name = "menuBeneficioFgts";
            this.menuBeneficioFgts.Size = new System.Drawing.Size(295, 26);
            this.menuBeneficioFgts.Text = "Benéficio de Deposito FGTS";
            this.menuBeneficioFgts.Click += new System.EventHandler(this.menuBeneficioFgts_Click);
            // 
            // menuBeneficioFerias
            // 
            this.menuBeneficioFerias.Name = "menuBeneficioFerias";
            this.menuBeneficioFerias.Size = new System.Drawing.Size(295, 26);
            this.menuBeneficioFerias.Text = "Benéficio Férias";
            this.menuBeneficioFerias.Click += new System.EventHandler(this.menuBeneficioFerias_Click);
            // 
            // menuBeneficioHoraExtra
            // 
            this.menuBeneficioHoraExtra.Name = "menuBeneficioHoraExtra";
            this.menuBeneficioHoraExtra.Size = new System.Drawing.Size(295, 26);
            this.menuBeneficioHoraExtra.Text = "Benéficio Hora extra";
            this.menuBeneficioHoraExtra.Click += new System.EventHandler(this.menuBeneficioHoraExtra_Click);
            // 
            // menuBeneficioPericulosidade
            // 
            this.menuBeneficioPericulosidade.Name = "menuBeneficioPericulosidade";
            this.menuBeneficioPericulosidade.Size = new System.Drawing.Size(295, 26);
            this.menuBeneficioPericulosidade.Text = "Benéficio Periculosidade";
            this.menuBeneficioPericulosidade.Click += new System.EventHandler(this.menuBeneficioPericulosidade_Click);
            // 
            // menuBeneficioPis
            // 
            this.menuBeneficioPis.Name = "menuBeneficioPis";
            this.menuBeneficioPis.Size = new System.Drawing.Size(295, 26);
            this.menuBeneficioPis.Text = "Benéficio de PIS";
            this.menuBeneficioPis.Click += new System.EventHandler(this.menuBeneficioPis_Click);
            // 
            // menuBeneficioSeguroDesemprego
            // 
            this.menuBeneficioSeguroDesemprego.Name = "menuBeneficioSeguroDesemprego";
            this.menuBeneficioSeguroDesemprego.Size = new System.Drawing.Size(295, 26);
            this.menuBeneficioSeguroDesemprego.Text = "Benéficio Seguro Desemprego";
            this.menuBeneficioSeguroDesemprego.Click += new System.EventHandler(this.menuBeneficioSeguroDesemprego_Click);
            // 
            // menuBeneficioValeTransporte
            // 
            this.menuBeneficioValeTransporte.Name = "menuBeneficioValeTransporte";
            this.menuBeneficioValeTransporte.Size = new System.Drawing.Size(295, 26);
            this.menuBeneficioValeTransporte.Text = "Benéficio de Vale Transporte";
            this.menuBeneficioValeTransporte.Click += new System.EventHandler(this.menuBeneficioValeTransporte_Click);
            // 
            // PrincipalMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.rh_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.MenuPrincipal);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.MenuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrincipalMdi";
            this.Text = "PrincipalMdi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simuladoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDescontoInss;
        private System.Windows.Forms.ToolStripMenuItem menuDescontoIrrf;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioAdicionalNoturno;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioFgts;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioFerias;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioHoraExtra;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioPericulosidade;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioPis;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioSeguroDesemprego;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioValeTransporte;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroFuncionario;
    }
}