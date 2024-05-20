using SOLID.HandsOn_W12.Units;

namespace SOLID.HandsOn_W12.Switches;

public abstract class Switch : ISwitch
{
	public abstract string Name { get;}
	public IElectricalUnit ElectricalUnit { get; private set; }
	public ISwitch SetElectricalUnit(IElectricalUnit unit)
	{
		ElectricalUnit = unit;
		return this;
	}

	public ISwitch On()
	{
		Console.WriteLine($"{this.Name} toogles on");
		ElectricalUnit.On();
		return this;
	}

	public ISwitch Off()
	{
		Console.WriteLine($"{this.Name} toogles off");
		ElectricalUnit.Off();
		return this;
	}
}