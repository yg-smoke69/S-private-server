using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AE1")]
public class PVECardInfo
{
	[Token(Token = "0x400A90F")]
	[FieldOffset(Offset = "0x8")]
	public bool enable_flip;

	[Token(Token = "0x400A910")]
	[FieldOffset(Offset = "0xC")]
	public List<CardPrice> card_price;

	[Token(Token = "0x400A911")]
	[FieldOffset(Offset = "0x10")]
	public List<AwardFromCard> awards;

	[Token(Token = "0x400A912")]
	[FieldOffset(Offset = "0x14")]
	public uint flip_count_today;

	[Token(Token = "0x400A913")]
	[FieldOffset(Offset = "0x18")]
	public uint flip_count_max;

	[Token(Token = "0x400A914")]
	[FieldOffset(Offset = "0x1C")]
	public List<CardImageDesc> back_image;

	[Token(Token = "0x400A915")]
	[FieldOffset(Offset = "0x20")]
	public uint match_rank;

	[Token(Token = "0x600813C")]
	[Address(RVA = "0x33DEE00", Offset = "0x33DEE00", VA = "0x33DEE00")]
	public PVECardInfo()
	{
	}
}
