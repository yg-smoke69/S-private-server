using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B0F")]
public class GarenaRegisterSwitchDesc
{
	[Token(Token = "0x400AA1B")]
	[FieldOffset(Offset = "0x8")]
	public string country;

	[Token(Token = "0x400AA1C")]
	[FieldOffset(Offset = "0xC")]
	public bool register_switch;

	[Token(Token = "0x600816A")]
	[Address(RVA = "0x30A1D58", Offset = "0x30A1D58", VA = "0x30A1D58")]
	public GarenaRegisterSwitchDesc()
	{
	}
}
