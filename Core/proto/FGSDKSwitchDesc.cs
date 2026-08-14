using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B7F")]
public class FGSDKSwitchDesc
{
	[Token(Token = "0x400ACF8")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400ACF9")]
	[FieldOffset(Offset = "0xC")]
	public string url;

	[Token(Token = "0x400ACFA")]
	[FieldOffset(Offset = "0x10")]
	public uint rate;

	[Token(Token = "0x400ACFB")]
	[FieldOffset(Offset = "0x18")]
	public long utflag;

	[Token(Token = "0x60081DA")]
	[Address(RVA = "0x30A0A20", Offset = "0x30A0A20", VA = "0x30A0A20")]
	public FGSDKSwitchDesc()
	{
	}
}
