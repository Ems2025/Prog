using ListaAtividades.Banco_de_Dados;
using ListaAtividades.Dominio;
using MySql.Data.MySqlClient;

namespace ListaAtividades.Repositorio
{
    internal class AtividadeRepositorio
    {
        public void criar(string titulo) // o METODO CRIAR
        {
            using (var conn = DataBase.GetConnection())
            {
                conn.Open(); //abrindo  a conexao
                string query = "insert into atividade (titulo) values (@titulo);";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@titulo", titulo);
                    cmd.ExecuteNonQuery();

                }



            }
        }
        public void AtualizarSituacao(int id, int novaSituacao)
        {
            using (var conn = DataBase.GetConnection())
            {
                conn.Open();
                string query = "Update atividade SET situacao = @situacao WHERE id= @id;";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@situacao", novaSituacao);
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                    }
                }
            }

        }
        public Atividade buscarAtividadeEmAndamento(object cmd, Situacao Situacao)
        {
            using (var conn = DataBase.GetConnection())
            {

                conn.Open();

                string query = $"select * FROM atividade WHERE situacao ={Situacao.Realizando};";

                using (var cmd = new MySqlCommand(query, conn))
                {

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            return new Atividade()
                            {
                                ID = reader.GetInt32("id"),
                                Titulo = reader.GetString("titulo"),
                                Situacao = (Situacao)reader.GetInt32("Situacao")


                            };
                        }

                    }
                    return new Atividade();
                }
            }
        }

        private List<Atividade> ListarAtividadesPendentes()
        {
            List<Atividade> atividades = [];

            using (var conn = DataBase.GetConnection())

            {
                conn.Open();

                string query = $"Selct * FROm atividade WHERE situacao = {(int)Situacao.Pendente};";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        atividades.Add(new Atividade()
                        {
                            ID = reader.GetInt32("id"),
                            Titulo = reader.GetString("titulo"),
                            Situacao = (Situacao)reader.GetInt32("Situacao"))

                        };

                }
            }
        }
    }
}
}


