using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001613")]
public class ActivityBingoRewardsInfo
{
	[Token(Token = "0x40094F3")]
	[FieldOffset(Offset = "0x8")]
	public uint rewards_id;

	[Token(Token = "0x40094F4")]
	[FieldOffset(Offset = "0xC")]
	public bool awarded;

	[Token(Token = "0x6007C5D")]
	[Address(RVA = "0x317A028", Offset = "0x317A028", VA = "0x317A028")]
	public ActivityBingoRewardsInfo()
	{
	}
}
