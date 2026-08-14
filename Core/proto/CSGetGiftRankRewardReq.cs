using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200173F")]
public class CSGetGiftRankRewardReq
{
	[Token(Token = "0x40099B1")]
	[FieldOffset(Offset = "0x8")]
	public uint rank_id;

	[Token(Token = "0x40099B2")]
	[FieldOffset(Offset = "0xC")]
	public EStore.GiftRankType gift_rank_type;

	[Token(Token = "0x40099B3")]
	[FieldOffset(Offset = "0x10")]
	public uint gift_item_num;

	[Token(Token = "0x6007D99")]
	[Address(RVA = "0x3185A70", Offset = "0x3185A70", VA = "0x3185A70")]
	public CSGetGiftRankRewardReq()
	{
	}
}
