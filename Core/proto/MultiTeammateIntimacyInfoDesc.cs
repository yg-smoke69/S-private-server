using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BF1")]
public class MultiTeammateIntimacyInfoDesc
{
	[Token(Token = "0x400AFFF")]
	[FieldOffset(Offset = "0x8")]
	public EChummy.MultiRelationType multi_relation_type;

	[Token(Token = "0x400B000")]
	[FieldOffset(Offset = "0xC")]
	public uint game_mode;

	[Token(Token = "0x400B001")]
	[FieldOffset(Offset = "0x10")]
	public uint upper_ranking;

	[Token(Token = "0x400B002")]
	[FieldOffset(Offset = "0x14")]
	public uint lower_ranking;

	[Token(Token = "0x400B003")]
	[FieldOffset(Offset = "0x18")]
	public uint intimacy_value;

	[Token(Token = "0x600824C")]
	[Address(RVA = "0x30A9200", Offset = "0x30A9200", VA = "0x30A9200")]
	public MultiTeammateIntimacyInfoDesc()
	{
	}
}
