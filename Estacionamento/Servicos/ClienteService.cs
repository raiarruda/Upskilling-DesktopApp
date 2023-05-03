using Estacionamento.Entidades;
using Estacionamento.Utilitarios;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Servicos
{
    public class ClienteService
    {
        //Local
        //private static string stringConexao = "Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=123456;";
        /// <summary>
        /// Conexao nuvem
        /// </summary>
        private static string stringConexao = "Server=babar.db.elephantsql.com;Port=5432;Database=udnsecwa;User Id=udnsecwa;Password=wj8iuGtCG2huQ6mFO2r9dirVB23Ixyuo;";

        private readonly PersistenciaPostgres<Cliente> _persistencia = new PersistenciaPostgres<Cliente>(stringConexao);


        public void SalvarCliente(Cliente cliente)
        {
            try
            {
                _persistencia.Incluir(cliente);
                Console.WriteLine("Cliente incluído no banco");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao incluir cliente no banco");
            }
        }
        public List<Cliente> CarregarClientes()
        {
            try
            {
                return _persistencia.Buscar();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao buscar clientes no banco: " + ex.Message);
                return new List<Cliente>();
            }
        }
    }
}
