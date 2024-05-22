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
    public partial class F_consulta : Form
    {
        public F_consulta()
        {
            InitializeComponent();
        }

        private void F_consulta_Load(object sender, EventArgs e)
        {
            dgv_agenda.DataSource = Banco.obterVetIDNome();
            dgv_agenda.Columns[0].Width = 85;
            dgv_agenda.Columns[1].Width = 85;
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
                dgv_Agendamento.DataSource = Banco.obterAgenIDNome(tb_idVet.Text);
            }
        }

        private void dgv_Agendamento_SelectionChanged(object sender, EventArgs e)
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
                tb_petid.Text = dt.Rows[0].Field<Int64>("pet_id").ToString();
                tb_tutorid.Text = dt.Rows[0].Field<Int64>("tutor_id").ToString();
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();
            consulta.agen_id = tb_idAgen.Text;
            consulta.prblema = tb_problema.Text;
            consulta.tutores_id=tb_tutorid.Text;
            consulta.pet_id = tb_petid.Text;
            consulta.solucao = tb_solucao.Text;
            consulta.vet_id = tb_idVet.Text;
            Banco.Novocon(consulta);
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tb_especVet.Clear();
            tb_problema.Clear();
            tb_idAgen.Clear();
            tb_tutorid.Clear();
            tb_petid.Clear();
            tb_solucao.Clear();
            tb_idVet.Clear();   
            tb_solucao.Clear(); 
            mtb_data.Clear();
            mtb_horas.Clear();
            tb_motivo.Clear();

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            tb_especVet.Clear();
            tb_problema.Clear();
            tb_idAgen.Clear();
            tb_tutorid.Clear();
            tb_petid.Clear();
            tb_solucao.Clear();
            tb_idVet.Clear();
            tb_solucao.Clear();
            mtb_data.Clear();
            mtb_horas.Clear();
            tb_motivo.Clear();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
