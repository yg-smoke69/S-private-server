using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001756")]
public class CSGetMysteryLuckyDrawReq
{
	[Token(Token = "0x40099FF")]
	[FieldOffset(Offset = "0x8")]
	public uint entry_from;

	[Token(Token = "0x4009A00")]
	[FieldOffset(Offset = "0xC")]
	public uint shop_id;

	[Token(Token = "0x6007DB0")]
	[Address(RVA = "0x3187E0C", Offset = "0x3187E0C", VA = "0x3187E0C")]
	public CSGetMysteryLuckyDrawReq()
	{
	}
}
