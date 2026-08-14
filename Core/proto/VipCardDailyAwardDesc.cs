using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BDD")]
public class VipCardDailyAwardDesc
{
	[Token(Token = "0x400AF48")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AF49")]
	[FieldOffset(Offset = "0xC")]
	public EVipCard.VipCardType type;

	[Token(Token = "0x400AF4A")]
	[FieldOffset(Offset = "0x10")]
	public uint day_time;

	[Token(Token = "0x400AF4B")]
	[FieldOffset(Offset = "0x14")]
	public List<AwardDesc> awards;

	[Token(Token = "0x6008238")]
	[Address(RVA = "0x33E4A44", Offset = "0x33E4A44", VA = "0x33E4A44")]
	public VipCardDailyAwardDesc()
	{
	}
}
