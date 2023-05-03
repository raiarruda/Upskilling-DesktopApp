using System;
using System.Collections.Generic;

namespace Estacionamento.Entidades
{
    public class Cliente
    {


        public string Nome { get; set; }
        public string Telefone { get; set; }

        static List<Cliente> clientes = new List<Cliente> { };


    }


}