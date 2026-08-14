using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C23")]
public class RankingTaskCdtDesc
{
	[Token(Token = "0x400B116")]
	[FieldOffset(Offset = "0x8")]
	public uint task_id;

	[Token(Token = "0x400B117")]
	[FieldOffset(Offset = "0xC")]
	public string key;

	[Token(Token = "0x400B118")]
	[FieldOffset(Offset = "0x10")]
	public uint match_mode;

	[Token(Token = "0x400B119")]
	[FieldOffset(Offset = "0x14")]
	public uint game_mode;

	[Token(Token = "0x400B11A")]
	[FieldOffset(Offset = "0x18")]
	public ERankingTask.PreConditionType pre_cdt_type1;

	[Token(Token = "0x400B11B")]
	[FieldOffset(Offset = "0x1C")]
	public uint pre_cdt_value1;

	[Token(Token = "0x400B11C")]
	[FieldOffset(Offset = "0x20")]
	public ERankingTask.PreConditionType pre_cdt_type2;

	[Token(Token = "0x400B11D")]
	[FieldOffset(Offset = "0x24")]
	public uint pre_cdt_value2;

	[Token(Token = "0x400B11E")]
	[FieldOffset(Offset = "0x28")]
	public ERankingTask.PreConditionType pre_cdt_type3;

	[Token(Token = "0x400B11F")]
	[FieldOffset(Offset = "0x2C")]
	public uint pre_cdt_value3;

	[Token(Token = "0x400B120")]
	[FieldOffset(Offset = "0x30")]
	public ERankingTask.ConditionType cdt_type;

	[Token(Token = "0x400B121")]
	[FieldOffset(Offset = "0x34")]
	public uint cdt_value;

	[Token(Token = "0x400B122")]
	[FieldOffset(Offset = "0x38")]
	public AwardDesc award;

	[Token(Token = "0x400B123")]
	[FieldOffset(Offset = "0x3C")]
	public uint award_point_num;

	[Token(Token = "0x6008287")]
	[Address(RVA = "0x33E0DF0", Offset = "0x33E0DF0", VA = "0x33E0DF0")]
	public RankingTaskCdtDesc()
	{
	}
}
