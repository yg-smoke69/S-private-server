using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BF4")]
public class RecommendMentorPoolSettingDesc
{
	[Token(Token = "0x400B00B")]
	[FieldOffset(Offset = "0x8")]
	public uint pool_num;

	[Token(Token = "0x400B00C")]
	[FieldOffset(Offset = "0xC")]
	public uint factor;

	[Token(Token = "0x600824F")]
	[Address(RVA = "0x33E1160", Offset = "0x33E1160", VA = "0x33E1160")]
	public RecommendMentorPoolSettingDesc()
	{
	}
}
