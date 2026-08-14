using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A2C")]
public class ClanRecommendDesc
{
	[Token(Token = "0x400A3F2")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A3F3")]
	[FieldOffset(Offset = "0xC")]
	public uint factor;

	[Token(Token = "0x6008084")]
	[Address(RVA = "0x309C090", Offset = "0x309C090", VA = "0x309C090")]
	public ClanRecommendDesc()
	{
	}
}
