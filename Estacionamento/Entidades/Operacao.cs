using System;

namespace Estacionamento.Entidades
{

    public class Operacao
    {

        Guid Id = Guid.NewGuid();
        Guid VeiculoId { get; set; }
        DateTime DataEntrada { get; set; }
        DateTime DataSaida { get; set; }

    }
}