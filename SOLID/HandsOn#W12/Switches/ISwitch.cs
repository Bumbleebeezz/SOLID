using SOLID.HandsOn_W12.Units;

namespace SOLID.HandsOn_W12.Switches;

public interface ISwitch
{
	ISwitch SetElectricalUnit(IElectricalUnit unit);
	ISwitch On();
	ISwitch Off();
}