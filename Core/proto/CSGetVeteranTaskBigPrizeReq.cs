using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017D6")]
public class CSGetVeteranTaskBigPrizeReq
{
	[Token(Token = "0x4009B87")]
	[FieldOffset(Offset = "0x8")]
	public EAttendance.VeteranClass veteran_class;

	[Token(Token = "0x4009B88")]
	[FieldOffset(Offset = "0xC")]
	public uint big_prize_id;

	[Token(Token = "0x4009B89")]
	[FieldOffset(Offset = "0x10")]
	public uint big_prize_index;

	[Token(Token = "0x6007E30")]
	[Address(RVA = "0x30961D4", Offset = "0x30961D4", VA = "0x30961D4")]
	public CSGetVeteranTaskBigPrizeReq()
	{
	}
}
