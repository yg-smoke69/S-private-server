using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013E8")]
public class ReviveTokenUsed
{
	[Token(Token = "0x4008B75")]
	[FieldOffset(Offset = "0x8")]
	public uint used_gems;

	[Token(Token = "0x4008B76")]
	[FieldOffset(Offset = "0xC")]
	public uint used_coins;

	[Token(Token = "0x4008B77")]
	[FieldOffset(Offset = "0x10")]
	public List<Item> used_items;

	[Token(Token = "0x6007AC9")]
	[Address(RVA = "0x33E1AB8", Offset = "0x33E1AB8", VA = "0x33E1AB8")]
	public ReviveTokenUsed()
	{
	}
}
