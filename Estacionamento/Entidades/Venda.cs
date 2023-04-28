using System;

public class Class1
{
	public Class1()
	{
		Guid Id = Guid.NewGuid();
		Guid VeiculoId { get; set; }
		DateTime DataEntrada { get; set; }
		DateTime DataSaida { get; set; }
	}
}
