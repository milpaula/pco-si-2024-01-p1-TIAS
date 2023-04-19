using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula08_CRUD_XML
{
    public partial class Form1 : Form
    {
        private ClientesDAO clientes;

        public Form1()
        {
            InitializeComponent();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clientes = new ClientesDAO();
            clientes.Carregar();
            dataGridView1.DataSource = clientes.MostrarClientes();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente()
            {
                Nome = textNome.Text,
                Email = textEmail.Text
            };

            clientes.Adicionar(cli);
            clientes.Salvar();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = clientes.MostrarClientes();
        }

        private void btnRemover_Click(object sender, EventArgs e){

            clientes.Remover();
            clientes.Carregar();

        }
    }
}
