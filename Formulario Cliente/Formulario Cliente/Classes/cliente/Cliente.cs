using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario_Cliente.Classes.cliente
{
    class Cliente
    {
        private long id;
        private string nome;
        private string telefone;

        public long Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public override string ToString()
        {
            return "[ Id: "+this.id + "] [ Nome: " + this.nome + "] [ Telefone: " + this.telefone+" ]";

        }
    }
}
