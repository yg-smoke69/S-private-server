using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200160C")]
public class CSGetBingoRewardsInfoRes
{
	[Token(Token = "0x40094E4")]
	[FieldOffset(Offset = "0x8")]
	public List<ActivityBingoRewardsInfo> rewards;

	[Token(Token = "0x40094E5")]
	[FieldOffset(Offset = "0xC")]
	public AwardData init_awards;

	[Token(Token = "0x6007C56")]
	[Address(RVA = "0x318238C", Offset = "0x318238C", VA = "0x318238C")]
	public CSGetBingoRewardsInfoRes()
	{
	}
}
