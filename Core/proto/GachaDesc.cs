using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016E5")]
public class GachaDesc
{
	[Token(Token = "0x4009796")]
	[FieldOffset(Offset = "0x8")]
	public uint chest_id;

	[Token(Token = "0x4009797")]
	[FieldOffset(Offset = "0xC")]
	public ClientChestType chest_type;

	[Token(Token = "0x4009798")]
	[FieldOffset(Offset = "0x10")]
	public List<GachaShowItemsWithJackpot> item_list_with_jackpot;

	[Token(Token = "0x4009799")]
	[FieldOffset(Offset = "0x14")]
	public List<ExtraRewardDesc> extra_rewards;

	[Token(Token = "0x6007D3F")]
	[Address(RVA = "0x30A16B0", Offset = "0x30A16B0", VA = "0x30A16B0")]
	public GachaDesc()
	{
	}
}
