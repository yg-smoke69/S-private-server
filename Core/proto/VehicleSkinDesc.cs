using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019AA")]
public class VehicleSkinDesc
{
	[Token(Token = "0x400A0F3")]
	[FieldOffset(Offset = "0x8")]
	public uint item_id;

	[Token(Token = "0x400A0F4")]
	[FieldOffset(Offset = "0xC")]
	public uint vehicle_id;

	[Token(Token = "0x6008001")]
	[Address(RVA = "0x33E41C8", Offset = "0x33E41C8", VA = "0x33E41C8")]
	public VehicleSkinDesc()
	{
	}
}
