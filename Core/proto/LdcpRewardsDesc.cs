using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B43")]
public class LdcpRewardsDesc
{
	[Token(Token = "0x400AB93")]
	[FieldOffset(Offset = "0x8")]
	public uint money;

	[Token(Token = "0x400AB94")]
	[FieldOffset(Offset = "0xC")]
	public List<AwardDesc> award_items;

	[Token(Token = "0x400AB95")]
	[FieldOffset(Offset = "0x10")]
	public bool big_one;

	[Token(Token = "0x600819E")]
	[Address(RVA = "0x30A43B8", Offset = "0x30A43B8", VA = "0x30A43B8")]
	public LdcpRewardsDesc()
	{
	}
}
