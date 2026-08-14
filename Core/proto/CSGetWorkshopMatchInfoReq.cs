using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018F7")]
public class CSGetWorkshopMatchInfoReq
{
	[Token(Token = "0x4009E4C")]
	[FieldOffset(Offset = "0x8")]
	public uint player_cnt;

	[Token(Token = "0x4009E4D")]
	[FieldOffset(Offset = "0xC")]
	public EWorkshop.MatchPoolType match_pool_type;

	[Token(Token = "0x4009E4E")]
	[FieldOffset(Offset = "0x10")]
	public bool is_in_group;

	[Token(Token = "0x4009E4F")]
	[FieldOffset(Offset = "0x14")]
	public ulong[] member_ids;

	[Token(Token = "0x6007F50")]
	[Address(RVA = "0x3096DD8", Offset = "0x3096DD8", VA = "0x3096DD8")]
	public CSGetWorkshopMatchInfoReq()
	{
	}
}
