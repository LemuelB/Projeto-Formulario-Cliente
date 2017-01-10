using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Formulario_Cliente.Classes.conexao;

namespace Formulario_Cliente.Classes.conexao
{
   public class ConnectionFactory
    {
       public SqlConnection getConnection()
        {
            try{

                //string de conexão, para acessar através do ip
                string url = "Data Source=192.168.0.102,";
                string porta = "1433;";
                string libConexaoRede = "Network Library=DBMSSOCN;";
                string banco = "Initial Catalog=myDataBase;";
                string user = "User ID=sa;";
                string senha = "Password =123456;";

               
                return new SqlConnection(url + porta + libConexaoRede + banco + user + senha);

            }catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Erro ao iniciar a conexão\n"+ex.Message);

            }
            return null;
        }
    }
}
