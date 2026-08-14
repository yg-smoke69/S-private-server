using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200160E")]
public class CSFlipBingoRes
{
	[Token(Token = "0x40094E8")]
	[FieldOffset(Offset = "0x8")]
	public uint activity_id;

	[Token(Token = "0x40094E9")]
	[FieldOffset(Offset = "0xC")]
	public List<ActivityBingoRewardsInfo> rewards;

	[Token(Token = "0x6007C58")]
	[Address(RVA = "0x3180800", Offset = "0x3180800", VA = "0x3180800")]
	public CSFlipBingoRes()
	{
	}
}
