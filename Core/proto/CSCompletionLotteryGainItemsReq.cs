using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016ED")]
public class CSCompletionLotteryGainItemsReq
{
	[Token(Token = "0x40097F8")]
	[FieldOffset(Offset = "0x8")]
	public uint lottery_id;

	[Token(Token = "0x40097F9")]
	[FieldOffset(Offset = "0xC")]
	public uint lottery_sub_id;

	[Token(Token = "0x40097FA")]
	[FieldOffset(Offset = "0x10")]
	public uint[] id_list;

	[Token(Token = "0x6007D47")]
	[Address(RVA = "0x317F0B4", Offset = "0x317F0B4", VA = "0x317F0B4")]
	public CSCompletionLotteryGainItemsReq()
	{
	}
}
