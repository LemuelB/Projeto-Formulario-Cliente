using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Formulario_Cliente.Classes.conexao;
using Formulario_Cliente.Classes.cliente;


namespace Formulario_Cliente
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Adicionar(object sender, EventArgs e)
        {
            SqlConnection con = new ConnectionFactory().getConnection();

            Cliente cliente = new Cliente();
            cliente.Nome = Convert.ToString(txb_Nome.Text);
            cliente.Telefone = Convert.ToString(txb_Telefone.Text);

            ClienteDAO dao = new ClienteDAO();
            dao.adicionar(cliente);

        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new ConnectionFactory().getConnection();

            ClienteDAO dao = new ClienteDAO();

            List<Cliente> cliente = dao.listar();



            foreach (Cliente Dao in cliente) {
                list_Box.Items.Add(Dao);
            }



        }
    }
}
