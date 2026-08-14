using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A17")]
public class RecommendStudentPoolSettingDesc
{
	[Token(Token = "0x400A39B")]
	[FieldOffset(Offset = "0x8")]
	public uint pool_num;

	[Token(Token = "0x400A39C")]
	[FieldOffset(Offset = "0xC")]
	public uint factor;

	[Token(Token = "0x600806F")]
	[Address(RVA = "0x33E1168", Offset = "0x33E1168", VA = "0x33E1168")]
	public RecommendStudentPoolSettingDesc()
	{
	}
}
