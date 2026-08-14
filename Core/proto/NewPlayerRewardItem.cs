using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001601")]
public class NewPlayerRewardItem
{
	[Token(Token = "0x40094C5")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x40094C6")]
	[FieldOffset(Offset = "0xC")]
	public uint signed;

	[Token(Token = "0x40094C7")]
	[FieldOffset(Offset = "0x10")]
	public List<AwardDesc> awards;

	[Token(Token = "0x6007C4B")]
	[Address(RVA = "0x33DE630", Offset = "0x33DE630", VA = "0x33DE630")]
	public NewPlayerRewardItem()
	{
	}
}
