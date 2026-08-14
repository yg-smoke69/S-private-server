using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016D6")]
public class CSLotteryExtraRewardReq
{
	[Token(Token = "0x4009777")]
	[FieldOffset(Offset = "0x8")]
	public uint chest_id;

	[Token(Token = "0x4009778")]
	[FieldOffset(Offset = "0xC")]
	public uint condition_num;

	[Token(Token = "0x4009779")]
	[FieldOffset(Offset = "0x10")]
	public uint chest_sub_id;

	[Token(Token = "0x6007D30")]
	[Address(RVA = "0x30977A8", Offset = "0x30977A8", VA = "0x30977A8")]
	public CSLotteryExtraRewardReq()
	{
	}
}
