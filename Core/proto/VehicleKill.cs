using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013E4")]
public class VehicleKill
{
	[Token(Token = "0x4008B69")]
	[FieldOffset(Offset = "0x8")]
	public uint vehicle_id;

	[Token(Token = "0x4008B6A")]
	[FieldOffset(Offset = "0xC")]
	public uint cnt;

	[Token(Token = "0x6007AC5")]
	[Address(RVA = "0x33E41C0", Offset = "0x33E41C0", VA = "0x33E41C0")]
	public VehicleKill()
	{
	}
}
