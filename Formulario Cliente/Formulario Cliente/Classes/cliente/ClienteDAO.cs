using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Formulario_Cliente.Classes.conexao;
using System.Windows.Forms;
using Formulario_Cliente.Classes.dao;

namespace Formulario_Cliente.Classes.cliente 
{
    class ClienteDAO : DAO<Cliente>
    {
        //a conexão com o banco de dados
        private SqlConnection connection;

        public ClienteDAO()
        {
            this.connection = new ConnectionFactory().getConnection();
        }

        public override void adicionar(Cliente cliente)
        {
            string sql = "INSERT INTO Cliente" +
                "( nome, telefone)" +
                "VALUES ( @nome, @telefone)";

            try
            {
                SqlCommand comando = new SqlCommand(sql, connection);

               // comando.Parameters.Add("@id", SqlDbType.Int).Value = cliente.Id;
                comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = cliente.Nome;
                comando.Parameters.Add("@telefone", SqlDbType.VarChar).Value = cliente.Telefone;

                connection.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("sucesso!!!");
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                connection.Close();
            }
        }

       
        public override void alterar()
        {
            throw new NotImplementedException();
        }

        public override List<Cliente> listar()
        {
            throw new NotImplementedException();
        }

        public override void remover()
        {
            throw new NotImplementedException();
        }
    }
}
