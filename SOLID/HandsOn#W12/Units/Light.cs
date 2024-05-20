namespace SOLID.HandsOn_W12.Units;

public class Light : IElectricalUnit
{
	public void On()
	{
		Console.WriteLine("Light is on, let there be light!");
	}

	public void Off()
	{
		Console.WriteLine("Light is off, can´t see anything!");
	}
}