using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001515")]
public class CSGetAccountMatchStatsReq
{
	[Token(Token = "0x40090AB")]
	[FieldOffset(Offset = "0x8")]
	public ulong match_id;

	[Token(Token = "0x40090AC")]
	[FieldOffset(Offset = "0x10")]
	public bool is_pve;

	[Token(Token = "0x6007B5E")]
	[Address(RVA = "0x3180D48", Offset = "0x3180D48", VA = "0x3180D48")]
	public CSGetAccountMatchStatsReq()
	{
	}
}
