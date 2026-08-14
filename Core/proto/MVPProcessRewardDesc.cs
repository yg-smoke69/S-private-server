using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B86")]
public class MVPProcessRewardDesc
{
	[Token(Token = "0x400AD1C")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AD1D")]
	[FieldOffset(Offset = "0xC")]
	public uint progress;

	[Token(Token = "0x400AD1E")]
	[FieldOffset(Offset = "0x10")]
	public List<AwardDesc> award_items;

	[Token(Token = "0x60081E1")]
	[Address(RVA = "0x30A722C", Offset = "0x30A722C", VA = "0x30A722C")]
	public MVPProcessRewardDesc()
	{
	}
}
