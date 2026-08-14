using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016D8")]
public class CSGetLotteryProbabilityReq
{
	[Token(Token = "0x400977C")]
	[FieldOffset(Offset = "0x8")]
	public uint chest_id;

	[Token(Token = "0x400977D")]
	[FieldOffset(Offset = "0xC")]
	public uint chest_sub_id;

	[Token(Token = "0x6007D32")]
	[Address(RVA = "0x3187208", Offset = "0x3187208", VA = "0x3187208")]
	public CSGetLotteryProbabilityReq()
	{
	}
}
