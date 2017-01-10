using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Formulario_Cliente.Classes.dao
{
  abstract  class  DAO <T>
    {
        abstract public void adicionar(T elemento);
        abstract public void remover(int id);
        abstract public List<T> listar();
        abstract public void alterar();
    }
}
