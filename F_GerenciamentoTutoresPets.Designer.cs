namespace A3_2024._1
{
    partial class F_GerenciamentoTutoresPets
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.dgv_pets = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_racaPet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_especiePet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_telefone = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nomePet = new System.Windows.Forms.TextBox();
            this.dgv_tutores = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_excluirPet = new System.Windows.Forms.Button();
            this.btn_novoPet = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_excluirTutor = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_novoTutor = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_novoTutor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mtb_idade = new System.Windows.Forms.MaskedTextBox();
            this.mtb_idPet = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pets)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tutores)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(230, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 16);
            this.label10.TabIndex = 41;
            this.label10.Text = "ID";
            // 
            // dgv_pets
            // 
            this.dgv_pets.AllowUserToAddRows = false;
            this.dgv_pets.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_pets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_pets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pets.EnableHeadersVisualStyles = false;
            this.dgv_pets.Location = new System.Drawing.Point(393, 250);
            this.dgv_pets.MultiSelect = false;
            this.dgv_pets.Name = "dgv_pets";
            this.dgv_pets.ReadOnly = true;
            this.dgv_pets.RowHeadersVisible = false;
            this.dgv_pets.RowHeadersWidth = 51;
            this.dgv_pets.RowTemplate.Height = 24;
            this.dgv_pets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_pets.Size = new System.Drawing.Size(590, 232);
            this.dgv_pets.TabIndex = 51;
            this.dgv_pets.SelectionChanged += new System.EventHandler(this.dgv_pets_SelectionChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 47;
            this.label8.Text = "Raça";
            // 
            // tb_racaPet
            // 
            this.tb_racaPet.Location = new System.Drawing.Point(9, 391);
            this.tb_racaPet.Name = "tb_racaPet";
            this.tb_racaPet.Size = new System.Drawing.Size(319, 22);
            this.tb_racaPet.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 45;
            this.label7.Text = "Especie";
            // 
            // tb_especiePet
            // 
            this.tb_especiePet.Location = new System.Drawing.Point(15, 341);
            this.tb_especiePet.Name = "tb_especiePet";
            this.tb_especiePet.Size = new System.Drawing.Size(313, 22);
            this.tb_especiePet.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "Nome";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.tb_id);
            this.panel1.Controls.Add(this.lb_id);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_email);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_telefone);
            this.panel1.Controls.Add(this.tb_nome);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_endereco);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(9, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 232);
            this.panel1.TabIndex = 42;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(270, 28);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(49, 22);
            this.tb_id.TabIndex = 27;
            this.tb_id.TabStop = false;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(244, 28);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(20, 16);
            this.lb_id.TabIndex = 26;
            this.lb_id.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Dados do Tutor";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(37, 121);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(148, 22);
            this.tb_email.TabIndex = 13;
            this.tb_email.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome";
            // 
            // tb_telefone
            // 
            this.tb_telefone.Location = new System.Drawing.Point(200, 121);
            this.tb_telefone.Name = "tb_telefone";
            this.tb_telefone.Size = new System.Drawing.Size(119, 22);
            this.tb_telefone.TabIndex = 15;
            this.tb_telefone.TabStop = false;
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(37, 62);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(282, 22);
            this.tb_nome.TabIndex = 9;
            this.tb_nome.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Telefone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Endereco";
            // 
            // tb_endereco
            // 
            this.tb_endereco.Location = new System.Drawing.Point(37, 176);
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.Size = new System.Drawing.Size(282, 22);
            this.tb_endereco.TabIndex = 11;
            this.tb_endereco.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "email";
            // 
            // tb_nomePet
            // 
            this.tb_nomePet.Location = new System.Drawing.Point(15, 282);
            this.tb_nomePet.Name = "tb_nomePet";
            this.tb_nomePet.Size = new System.Drawing.Size(313, 22);
            this.tb_nomePet.TabIndex = 44;
            // 
            // dgv_tutores
            // 
            this.dgv_tutores.AllowUserToAddRows = false;
            this.dgv_tutores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tutores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_tutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tutores.EnableHeadersVisualStyles = false;
            this.dgv_tutores.Location = new System.Drawing.Point(393, 12);
            this.dgv_tutores.MultiSelect = false;
            this.dgv_tutores.Name = "dgv_tutores";
            this.dgv_tutores.ReadOnly = true;
            this.dgv_tutores.RowHeadersVisible = false;
            this.dgv_tutores.RowHeadersWidth = 51;
            this.dgv_tutores.RowTemplate.Height = 24;
            this.dgv_tutores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tutores.Size = new System.Drawing.Size(590, 232);
            this.dgv_tutores.TabIndex = 39;
            this.dgv_tutores.SelectionChanged += new System.EventHandler(this.dgv_tutores_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_excluirPet);
            this.panel2.Controls.Add(this.btn_novoPet);
            this.panel2.Controls.Add(this.btn_fechar);
            this.panel2.Controls.Add(this.btn_excluirTutor);
            this.panel2.Controls.Add(this.btn_salvar);
            this.panel2.Controls.Add(this.btn_novoTutor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 503);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(991, 32);
            this.panel2.TabIndex = 52;
            // 
            // btn_excluirPet
            // 
            this.btn_excluirPet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluirPet.Location = new System.Drawing.Point(375, 0);
            this.btn_excluirPet.Name = "btn_excluirPet";
            this.btn_excluirPet.Size = new System.Drawing.Size(113, 23);
            this.btn_excluirPet.TabIndex = 5;
            this.btn_excluirPet.Text = "Excluir Pet";
            this.btn_excluirPet.UseVisualStyleBackColor = true;
            // 
            // btn_novoPet
            // 
            this.btn_novoPet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novoPet.Location = new System.Drawing.Point(131, 2);
            this.btn_novoPet.Name = "btn_novoPet";
            this.btn_novoPet.Size = new System.Drawing.Size(113, 23);
            this.btn_novoPet.TabIndex = 4;
            this.btn_novoPet.Text = "Novo Pet";
            this.btn_novoPet.UseVisualStyleBackColor = true;
            this.btn_novoPet.Click += new System.EventHandler(this.btn_novoPet_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.Location = new System.Drawing.Point(870, 3);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(113, 23);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_excluirTutor
            // 
            this.btn_excluirTutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluirTutor.Location = new System.Drawing.Point(256, 0);
            this.btn_excluirTutor.Name = "btn_excluirTutor";
            this.btn_excluirTutor.Size = new System.Drawing.Size(113, 23);
            this.btn_excluirTutor.TabIndex = 2;
            this.btn_excluirTutor.Text = "Excluir Tutor";
            this.btn_excluirTutor.UseVisualStyleBackColor = true;
            this.btn_excluirTutor.Click += new System.EventHandler(this.btn_excluirTutor_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.Location = new System.Drawing.Point(504, 0);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(126, 23);
            this.btn_salvar.TabIndex = 1;
            this.btn_salvar.Text = "Salvar Alterações";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_novoTutor
            // 
            this.btn_novoTutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novoTutor.Location = new System.Drawing.Point(12, 3);
            this.btn_novoTutor.Name = "btn_novoTutor";
            this.btn_novoTutor.Size = new System.Drawing.Size(113, 23);
            this.btn_novoTutor.TabIndex = 0;
            this.btn_novoTutor.Text = "Novo Tutor";
            this.btn_novoTutor.UseVisualStyleBackColor = true;
            this.btn_novoTutor.Click += new System.EventHandler(this.btn_novoTutor_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(230, 429);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 16);
            this.label11.TabIndex = 53;
            this.label11.Text = "ID Novo Tutor";
            // 
            // tb_novoTutor
            // 
            this.tb_novoTutor.AllowDrop = true;
            this.tb_novoTutor.Location = new System.Drawing.Point(233, 448);
            this.tb_novoTutor.Name = "tb_novoTutor";
            this.tb_novoTutor.Size = new System.Drawing.Size(100, 22);
            this.tb_novoTutor.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 429);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 49;
            this.label9.Text = "Idade";
            // 
            // mtb_idade
            // 
            this.mtb_idade.Location = new System.Drawing.Point(15, 448);
            this.mtb_idade.Name = "mtb_idade";
            this.mtb_idade.Size = new System.Drawing.Size(100, 22);
            this.mtb_idade.TabIndex = 54;
            // 
            // mtb_idPet
            // 
            this.mtb_idPet.Location = new System.Drawing.Point(255, 251);
            this.mtb_idPet.Name = "mtb_idPet";
            this.mtb_idPet.Size = new System.Drawing.Size(65, 22);
            this.mtb_idPet.TabIndex = 55;
            // 
            // F_GerenciamentoTutoresPets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 535);
            this.Controls.Add(this.mtb_idPet);
            this.Controls.Add(this.mtb_idade);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgv_pets);
            this.Controls.Add(this.tb_novoTutor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_racaPet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_especiePet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_nomePet);
            this.Controls.Add(this.dgv_tutores);
            this.Name = "F_GerenciamentoTutoresPets";
            this.Text = "F_GerenciamentoTutoresPets";
            this.Load += new System.EventHandler(this.F_GerenciamentoTutoresPets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pets)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tutores)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgv_pets;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_racaPet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_especiePet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_telefone;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_endereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nomePet;
        private System.Windows.Forms.DataGridView dgv_tutores;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_excluirTutor;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_novoTutor;
        private System.Windows.Forms.Button btn_novoPet;
        private System.Windows.Forms.Button btn_excluirPet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_novoTutor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mtb_idade;
        private System.Windows.Forms.MaskedTextBox mtb_idPet;
    }
}