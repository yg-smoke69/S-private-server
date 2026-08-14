using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016EC")]
public class CSReRandomCompletionLotteryReq
{
	[Token(Token = "0x40097F4")]
	[FieldOffset(Offset = "0x8")]
	public uint lottery_id;

	[Token(Token = "0x40097F5")]
	[FieldOffset(Offset = "0xC")]
	public uint lottery_sub_id;

	[Token(Token = "0x40097F6")]
	[FieldOffset(Offset = "0x10")]
	public uint[] id_list;

	[Token(Token = "0x40097F7")]
	[FieldOffset(Offset = "0x14")]
	public string nick_name;

	[Token(Token = "0x6007D46")]
	[Address(RVA = "0x3098D98", Offset = "0x3098D98", VA = "0x3098D98")]
	public CSReRandomCompletionLotteryReq()
	{
	}
}
