using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200165A")]
public class CSPrepareForClanWarReq
{
	[Token(Token = "0x40095FF")]
	[FieldOffset(Offset = "0x8")]
	public ulong clan_id;

	[Token(Token = "0x4009600")]
	[FieldOffset(Offset = "0x10")]
	public bool has_prepared;

	[Token(Token = "0x4009601")]
	[FieldOffset(Offset = "0x14")]
	public uint system_platform;

	[Token(Token = "0x4009602")]
	[FieldOffset(Offset = "0x18")]
	public MatchClientInfo client_info;

	[Token(Token = "0x6007CA4")]
	[Address(RVA = "0x3098718", Offset = "0x3098718", VA = "0x3098718")]
	public CSPrepareForClanWarReq()
	{
	}
}
