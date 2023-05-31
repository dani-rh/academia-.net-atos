using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOnet
{
    internal class Banco
    {
        private string stringConexao = "Data Source=localhost;" 
            + "Initial Catalog=adonet; User ID=atos;" + "password=Senh@_123;language=Portuguese";

        private SqlConnection cn;

        private void conexao()
        {
            cn = new SqlConnection(stringConexao);
        }

        public SqlConnection abrirConexao()
        {
            try
            {
                conexao();
                cn.Open();
                return cn;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void fecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public DataTable executarConsultaGenerica(string sql)
        {
            try
            {
                abrirConexao();

                SqlCommand command = new SqlCommand(sql, cn);//cria o comando
                command.ExecuteNonQuery();//executa o comando
                
                SqlDataAdapter adapter = new SqlDataAdapter(command);//adapter, que manuseia os dados do comando
                DataTable dt = new DataTable();//tabela em memória
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                fecharConexao();
            }
        }


    }
}
