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
            string sql = "SELECT * FROM Cliente";
            List<Cliente> lista = new List<Cliente>();
            
            
            try
            {
                SqlCommand comando = new SqlCommand(sql, connection);

                connection.Open();

                SqlDataReader reader = comando.ExecuteReader();
                
                while(reader.Read())
                {
                    Cliente cliente = new Cliente();

                    cliente.Id = Convert.ToInt32(reader["id"]);
                    cliente.Nome = Convert.ToString(reader["nome"]);
                    cliente.Telefone = Convert.ToString(reader["Telefone"]);

                    lista.Add(cliente);
                }   
                    
                MessageBox.Show("sucesso!!!");

                reader.Close();
                
                connection.Close();
                return lista;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                connection.Close();
            }
            return null;
        }

        public override void remover(int id)
        {
            string sql = "DELETE FROM Cliente where id = @id ";

            try
            {
                SqlCommand comando = new SqlCommand(sql, connection);

                comando.Parameters.Add("@id", SqlDbType.Int).Value = id ;

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
    }
}
