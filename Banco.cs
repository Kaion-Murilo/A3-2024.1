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
        private static SQLiteConnection conexao;
        private static SQLiteConnection ConexaoBanco()
        {


            conexao = new SQLiteConnection("Data Source =" + Globais.caminhoBanco + Globais.nomeBanco);

            conexao.Open();
            return conexao;
        }
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
        /// Fucoes do form F_GestaoUsuarios
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


                cmd.CommandText = "SELECT  * FROM tb_veterinarios ";

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
                Console.WriteLine("----------------------");
                Console.WriteLine(cmd.CommandText);
                Console.WriteLine("----------------------");
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
        public static void AtualizarAgen(Agendamentos agendamentos, string novotutor, string novopet, string novovet)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();


                cmd.CommandText = "UPDATE tb_agen SET  horas='" + agendamentos.hora + "',data='" + agendamentos.data + "',motivo='" + agendamentos.motivo + "' WHERE id_agen =" + agendamentos.id;

                Console.WriteLine("----------------------");
                Console.WriteLine(cmd.CommandText);
                Console.WriteLine("----------------------");
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);

                da.Fill(dt);
                cmd.ExecuteNonQuery();

                if (novopet != "" && novotutor != "" && novovet != "")
                {
                    // Se tanto novopet quanto novotutor estiverem preenchidos, execute esta consulta SQL

                    cmd.CommandText = "UPDATE tb_agen SET tutor_id='" + agendamentos.tutor_id + "',vet_id='" + agendamentos.vet_id + "',pet_id='" + agendamentos.pet_id + "' WHERE agen_id =" + agendamentos.id;

                }
                else if (novopet != "")
                {
                    // Se apenas novopet estiver preenchido, execute esta consulta SQL

                     cmd.CommandText = "UPDATE tb_agen SET  pet_id='" + novopet + "' WHERE agen_id =" + agendamentos.id;

                   
                }
                else if (novotutor != "")
                {
                    // Se apenas novotutor estiver preenchido, execute esta consulta SQL
                    cmd.CommandText = "UPDATE tb_agen SET  tutor_id='" + novotutor + "' WHERE agen_id =" + agendamentos.id;
                }
                else if (novovet != "")
                {
                    // Se apenas novotutor estiver preenchido, execute esta consulta SQL
                    cmd.CommandText = "UPDATE tb_agen SET  vet_id='" + novovet + "' WHERE agen_id =" + agendamentos.id;
                }
                else
                {
                    // Se ambos novopet e novotutor estiverem vazios, execute esta consulta SQL

                }
                Console.WriteLine("----------------------");
                Console.WriteLine(cmd.CommandText);
                Console.WriteLine("----------------------");

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
        public static void AtualizarCon(Consulta consulta)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();


                cmd.CommandText = "UPDATE tb_con SET  problema='" + consulta.prblema + "',solucao='" + consulta.solucao + "' WHERE con_id =" + consulta.con_id;

                Console.WriteLine("----------------------");
                Console.WriteLine(cmd.CommandText);
                Console.WriteLine("----------------------");
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);

                da.Fill(dt);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void DeletarTutor(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "DELETE FROM tb_tutores  WHERE tutores_id =" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void DeletarPet(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "DELETE FROM tb_pets  WHERE pet_id =" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void DeletarAgen(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "DELETE FROM tb_agen  WHERE id_agen =" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void DeletarCon(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "DELETE FROM tb_con  WHERE con_id =" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// Fim Fucoes do form F_GestaoUsuarios
        ///////////////////////////Funcao de form Novo Tutor
        public static void Novatutor(Usuarios u)
        {
            if (existenome(u))
            {
                MessageBox.Show("nomes isuais");
            }
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_tutores (nome,endereco,telefone,email) VALUES (@nome,@endereco,@telefone,@email)";
                cmd.Parameters.AddWithValue("@nome", u.nome);
                cmd.Parameters.AddWithValue("@endereco", u.endereco);
                cmd.Parameters.AddWithValue("@telefone", u.telefone);
                cmd.Parameters.AddWithValue("@email", u.email);
                Console.WriteLine("----------------------");
                Console.WriteLine(cmd.CommandText);
                Console.WriteLine("----------------------");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo usuairos inserido");
                vcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar o novo ususarios");
                throw ex;
            }

        }
        public static void NovoPet(Pet pet)
        {
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_pets (nome,especie,raca,idade,tutor_id) VALUES (@nome,@especie,@raca,@idade,@tutor_id)";
                cmd.Parameters.AddWithValue("@nome", pet.nome);
                cmd.Parameters.AddWithValue("@especie", pet.especie);
                cmd.Parameters.AddWithValue("@raca", pet.raca);
                cmd.Parameters.AddWithValue("@idade", pet.idade);
                cmd.Parameters.AddWithValue("@tutor_id", pet.tutor_id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo Pet inserido");
                vcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar o novo Pet");
                throw ex;
            }

        }
        public static void NovoAgen(Agendamentos agendamentos)
        {
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_agen (horas,data,vet_id,pet_id,tutor_id,motivo) VALUES (@horas,@data,@vet_id,@pet_id,@tutor_id,@motivo)";
                cmd.Parameters.AddWithValue("@horas", agendamentos.hora);
                cmd.Parameters.AddWithValue("@data", agendamentos.data);
                cmd.Parameters.AddWithValue("@vet_id", agendamentos.vet_id);
                cmd.Parameters.AddWithValue("@pet_id", agendamentos.pet_id);
                cmd.Parameters.AddWithValue("@tutor_id", agendamentos.tutor_id);
                cmd.Parameters.AddWithValue("@motivo", agendamentos.motivo);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo Agendamentos inserido");
                vcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar o novo agendameto");
                throw ex;
            }

        }
        ////////Fim das Funcoes do Form Nova Consultas  
        ///Rotinas Gerais <summary>
        /// Rotinas Gerais
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public static void Novocon(Consulta consulta)
        {
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                ////cada agendamento so pode ter uma consulta(Pendencia)
                cmd.CommandText = "INSERT INTO tb_con (pet_id,tutores_id,vet_id,agen_id,problema,solucao) VALUES (@pet_id,@tutores_id,@vet_id,@agen_id,@problema,@solucao)";
                cmd.Parameters.AddWithValue("@pet_id",consulta.pet_id);
                cmd.Parameters.AddWithValue("@tutores_id", consulta.tutores_id);
                cmd.Parameters.AddWithValue("@vet_id", consulta.vet_id);
                cmd.Parameters.AddWithValue("@problema", consulta.prblema);
                cmd.Parameters.AddWithValue("@solucao", consulta.solucao);
                cmd.Parameters.AddWithValue("@agen_id", consulta.agen_id);
                cmd.ExecuteNonQuery();
                Console.WriteLine("----------------------");
                Console.WriteLine(cmd.CommandText);

                Console.WriteLine("----------------------");
                MessageBox.Show("Novo Consulta inserido");
                vcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar o novo Consulta");
                throw ex;
            }

        }
        public static bool existenome(Usuarios u)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT nome FROM tb_tutores WHERE nome='" + u.nome + "' ";
            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            { res = true; }
            else { res = false; }
            return res;
        }


    }
}
