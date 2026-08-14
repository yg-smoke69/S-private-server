using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019D6")]
public class ActivityBingoRewardsDesc
{
	[Token(Token = "0x400A213")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A214")]
	[FieldOffset(Offset = "0xC")]
	public uint level;

	[Token(Token = "0x400A215")]
	[FieldOffset(Offset = "0x10")]
	public uint[] activity_ids;

	[Token(Token = "0x400A216")]
	[FieldOffset(Offset = "0x14")]
	public List<AwardDesc> awards;

	[Token(Token = "0x600802E")]
	[Address(RVA = "0x3179F9C", Offset = "0x3179F9C", VA = "0x3179F9C")]
	public ActivityBingoRewardsDesc()
	{
	}
}
