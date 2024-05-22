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
    public partial class F_gerenciamentoconsultas : Form
    {
        public F_gerenciamentoconsultas()
        {
            InitializeComponent();
        }



        private void F_gerenciamentoconsultas_Load(object sender, EventArgs e)
        {
            {
                dgv_vet.DataSource = Banco.obterVetIDNome();
                dgv_vet.Columns[0].Width = 85;
                dgv_vet.Columns[1].Width = 85;
            }
        }
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
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
                dgv_consultas.DataSource = Banco.obterConIDNome(tb_idVet.Text);
            }
        }

        private void dgv_consultas_SelectionChanged(object sender, EventArgs e)
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
                dt = Banco.obterConIDNome(tb_idVet.Text);
                if (dt != null && dt.Rows.Count > 0)    
                {
                    tb_idcon.Text = dt.Rows[0].Field<Int64>("con_id").ToString();
                    tb_problema.Text = dt.Rows[0].Field<string>("problema").ToString();
                    tb_solucao.Text = dt.Rows[0].Field<string>("solucao").ToString();
                
            }
            }
        }

        private void btn_novaConsulta_Click(object sender, EventArgs e)
        {
            F_consulta f_Consulta = new F_consulta();
            f_Consulta.ShowDialog();
        }

        private void btn_excluirConsulta_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirmar Exclusao? ", "Excluir?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Banco.DeletarCon(tb_idcon.Text);
                dgv_consultas.Rows.Remove(dgv_consultas.CurrentRow);
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
           Consulta consulta = new Consulta();
            consulta.prblema = tb_problema.Text;
            consulta.solucao = tb_solucao.Text;
            consulta.con_id = tb_idcon.Text;
    
 
            Banco.AtualizarCon(consulta);
        }

        private void btn_fechar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
