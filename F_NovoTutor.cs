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
    public partial class F_NovoTutor : Form
    {
        public F_NovoTutor()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.nome = tb_nome.Text;
            usuarios.telefone = tb_telefone.Text;   
            usuarios.email = tb_email.Text;
            usuarios.endereco= tb_endereco.Text;
            Banco.Novatutor(usuarios); 
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            tb_nome.Clear();
            tb_telefone.Clear();    
            tb_email.Clear();   
            tb_endereco.Clear();    
            tb_nome.Focus();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tb_nome.Clear();
            tb_telefone.Clear();
            tb_email.Clear();
            tb_endereco.Clear();
            tb_nome.Focus();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
