using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B4A")]
public class BooyahDayProcessRewardDesc
{
	[Token(Token = "0x400ABB1")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400ABB2")]
	[FieldOffset(Offset = "0x10")]
	public ulong progress;

	[Token(Token = "0x400ABB3")]
	[FieldOffset(Offset = "0x18")]
	public List<AwardDesc> award_items;

	[Token(Token = "0x60081A5")]
	[Address(RVA = "0x317CA08", Offset = "0x317CA08", VA = "0x317CA08")]
	public BooyahDayProcessRewardDesc()
	{
	}
}
