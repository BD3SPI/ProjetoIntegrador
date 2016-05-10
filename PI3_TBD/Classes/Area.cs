using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace MVC.Classes
{
    class Area
    {
        public string descricao { get; set; }
        public string codarea { get; set; }

        public void Inserir()
        {
            try
            {
                SqlConnection cn = Conexao.AbrirConexao();
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = "INSERT INTO area (descricao) values (@descricao)";
                cmd.Parameters.Add("@descricao", SqlDbType.VarChar, 50).Value = this.descricao;

                cmd.ExecuteNonQuery();
                cn.Close();
                cn.Dispose();
            }

            catch (ArgumentException)
            {
            }

        }

        public void PreencherDataGrid(DataGridView tex)
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
                    comm.CommandText = "SELECT codArea as 'ID', descricao As 'Descrição' FROM area";
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
                    //dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    //dataGridView1.Columns[3].Visible = false;
                }
                conn.Close();
                conn.Dispose();
            }
        }

        public static List<Area> SelecionarArea()
        {
            SqlConnection cn = Conexao.AbrirConexao();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT codArea, descricao FROM area";

            SqlDataReader dr = cmd.ExecuteReader();
            List<Area> Areas = new List<Area>();

            while (dr.Read())
            {
                Area area = new Area();
                area.codarea = dr["codArea"].ToString();
                area.descricao = dr["descricao"].ToString();
                Areas.Add(area);
            }

            cn.Close();
            cn.Dispose();
            return Areas;






        }

    }
}
