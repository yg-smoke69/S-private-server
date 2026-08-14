using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200135B")]
public class AwardData
{
	[Token(Token = "0x40088C3")]
	[FieldOffset(Offset = "0x8")]
	public List<Item> items;

	[Token(Token = "0x40088C4")]
	[FieldOffset(Offset = "0xC")]
	public uint coins;

	[Token(Token = "0x40088C5")]
	[FieldOffset(Offset = "0x10")]
	public uint gems;

	[Token(Token = "0x40088C6")]
	[FieldOffset(Offset = "0x14")]
	public uint exps;

	[Token(Token = "0x40088C7")]
	[FieldOffset(Offset = "0x18")]
	public uint activeness;

	[Token(Token = "0x40088C8")]
	[FieldOffset(Offset = "0x1C")]
	public uint accelerators;

	[Token(Token = "0x40088C9")]
	[FieldOffset(Offset = "0x20")]
	public uint general_times_for_ugc_room;

	[Token(Token = "0x6007A5C")]
	[Address(RVA = "0x317B378", Offset = "0x317B378", VA = "0x317B378")]
	public AwardData()
	{
	}
}
