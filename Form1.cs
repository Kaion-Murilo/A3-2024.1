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
    public partial class Form1 : Form
    {
        public Form1()
        {   
            InitializeComponent();
            F_Login f_login = new F_Login(this);
            f_login.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();    
        }

        private void loToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_nomeUsuarios.Text = "-----";
            Globais.logado = false;
            Globais.nivel = 0;
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado) 
            { }
            else
            {
                MessageBox.Show("presisa esta logado");
            }
        }

        private void novosTutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                F_NovoTutor f_NovoTutor = new F_NovoTutor();
                f_NovoTutor.ShowDialog();
            }
            else
            {
                MessageBox.Show("presisa esta logado");
            }
        }

        private void novosPetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                n_id_tutor f_Novopet = new n_id_tutor();
                f_Novopet.ShowDialog();
            }
            else
            {
                MessageBox.Show("presisa esta logado");
            }
        }

        private void gerenciamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                F_Agendamento f_Agendamento = new F_Agendamento();
                f_Agendamento.ShowDialog();
            }
            else
            {
                MessageBox.Show("presisa esta logado");
            }
        }

        private void tutoresEPetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
               F_GerenciamentoTutoresPets f_GerenciamentoTutoresPets= new F_GerenciamentoTutoresPets();
                f_GerenciamentoTutoresPets.ShowDialog();
            }
            else
            {
                MessageBox.Show("presisa esta logado");
            }
        }

        private void agendamentosEConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                F_GerenciamentoAgendamentos f_GerenciamentoAgendamentos = new F_GerenciamentoAgendamentos();
                f_GerenciamentoAgendamentos.ShowDialog();
            }
            else
            {
                MessageBox.Show("presisa esta logado");
            }
        }

        private void novaConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
               F_consulta f_Consulta = new F_consulta();
                f_Consulta.ShowDialog();
            }
            else
            {
                MessageBox.Show("presisa esta logado");
            }
        }

        private void gerenciamentoDeConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                F_gerenciamentoconsultas f_Gerenciamentoconsultas = new F_gerenciamentoconsultas();
                f_Gerenciamentoconsultas.ShowDialog();
            }
            else
            {
                MessageBox.Show("presisa esta logado");
            }
        }
    }
}
