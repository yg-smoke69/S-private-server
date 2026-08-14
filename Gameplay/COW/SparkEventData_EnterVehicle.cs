using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E1F")]
internal class SparkEventData_EnterVehicle : SparkEventData_Base
{
	[Token(Token = "0x400BE69")]
	[FieldOffset(Offset = "0x10")]
	public int vehicle_id;

	[Token(Token = "0x400BE6A")]
	[FieldOffset(Offset = "0x14")]
	public int vehicle_hp;

	[Token(Token = "0x6008FE0")]
	[Address(RVA = "0x20F5488", Offset = "0x20F5488", VA = "0x20F5488")]
	public SparkEventData_EnterVehicle()
	{
	}

	[Token(Token = "0x6008FE1")]
	[Address(RVA = "0x20F5490", Offset = "0x20F5490", VA = "0x20F5490", Slot = "4")]
	public override string GetEventType()
	{
		return null;
	}
}
