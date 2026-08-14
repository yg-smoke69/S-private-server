using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C22")]
public class RankingTaskDesc
{
	[Token(Token = "0x400B114")]
	[FieldOffset(Offset = "0x8")]
	public uint season_day;

	[Token(Token = "0x400B115")]
	[FieldOffset(Offset = "0xC")]
	public uint[] task_group_id;

	[Token(Token = "0x6008286")]
	[Address(RVA = "0x33E0E90", Offset = "0x33E0E90", VA = "0x33E0E90")]
	public RankingTaskDesc()
	{
	}
}
