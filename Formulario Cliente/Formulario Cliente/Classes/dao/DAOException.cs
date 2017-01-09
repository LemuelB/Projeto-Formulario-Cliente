using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario_Cliente.Classes.dao
{
    class DAOException: Exception
    {

        DAOException()
        {

        }

        DAOException(string msg)
        {
            System.Windows.Forms.MessageBox.Show(msg);

        }


    }
}
