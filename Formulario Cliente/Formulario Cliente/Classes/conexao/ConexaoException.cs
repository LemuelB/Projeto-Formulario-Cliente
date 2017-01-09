using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario_Cliente.Classes.conexao
{
    class ConexaoException
    {
        ConexaoException()
        {

        }

        ConexaoException(string msg)
        {
            System.Windows.Forms.MessageBox.Show(msg);
        }
    }
}
