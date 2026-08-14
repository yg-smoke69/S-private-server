using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BB2")]
public class LuckyWheelDiscountDesc
{
	[Token(Token = "0x400AE3B")]
	[FieldOffset(Offset = "0x8")]
	public uint wheel_id;

	[Token(Token = "0x400AE3C")]
	[FieldOffset(Offset = "0xC")]
	public uint discount_id;

	[Token(Token = "0x400AE3D")]
	[FieldOffset(Offset = "0x10")]
	public uint award_type;

	[Token(Token = "0x400AE3E")]
	[FieldOffset(Offset = "0x14")]
	public uint award_value;

	[Token(Token = "0x400AE3F")]
	[FieldOffset(Offset = "0x18")]
	public uint weight;

	[Token(Token = "0x400AE40")]
	[FieldOffset(Offset = "0x1C")]
	public uint award_level;

	[Token(Token = "0x400AE41")]
	[FieldOffset(Offset = "0x20")]
	public bool need_share;

	[Token(Token = "0x400AE42")]
	[FieldOffset(Offset = "0x24")]
	public List<LuckyWheelDiscountMelonDesc> melons;

	[Token(Token = "0x600820D")]
	[Address(RVA = "0x30A6ED8", Offset = "0x30A6ED8", VA = "0x30A6ED8")]
	public LuckyWheelDiscountDesc()
	{
	}
}
