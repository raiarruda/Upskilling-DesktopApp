using Estacionamento.Entidades;
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
        public ClienteForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void ClienteForm_Load(object sender, EventArgs e)
        {
            carregarDados();
        }

        private void btnAdicionarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente{
                Nome = txtNome.Text,
                Telefone = txtTelefone.Text
                };

            cliente.Salvar();

            foreach (Cliente c in  Cliente.Todos()) {
                Console.WriteLine(c.Nome);
                    }

             carregarDados();
        }

        private void carregarDados()
        {
                        BindingSource bindingSource = new BindingSource(); 
            bindingSource.DataSource = Cliente.Todos();

            dataGridView1.DataSource = bindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrincipalForm p = new PrincipalForm();;
            p.Show();
            this.Close();
        }
    }
}
