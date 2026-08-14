using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001740")]
public class CSGetGiftRankRewardRes
{
	[Token(Token = "0x40099B4")]
	[FieldOffset(Offset = "0x8")]
	public AwardDesc award;

	[Token(Token = "0x40099B5")]
	[FieldOffset(Offset = "0xC")]
	public uint[] rewarded_list;

	[Token(Token = "0x6007D9A")]
	[Address(RVA = "0x3185A78", Offset = "0x3185A78", VA = "0x3185A78")]
	public CSGetGiftRankRewardRes()
	{
	}
}
