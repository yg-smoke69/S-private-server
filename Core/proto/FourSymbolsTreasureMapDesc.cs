using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BB7")]
public class FourSymbolsTreasureMapDesc
{
	[Token(Token = "0x400AE7A")]
	[FieldOffset(Offset = "0x8")]
	public uint start_time;

	[Token(Token = "0x400AE7B")]
	[FieldOffset(Offset = "0xC")]
	public uint end_time;

	[Token(Token = "0x400AE7C")]
	[FieldOffset(Offset = "0x10")]
	public string image_url;

	[Token(Token = "0x6008212")]
	[Address(RVA = "0x30A11D8", Offset = "0x30A11D8", VA = "0x30A11D8")]
	public FourSymbolsTreasureMapDesc()
	{
	}
}
