using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A7A")]
public class RankingScaleModifyDesc
{
	[Token(Token = "0x400A5B6")]
	[FieldOffset(Offset = "0x8")]
	public uint life_time_lower;

	[Token(Token = "0x400A5B7")]
	[FieldOffset(Offset = "0xC")]
	public uint life_time_upper;

	[Token(Token = "0x400A5B8")]
	[FieldOffset(Offset = "0x10")]
	public List<RankingScaleModifyDetailDesc> scale_modify_details;

	[Token(Token = "0x60080D7")]
	[Address(RVA = "0x33E0C6C", Offset = "0x33E0C6C", VA = "0x33E0C6C")]
	public RankingScaleModifyDesc()
	{
	}
}
