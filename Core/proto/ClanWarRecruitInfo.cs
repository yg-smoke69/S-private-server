using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013C5")]
public class ClanWarRecruitInfo
{
	[Token(Token = "0x4008AFF")]
	[FieldOffset(Offset = "0x8")]
	public ulong clan_id;

	[Token(Token = "0x4008B00")]
	[FieldOffset(Offset = "0x10")]
	public uint entry_rank;

	[Token(Token = "0x4008B01")]
	[FieldOffset(Offset = "0x14")]
	public uint entry_cs_rank;

	[Token(Token = "0x6007AB0")]
	[Address(RVA = "0x309C444", Offset = "0x309C444", VA = "0x309C444")]
	public ClanWarRecruitInfo()
	{
	}
}
