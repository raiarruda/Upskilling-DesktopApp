using Estacionamento.Entidades;
using Estacionamento.Servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento_Desktop
{
    public partial class ClienteForm : Form
    {

        ClienteService clienteService = new ClienteService();

        public ClienteForm()
        {
            InitializeComponent();
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {
            carregarDados();
        }

        private void btnAdicionarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente
            {
                Nome = txtNome.Text,
                Telefone = txtTelefone.Text
            };

            clienteService.SalvarCliente(cliente);

            carregarDados();
        }

        private void carregarDados()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = clienteService.CarregarClientes();

            dataGridView1.DataSource = bindingSource;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            PrincipalForm p = new PrincipalForm(); ;
            p.Show();
            Close();
        }
    }
}
