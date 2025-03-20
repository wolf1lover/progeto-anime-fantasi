using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace progeto_anime_fantasi
{
    public class Usuario
    {
        public int IDAnime { get; set; }

        public string Nome { get; set; }

        public string Senha { get; set; }

        public int IDregistro { get; set; }

        public string ImagemAnime { get; set; }

        public string NomeAnime { get; set; }

        public string DataLancamentoAnime { get; set; }

        public string AvaliacaoAnime { get; set; }

        public string EpisodiosAnime { get; set; }



        public static DataTable GetUsuario(string nome, string senha)
        {
            var dt = new DataTable();
            var sql = "SELECT USU_IDUsuario, USU_Nome, USU_Senha FROM tbl_usuario WHERE USU_Nome = @Nome AND USU_Senha = @Senha";

            try
            {
                using (var cn = new MySqlConnection(Conn.strConn))
                {
                    cn.Open();

                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", nome);
                        cmd.Parameters.AddWithValue("@Senha", senha);
                        MessageBox.Show(nome, "Banco de dados");
                        MessageBox.Show(senha, "Banco de dados");

                        using (var da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }


                }


            }
            catch (MySqlException erro)
            {
                MessageBox.Show(erro.Message);
            }

            return dt;
        }


        public bool registerUsuario()
        {

            var sql = "INSERT INTO kitsune_registros(USU_Nome, USU_Senha) VALUES (@Nome, @Senha)";

            try
            {
                using (var cn = new MySqlConnection(Conn.strConn))
                {
                    cn.Open();

                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", this.Nome);
                        cmd.Parameters.AddWithValue("@Senha", this.Senha);

                        //ENQ Retorno qntidade de linhas afetadas
                        int linhasAfetadas = cmd.ExecuteNonQuery();
                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Usuário cadastrado com sucesso.", "Cadastro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                    }

                }

            }
            catch (MySqlException erro)
            {
                MessageBox.Show(erro.Message);

            }
            return false;
        }

        public bool registerAnime()
        {

            var sql = "INSERT INTO cardanimes(AnimeAvaliacao, AnimeDataLancamento, EpisodiosAnime, ImagemAnime, AnimeNome) VALUES (@Avaliacao, @DataLancamento, @Episodios, @Imagem, @AnimeNome)";

            try
            {

                using (var cn =new MySqlConnection(Conn.strConn))
                {
                    cn.Open();

                    using (var cmd = new MySqlCommand(sql, cn))
                    {

                        cmd.Parameters.AddWithValue("@Avaliacao", this.AvaliacaoAnime);
                        cmd.Parameters.AddWithValue("@DataLancamento", this.DataLancamentoAnime);
                        cmd.Parameters.AddWithValue("@Episodios", this.EpisodiosAnime);
                        cmd.Parameters.AddWithValue("@Imagem", this.ImagemAnime);
                        cmd.Parameters.AddWithValue("@AnimeNome", this.NomeAnime);

                        int linhasAfetadas = cmd.ExecuteNonQuery();
                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Registro de dados, realizado com sucesso.", "Cadastro de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }

                    }
                }

            }
            catch (MySqlException erro)
            {
                MessageBox.Show(erro.Message);

            }
            return false;
        }

        public bool deleteUsuario()
        {
            if (this.IDAnime == 0)
            {
                MessageBox.Show("Usuário inválido", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string sql = "DELETE from tbl_usuario WHERE USU_IDUsuario = @IDUsuario";

            try
            {
                using (var cn = new MySqlConnection(Conn.strConn))
                {
                    cn.Open();

                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@IDUsuario", this.IDAnime);
                        cmd.Parameters.AddWithValue("@Nome", this.Nome);
                        cmd.Parameters.AddWithValue("@Senha", this.Senha);

                        //ENQ Retorno qntidade de linhas afetadas
                        int linhasAfetadas = cmd.ExecuteNonQuery();
                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Usuário removido com sucesso.", "Remoção de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                    }

                }


            }

            catch (MySqlException erro)
            {
                MessageBox.Show(erro.Message);
            }
            return false;
        }

        public bool updateUsuario()
        {
            if (this.IDAnime == 0)
            {
                MessageBox.Show("Usuário inválido", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string sql = "UPDATE tbl_usuario SET USU_Nome = @Nome, USU_Senha = @Senha WHERE USU+IDUsuario = @IDUsuario";

            try
            {
                using (var cn = new MySqlConnection(Conn.strConn))
                {
                    cn.Open();

                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@IDUsuario", this.IDAnime);
                        cmd.Parameters.AddWithValue("@Nome", this.Nome);
                        cmd.Parameters.AddWithValue("@Senha", this.Senha);

                        //ENQ Retorno qntidade de linhas afetadas
                        int linhasAfetadas = cmd.ExecuteNonQuery();
                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Usuário atualizado com sucesso.", "Atualização de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                    }

                }


            }

            catch (MySqlException erro)
            {
                MessageBox.Show(erro.Message);
            }
            return false;
        }

    }
}
