using System;

public class Class1
{
	public Class1()
	{
		Guid Id = Guid.NewGuid();
		Guid ClienteId { get; set; }
		string placa { get; set; }
		string marca { get; set; }
	}
}
