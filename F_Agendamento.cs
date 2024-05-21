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
    public partial class F_Agendamento : Form
    {
        public F_Agendamento()
        {
            InitializeComponent();
        }

        private void F_Agendamento_Load(object sender, EventArgs e)
        {
            dgv_tutores.DataSource = Banco.obterTutoresIDNome();
            dgv_tutores.Columns[0].Width = 85;
            dgv_tutores.Columns[1].Width = 85;

            dgv_vet.DataSource = Banco.obterVetIDNome();
            dgv_vet.Columns[0].Width = 85;
            dgv_vet.Columns[1].Width = 85;

            dgv_pets.DataSource = Banco.obterPetIDNome(tb_id.Text);
            dgv_pets.Columns[0].Width = 85;
            dgv_pets.Columns[1].Width = 85;


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
                tb_idPet.Text = dt.Rows[0].Field<Int64>("pet_id").ToString();
                tb_nomePet.Text = dt.Rows[0].Field<string>("nome").ToString();
                tb_especiePet.Text = dt.Rows[0].Field<string>("especie").ToString();
                tb_racaPet.Text = dt.Rows[0].Field<string>("raca").ToString();
                tb_idadePet.Text = dt.Rows[0].Field<Int64>("idade").ToString();



            }
        }

        private void dgv_vet_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinahas = dgv.SelectedRows.Count;
            if (contlinahas > 0)
            { //Pet
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.obterDadosVet(vid);
                tb_idVet.Text = dt.Rows[0].Field<Int64>("vet_id").ToString();
                tb_nomeVet.Text = dt.Rows[0].Field<string>("nome").ToString();
                tb_especVet.Text = dt.Rows[0].Field<string>("especialidade").ToString();
                dgv_pets.DataSource = Banco.obterPetIDNome(tb_id.Text);
                dgv_agendamentos.DataSource = Banco.obterAgenIDNome(tb_idVet.Text);

            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tb_id.Text))
            {
                MessageBox.Show("Selecione um tutor.");
                return;
            }

            Agendamentos agendamentos = new Agendamentos();
            agendamentos.hora = mtb_horas.Text;
            agendamentos.data = mtb_data.Text;
            agendamentos.tutor_id = tb_id.Text;
            agendamentos.vet_id =  tb_idVet.Text;
            agendamentos.pet_id = tb_idPet.Text; 
            agendamentos.motivo= tb_motivo.Text;
            Banco.NovoAgen(agendamentos);


            MessageBox.Show("Pet inserido com sucesso!");
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tb_nome.Clear();
            tb_racaPet.Clear();
            tb_email.Clear();
            tb_endereco.Clear();
            tb_id.Clear();
            tb_nomePet.Clear();
            tb_especiePet.Clear();
            tb_telefone.Clear();
            tb_motivo.Clear();
            tb_idPet.Clear();
            mtb_data.Clear();
            mtb_horas.Clear();
            tb_idVet.Clear();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            tb_nome.Clear();
            tb_racaPet.Clear();
            tb_email.Clear();
            tb_endereco.Clear();
            tb_id.Clear();
            tb_nomePet.Clear();
            tb_especiePet.Clear();
            tb_telefone.Clear();
            tb_motivo.Clear();
            tb_idPet.Clear();
            mtb_data.Clear();
            mtb_horas.Clear();
            tb_idVet.Clear();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
