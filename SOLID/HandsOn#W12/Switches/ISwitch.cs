using SOLID.HandsOn_W12.Units;

namespace SOLID.HandsOn_W12.Switches;

public interface ISwitch
{
	void SetElectricalUnit(IElectricalUnit unit);
	void On();
	void Off();
}