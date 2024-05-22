namespace A3_2024._1
{
    partial class F_consulta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_vet_nome = new System.Windows.Forms.Label();
            this.tb_idVet = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_idAgen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_motivo = new System.Windows.Forms.TextBox();
            this.mtb_data = new System.Windows.Forms.MaskedTextBox();
            this.mtb_horas = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgv_Agendamento = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_especVet = new System.Windows.Forms.TextBox();
            this.tb_nomeVet = new System.Windows.Forms.TextBox();
            this.tb_problema = new System.Windows.Forms.TextBox();
            this.tb_solucao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.tb_tutorid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_petid = new System.Windows.Forms.TextBox();
            this.dgv_agenda = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Agendamento)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_agenda)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_vet_nome
            // 
            this.lb_vet_nome.AutoSize = true;
            this.lb_vet_nome.Location = new System.Drawing.Point(36, 14);
            this.lb_vet_nome.Name = "lb_vet_nome";
            this.lb_vet_nome.Size = new System.Drawing.Size(67, 16);
            this.lb_vet_nome.TabIndex = 103;
            this.lb_vet_nome.Text = "Nome Vet";
            // 
            // tb_idVet
            // 
            this.tb_idVet.Location = new System.Drawing.Point(211, 14);
            this.tb_idVet.Name = "tb_idVet";
            this.tb_idVet.ReadOnly = true;
            this.tb_idVet.Size = new System.Drawing.Size(49, 22);
            this.tb_idVet.TabIndex = 102;
            this.tb_idVet.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(185, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 16);
            this.label14.TabIndex = 101;
            this.label14.Text = "ID";
            // 
            // tb_idAgen
            // 
            this.tb_idAgen.Location = new System.Drawing.Point(67, 146);
            this.tb_idAgen.Name = "tb_idAgen";
            this.tb_idAgen.ReadOnly = true;
            this.tb_idAgen.Size = new System.Drawing.Size(49, 22);
            this.tb_idAgen.TabIndex = 128;
            this.tb_idAgen.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 127;
            this.label1.Text = "ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(198, 127);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 16);
            this.label15.TabIndex = 125;
            this.label15.Text = "Motivo";
            // 
            // tb_motivo
            // 
            this.tb_motivo.Location = new System.Drawing.Point(201, 146);
            this.tb_motivo.Multiline = true;
            this.tb_motivo.Name = "tb_motivo";
            this.tb_motivo.Size = new System.Drawing.Size(276, 71);
            this.tb_motivo.TabIndex = 126;
            // 
            // mtb_data
            // 
            this.mtb_data.Location = new System.Drawing.Point(48, 186);
            this.mtb_data.Mask = "00/00/0000";
            this.mtb_data.Name = "mtb_data";
            this.mtb_data.Size = new System.Drawing.Size(68, 22);
            this.mtb_data.TabIndex = 124;
            this.mtb_data.ValidatingType = typeof(System.DateTime);
            // 
            // mtb_horas
            // 
            this.mtb_horas.Location = new System.Drawing.Point(136, 186);
            this.mtb_horas.Mask = "90:00";
            this.mtb_horas.Name = "mtb_horas";
            this.mtb_horas.Size = new System.Drawing.Size(41, 22);
            this.mtb_horas.TabIndex = 123;
            this.mtb_horas.ValidatingType = typeof(System.DateTime);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(133, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 16);
            this.label13.TabIndex = 122;
            this.label13.Text = "Horas";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(45, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 16);
            this.label12.TabIndex = 121;
            this.label12.Text = "Data";
            // 
            // dgv_Agendamento
            // 
            this.dgv_Agendamento.AllowUserToAddRows = false;
            this.dgv_Agendamento.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Agendamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Agendamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Agendamento.EnableHeadersVisualStyles = false;
            this.dgv_Agendamento.Location = new System.Drawing.Point(503, 272);
            this.dgv_Agendamento.MultiSelect = false;
            this.dgv_Agendamento.Name = "dgv_Agendamento";
            this.dgv_Agendamento.ReadOnly = true;
            this.dgv_Agendamento.RowHeadersVisible = false;
            this.dgv_Agendamento.RowHeadersWidth = 51;
            this.dgv_Agendamento.RowTemplate.Height = 24;
            this.dgv_Agendamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Agendamento.Size = new System.Drawing.Size(325, 236);
            this.dgv_Agendamento.TabIndex = 120;
            this.dgv_Agendamento.SelectionChanged += new System.EventHandler(this.dgv_Agendamento_SelectionChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 16);
            this.label11.TabIndex = 130;
            this.label11.Text = "Especialidade";
            // 
            // tb_especVet
            // 
            this.tb_especVet.Location = new System.Drawing.Point(39, 95);
            this.tb_especVet.Name = "tb_especVet";
            this.tb_especVet.Size = new System.Drawing.Size(313, 22);
            this.tb_especVet.TabIndex = 131;
            // 
            // tb_nomeVet
            // 
            this.tb_nomeVet.Location = new System.Drawing.Point(39, 42);
            this.tb_nomeVet.Name = "tb_nomeVet";
            this.tb_nomeVet.Size = new System.Drawing.Size(313, 22);
            this.tb_nomeVet.TabIndex = 129;
            // 
            // tb_problema
            // 
            this.tb_problema.Location = new System.Drawing.Point(44, 290);
            this.tb_problema.Multiline = true;
            this.tb_problema.Name = "tb_problema";
            this.tb_problema.Size = new System.Drawing.Size(276, 71);
            this.tb_problema.TabIndex = 132;
            // 
            // tb_solucao
            // 
            this.tb_solucao.Location = new System.Drawing.Point(44, 401);
            this.tb_solucao.Multiline = true;
            this.tb_solucao.Name = "tb_solucao";
            this.tb_solucao.Size = new System.Drawing.Size(276, 71);
            this.tb_solucao.TabIndex = 133;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 134;
            this.label2.Text = "Problema";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 135;
            this.label3.Text = "solucao";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 530);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 42);
            this.panel1.TabIndex = 136;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.Location = new System.Drawing.Point(711, 3);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(92, 34);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.Location = new System.Drawing.Point(198, 3);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(81, 34);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.Location = new System.Drawing.Point(112, 3);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(80, 34);
            this.btn_salvar.TabIndex = 1;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novo.Location = new System.Drawing.Point(12, 3);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(94, 34);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // tb_tutorid
            // 
            this.tb_tutorid.Location = new System.Drawing.Point(303, 14);
            this.tb_tutorid.Name = "tb_tutorid";
            this.tb_tutorid.ReadOnly = true;
            this.tb_tutorid.Size = new System.Drawing.Size(49, 22);
            this.tb_tutorid.TabIndex = 138;
            this.tb_tutorid.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 137;
            this.label4.Text = "ID";
            // 
            // tb_petid
            // 
            this.tb_petid.Location = new System.Drawing.Point(376, 14);
            this.tb_petid.Name = "tb_petid";
            this.tb_petid.ReadOnly = true;
            this.tb_petid.Size = new System.Drawing.Size(49, 22);
            this.tb_petid.TabIndex = 139;
            this.tb_petid.TabStop = false;
            // 
            // dgv_agenda
            // 
            this.dgv_agenda.AllowUserToAddRows = false;
            this.dgv_agenda.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_agenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_agenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_agenda.EnableHeadersVisualStyles = false;
            this.dgv_agenda.Location = new System.Drawing.Point(503, 14);
            this.dgv_agenda.MultiSelect = false;
            this.dgv_agenda.Name = "dgv_agenda";
            this.dgv_agenda.ReadOnly = true;
            this.dgv_agenda.RowHeadersVisible = false;
            this.dgv_agenda.RowHeadersWidth = 51;
            this.dgv_agenda.RowTemplate.Height = 24;
            this.dgv_agenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_agenda.Size = new System.Drawing.Size(325, 227);
            this.dgv_agenda.TabIndex = 100;
            this.dgv_agenda.SelectionChanged += new System.EventHandler(this.dgv_vet_SelectionChanged);
            // 
            // F_consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 572);
            this.Controls.Add(this.tb_petid);
            this.Controls.Add(this.tb_tutorid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_solucao);
            this.Controls.Add(this.tb_problema);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_especVet);
            this.Controls.Add(this.tb_nomeVet);
            this.Controls.Add(this.tb_idAgen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tb_motivo);
            this.Controls.Add(this.mtb_data);
            this.Controls.Add(this.mtb_horas);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgv_Agendamento);
            this.Controls.Add(this.lb_vet_nome);
            this.Controls.Add(this.tb_idVet);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dgv_agenda);
            this.Name = "F_consulta";
            this.Text = "F_consulta";
            this.Load += new System.EventHandler(this.F_consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Agendamento)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_agenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_vet_nome;
        private System.Windows.Forms.TextBox tb_idVet;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_idAgen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_motivo;
        private System.Windows.Forms.MaskedTextBox mtb_data;
        private System.Windows.Forms.MaskedTextBox mtb_horas;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgv_Agendamento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_especVet;
        private System.Windows.Forms.TextBox tb_nomeVet;
        private System.Windows.Forms.TextBox tb_problema;
        private System.Windows.Forms.TextBox tb_solucao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.TextBox tb_tutorid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_petid;
        private System.Windows.Forms.DataGridView dgv_agenda;
    }
}