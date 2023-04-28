using System;
namespace Estacionamento.Entidades
{
    public class Cliente
    {


        Guid Id = Guid.NewGuid();
        string Nome { get; set; }
        int Telefone { get; set; }


    }


}