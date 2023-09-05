using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola_POO_BASE.Classes
{
    public class Aluno : Usuario
    {
        #region Propriedades
        public DateTime DtMatricula { get; set; }
        #endregion

        #region Construtores
        public Aluno()
        {
        }

        public Aluno(int id, string nome, DateTime dtNascimento, DateTime dtMatricula, string email, string senha, bool ativo) : base(id, nome, dtNascimento, email, senha, ativo)
        {
            DtMatricula = dtMatricula;
        }
        #endregion

        #region Métodos
        public void Cadastrar(List<Aluno> alunos)
        {
            string query = string.Format($"INSERT INTO Aluno VALUES('{Nome}', '{DtNascimento}', '{DtMatricula}', '{Email}', '{Crypto.Sha256("123")}', 1)");
            query += "; SELECT SCOPE_IDENTITY()";
            Conexao cn = new Conexao(query);

            try
            {
                cn.AbrirConexao();
                Id = Convert.ToInt32(cn.comando.ExecuteScalar());
                alunos.Add(this);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.FecharConexao();
            }
        }

        public void Alterar()
        {
            string query = string.Format("");
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbrirConexao();
                cn.comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally 
            {
                cn.FecharConexao(); 
            }
        }
        #endregion
    }
}
