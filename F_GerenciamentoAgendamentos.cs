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
    public partial class F_GerenciamentoAgendamentos : Form
    {
        public F_GerenciamentoAgendamentos()
        {
            InitializeComponent();
        }
        private void F_GerenciamentoAgendamentos_Load(object sender, EventArgs e)
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
                dgv_agendamentos.DataSource = Banco.obterAgenIDNome(tb_idVet.Text);

            }
        }

        private void dgv_agendamentos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinahas = dgv.SelectedRows.Count;
            if (contlinahas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.obterAgenIDNome(tb_idVet.Text);
                tb_idAgen.Text = dt.Rows[0].Field<Int64>("id_agen").ToString();
                mtb_data.Text = dt.Rows[0].Field<string>("data").ToString();
                mtb_horas.Text = dt.Rows[0].Field<string>("horas").ToString();
                tb_motivo.Text = dt.Rows[0].Field<string>("motivo").ToString();
            }
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
                dgv_pets.DataSource = Banco.obterPetIDNome(tb_id.Text);
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Agendamentos agendamentos = new Agendamentos();
            string novopet, novotutor, novovet;
            agendamentos.id = tb_idAgen.Text;
            agendamentos.hora = mtb_horas.Text;
            agendamentos.data = mtb_data.Text;
            novotutor = tb_novoTutor.Text;
            novovet = tb_novoVet.Text;
            novopet = tb_idPet.Text;
            agendamentos.motivo = tb_motivo.Text;

            Banco.AtualizarAgen(agendamentos, novopet, novotutor, novovet);
        }
    }
}
