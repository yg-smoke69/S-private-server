using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016D4")]
public class CSLotteryReq
{
	[Token(Token = "0x4009761")]
	[FieldOffset(Offset = "0x8")]
	public uint chest_id;

	[Token(Token = "0x4009762")]
	[FieldOffset(Offset = "0xC")]
	public uint gacha_type;

	[Token(Token = "0x4009763")]
	[FieldOffset(Offset = "0x10")]
	public uint chest_sub_id;

	[Token(Token = "0x4009764")]
	[FieldOffset(Offset = "0x14")]
	public ELottery.ConsumeType consume_type;

	[Token(Token = "0x4009765")]
	[FieldOffset(Offset = "0x18")]
	public uint finite_jackpot;

	[Token(Token = "0x4009766")]
	[FieldOffset(Offset = "0x1C")]
	public uint finite_lottery_count;

	[Token(Token = "0x4009767")]
	[FieldOffset(Offset = "0x20")]
	public uint show_type;

	[Token(Token = "0x6007D2E")]
	[Address(RVA = "0x30977B0", Offset = "0x30977B0", VA = "0x30977B0")]
	public CSLotteryReq()
	{
	}
}
