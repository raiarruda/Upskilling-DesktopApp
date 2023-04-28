using System;
using System.Collections.Generic;

namespace Estacionamento.Entidades
{
    public class Cliente
    {


        Guid Id = Guid.NewGuid();
        public string Nome { get; set; }
        public string Telefone { get; set; }

        static List<Cliente> clientes = new List<Cliente> { };

        public static List<Cliente> Todos()
        {
            return clientes;
        }

        public void Salvar()
        {
            clientes.Add(this);
        }
    }


}