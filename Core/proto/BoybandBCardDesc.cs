using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BFE")]
public class BoybandBCardDesc
{
	[Token(Token = "0x400B02B")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400B02C")]
	[FieldOffset(Offset = "0xC")]
	public uint card_chip_id;

	[Token(Token = "0x400B02D")]
	[FieldOffset(Offset = "0x10")]
	public uint card_num;

	[Token(Token = "0x400B02E")]
	[FieldOffset(Offset = "0x14")]
	public string card_name;

	[Token(Token = "0x400B02F")]
	[FieldOffset(Offset = "0x18")]
	public string card_res;

	[Token(Token = "0x400B030")]
	[FieldOffset(Offset = "0x1C")]
	public List<AwardDesc> rewards;

	[Token(Token = "0x400B031")]
	[FieldOffset(Offset = "0x20")]
	public string card_color;

	[Token(Token = "0x400B032")]
	[FieldOffset(Offset = "0x24")]
	public string card_des;

	[Token(Token = "0x6008259")]
	[Address(RVA = "0x317D1C8", Offset = "0x317D1C8", VA = "0x317D1C8")]
	public BoybandBCardDesc()
	{
	}
}
