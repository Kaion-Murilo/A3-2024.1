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
    public partial class n_id_tutor : Form
    {
        public n_id_tutor()
        {
            InitializeComponent();
        }

        private void F_NovoPet_Load(object sender, EventArgs e)
        {
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

            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_id.Text))
            {
                MessageBox.Show("Selecione um tutor.");
                return;
            }

            Pet pet = new Pet();
            pet.nome = tb_nomePet.Text;
            pet.raca = tb_racaPet.Text;
            pet.especie = tb_especiePet.Text;
            pet.idade = Convert.ToInt32(Math.Round(n_idade.Value,0));
            pet.tutor_id = tb_id.Text;
            Banco.NovoPet(pet) ;


            MessageBox.Show("Pet inserido com sucesso!");
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
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
            n_idade.Value = 0;  

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
            n_idade.Value = 0;
        }
    }
}
