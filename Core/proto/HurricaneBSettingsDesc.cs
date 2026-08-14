using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B9B")]
public class HurricaneBSettingsDesc
{
	[Token(Token = "0x400ADA7")]
	[FieldOffset(Offset = "0x8")]
	public uint token_id;

	[Token(Token = "0x400ADA8")]
	[FieldOffset(Offset = "0xC")]
	public uint token_num;

	[Token(Token = "0x400ADA9")]
	[FieldOffset(Offset = "0x10")]
	public uint skip_num;

	[Token(Token = "0x400ADAA")]
	[FieldOffset(Offset = "0x14")]
	public uint skip_star;

	[Token(Token = "0x60081F6")]
	[Address(RVA = "0x30A3554", Offset = "0x30A3554", VA = "0x30A3554")]
	public HurricaneBSettingsDesc()
	{
	}
}
