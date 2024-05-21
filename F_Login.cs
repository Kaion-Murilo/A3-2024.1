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
    public partial class F_Login : Form
    {
        Form1 form1;
        DataTable dt = new DataTable();
        public F_Login(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void btn_Logar_Click(object sender, EventArgs e)
        {
            string nome = tb_nome.Text;
            string senha = tb_senha.Text;
            if (nome == "" || senha == "")
            {
                MessageBox.Show("Usuario  e ou senha invalida");
                tb_nome.Focus();
                return;
            }
            string sql = "SELECT * FROM tb_funcionarios WHERE nome='" + nome + "' AND senha='" + senha + "'";
            dt = Banco.consulta(sql);
            if (dt.Rows.Count == 1)
            {
                form1.lb_nomeUsuarios.Text = dt.Rows[0].Field<string>("nome");
                Globais.logado = true;
                Globais.nivel = int.Parse(dt.Rows[0].Field<Int64>("nivel").ToString());
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuarios nao encontrado");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
