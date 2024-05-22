using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;
using System.Drawing;

namespace A3_2024._1
{
    internal class Banco
    {
        private static Banco _instance;
        private static SQLiteConnection conexao;

        // Construtor privado para evitar instanciamento direto
        private Banco() { }

        // Método para obter a instância única da classe Banco
        public static Banco Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Banco();
                }
                return _instance;
            }
        }

        // Método para obter a conexão com o banco de dados
        private static SQLiteConnection ConexaoBanco()
        {
            if (conexao == null)
            {
                conexao = new SQLiteConnection("Data Source =" + Globais.caminhoBanco + Globais.nomeBanco);
                conexao.Open();
            }
            return conexao;
        }

        // Métodos da classe Banco utilizando a conexão singleton

        public static DataTable obterTodosUsuarios()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "SELECT * FROM tb_usuarios";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable consulta(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Outras funções da classe Banco

        public static DataTable obterTutoresIDNome()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "SELECT tutores_id as 'ID Usuarisos', nome as 'Nome usuarios' FROM tb_tutores";
                Console.WriteLine("----------------------");
                Console.WriteLine(cmd.CommandText);
                Console.WriteLine("----------------------");
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);

                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable obterPetIDNome(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                if (id == "")
                {
                    cmd.CommandText = "SELECT pet_id,nome, especie, raca, idade FROM tb_pets WHERE tutor_id = 1";
                }
                else
                {
                    cmd.CommandText = "SELECT pet_id, nome, especie, raca, idade FROM tb_pets WHERE tutor_id = " + id;
                }
                Console.WriteLine("----------------------");
                Console.WriteLine(cmd.CommandText);
                Console.WriteLine("----------------------");
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);

                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable obterVetIDNome()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "SELECT  * FROM tb_veterinarios";

                da = new SQLiteDataAdapter(cmd.CommandText, vcon);

                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable obterAgenIDNome(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "SELECT  * FROM tb_agen WHERE vet_id = " + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                Console.WriteLine("----------------------");
                Console.WriteLine(cmd.CommandText);
                Console.WriteLine(id);
                Console.WriteLine("----------------------");
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable obterConIDNome(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "SELECT  * FROM tb_con WHERE vet_id = " + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                Console.WriteLine("----------------------");
                Console.WriteLine(cmd.CommandText);
                Console.WriteLine(id);
                Console.WriteLine("----------------------");
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable obterDadosTutores(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_tutores WHERE tutores_id = " + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable obterDadosPets(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "SELECT * FROM tb_pets WHERE pet_id = " + id;

                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable obterDadosVet(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "SELECT * FROM tb_veterinarios WHERE vet_id = " + id;

                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable obterDadosAgen(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "SELECT * FROM tb_agen WHERE vet_id = " + id;

                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Atualizar(Usuarios u, Pet pet)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "UPDATE tb_tutores SET  nome='" + u.nome + "',telefone='" + u.telefone + "',endereco='" + u.endereco + "',email='" + u.email + "' WHERE tutores_id =" + u.id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                cmd.ExecuteNonQuery();
                if (pet.tutor_id == u.id || pet.tutor_id == "")
                {
                    cmd.CommandText = "UPDATE tb_pets SET  nome='" + pet.nome + "',especie='" + pet.especie + "',idade='" + pet.idade + "',raca='" + pet.raca + "',tutor_id='" + pet.tutor_id + "' WHERE pet_id =" + pet.id;
                }
                else
                {
                    cmd.CommandText = "UPDATE tb_pets SET  nome='" + pet.nome + "',especie='" + pet.especie + "',idade='" + pet.idade + "',raca='" + pet.raca + "',tutor_id='" + pet.tutor_id + "' WHERE pet_id =" + pet.id;
                }

                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
