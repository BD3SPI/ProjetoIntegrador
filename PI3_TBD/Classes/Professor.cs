using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC.Classes;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using MVC.Telas;

namespace MVC.Classes
{
    class Professor
    {
        private int codigo;
        private string nome;
        private string email;
        private string senha;
        private string idSenac;
        private char tipo;

        public void setCod(int cod)
        {
            this.codigo = cod;
        }
        public int getCod()
        {
            return codigo;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return nome;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }
        public string getEmail()
        {
            return email;
        }

        public void setSenha(string senha)
        {
            this.senha = senha;
        }
        public string getSenha()
        {
            return senha;
        }

        public void setIDsenac(string idSenac)
        {
            this.idSenac = idSenac;
        }
        public string getIDsenac()
        {
            return idSenac;
        }

        public void setTipo(char tipo)
        {
            this.tipo = tipo;
        }
        public char getTipo()
        {
            return tipo;
        }
        public override string ToString()
        {
            return nome;
        }
 



        public void Inserir()
        {
            try
            {
                SqlConnection con = Conexao.AbrirConexao();
                SqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "INSERT INTO Professor (nome, email, senha, idSenac, tipo) VALUES (@nome, @email, HASHBYTES('SHA1',@senha), @idSenac, @tipo)";

                cmd.Parameters.Add("@nome", SqlDbType.VarChar, 50).Value = this.nome;
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = this.email;
                cmd.Parameters.Add("@senha", SqlDbType.VarChar, 50).Value = this.senha;
                cmd.Parameters.Add("@idSenac", SqlDbType.Char, 6).Value = this.idSenac;
                cmd.Parameters.Add("tipo", SqlDbType.Char, 1).Value = this.tipo;
                cmd.ExecuteNonQuery();

                con.Close();

            }
            catch (ArgumentException)
            {
                MessageBox.Show("Falha no Cadastro!", "Mensagem");
            }
        }

        public void Alterar(int cod)
        {
            try
            {
                SqlConnection con = Conexao.AbrirConexao();
                SqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "UPDATE Professor SET nome = @nome,email= @email,idSenac = @idSenac, tipo= @tipo WHERE codProfessor = " + cod;

                cmd.Parameters.Add("@nome", SqlDbType.VarChar, 50).Value = this.nome;
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = this.email;
                cmd.Parameters.Add("@idSenac", SqlDbType.Char, 6).Value = this.idSenac;
                cmd.Parameters.Add("tipo", SqlDbType.Char, 1).Value = this.tipo;
                cmd.ExecuteNonQuery();
                //                MessageBox.Show("Cadastro efetuado com sucesso!");

                con.Close();

            }
            catch (ArgumentException)
            {
                MessageBox.Show("Falha no Cadastro!", "Mensagem");
            }
        }

        public void AlterarCSenha(int cod)
        {
            try
            {
                SqlConnection con = Conexao.AbrirConexao();
                SqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "UPDATE Professor SET nome = @nome,email= @email,senha= HASHBYTES('SHA1',@senha),idSenac = @idSenac, tipo= @tipo WHERE codProfessor = " + cod;

                cmd.Parameters.Add("@nome", SqlDbType.VarChar, 50).Value = this.nome;
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = this.email;
                cmd.Parameters.Add("@senha", SqlDbType.VarChar, 50).Value = this.senha;
                cmd.Parameters.Add("@idSenac", SqlDbType.Char, 6).Value = this.idSenac;
                cmd.Parameters.Add("tipo", SqlDbType.Char, 1).Value = this.tipo;
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Cadastro efetuado com sucesso!");

                con.Close();

            }
            catch (ArgumentException)
            {
                MessageBox.Show("Falha no Cadastro!", "Mensagem");
            }
        }

        public static List<Professor> listaNomeProfessor(string nome)
        {
            try
            {
                string sql = "select nome from professor where nome like '%" + nome + "%'";
                SqlConnection con = Conexao.AbrirConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sql;

                SqlDataReader rd = cmd.ExecuteReader();
                List<Professor> lst = new List<Professor>();
                while (rd.Read())
                {
                    Professor p = new Professor();
                    p.nome = (rd.GetString(0));
                    lst.Add(p);

                }
                return lst;

                con.Close();
            }
            catch (ArgumentException ex)
            {
                throw ex;

            }

        }

        public  Professor preencherCampos(string professor)
        {
            string sql = "select * from professor where nome like '" + professor + "%'";
            SqlConnection con = Conexao.AbrirConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sql;
            SqlDataReader rd = cmd.ExecuteReader();
            Professor p = new Professor();
            try
            {
                while (rd.Read())
                {
                    p.setCod(Convert.ToInt32(rd["codProfessor"]));
                    p.setNome(rd["nome"].ToString());
                    p.setEmail(rd["email"].ToString());
                    p.setIDsenac(rd["idsenac"].ToString());
                    p.setSenha (rd["senha"].ToString());
                    p.setTipo(Convert.ToChar(rd["tipo"]));
                }

                return p;
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public static void Excluir(int cod)
        {
            try
            {
                string sql = "DELETE FROM professor where codProfessor =" + cod;
                SqlConnection con = Conexao.AbrirConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sql;

                cmd.ExecuteNonQuery();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Falha na exclusão");
            }


        }

    }
}
