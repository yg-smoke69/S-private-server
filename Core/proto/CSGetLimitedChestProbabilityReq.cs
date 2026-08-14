using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200191A")]
public class CSGetLimitedChestProbabilityReq
{
	[Token(Token = "0x4009EC3")]
	[FieldOffset(Offset = "0x8")]
	public uint chest_id;

	[Token(Token = "0x4009EC4")]
	[FieldOffset(Offset = "0xC")]
	public uint chest_sub_id;

	[Token(Token = "0x4009EC5")]
	[FieldOffset(Offset = "0x10")]
	public uint rare_prize_id;

	[Token(Token = "0x4009EC6")]
	[FieldOffset(Offset = "0x14")]
	public uint super_rare_prize_id;

	[Token(Token = "0x6007F73")]
	[Address(RVA = "0x31868A4", Offset = "0x31868A4", VA = "0x31868A4")]
	public CSGetLimitedChestProbabilityReq()
	{
	}
}
