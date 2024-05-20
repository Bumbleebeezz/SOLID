using SOLID.HandsOn_W12.Units;

namespace SOLID.HandsOn_W12.Switches;

public abstract class Switch : ISwitch
{
	public abstract string Name { get;}
	public IElectricalUnit ElectricalUnit { get; private set; }
	public void SetElectricalUnit(IElectricalUnit unit)
	{
		ElectricalUnit = unit;
	}

	public void On()
	{
		ElectricalUnit.On();
	}

	public void Off()
	{
		ElectricalUnit.Off();
	}
}