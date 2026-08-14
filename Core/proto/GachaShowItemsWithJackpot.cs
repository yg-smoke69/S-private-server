using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016E8")]
public class GachaShowItemsWithJackpot
{
	[Token(Token = "0x40097DF")]
	[FieldOffset(Offset = "0x8")]
	public List<GachaShowItem> items;

	[Token(Token = "0x40097E0")]
	[FieldOffset(Offset = "0xC")]
	public uint jackpot;

	[Token(Token = "0x6007D42")]
	[Address(RVA = "0x30A1780", Offset = "0x30A1780", VA = "0x30A1780")]
	public GachaShowItemsWithJackpot()
	{
	}
}
