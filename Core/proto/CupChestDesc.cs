using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BAC")]
public class CupChestDesc
{
	[Token(Token = "0x400AE22")]
	[FieldOffset(Offset = "0x8")]
	public uint cup_type;

	[Token(Token = "0x400AE23")]
	[FieldOffset(Offset = "0xC")]
	public uint cup_id;

	[Token(Token = "0x400AE24")]
	[FieldOffset(Offset = "0x10")]
	public uint chest_id;

	[Token(Token = "0x400AE25")]
	[FieldOffset(Offset = "0x14")]
	public uint[] chest_tier;

	[Token(Token = "0x400AE26")]
	[FieldOffset(Offset = "0x18")]
	public uint chest_unlock_wins;

	[Token(Token = "0x400AE27")]
	[FieldOffset(Offset = "0x1C")]
	public string chest_res;

	[Token(Token = "0x400AE28")]
	[FieldOffset(Offset = "0x20")]
	public string chest_name;

	[Token(Token = "0x400AE29")]
	[FieldOffset(Offset = "0x24")]
	public uint[] ticket_item_id;

	[Token(Token = "0x400AE2A")]
	[FieldOffset(Offset = "0x28")]
	public List<AwardDesc> awards;

	[Token(Token = "0x6008207")]
	[Address(RVA = "0x309DBA0", Offset = "0x309DBA0", VA = "0x309DBA0")]
	public CupChestDesc()
	{
	}
}
