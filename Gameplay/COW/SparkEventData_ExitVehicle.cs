using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E20")]
internal class SparkEventData_ExitVehicle : SparkEventData_Base
{
	[Token(Token = "0x400BE6B")]
	[FieldOffset(Offset = "0x10")]
	public int vehicle_id;

	[Token(Token = "0x400BE6C")]
	[FieldOffset(Offset = "0x14")]
	public int vehicle_hp;

	[Token(Token = "0x6008FE2")]
	[Address(RVA = "0x20F5534", Offset = "0x20F5534", VA = "0x20F5534")]
	public SparkEventData_ExitVehicle()
	{
	}

	[Token(Token = "0x6008FE3")]
	[Address(RVA = "0x20F553C", Offset = "0x20F553C", VA = "0x20F553C", Slot = "4")]
	public override string GetEventType()
	{
		return null;
	}
}
