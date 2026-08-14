using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B42")]
public class LdcpHelpRewardsDesc
{
	[Token(Token = "0x400AB91")]
	[FieldOffset(Offset = "0x8")]
	public uint target;

	[Token(Token = "0x400AB92")]
	[FieldOffset(Offset = "0xC")]
	public List<AwardDesc> award_items;

	[Token(Token = "0x600819D")]
	[Address(RVA = "0x30A432C", Offset = "0x30A432C", VA = "0x30A432C")]
	public LdcpHelpRewardsDesc()
	{
	}
}
