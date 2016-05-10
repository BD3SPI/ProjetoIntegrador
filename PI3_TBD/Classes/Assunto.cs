using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace MVC.Classes
{
    class Assunto
    {
        public string descricao { get; set; }
        public string idarea{ get; set; }

        public void Inserir()
        {
            try
            {
                SqlConnection cn = Conexao.AbrirConexao();
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = "INSERT  into ASSUNTO (Descricao, codarea) VALUES (@descricao, @codarea)";

                cmd.Parameters.Add("@descricao", SqlDbType.VarChar, 70).Value = this.descricao;
                cmd.Parameters.Add("@codarea", SqlDbType.VarChar, 20).Value = this.idarea;

                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Cadastro efetuado com sucesso");
            }

            catch (FormatException)
            {
                MessageBox.Show("Erro");

            }

            catch (Exception) 
            { 
                MessageBox.Show("Numero de caracter superir ao permitido", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
        }

        public void PreencherDataGridAssunto(DataGridView tex)
        {
            SqlConnection conn = Conexao.AbrirConexao();

            if (conn == null)
            {
                //MessageBox.Show("Não foi possível obter a conexão. Veja o log de erros.");

            }
            else
            {


                if (tex.DataSource != null)
                {
                    tex.DataSource = null;
                }
                else
                {
                    tex.Rows.Clear();

                }

                using (var comm = conn.CreateCommand())
                {
                    comm.CommandText = "SELECT A.codAssunto, A.descricao 'Assunto', R.descricao 'Area' From Assunto A inner join Area R ON A.codarea = r.codarea";


                    var dataTable = new DataTable();
                    using (var reader = comm.ExecuteReader())
                    {

                        dataTable.Load(reader);
                        reader.Close();
                        reader.Dispose();


                    }
                    tex.DataSource = dataTable;
                    tex.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    tex.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    tex.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    tex.Columns[0].Visible = false;
                    //dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    //dataGridView1.Columns[3].Visible = false;
                }

                conn.Close();
                conn.Dispose();

            }
        }


        public SqlDataReader Carregargrid(int id)
        {
            string sql = "SELECT A.codAssunto, A.descricao 'Assunto', R.descricao 'Area' From Assunto A inner join Area R ON A.codarea = r.codarea where codassunto =" +id;
            SqlConnection cn = Conexao.AbrirConexao();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;
            using (var reader = cmd.ExecuteReader()) 
            {

                return reader;
            }

         
            


            
        }

    }
}
