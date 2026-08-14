using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001916")]
public class CSSelectLimitedChestPrizeReq
{
	[Token(Token = "0x4009EB8")]
	[FieldOffset(Offset = "0x8")]
	public uint chest_id;

	[Token(Token = "0x4009EB9")]
	[FieldOffset(Offset = "0xC")]
	public uint chest_sub_id;

	[Token(Token = "0x4009EBA")]
	[FieldOffset(Offset = "0x10")]
	public uint rare_prize_id;

	[Token(Token = "0x4009EBB")]
	[FieldOffset(Offset = "0x14")]
	public uint super_rare_prize_id;

	[Token(Token = "0x6007F6F")]
	[Address(RVA = "0x309974C", Offset = "0x309974C", VA = "0x309974C")]
	public CSSelectLimitedChestPrizeReq()
	{
	}
}
