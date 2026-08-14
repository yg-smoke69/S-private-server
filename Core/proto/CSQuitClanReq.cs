using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001632")]
public class CSQuitClanReq
{
	[Token(Token = "0x400955D")]
	[FieldOffset(Offset = "0x8")]
	public ulong clan_id;

	[Token(Token = "0x400955E")]
	[FieldOffset(Offset = "0x10")]
	public bool is_clan_war_recruit;

	[Token(Token = "0x6007C7C")]
	[Address(RVA = "0x30989E8", Offset = "0x30989E8", VA = "0x30989E8")]
	public CSQuitClanReq()
	{
	}
}
