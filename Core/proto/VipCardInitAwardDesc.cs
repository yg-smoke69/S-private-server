using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BDE")]
public class VipCardInitAwardDesc
{
	[Token(Token = "0x400AF4C")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AF4D")]
	[FieldOffset(Offset = "0xC")]
	public EVipCard.VipCardType type;

	[Token(Token = "0x400AF4E")]
	[FieldOffset(Offset = "0x10")]
	public List<AwardDesc> awards;

	[Token(Token = "0x6008239")]
	[Address(RVA = "0x33E4C14", Offset = "0x33E4C14", VA = "0x33E4C14")]
	public VipCardInitAwardDesc()
	{
	}
}
