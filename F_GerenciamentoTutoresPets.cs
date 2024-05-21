using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3_2024._1
{
    public partial class F_GerenciamentoTutoresPets : Form
    {
        public F_GerenciamentoTutoresPets()
        {
            InitializeComponent();
        }

        private void F_GerenciamentoTutoresPets_Load(object sender, EventArgs e)
        {
            dgv_pets.DataSource = Banco.obterPetIDNome(tb_id.Text);
            dgv_pets.Columns[0].Width = 85;
            dgv_pets.Columns[1].Width = 85;
            dgv_tutores.DataSource = Banco.obterTutoresIDNome();
            dgv_tutores.Columns[0].Width = 85;
            dgv_tutores.Columns[1].Width = 85;
        }

        private void dgv_tutores_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinahas = dgv.SelectedRows.Count;
            if (contlinahas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.obterDadosTutores(vid);
                tb_id.Text = dt.Rows[0].Field<Int64>("tutores_id").ToString();
                tb_nome.Text = dt.Rows[0].Field<string>("nome").ToString();
                tb_telefone.Text = dt.Rows[0].Field<string>("telefone").ToString();
                tb_email.Text = dt.Rows[0].Field<string>("email").ToString();
                tb_endereco.Text = dt.Rows[0].Field<string>("endereco").ToString();
                dgv_pets.DataSource = Banco.obterPetIDNome(tb_id.Text);
            }
        }

        private void dgv_pets_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinahas = dgv.SelectedRows.Count;
            if (contlinahas > 0)
            { //Pet
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.obterDadosPets(vid);
                mtb_idPet.Text = dt.Rows[0].Field<Int64>("pet_id").ToString();
                tb_nomePet.Text = dt.Rows[0].Field<string>("nome").ToString();
                tb_especiePet.Text = dt.Rows[0].Field<string>("especie").ToString();
                tb_racaPet.Text = dt.Rows[0].Field<string>("raca").ToString();
                mtb_idade.Text = dt.Rows[0].Field<Int64>("idade").ToString();



            }
        }

        private void btn_novoTutor_Click(object sender, EventArgs e)
        {
            F_NovoTutor f_NovoTutor = new F_NovoTutor();
            f_NovoTutor.ShowDialog();
        }

        private void btn_novoPet_Click(object sender, EventArgs e)
        {
            n_id_tutor f_Novopet = new n_id_tutor();
            f_Novopet.ShowDialog();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_excluirTutor_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirmar Exclusao? ", "Excluir?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Banco.DeletarTutor(tb_id.Text);
                dgv_tutores.Rows.Remove(dgv_tutores.CurrentRow);
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            int linha = dgv_tutores.SelectedRows[0].Index;
            int linha1 = dgv_pets.SelectedRows[0].Index;
            Usuarios usuarios = new Usuarios();
            usuarios.id=tb_id.Text;
            usuarios.nome = tb_nome.Text;
            usuarios.telefone = tb_telefone.Text;
            usuarios.email = tb_email.Text;
            usuarios.endereco = tb_endereco.Text;
            //dgv_usuarios.DataSource = Banco.obterUsuariosIDNome();
            // dgv_usuarios.CurrentCell = dgv_usuarios[0, linha];
            dgv_tutores[1, linha].Value = tb_nome.Text;
            Pet pet = new Pet();
            pet.id = mtb_idPet.TabIndex;
            pet.nome = tb_nomePet.Text;
            pet.raca = tb_racaPet.Text;
            pet.especie = tb_especiePet.Text;
            pet.idade= mtb_idade.TabIndex;
            pet.tutor_id = tb_novoTutor.Text;
            dgv_pets[1, linha].Value = tb_nomePet.Text;
            Banco.Atualizar(usuarios,pet);
        }
    }
}
