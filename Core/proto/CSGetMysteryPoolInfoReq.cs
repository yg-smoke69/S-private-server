using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200175B")]
public class CSGetMysteryPoolInfoReq
{
	[Token(Token = "0x4009A0C")]
	[FieldOffset(Offset = "0x8")]
	public uint pool_id;

	[Token(Token = "0x4009A0D")]
	[FieldOffset(Offset = "0xC")]
	public string language;

	[Token(Token = "0x4009A0E")]
	[FieldOffset(Offset = "0x10")]
	public uint shop_id;

	[Token(Token = "0x6007DB5")]
	[Address(RVA = "0x3187E1C", Offset = "0x3187E1C", VA = "0x3187E1C")]
	public CSGetMysteryPoolInfoReq()
	{
	}
}
