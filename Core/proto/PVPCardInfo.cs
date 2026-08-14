using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AE0")]
public class PVPCardInfo
{
	[Token(Token = "0x400A908")]
	[FieldOffset(Offset = "0x8")]
	public bool enable_flip;

	[Token(Token = "0x400A909")]
	[FieldOffset(Offset = "0x9")]
	public bool win_award;

	[Token(Token = "0x400A90A")]
	[FieldOffset(Offset = "0xC")]
	public List<CardPrice> card_price;

	[Token(Token = "0x400A90B")]
	[FieldOffset(Offset = "0x10")]
	public List<AwardFromCard> awards;

	[Token(Token = "0x400A90C")]
	[FieldOffset(Offset = "0x14")]
	public uint flip_count_today;

	[Token(Token = "0x400A90D")]
	[FieldOffset(Offset = "0x18")]
	public uint flip_count_max;

	[Token(Token = "0x400A90E")]
	[FieldOffset(Offset = "0x1C")]
	public string back_image_url;

	[Token(Token = "0x600813B")]
	[Address(RVA = "0x33DEF04", Offset = "0x33DEF04", VA = "0x33DEF04")]
	public PVPCardInfo()
	{
	}
}
