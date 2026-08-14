using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C20")]
public class ExpGuideDesc
{
	[Token(Token = "0x400B10F")]
	[FieldOffset(Offset = "0x8")]
	public EFresh.GuideMode mode;

	[Token(Token = "0x400B110")]
	[FieldOffset(Offset = "0xC")]
	public uint exp;

	[Token(Token = "0x400B111")]
	[FieldOffset(Offset = "0x10")]
	public List<AwardDesc> awards;

	[Token(Token = "0x6008284")]
	[Address(RVA = "0x30A0054", Offset = "0x30A0054", VA = "0x30A0054")]
	public ExpGuideDesc()
	{
	}
}
