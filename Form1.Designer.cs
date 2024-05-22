namespace A3_2024._1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_nomeUsuarios = new System.Windows.Forms.Label();
            this.lb_us = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novosTutoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.petsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novosPetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerencimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutoresEPetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentosEConsultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.lb_nomeUsuarios);
            this.panel1.Controls.Add(this.lb_us);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 325);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 43);
            this.panel1.TabIndex = 0;
            // 
            // lb_nomeUsuarios
            // 
            this.lb_nomeUsuarios.AutoSize = true;
            this.lb_nomeUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nomeUsuarios.Location = new System.Drawing.Point(102, 12);
            this.lb_nomeUsuarios.Name = "lb_nomeUsuarios";
            this.lb_nomeUsuarios.Size = new System.Drawing.Size(33, 25);
            this.lb_nomeUsuarios.TabIndex = 1;
            this.lb_nomeUsuarios.Text = "---";
            // 
            // lb_us
            // 
            this.lb_us.AutoSize = true;
            this.lb_us.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_us.Location = new System.Drawing.Point(12, 12);
            this.lb_us.Name = "lb_us";
            this.lb_us.Size = new System.Drawing.Size(95, 25);
            this.lb_us.TabIndex = 0;
            this.lb_us.Text = "Usuarios:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.manutençaoToolStripMenuItem,
            this.turoresToolStripMenuItem,
            this.petsToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.gerencimentoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(691, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logonToolStripMenuItem,
            this.loToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // logonToolStripMenuItem
            // 
            this.logonToolStripMenuItem.Name = "logonToolStripMenuItem";
            this.logonToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.logonToolStripMenuItem.Text = "Logon";
            this.logonToolStripMenuItem.Click += new System.EventHandler(this.logonToolStripMenuItem_Click);
            // 
            // loToolStripMenuItem
            // 
            this.loToolStripMenuItem.Name = "loToolStripMenuItem";
            this.loToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.loToolStripMenuItem.Text = "Logoff";
            this.loToolStripMenuItem.Click += new System.EventHandler(this.loToolStripMenuItem_Click);
            // 
            // manutençaoToolStripMenuItem
            // 
            this.manutençaoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bancoDeDadosToolStripMenuItem});
            this.manutençaoToolStripMenuItem.Name = "manutençaoToolStripMenuItem";
            this.manutençaoToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.manutençaoToolStripMenuItem.Text = "Manutençao";
            // 
            // bancoDeDadosToolStripMenuItem
            // 
            this.bancoDeDadosToolStripMenuItem.Name = "bancoDeDadosToolStripMenuItem";
            this.bancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.bancoDeDadosToolStripMenuItem.Text = "Banco de dados";
            this.bancoDeDadosToolStripMenuItem.Click += new System.EventHandler(this.bancoDeDadosToolStripMenuItem_Click);
            // 
            // turoresToolStripMenuItem
            // 
            this.turoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novosTutoresToolStripMenuItem});
            this.turoresToolStripMenuItem.Name = "turoresToolStripMenuItem";
            this.turoresToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.turoresToolStripMenuItem.Text = "Tutores";
            // 
            // novosTutoresToolStripMenuItem
            // 
            this.novosTutoresToolStripMenuItem.Name = "novosTutoresToolStripMenuItem";
            this.novosTutoresToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.novosTutoresToolStripMenuItem.Text = "Novos Tutores";
            this.novosTutoresToolStripMenuItem.Click += new System.EventHandler(this.novosTutoresToolStripMenuItem_Click);
            // 
            // petsToolStripMenuItem
            // 
            this.petsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novosPetsToolStripMenuItem});
            this.petsToolStripMenuItem.Name = "petsToolStripMenuItem";
            this.petsToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.petsToolStripMenuItem.Text = "Pets";
            // 
            // novosPetsToolStripMenuItem
            // 
            this.novosPetsToolStripMenuItem.Name = "novosPetsToolStripMenuItem";
            this.novosPetsToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.novosPetsToolStripMenuItem.Text = "Novos Pets";
            this.novosPetsToolStripMenuItem.Click += new System.EventHandler(this.novosPetsToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciamentoToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.consultasToolStripMenuItem.Text = "Consultas e Agendamentos";
            // 
            // gerenciamentoToolStripMenuItem
            // 
            this.gerenciamentoToolStripMenuItem.Name = "gerenciamentoToolStripMenuItem";
            this.gerenciamentoToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.gerenciamentoToolStripMenuItem.Text = "Gerenciamento";
            this.gerenciamentoToolStripMenuItem.Click += new System.EventHandler(this.gerenciamentoToolStripMenuItem_Click);
            // 
            // gerencimentoToolStripMenuItem
            // 
            this.gerencimentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tutoresEPetsToolStripMenuItem,
            this.agendamentosEConsultasToolStripMenuItem});
            this.gerencimentoToolStripMenuItem.Name = "gerencimentoToolStripMenuItem";
            this.gerencimentoToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.gerencimentoToolStripMenuItem.Text = "Gerencimento";
            // 
            // tutoresEPetsToolStripMenuItem
            // 
            this.tutoresEPetsToolStripMenuItem.Name = "tutoresEPetsToolStripMenuItem";
            this.tutoresEPetsToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.tutoresEPetsToolStripMenuItem.Text = "Tutores e Pets";
            this.tutoresEPetsToolStripMenuItem.Click += new System.EventHandler(this.tutoresEPetsToolStripMenuItem_Click);
            // 
            // agendamentosEConsultasToolStripMenuItem
            // 
            this.agendamentosEConsultasToolStripMenuItem.Name = "agendamentosEConsultasToolStripMenuItem";
            this.agendamentosEConsultasToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.agendamentosEConsultasToolStripMenuItem.Text = "Agendamentos e Consultas";
            this.agendamentosEConsultasToolStripMenuItem.Click += new System.EventHandler(this.agendamentosEConsultasToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 368);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_us;
        public System.Windows.Forms.Label lb_nomeUsuarios;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bancoDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novosTutoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem petsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novosPetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerencimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutoresEPetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendamentosEConsultasToolStripMenuItem;
    }
}

