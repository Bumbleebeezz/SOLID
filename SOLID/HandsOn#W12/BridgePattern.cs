using SOLID.HandsOn_W12.Switches;
using SOLID.HandsOn_W12.Units;

namespace SOLID.HandsOn_W12;

public static class BridgePattern
{
	public static void Run()
	{
		// BRIDGE Pattern, SRP 

		Console.WriteLine("Starting test");

		IElectricalUnit unit = new Light();
		ISwitch sw = new StandardSwitch();

		sw
			.SetElectricalUnit(unit)
			.On()
			.Off();

		unit = new Fan();

		sw.SetElectricalUnit(unit);
		sw.On();
		sw.Off();

		sw = new FancySwitch();
		sw.SetElectricalUnit(unit);
		sw.On();
		sw.Off();

		unit = new Light();

		sw.SetElectricalUnit(unit);
		sw.On();
		sw.Off();
	}
}