using System;
namespace Estacionamento.Entidades
{
    public class Veiculo
    {

        Guid Id = Guid.NewGuid();
        Guid ClienteId { get; set; }
        string placa { get; set; }
        string marca { get; set; }

    }
}
