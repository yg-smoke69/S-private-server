using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001866")]
public class CSGetLimitedEventEPInfoRes
{
	[Token(Token = "0x4009CEA")]
	[FieldOffset(Offset = "0x8")]
	public bool is_purchase_ep;

	[Token(Token = "0x4009CEB")]
	[FieldOffset(Offset = "0xC")]
	public uint progress;

	[Token(Token = "0x4009CEC")]
	[FieldOffset(Offset = "0x10")]
	public List<RewardStatus> rewards;

	[Token(Token = "0x4009CED")]
	[FieldOffset(Offset = "0x14")]
	public uint exchange_progress;

	[Token(Token = "0x6007EBF")]
	[Address(RVA = "0x3186974", Offset = "0x3186974", VA = "0x3186974")]
	public CSGetLimitedEventEPInfoRes()
	{
	}
}
