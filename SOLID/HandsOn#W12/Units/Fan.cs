namespace SOLID.HandsOn_W12.Units;

public class Fan : IElectricalUnit
{
	public void On()
	{
		Console.WriteLine("Fan is on, spin spin");
	}

	public void Off()
	{
		Console.WriteLine("Fan is off, 0 circulation");
	}
}